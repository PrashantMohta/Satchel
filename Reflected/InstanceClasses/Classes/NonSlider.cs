namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of NonSlider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NonSliderR : InstanceClassWrapper<NonSlider>
{
    public NonSliderR(NonSlider _orig) : base(_orig)
    {
    }
}