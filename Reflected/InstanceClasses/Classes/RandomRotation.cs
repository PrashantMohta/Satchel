namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RandomRotation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomRotationR : InstanceClassWrapper<RandomRotation>
{
    public RandomRotationR(RandomRotation _orig) : base(_orig)
    {
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