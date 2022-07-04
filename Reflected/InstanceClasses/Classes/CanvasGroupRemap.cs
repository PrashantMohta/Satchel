using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CanvasGroupRemap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CanvasGroupRemapR : InstanceClassWrapper<CanvasGroupRemap>
{
    public CanvasGroupRemapR(CanvasGroupRemap _orig) : base(_orig)
    {
    }

    public SpriteRenderer[] spriteRenderers
    {
        get => GetField<SpriteRenderer[]>();
        set => SetField(value);
    }

    public TextMeshPro[] textMeshes
    {
        get => GetField<TextMeshPro[]>();
        set => SetField(value);
    }

    public CanvasGroup group
    {
        get => orig.group;
        set => orig.group = value;
    }

    public float alpha
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool skippedFirstUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Sync(float alpha)
    {
        CallMethod(new object[] { alpha });
    }
}