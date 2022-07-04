namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RandomRotationRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomRotationRangeR : InstanceClassWrapper<RandomRotationRange>
{
    public RandomRotationRangeR(RandomRotationRange _orig) : base(_orig)
    {
    }

    public float min
    {
        get => orig.min;
        set => orig.min = value;
    }

    public float max
    {
        get => orig.max;
        set => orig.max = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void RandomRotate()
    {
        CallMethod();
    }
}