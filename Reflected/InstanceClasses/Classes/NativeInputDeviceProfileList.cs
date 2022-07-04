namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputDeviceProfileList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputDeviceProfileListR:InstanceClassWrapper<InControl.NativeInputDeviceProfileList>
{
public NativeInputDeviceProfileListR(InControl.NativeInputDeviceProfileList _orig) : base(_orig) {}
public System.String[] Profiles
{
get => InControl.NativeInputDeviceProfileList.Profiles;
set => SetField(value);
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

}
}
