using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dTileMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dTileMapR : InstanceClassWrapper<tk2dTileMap>
{
    public tk2dTileMapR(tk2dTileMap _orig) : base(_orig)
    {
    }

    public string editorDataGUID
    {
        get => orig.editorDataGUID;
        set => orig.editorDataGUID = value;
    }

    public tk2dTileMapData data
    {
        get => orig.data;
        set => orig.data = value;
    }

    public GameObject renderData
    {
        get => orig.renderData;
        set => orig.renderData = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => GetField<tk2dSpriteCollectionData>();
        set => SetField(value);
    }

    public int spriteCollectionKey
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public int height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public int partitionSizeX
    {
        get => orig.partitionSizeX;
        set => orig.partitionSizeX = value;
    }

    public int partitionSizeY
    {
        get => orig.partitionSizeY;
        set => orig.partitionSizeY = value;
    }

    public Layer[] layers
    {
        get => GetField<Layer[]>();
        set => SetField(value);
    }

    public ColorChannel colorChannel
    {
        get => GetField<ColorChannel>();
        set => SetField(value);
    }

    public GameObject prefabsRoot
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public List<tk2dTileMap.TilemapPrefabInstance> tilePrefabsList
    {
        get => GetField<List<tk2dTileMap.TilemapPrefabInstance>>();
        set => SetField(value);
    }

    public bool _inEditMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string serializedMeshPath
    {
        get => orig.serializedMeshPath;
        set => orig.serializedMeshPath = value;
    }

    public tk2dSpriteCollectionData Editor__SpriteCollection
    {
        get => orig.Editor__SpriteCollection;
        set => orig.Editor__SpriteCollection = value;
    }

    public tk2dSpriteCollectionData SpriteCollectionInst => orig.SpriteCollectionInst;

    public bool AllowEdit => orig.AllowEdit;

    public List<tk2dTileMap.TilemapPrefabInstance> TilePrefabsList => orig.TilePrefabsList;

    public Layer[] Layers
    {
        get => orig.Layers;
        set => orig.Layers = value;
    }

    public ColorChannel ColorChannel
    {
        get => orig.ColorChannel;
        set => orig.ColorChannel = value;
    }

    public GameObject PrefabsRoot
    {
        get => orig.PrefabsRoot;
        set => orig.PrefabsRoot = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Build()
    {
        orig.Build();
    }

    public void ForceBuild()
    {
        orig.ForceBuild();
    }

    public void ClearSpawnedInstances()
    {
        CallMethod();
    }

    public void SetPrefabsRootActive(bool active)
    {
        CallMethod(new object[] { active });
    }

    public void Build(tk2dTileMap.BuildFlags buildFlags)
    {
        orig.Build(buildFlags);
    }

    public bool GetTileAtPosition(Vector3 position, out int x, out int y)
    {
        return orig.GetTileAtPosition(position, out x, out y);
    }

    public bool GetTileFracAtPosition(Vector3 position, out float x, out float y)
    {
        return orig.GetTileFracAtPosition(position, out x, out y);
    }

    public Vector3 GetTilePosition(int x, int y)
    {
        return orig.GetTilePosition(x, y);
    }

    public int GetTileIdAtPosition(Vector3 position, int layer)
    {
        return orig.GetTileIdAtPosition(position, layer);
    }

    public TileInfo GetTileInfoForTileId(int tileId)
    {
        return orig.GetTileInfoForTileId(tileId);
    }

    public Color GetInterpolatedColorAtPosition(Vector3 position)
    {
        return orig.GetInterpolatedColorAtPosition(position);
    }

    public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
    {
        return orig.UsesSpriteCollection(spriteCollection);
    }

    public void EndEditMode()
    {
        orig.EndEditMode();
    }

    public void TouchMesh(Mesh mesh)
    {
        orig.TouchMesh(mesh);
    }

    public void DestroyMesh(Mesh mesh)
    {
        orig.DestroyMesh(mesh);
    }

    public int GetTilePrefabsListCount()
    {
        return orig.GetTilePrefabsListCount();
    }

    public void GetTilePrefabsListItem(int index, out int x, out int y, out int layer, out GameObject instance)
    {
        orig.GetTilePrefabsListItem(index, out x, out y, out layer, out instance);
    }

    public void SetTilePrefabsList(List<int> xs, List<int> ys, List<int> layers, List<GameObject> instances)
    {
        orig.SetTilePrefabsList(xs, ys, layers, instances);
    }

    public int GetTile(int x, int y, int layer)
    {
        return orig.GetTile(x, y, layer);
    }

    public tk2dTileFlags GetTileFlags(int x, int y, int layer)
    {
        return orig.GetTileFlags(x, y, layer);
    }

    public void SetTile(int x, int y, int layer, int tile)
    {
        orig.SetTile(x, y, layer, tile);
    }

    public void SetTileFlags(int x, int y, int layer, tk2dTileFlags flags)
    {
        orig.SetTileFlags(x, y, layer, flags);
    }

    public void ClearTile(int x, int y, int layer)
    {
        orig.ClearTile(x, y, layer);
    }
}