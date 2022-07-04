namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ContentArea allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ContentAreaR:InstanceClassWrapper<Modding.Menu.ContentArea>
{
public ContentAreaR(Modding.Menu.ContentArea _orig) : base(_orig) {}
public UnityEngine.GameObject ContentObject
{
get => orig.ContentObject;
set => SetProperty(value);
}

public Modding.Menu.IContentLayout Layout
{
get => orig.Layout;
set => orig.Layout = value;
}

public Modding.Menu.INavigationGraph NavGraph
{
get => orig.NavGraph;
set => orig.NavGraph = value;
}

}
}
