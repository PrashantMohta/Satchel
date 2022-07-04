namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GamepadVibrationMixer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GamepadVibrationMixerR:InstanceClassWrapper<GamepadVibrationMixer>
{
public GamepadVibrationMixerR(GamepadVibrationMixer _orig) : base(_orig) {}
public bool isPaused
{
get => GetField<bool>();
set => SetField(value);
}

public System.Collections.Generic.List<GamepadVibrationMixer.GamepadVibrationEmission> playingEmissions
{
get => GetField<System.Collections.Generic.List<GamepadVibrationMixer.GamepadVibrationEmission>>();
set => SetField(value);
}

public bool IsPaused
{
get => orig.IsPaused;
set => orig.IsPaused = value;
}

public int PlayingEmissionCount
{
get => orig.PlayingEmissionCount;
}

public VibrationEmission GetPlayingEmission (int playingEmissionIndex) =>
orig.GetPlayingEmission(playingEmissionIndex);

public VibrationEmission PlayEmission (VibrationData vibrationData, VibrationTarget vibrationTarget, bool isLooping, string tag) =>
orig.PlayEmission(vibrationData, vibrationTarget, isLooping, tag);

public void StopAllEmissions () =>
orig.StopAllEmissions();

public void StopAllEmissionsWithTag (string tag) =>
orig.StopAllEmissionsWithTag(tag);

public void Update (float deltaTime) =>
orig.Update(deltaTime);

public float AdjustForPlatform (float val) =>
CallMethod<float>(new object[] {val});

}
}
