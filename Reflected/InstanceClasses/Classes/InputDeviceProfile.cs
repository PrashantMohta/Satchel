namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InputDeviceProfile allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputDeviceProfileR:InstanceClassWrapper<InControl.InputDeviceProfile>
{
public InputDeviceProfileR(InControl.InputDeviceProfile _orig) : base(_orig) {}
public System.Collections.Generic.List<System.Type> hiddenProfiles
{
get => GetFieldStatic<System.Collections.Generic.List<System.Type>>();
set => SetField(value);
}

public InControl.InputDeviceProfileType profileType
{
get => GetField<InControl.InputDeviceProfileType>();
set => SetField(value);
}

public string deviceName
{
get => GetField<string>();
set => SetField(value);
}

public string deviceNotes
{
get => GetField<string>();
set => SetField(value);
}

public InControl.InputDeviceClass deviceClass
{
get => GetField<InControl.InputDeviceClass>();
set => SetField(value);
}

public InControl.InputDeviceStyle deviceStyle
{
get => GetField<InControl.InputDeviceStyle>();
set => SetField(value);
}

public float sensitivity
{
get => GetField<float>();
set => SetField(value);
}

public float lowerDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public float upperDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public System.String[] includePlatforms
{
get => GetField<System.String[]>();
set => SetField(value);
}

public System.String[] excludePlatforms
{
get => GetField<System.String[]>();
set => SetField(value);
}

public int minSystemBuildNumber
{
get => GetField<int>();
set => SetField(value);
}

public int maxSystemBuildNumber
{
get => GetField<int>();
set => SetField(value);
}

public InControl.VersionInfo minUnityVersion
{
get => GetField<InControl.VersionInfo>();
set => SetField(value);
}

public InControl.VersionInfo maxUnityVersion
{
get => GetField<InControl.VersionInfo>();
set => SetField(value);
}

public InControl.InputDeviceMatcher[] matchers
{
get => GetField<InControl.InputDeviceMatcher[]>();
set => SetField(value);
}

public InControl.InputDeviceMatcher[] lastResortMatchers
{
get => GetField<InControl.InputDeviceMatcher[]>();
set => SetField(value);
}

public InControl.InputControlMapping[] analogMappings
{
get => GetField<InControl.InputControlMapping[]>();
set => SetField(value);
}

public InControl.InputControlMapping[] buttonMappings
{
get => GetField<InControl.InputControlMapping[]>();
set => SetField(value);
}

public InControl.InputControlSource MenuKey
{
get => GetFieldStatic<InControl.InputControlSource>();
set => SetField(value);
}

public InControl.InputControlSource EscapeKey
{
get => GetFieldStatic<InControl.InputControlSource>();
set => SetField(value);
}

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

public InControl.InputDeviceProfile CreateInstanceOfType (System.Type type) =>
InControl.InputDeviceProfile.CreateInstanceOfType(type);

public InControl.InputDeviceProfile CreateInstanceOfType (string typeName) =>
InControl.InputDeviceProfile.CreateInstanceOfType(typeName);

public void Define () =>
orig.Define();

public bool Matches (InControl.InputDeviceInfo deviceInfo) =>
orig.Matches(deviceInfo);

public bool LastResortMatches (InControl.InputDeviceInfo deviceInfo) =>
orig.LastResortMatches(deviceInfo);

public bool Matches (InControl.InputDeviceInfo deviceInfo, InControl.InputDeviceMatcher[] matchers) =>
orig.Matches(deviceInfo, matchers);

public void Hide (System.Type type) =>
InControl.InputDeviceProfile.Hide(type);

public InControl.InputControlSource Button (int index) =>
CallMethodStatic<InControl.InputControlSource>(new object[] {index});

public InControl.InputControlSource Analog (int index) =>
CallMethodStatic<InControl.InputControlSource>(new object[] {index});

public InControl.InputControlMapping LeftStickLeftMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftStickRightMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftStickUpMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftStickDownMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftStickUpMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftStickDownMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickLeftMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickRightMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickUpMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickDownMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickUpMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightStickDownMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping LeftTriggerMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping RightTriggerMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadLeftMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadRightMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadUpMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadDownMapping (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadUpMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

public InControl.InputControlMapping DPadDownMapping2 (int analog) =>
CallMethodStatic<InControl.InputControlMapping>(new object[] {analog});

}
}
