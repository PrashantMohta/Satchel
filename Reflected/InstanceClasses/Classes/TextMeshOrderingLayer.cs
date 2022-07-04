namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TextMeshOrderingLayer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TextMeshOrderingLayerR : InstanceClassWrapper<TextMeshOrderingLayer>
{
    public TextMeshOrderingLayerR(TextMeshOrderingLayer _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}