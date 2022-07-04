namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ChainedNavGraph allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ChainedNavGraphR:InstanceClassWrapper<Modding.Menu.ChainedNavGraph>
{
public ChainedNavGraphR(Modding.Menu.ChainedNavGraph _orig) : base(_orig) {}
public UnityEngine.UI.Selectable first
{
get => GetField<UnityEngine.UI.Selectable>();
set => SetField(value);
}

public UnityEngine.UI.Selectable last
{
get => GetField<UnityEngine.UI.Selectable>();
set => SetField(value);
}

public void AddNavigationNode (UnityEngine.UI.Selectable selectable) =>
orig.AddNavigationNode(selectable);

public UnityEngine.UI.Selectable BuildNavigation () =>
orig.BuildNavigation();

}
}
