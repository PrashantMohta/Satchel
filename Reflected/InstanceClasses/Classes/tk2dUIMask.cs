namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIMask allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIMaskR : InstanceClassWrapper<tk2dUIMask>
{
    public tk2dUIMaskR(tk2dUIMask _orig) : base(_orig)
    {
    }

    public Vector2 size
    {
        get => orig.size;
        set => orig.size = value;
    }

    public float depth
    {
        get => orig.depth;
        set => orig.depth = value;
    }

    public bool createBoxCollider
    {
        get => orig.createBoxCollider;
        set => orig.createBoxCollider = value;
    }

    public MeshFilter _thisMeshFilter
    {
        get => GetField<MeshFilter>();
        set => SetField(value);
    }

    public BoxCollider _thisBoxCollider
    {
        get => GetField<BoxCollider>();
        set => SetField(value);
    }

    public Vector2[] uv
    {
        get => GetFieldStatic<Vector2[]>();
        set => SetField(value);
    }

    public int[] indices
    {
        get => GetFieldStatic<int[]>();
        set => SetField(value);
    }

    public MeshFilter ThisMeshFilter => GetProperty<MeshFilter>();

    public BoxCollider ThisBoxCollider => GetProperty<BoxCollider>();


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public Mesh FillMesh(Mesh mesh)
    {
        return CallMethod<Mesh>(new object[] { mesh });
    }

    public void OnDrawGizmosSelected()
    {
        CallMethod();
    }

    public void Build()
    {
        orig.Build();
    }

    public void ReshapeBounds(Vector3 dMin, Vector3 dMax)
    {
        orig.ReshapeBounds(dMin, dMax);
    }
}