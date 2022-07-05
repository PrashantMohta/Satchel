namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequenceBindingsDisplay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSequenceBindingsDisplayR : InstanceClassWrapper<BossSequenceBindingsDisplay>
{
    public BossSequenceBindingsDisplayR(BossSequenceBindingsDisplay _orig) : base(_orig)
    {
    }

    public GameObject[] bindingIcons
    {
        get => orig.bindingIcons;
        set => orig.bindingIcons = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void CountBindings(out int total, out int completed)
    {
        BossSequenceBindingsDisplay.CountBindings(out total, out completed);
    }

    public int CountCompletedBindings()
    {
        return BossSequenceBindingsDisplay.CountCompletedBindings();
    }

    public int CountTotalBindings()
    {
        return BossSequenceBindingsDisplay.CountTotalBindings();
    }
}