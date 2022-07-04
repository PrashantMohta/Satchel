using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ReplaceTextLineBreaks allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ReplaceTextLineBreaksR : InstanceClassWrapper<ReplaceTextLineBreaks>
{
    public ReplaceTextLineBreaksR(ReplaceTextLineBreaks _orig) : base(_orig)
    {
    }

    public TextMeshPro textMesh
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }
}