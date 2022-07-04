namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dResource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dResourceR:InstanceClassWrapper<tk2dResource>
{
public tk2dResourceR(tk2dResource _orig) : base(_orig) {}
public UnityEngine.Object objectReference
{
get => orig.objectReference;
set => orig.objectReference = value;
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
