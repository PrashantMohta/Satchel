namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LogitechF310ModeDWindowsNativeProfile allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LogitechF310ModeDWindowsNativeProfileR:InstanceClassWrapper<InControl.NativeDeviceProfiles.LogitechF310ModeDWindowsNativeProfile>
{
public LogitechF310ModeDWindowsNativeProfileR(InControl.NativeDeviceProfiles.LogitechF310ModeDWindowsNativeProfile _orig) : base(_orig) {}
public InControl.InputDeviceProfileType ProfileType
{
get => orig.ProfileType;
set => SetProperty(value);
}

public string DeviceName
{
get => orig.DeviceName;
set => SetProperty(value);
}

public string DeviceNotes
{
get => orig.DeviceNotes;
set => SetProperty(value);
}

public InControl.InputDeviceClass DeviceClass
{
get => orig.DeviceClass;
set => SetProperty(value);
}

public InControl.InputDeviceStyle DeviceStyle
{
get => orig.DeviceStyle;
set => SetProperty(value);
}

public float Sensitivity
{
get => orig.Sensitivity;
set => SetProperty(value);
}

public float LowerDeadZone
{
get => orig.LowerDeadZone;
set => SetProperty(value);
}

public float UpperDeadZone
{
get => orig.UpperDeadZone;
set => SetProperty(value);
}

public InControl.InputControlMapping[] AnalogMappings
{
get => orig.AnalogMappings;
set => SetProperty(value);
}

public InControl.InputControlMapping[] ButtonMappings
{
get => orig.ButtonMappings;
set => SetProperty(value);
}

public System.String[] IncludePlatforms
{
get => orig.IncludePlatforms;
set => SetProperty(value);
}

public System.String[] ExcludePlatforms
{
get => orig.ExcludePlatforms;
set => SetProperty(value);
}

public int MinSystemBuildNumber
{
get => orig.MinSystemBuildNumber;
set => SetProperty(value);
}

public int MaxSystemBuildNumber
{
get => orig.MaxSystemBuildNumber;
set => SetProperty(value);
}

public InControl.VersionInfo MinUnityVersion
{
get => orig.MinUnityVersion;
set => SetProperty(value);
}

public InControl.VersionInfo MaxUnityVersion
{
get => orig.MaxUnityVersion;
set => SetProperty(value);
}

public InControl.InputDeviceMatcher[] Matchers
{
get => orig.Matchers;
set => SetProperty(value);
}

public InControl.InputDeviceMatcher[] LastResortMatchers
{
get => orig.LastResortMatchers;
set => SetProperty(value);
}

public bool IsSupportedOnThisPlatform
{
get => orig.IsSupportedOnThisPlatform;
}

public bool IsHidden
{
get => orig.IsHidden;
}

public bool IsNotHidden
{
get => orig.IsNotHidden;
}

public int AnalogCount
{
get => orig.AnalogCount;
}

public int ButtonCount
{
get => orig.ButtonCount;
}

public void Define () =>
orig.Define();

}
}
