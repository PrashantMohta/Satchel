namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WeightedItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WeightedItemR : InstanceClassWrapper<WeightedItem>
{
    public WeightedItemR(WeightedItem _orig) : base(_orig)
    {
    }

    public float weight
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float Weight => orig.Weight;
}