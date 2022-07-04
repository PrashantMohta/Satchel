namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AutoZSorter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoZSorterR : InstanceClassWrapper<AutoZSorter>
{
    public AutoZSorterR(AutoZSorter _orig) : base(_orig)
    {
    }

    public GameObject prefabToSort
    {
        get => orig.prefabToSort;
        set => orig.prefabToSort = value;
    }

    public float amountToSpace
    {
        get => orig.amountToSpace;
        set => orig.amountToSpace = value;
    }
}