namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SplashAnimator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SplashAnimatorR : InstanceClassWrapper<SplashAnimator>
{
    public SplashAnimatorR(SplashAnimator _orig) : base(_orig)
    {
    }

    public float scaleMin
    {
        get => orig.scaleMin;
        set => orig.scaleMin = value;
    }

    public float scaleMax
    {
        get => orig.scaleMax;
        set => orig.scaleMax = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }
}