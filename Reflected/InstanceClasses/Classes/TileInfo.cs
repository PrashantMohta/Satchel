using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TileInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TileInfoR : InstanceClassWrapper<TileInfo>
{
    public TileInfoR(TileInfo _orig) : base(_orig)
    {
    }

    public string stringVal
    {
        get => orig.stringVal;
        set => orig.stringVal = value;
    }

    public int intVal
    {
        get => orig.intVal;
        set => orig.intVal = value;
    }

    public float floatVal
    {
        get => orig.floatVal;
        set => orig.floatVal = value;
    }

    public bool enablePrefabOffset
    {
        get => orig.enablePrefabOffset;
        set => orig.enablePrefabOffset = value;
    }
}