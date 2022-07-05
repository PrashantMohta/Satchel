using Modding.Menu;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SingleContentLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SingleContentLayoutR : InstanceClassWrapper<SingleContentLayout>
{
    public SingleContentLayoutR(SingleContentLayout _orig) : base(_orig)
    {
    }

    public AnchoredPosition Position
    {
        get => orig.Position;
        set => orig.Position = value;
    }

    public void ModifyNext(RectTransform rt)
    {
        orig.ModifyNext(rt);
    }
}