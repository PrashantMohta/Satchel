using System.IO;
using System.Text;

namespace Satchel
{
	/// <summary>
	/// WAV utility for recording and audio playback functions in Unity.
	/// Version: 1.0 alpha 1
	///
	/// - Use "ToAudioClip" method for loading wav file / bytes.
	/// Loads .wav (PCM uncompressed) files at 8,16,24 and 32 bits and converts data to Unity's AudioClip.
	///
	/// - Use "FromAudioClip" method for saving wav file / bytes.
	/// Converts an AudioClip's float data into wav byte array at 16 bit.
	/// </summary>
	/// <remarks>
	/// For documentation and usage examples: https://github.com/deadlyfingers/UnityWav
	/// </remarks>
	public class WavUtils
	{
		private class HeaderData
		{
			public UInt16 AudioFormat;
			public UInt16 NumChannels;
			public UInt32 SampleRate;
			public UInt32 ByteRate;
			public UInt16 BlockAlign;
			public UInt16 BitsPerSample;
		}

		/// <summary>
		///     Load PCM format *.wav audio file (using Unity's Application data path) and convert to AudioClip.
		/// </summary>
		/// <returns>The AudioClip.</returns>
		/// <param name="filePath">Local file path to .wav file</param>
		public static AudioClip ToAudioClip(string filePath)
		{
			var fileBytes = File.ReadAllBytes(filePath);
			return ToAudioClip(fileBytes, Path.GetFileNameWithoutExtension(filePath));
		}

		public static AudioClip ToAudioClip(byte[] fileBytes, string name = "wav")
		{
			string RiffChunkID = Encoding.ASCII.GetString(new byte[] { 0x52, 0x49, 0x46, 0x46 }, 0, 4);
			string WaveFormat = Encoding.ASCII.GetString(new byte[] { 0x57, 0x41, 0x56, 0x45 }, 0, 4);
			string fmtChunkID = Encoding.ASCII.GetString(new byte[] { 0x66, 0x6d, 0x74, 0x20 }, 0, 4);
			string dataChunkID = Encoding.ASCII.GetString(new byte[] { 0x64, 0x61, 0x74, 0x61 }, 0, 4);

			string ChunkID = Encoding.ASCII.GetString(fileBytes, 0, 4);
			if (RiffChunkID != ChunkID)
			{
				Satchel.Instance.LogError($"ERROR: RIFF chunk id doesn't match! \"{RiffChunkID}\" and \"{ChunkID}\"");
				return null;
			}
			UInt32 ChunkSize = BitConverter.ToUInt32(fileBytes, 4);
			if (ChunkSize != fileBytes.Length - 8)
			{
				Satchel.Instance.LogError($"ERROR: Chunk size doesn't match! \"{ChunkSize}\" and \"{fileBytes.Length - 8}\"");
				return null;
			}
			string Format = Encoding.ASCII.GetString(fileBytes, 8, 4);
			if (WaveFormat != Format)
			{
				Satchel.Instance.LogError($"ERROR: Format doesn't match! \"{WaveFormat}\" and \"{Format}\"");
				return null;
			}

			HeaderData headerData = new HeaderData();
			byte[] pcmDataBytes = Array.Empty<byte>();

			UInt32 currentHeaderOffset = 12;
			while (currentHeaderOffset < fileBytes.Length)
			{
				string SubchunkID = Encoding.ASCII.GetString(fileBytes, (int)currentHeaderOffset, 4);
				UInt32 SubchunkSize = BitConverter.ToUInt32(fileBytes, (int)currentHeaderOffset + 4);
				if (fmtChunkID == SubchunkID)
				{
					headerData.AudioFormat = BitConverter.ToUInt16(fileBytes, (int)currentHeaderOffset + 8);
					if (headerData.AudioFormat != 1)
					{
						Satchel.Instance.LogError($"ERROR: Format doesn't match! \"{WaveFormat}\" and \"{Format}\"");
						return null;
					}
					headerData.NumChannels = BitConverter.ToUInt16(fileBytes, (int)currentHeaderOffset + 10);
					headerData.SampleRate = BitConverter.ToUInt32(fileBytes, (int)currentHeaderOffset + 12);
					headerData.ByteRate = BitConverter.ToUInt32(fileBytes, (int)currentHeaderOffset + 16);
					headerData.BlockAlign = BitConverter.ToUInt16(fileBytes, (int)currentHeaderOffset + 20);
					headerData.BitsPerSample = BitConverter.ToUInt16(fileBytes, (int)currentHeaderOffset + 22);
				}
				else if (dataChunkID == SubchunkID)
				{
					pcmDataBytes = new byte[SubchunkSize];
					for (UInt32 i = 0; i < SubchunkSize; i++)
					{
						pcmDataBytes[i] = fileBytes[currentHeaderOffset + 8 + i];
					}
				}
				currentHeaderOffset += 8 + SubchunkSize;
			}

			float[] data;
			switch (headerData.BitsPerSample)
			{
				case 8:
					data = Convert8BitByteArrayToAudioClipData(pcmDataBytes);
					break;
				case 16:
					data = Convert16BitByteArrayToAudioClipData(pcmDataBytes);
					break;
				case 24:
					data = Convert24BitByteArrayToAudioClipData(pcmDataBytes);
					break;
				case 32:
					data = Convert32BitByteArrayToAudioClipData(pcmDataBytes);
					break;
				default:
					throw new Exception(headerData.BitsPerSample + " bit depth is not supported.");
			}

			Satchel.Instance.LogDebug($"RIFF WAVE data for \"{name}\":\n" +
			                     $"ChunkSize: {ChunkSize}\n" +
			                     $"fmt.AudioFormat: {headerData.AudioFormat}\n" +
			                     $"fmt.NumChannels: {headerData.NumChannels}\n" +
			                     $"fmt.SampleRate: {headerData.SampleRate}\n" +
			                     $"fmt.ByteRate: {headerData.ByteRate}\n" +
			                     $"fmt.BlockAlign: {headerData.BlockAlign}\n" +
			                     $"fmt.BitsPerSample: {headerData.BitsPerSample}\n" +
			                     $"data length: {pcmDataBytes.Length}");

			var audioClip = AudioClip.Create(name, data.Length / headerData.NumChannels, headerData.NumChannels, (int)headerData.SampleRate, false);
			audioClip.SetData(data, 0);
			return audioClip;
		}

		private static string FormatCode(ushort code)
		{
			switch (code)
			{
				case 1:
					return "PCM";
				case 2:
					return "ADPCM";
				case 3:
					return "IEEE";
				case 7:
					return "μ-law";
				case 65534:
					return "WaveFormatExtensable";
				default:
					Satchel.Instance.LogWarn("Unknown wav code format:" + code);
					return "";
			}
		}

		#region wav file bytes to Unity AudioClip conversion methods

		private static float[] Convert8BitByteArrayToAudioClipData(byte[] source)
		{
			var wavSize = source.Length;

			var data = new float[wavSize];

			float maxValue = sbyte.MaxValue;

			var i = 0;
			while (i < wavSize)
			{
				data[i] = Mathf.Clamp(source[i] / maxValue, -1.0f, 1.0f);
				++i;
			}

			return data;
		}

		private static float[] Convert16BitByteArrayToAudioClipData(byte[] source)
		{
			var wavSize = source.Length;

			var x = sizeof(short); // block size = 2
			var convertedSize = wavSize / x;

			var data = new float[convertedSize];

			float maxValue = short.MaxValue;

			var offset = 0;
			var i = 0;
			while (i < convertedSize)
			{
				offset = i * x;
				data[i] = Mathf.Clamp(BitConverter.ToInt16(source, offset) / maxValue, -1.0f, 1.0f);
				++i;
			}

			return data;
		}

		private static float[] Convert24BitByteArrayToAudioClipData(byte[] source)
		{
			var wavSize = source.Length;

			var x = 3; // block size = 3
			var convertedSize = wavSize / x;

			float maxValue = int.MaxValue; // 24 bits bit depth goes from -0x800000 to 0x7FFFFF, but apparently 24 bit uses 32 bit limits

			var data = new float[convertedSize];

			var block = new byte[sizeof(int)]; // using a 4 byte block for copying 3 bytes, then copy bytes with 1 offset

			var offset = 0;
			var i = 0;
			while (i < convertedSize)
			{
				offset = i * x;
				Buffer.BlockCopy(source, offset, block, 1, x);
				data[i] = Mathf.Clamp(BitConverter.ToInt32(block, 0) / maxValue, -1.0f, 1.0f);
				++i;
			}

			return data;
		}

		private static float[] Convert32BitByteArrayToAudioClipData(byte[] source)
		{
			var wavSize = source.Length;

			var x = sizeof(float); //  block size = 4
			var convertedSize = wavSize / x;

			float maxValue = int.MaxValue;

			var data = new float[convertedSize];

			var offset = 0;
			var i = 0;
			while (i < convertedSize)
			{
				offset = i * x;
				data[i] = Mathf.Clamp(BitConverter.ToInt32(source, offset) / maxValue, -1.0f, 1.0f);
				++i;
			}

			return data;
		}

		#endregion
	}
}