using Modding.Menu;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnumeratorLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnumeratorLayoutR : InstanceClassWrapper<EnumeratorLayout>
{
    public EnumeratorLayoutR(EnumeratorLayout _orig) : base(_orig)
    {
    }

    public IEnumerator<AnchoredPosition> generator
    {
        get => GetField<IEnumerator<AnchoredPosition>>();
        set => SetField(value);
    }

    public void ModifyNext(RectTransform rt)
    {
        orig.ModifyNext(rt);
    }
}