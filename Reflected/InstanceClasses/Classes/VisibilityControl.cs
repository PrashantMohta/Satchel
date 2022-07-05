namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of VisibilityControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VisibilityControlR : InstanceClassWrapper<VisibilityControl>
{
    public VisibilityControlR(VisibilityControl _orig) : base(_orig)
    {
    }

    public Animator myAnimator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Reveal()
    {
        orig.Reveal();
    }

    public void Hide()
    {
        orig.Hide();
    }
}