namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TitleLogo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TitleLogoR : InstanceClassWrapper<TitleLogo>
{
    public TitleLogoR(TitleLogo _orig) : base(_orig)
    {
    }

    public StartManager startManager
    {
        get => orig.startManager;
        set => orig.startManager = value;
    }


    public void AnimationFinished()
    {
        orig.AnimationFinished();
    }
}