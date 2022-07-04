namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetTMProLeftVertex allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetTMProLeftVertexR:InstanceClassWrapper<GetTMProLeftVertex>
{
public GetTMProLeftVertexR(GetTMProLeftVertex _orig) : base(_orig) {}
public UnityEngine.Vector3[] vertices
{
get => orig.vertices;
set => orig.vertices = value;
}

public System.Single[] vectorX
{
get => orig.vectorX;
set => orig.vectorX = value;
}

public TMPro.TextMeshPro textMesh
{
get => GetField<TMPro.TextMeshPro>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public float GetLeftmostVertex () =>
orig.GetLeftmostVertex();

}
}
