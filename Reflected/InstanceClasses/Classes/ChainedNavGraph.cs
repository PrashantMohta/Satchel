using Modding.Menu;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ChainedNavGraph allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ChainedNavGraphR : InstanceClassWrapper<ChainedNavGraph>
{
    public ChainedNavGraphR(ChainedNavGraph _orig) : base(_orig)
    {
    }

    public Selectable first
    {
        get => GetField<Selectable>();
        set => SetField(value);
    }

    public Selectable last
    {
        get => GetField<Selectable>();
        set => SetField(value);
    }

    public void AddNavigationNode(Selectable selectable)
    {
        orig.AddNavigationNode(selectable);
    }

    public Selectable BuildNavigation()
    {
        return orig.BuildNavigation();
    }
}