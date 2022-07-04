namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIMask allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIMaskR:InstanceClassWrapper<tk2dUIMask>
{
public tk2dUIMaskR(tk2dUIMask _orig) : base(_orig) {}
public UnityEngine.Vector2 size
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

public UnityEngine.MeshFilter _thisMeshFilter
{
get => GetField<UnityEngine.MeshFilter>();
set => SetField(value);
}

public UnityEngine.BoxCollider _thisBoxCollider
{
get => GetField<UnityEngine.BoxCollider>();
set => SetField(value);
}

public UnityEngine.Vector2[] uv
{
get => GetFieldStatic<UnityEngine.Vector2[]>();
set => SetField(value);
}

public System.Int32[] indices
{
get => GetFieldStatic<System.Int32[]>();
set => SetField(value);
}

public UnityEngine.MeshFilter ThisMeshFilter
{
get => GetProperty<UnityEngine.MeshFilter>();
}

public UnityEngine.BoxCollider ThisBoxCollider
{
get => GetProperty<UnityEngine.BoxCollider>();
}



public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public UnityEngine.Mesh FillMesh (UnityEngine.Mesh mesh) =>
CallMethod<UnityEngine.Mesh>(new object[] {mesh});

public void OnDrawGizmosSelected () =>
CallMethod();

public void Build () =>
orig.Build();

public void ReshapeBounds (UnityEngine.Vector3 dMin, UnityEngine.Vector3 dMax) =>
orig.ReshapeBounds(dMin, dMax);

}
}
