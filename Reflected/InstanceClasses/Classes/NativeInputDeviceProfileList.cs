using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputDeviceProfileList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputDeviceProfileListR : InstanceClassWrapper<NativeInputDeviceProfileList>
{
    public NativeInputDeviceProfileListR(NativeInputDeviceProfileList _orig) : base(_orig)
    {
    }

    public string[] Profiles
    {
        get => NativeInputDeviceProfileList.Profiles;
        set => SetField(value);
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }
}