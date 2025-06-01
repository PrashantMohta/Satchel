using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Modding.Patches;
using Newtonsoft.Json;
using UnityEngine.UI;

namespace Satchel
{
    /// <summary>
    /// Utilities to work with PlayerData
    /// </summary>
    public static class PlayerDataUtils
    {

        /// <summary>
        /// Convert a SaveSlot to index 
        /// </summary>
        /// <param name="saveSlot">SaveSlot enum</param>
        /// <returns>index of the save slot</returns>
        public static int ConvertSlotToNumber(SaveSlotButton.SaveSlot saveSlot)
        {
            if (saveSlot == SaveSlotButton.SaveSlot.SLOT_1)
            {
                return 1;
            }
            if (saveSlot == SaveSlotButton.SaveSlot.SLOT_2)
            {
                return 2;
            }
            if (saveSlot == SaveSlotButton.SaveSlot.SLOT_3)
            {
                return 3;
            }
            if (saveSlot == SaveSlotButton.SaveSlot.SLOT_4)
            {
                return 4;
            }
            return 0;
        }
        /// <summary>
        /// Gets PlayerData for a saveSlot index
        /// </summary>
        /// <param name="saveSlot">Index of the saveSlot</param>
        /// <param name="callback">Method to be called after data is loaded</param>
        public static void GetPlayerDataForSlot(int saveSlot, Action<PlayerData> callback)
        {

            Platform.Current.ReadSaveSlot
            (
                saveSlot,
                delegate (byte[] fileBytes)
                {
                    if (fileBytes == null)
                    {
                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(null); });
                        }

                        return;
                    }

                    try
                    {
                        bool flag = GameManager.instance.gameConfig.useSaveEncryption && !Platform.Current.IsFileSystemProtected;
                        string json;
                        if (flag)
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            MemoryStream serializationStream = new MemoryStream(fileBytes);
                            string encryptedString = (string)binaryFormatter.Deserialize(serializationStream);
                            json = Encryption.Decrypt(encryptedString);
                        }
                        else
                        {
                            json = Encoding.UTF8.GetString(fileBytes);
                        }
                        SaveGameData saveGameData;
                        try
                        {
                            saveGameData = JsonConvert.DeserializeObject<SaveGameData>(json, new JsonSerializerSettings()
                            {
                                ContractResolver = ShouldSerializeContractResolver.Instance,
                                TypeNameHandling = TypeNameHandling.Auto,
                                ObjectCreationHandling = ObjectCreationHandling.Replace,
                                Converters = JsonConverterTypes.ConverterTypes
                            });
                        }
                        catch (Exception)
                        {
                            // Not a huge deal, this happens on saves with mod data which haven't been converted yet.
                            Satchel.Instance.LogWarn($"Failed to get save stats for slot {saveSlot} using Json.NET, falling back");

                            saveGameData = JsonUtility.FromJson<SaveGameData>(json);
                        }

                        PlayerData playerData = saveGameData.playerData;

                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(playerData); });
                        }
                    }
                    catch (Exception ex)
                    {
                        Satchel.Instance.LogError
                        (
                            string.Concat
                            (
                                new object[]
                                {
                                    "Error while loading save file for slot ",
                                    saveSlot,
                                    " Exception: ",
                                    ex
                                }
                            )
                        );
                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(null); });
                        }
                    }
                }
            );
        }


    }

}