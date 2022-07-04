namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MeshSortingOrder allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MeshSortingOrderR : InstanceClassWrapper<MeshSortingOrder>
{
    public MeshSortingOrderR(MeshSortingOrder _orig) : base(_orig)
    {
    }

    public string layerName
    {
        get => orig.layerName;
        set => orig.layerName = value;
    }

    public int order
    {
        get => orig.order;
        set => orig.order = value;
    }

    public MeshRenderer rend
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        orig.Update();
    }

    public void OnValidate()
    {
        orig.OnValidate();
    }
}