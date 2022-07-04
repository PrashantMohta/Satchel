using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputDeviceProfile allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputDeviceProfileR : InstanceClassWrapper<InputDeviceProfile>
{
    public InputDeviceProfileR(InputDeviceProfile _orig) : base(_orig)
    {
    }

    public List<Type> hiddenProfiles
    {
        get => GetFieldStatic<List<Type>>();
        set => SetField(value);
    }

    public InputDeviceProfileType profileType
    {
        get => GetField<InputDeviceProfileType>();
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

    public InputDeviceClass deviceClass
    {
        get => GetField<InputDeviceClass>();
        set => SetField(value);
    }

    public InputDeviceStyle deviceStyle
    {
        get => GetField<InputDeviceStyle>();
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

    public string[] includePlatforms
    {
        get => GetField<string[]>();
        set => SetField(value);
    }

    public string[] excludePlatforms
    {
        get => GetField<string[]>();
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

    public VersionInfo minUnityVersion
    {
        get => GetField<VersionInfo>();
        set => SetField(value);
    }

    public VersionInfo maxUnityVersion
    {
        get => GetField<VersionInfo>();
        set => SetField(value);
    }

    public InputDeviceMatcher[] matchers
    {
        get => GetField<InputDeviceMatcher[]>();
        set => SetField(value);
    }

    public InputDeviceMatcher[] lastResortMatchers
    {
        get => GetField<InputDeviceMatcher[]>();
        set => SetField(value);
    }

    public InputControlMapping[] analogMappings
    {
        get => GetField<InputControlMapping[]>();
        set => SetField(value);
    }

    public InputControlMapping[] buttonMappings
    {
        get => GetField<InputControlMapping[]>();
        set => SetField(value);
    }

    public InputControlSource MenuKey
    {
        get => GetFieldStatic<InputControlSource>();
        set => SetField(value);
    }

    public InputControlSource EscapeKey
    {
        get => GetFieldStatic<InputControlSource>();
        set => SetField(value);
    }

    public InputDeviceProfileType ProfileType
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

    public InputDeviceClass DeviceClass
    {
        get => orig.DeviceClass;
        set => SetProperty(value);
    }

    public InputDeviceStyle DeviceStyle
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

    public InputControlMapping[] AnalogMappings
    {
        get => orig.AnalogMappings;
        set => SetProperty(value);
    }

    public InputControlMapping[] ButtonMappings
    {
        get => orig.ButtonMappings;
        set => SetProperty(value);
    }

    public string[] IncludePlatforms
    {
        get => orig.IncludePlatforms;
        set => SetProperty(value);
    }

    public string[] ExcludePlatforms
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

    public VersionInfo MinUnityVersion
    {
        get => orig.MinUnityVersion;
        set => SetProperty(value);
    }

    public VersionInfo MaxUnityVersion
    {
        get => orig.MaxUnityVersion;
        set => SetProperty(value);
    }

    public InputDeviceMatcher[] Matchers
    {
        get => orig.Matchers;
        set => SetProperty(value);
    }

    public InputDeviceMatcher[] LastResortMatchers
    {
        get => orig.LastResortMatchers;
        set => SetProperty(value);
    }

    public bool IsSupportedOnThisPlatform => orig.IsSupportedOnThisPlatform;

    public bool IsHidden => orig.IsHidden;

    public bool IsNotHidden => orig.IsNotHidden;

    public int AnalogCount => orig.AnalogCount;

    public int ButtonCount => orig.ButtonCount;

    public InputDeviceProfile CreateInstanceOfType(Type type)
    {
        return InputDeviceProfile.CreateInstanceOfType(type);
    }

    public InputDeviceProfile CreateInstanceOfType(string typeName)
    {
        return InputDeviceProfile.CreateInstanceOfType(typeName);
    }

    public void Define()
    {
        orig.Define();
    }

    public bool Matches(InputDeviceInfo deviceInfo)
    {
        return orig.Matches(deviceInfo);
    }

    public bool LastResortMatches(InputDeviceInfo deviceInfo)
    {
        return orig.LastResortMatches(deviceInfo);
    }

    public bool Matches(InputDeviceInfo deviceInfo, InputDeviceMatcher[] matchers)
    {
        return orig.Matches(deviceInfo, matchers);
    }

    public void Hide(Type type)
    {
        InputDeviceProfile.Hide(type);
    }

    public InputControlSource Button(int index)
    {
        return CallMethodStatic<InputControlSource>(new object[] { index });
    }

    public InputControlSource Analog(int index)
    {
        return CallMethodStatic<InputControlSource>(new object[] { index });
    }

    public InputControlMapping LeftStickLeftMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftStickRightMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftStickUpMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftStickDownMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftStickUpMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftStickDownMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickLeftMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickRightMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickUpMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickDownMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickUpMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightStickDownMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping LeftTriggerMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping RightTriggerMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadLeftMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadRightMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadUpMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadDownMapping(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadUpMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }

    public InputControlMapping DPadDownMapping2(int analog)
    {
        return CallMethodStatic<InputControlMapping>(new object[] { analog });
    }
}