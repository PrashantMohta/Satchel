namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Asset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_AssetR:InstanceClassWrapper<TMPro.TMP_Asset>
{
public TMP_AssetR(TMPro.TMP_Asset _orig) : base(_orig) {}
public int hashCode
{
get => orig.hashCode;
set => orig.hashCode = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public int materialHashCode
{
get => orig.materialHashCode;
set => orig.materialHashCode = value;
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
