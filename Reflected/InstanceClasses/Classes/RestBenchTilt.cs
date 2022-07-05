namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RestBenchTilt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RestBenchTiltR : InstanceClassWrapper<RestBenchTilt>
{
    public RestBenchTiltR(RestBenchTilt _orig) : base(_orig)
    {
    }

    public float tilt
    {
        get => orig.tilt;
        set => orig.tilt = value;
    }


    public float GetTilt()
    {
        return orig.GetTilt();
    }
}