namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SaveSlotOverrides allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveSlotOverridesR:InstanceClassWrapper<SaveSlotOverrides>
{
public SaveSlotOverridesR(SaveSlotOverrides _orig) : base(_orig) {}
public UnityEngine.TextAsset[] overrideFiles
{
get => orig.overrideFiles;
set => orig.overrideFiles = value;
}



public void OnValidate () =>
CallMethod();

public void Awake () =>
CallMethod();

}
}
