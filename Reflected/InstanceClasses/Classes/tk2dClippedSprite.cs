namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dClippedSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dClippedSpriteR : InstanceClassWrapper<tk2dClippedSprite>
{
    public tk2dClippedSpriteR(tk2dClippedSprite _orig) : base(_orig)
    {
    }

    public Mesh mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public Vector2[] meshUvs
    {
        get => GetField<Vector2[]>();
        set => SetField(value);
    }

    public Vector3[] meshVertices
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Color32[] meshColors
    {
        get => GetField<Color32[]>();
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

    public int[] meshIndices
    {
        get => GetField<int[]>();
        set => SetField(value);
    }

    public Vector2 _clipBottomLeft
    {
        get => orig._clipBottomLeft;
        set => orig._clipBottomLeft = value;
    }

    public Vector2 _clipTopRight
    {
        get => orig._clipTopRight;
        set => orig._clipTopRight = value;
    }

    public Rect _clipRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public bool _createBoxCollider
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3 boundsCenter
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 boundsExtents
    {
        get => GetField<Vector3>();
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

    public Rect ClipRect
    {
        get => orig.ClipRect;
        set => orig.ClipRect = value;
    }

    public Vector2 clipBottomLeft
    {
        get => orig.clipBottomLeft;
        set => orig.clipBottomLeft = value;
    }

    public Vector2 clipTopRight
    {
        get => orig.clipTopRight;
        set => orig.clipTopRight = value;
    }

    public bool CreateBoxCollider
    {
        get => orig.CreateBoxCollider;
        set => orig.CreateBoxCollider = value;
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

    public void SetColors(Color32[] dest)
    {
        CallMethod(new object[] { dest });
    }

    public void SetGeometry(Vector3[] vertices, Vector2[] uvs)
    {
        CallMethod(new object[] { vertices, uvs });
    }

    public void Build()
    {
        orig.Build();
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

    public void UpdateGeometryImpl()
    {
        CallMethod();
    }

    public void UpdateCollider()
    {
        CallMethod();
    }

    public void CreateCollider()
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

    public void ReshapeBounds(Vector3 dMin, Vector3 dMax)
    {
        orig.ReshapeBounds(dMin, dMax);
    }
}