namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LocalizedTextMesh allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LocalizedTextMeshR:InstanceClassWrapper<LocalizedTextMesh>
{
public LocalizedTextMeshR(LocalizedTextMesh _orig) : base(_orig) {}
public string keyValue
{
get => orig.keyValue;
set => orig.keyValue = value;
}



public void Awake () =>
orig.Awake();

public void LocalizeTextMesh (string keyValue) =>
orig.LocalizeTextMesh(keyValue);

}
}
