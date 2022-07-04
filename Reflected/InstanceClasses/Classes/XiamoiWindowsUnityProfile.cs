using InControl;
using InControl.UnityDeviceProfiles;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of XiamoiWindowsUnityProfile allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XiamoiWindowsUnityProfileR : InstanceClassWrapper<XiamoiWindowsUnityProfile>
{
    public XiamoiWindowsUnityProfileR(XiamoiWindowsUnityProfile _orig) : base(_orig)
    {
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

    public void Define()
    {
        orig.Define();
    }
}