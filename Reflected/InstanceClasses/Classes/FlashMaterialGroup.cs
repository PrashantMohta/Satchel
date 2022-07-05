namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FlashMaterialGroup allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FlashMaterialGroupR : InstanceClassWrapper<FlashMaterialGroup>
{
    public FlashMaterialGroupR(FlashMaterialGroup _orig) : base(_orig)
    {
    }

    public float flashAmount
    {
        get => orig.flashAmount;
        set => orig.flashAmount = value;
    }

    public Renderer renderer
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public Material material
    {
        get => GetField<Material>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}