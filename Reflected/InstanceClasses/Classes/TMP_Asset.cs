using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Asset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_AssetR : InstanceClassWrapper<TMP_Asset>
{
    public TMP_AssetR(TMP_Asset _orig) : base(_orig)
    {
    }

    public int hashCode
    {
        get => orig.hashCode;
        set => orig.hashCode = value;
    }

    public Material material
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

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }
}