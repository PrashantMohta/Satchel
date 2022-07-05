namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AssetNamePickerAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AssetNamePickerAttributeR : InstanceClassWrapper<AssetNamePickerAttribute>
{
    public AssetNamePickerAttributeR(AssetNamePickerAttribute _orig) : base(_orig)
    {
    }

    public string searchFilter
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string SearchFilter => orig.SearchFilter;

    public int order
    {
        get => orig.order;
        set => orig.order = value;
    }

    public object TypeId => orig.TypeId;
}