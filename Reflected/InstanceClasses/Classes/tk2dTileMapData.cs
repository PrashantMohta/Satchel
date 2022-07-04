using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTileMapData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTileMapDataR : InstanceClassWrapper<tk2dTileMapData>
{
    public tk2dTileMapDataR(tk2dTileMapData _orig) : base(_orig)
    {
    }

    public Vector3 tileSize
    {
        get => orig.tileSize;
        set => orig.tileSize = value;
    }

    public Vector3 tileOrigin
    {
        get => orig.tileOrigin;
        set => orig.tileOrigin = value;
    }

    public bool generateUv2
    {
        get => orig.generateUv2;
        set => orig.generateUv2 = value;
    }

    public bool layersFixedZ
    {
        get => orig.layersFixedZ;
        set => orig.layersFixedZ = value;
    }

    public bool useSortingLayers
    {
        get => orig.useSortingLayers;
        set => orig.useSortingLayers = value;
    }

    public GameObject[] tilePrefabs
    {
        get => orig.tilePrefabs;
        set => orig.tilePrefabs = value;
    }

    public TileInfo[] tileInfo
    {
        get => GetField<TileInfo[]>();
        set => SetField(value);
    }

    public List<LayerInfo> tileMapLayers
    {
        get => orig.tileMapLayers;
        set => orig.tileMapLayers = value;
    }

    public int NumLayers => orig.NumLayers;

    public LayerInfo[] Layers => orig.Layers;

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

    public TileInfo GetTileInfoForSprite(int tileId)
    {
        return orig.GetTileInfoForSprite(tileId);
    }

    public TileInfo[] GetOrCreateTileInfo(int numTiles)
    {
        return orig.GetOrCreateTileInfo(numTiles);
    }

    public void GetTileOffset(out float x, out float y)
    {
        orig.GetTileOffset(out x, out y);
    }

    public void InitLayers()
    {
        CallMethod();
    }
}