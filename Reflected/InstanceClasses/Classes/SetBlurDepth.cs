namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetBlurDepth allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetBlurDepthR : InstanceClassWrapper<SetBlurDepth>
{
    public SetBlurDepthR(SetBlurDepth _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}