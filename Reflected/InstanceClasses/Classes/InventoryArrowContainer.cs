using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InventoryArrowContainer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InventoryArrowContainerR : InstanceClassWrapper<InventoryArrowContainer>
{
    public InventoryArrowContainerR(InventoryArrowContainer _orig) : base(_orig)
    {
    }

    public GameObject arrowVariant
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject promptVariant
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public TextMeshPro label
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public float labelLeftInset
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float labelRightInset
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Setup()
    {
        CallMethod();
    }
}