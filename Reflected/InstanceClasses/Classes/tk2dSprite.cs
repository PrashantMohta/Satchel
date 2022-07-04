namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteR : InstanceClassWrapper<tk2dSprite>
{
    public tk2dSpriteR(tk2dSprite _orig) : base(_orig)
    {
    }

    public Mesh mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public Vector3[] meshVertices
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector3[] meshNormals
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector4[] meshTangents
    {
        get => GetField<Vector4[]>();
        set => SetField(value);
    }

    public Color32[] meshColors
    {
        get => GetField<Color32[]>();
        set => SetField(value);
    }

    public tk2dSpriteCollectionData collectionInst
    {
        get => GetField<tk2dSpriteCollectionData>();
        set => SetField(value);
    }

    public Color _color
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Vector3 _scale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public int _spriteId
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public BoxCollider2D boxCollider2D
    {
        get => orig.boxCollider2D;
        set => orig.boxCollider2D = value;
    }

    public List<PolygonCollider2D> polygonCollider2D
    {
        get => orig.polygonCollider2D;
        set => orig.polygonCollider2D = value;
    }

    public List<EdgeCollider2D> edgeCollider2D
    {
        get => orig.edgeCollider2D;
        set => orig.edgeCollider2D = value;
    }

    public BoxCollider boxCollider
    {
        get => orig.boxCollider;
        set => orig.boxCollider = value;
    }

    public MeshCollider meshCollider
    {
        get => orig.meshCollider;
        set => orig.meshCollider = value;
    }

    public Vector3[] meshColliderPositions
    {
        get => orig.meshColliderPositions;
        set => orig.meshColliderPositions = value;
    }

    public Mesh meshColliderMesh
    {
        get => orig.meshColliderMesh;
        set => orig.meshColliderMesh = value;
    }

    public int renderLayer
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public tk2dSpriteCollectionData Collection
    {
        get => orig.Collection;
        set => orig.Collection = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public int SortingOrder
    {
        get => orig.SortingOrder;
        set => orig.SortingOrder = value;
    }

    public bool FlipX
    {
        get => orig.FlipX;
        set => orig.FlipX = value;
    }

    public bool FlipY
    {
        get => orig.FlipY;
        set => orig.FlipY = value;
    }

    public int spriteId
    {
        get => orig.spriteId;
        set => orig.spriteId = value;
    }

    public tk2dSpriteDefinition CurrentSprite => orig.CurrentSprite;


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

    public tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, int spriteId)
    {
        return tk2dSprite.AddComponent(go, spriteCollection, spriteId);
    }

    public tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, string spriteName)
    {
        return tk2dSprite.AddComponent(go, spriteCollection, spriteName);
    }

    public GameObject CreateFromTexture(Texture texture, tk2dSpriteCollectionSize size, Rect region, Vector2 anchor)
    {
        return tk2dSprite.CreateFromTexture(texture, size, region, anchor);
    }

    public void UpdateGeometry()
    {
        CallMethod();
    }

    public void UpdateColors()
    {
        CallMethod();
    }

    public void UpdateVertices()
    {
        CallMethod();
    }

    public void UpdateColorsImpl()
    {
        CallMethod();
    }

    public void UpdateVerticesImpl()
    {
        CallMethod();
    }

    public void UpdateGeometryImpl()
    {
        CallMethod();
    }

    public void UpdateMaterial()
    {
        CallMethod();
    }

    public int GetCurrentVertexCount()
    {
        return CallMethod<int>();
    }

    public void ForceBuild()
    {
        orig.ForceBuild();
    }

    public void ReshapeBounds(Vector3 dMin, Vector3 dMax)
    {
        orig.ReshapeBounds(dMin, dMax);
    }
}