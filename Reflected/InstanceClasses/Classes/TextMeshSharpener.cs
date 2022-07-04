namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TextMeshSharpener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TextMeshSharpenerR:InstanceClassWrapper<TextMeshSharpener>
{
public TextMeshSharpenerR(TextMeshSharpener _orig) : base(_orig) {}
public float lastPixelHeight
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.TextMesh textMesh
{
get => GetField<UnityEngine.TextMesh>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void resize () =>
CallMethod();

}
}
