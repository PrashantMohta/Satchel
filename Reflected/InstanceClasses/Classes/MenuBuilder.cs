namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuBuilder allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuBuilderR:InstanceClassWrapper<Modding.Menu.MenuBuilder>
{
public MenuBuilderR(Modding.Menu.MenuBuilder _orig) : base(_orig) {}
public System.Action<Modding.Menu.MenuBuilder> OnBuild
{
get => GetField<System.Action<Modding.Menu.MenuBuilder>>();
set => SetField(value);
}

public UnityEngine.GameObject MenuObject
{
get => orig.MenuObject;
set => orig.MenuObject = value;
}

public MenuScreen Screen
{
get => orig.Screen;
set => orig.Screen = value;
}

public Modding.Menu.INavigationGraph DefaultNavGraph
{
get => orig.DefaultNavGraph;
set => SetProperty(value);
}

public MenuScreen Build () =>
orig.Build();

public Modding.Menu.MenuBuilder AddContent (Modding.Menu.IContentLayout layout, Modding.Menu.INavigationGraph navgraph, System.Action<Modding.Menu.ContentArea> action) =>
orig.AddContent(layout, navgraph, action);

public Modding.Menu.MenuBuilder AddContent (Modding.Menu.IContentLayout layout, System.Action<Modding.Menu.ContentArea> action) =>
orig.AddContent(layout, action);

public Modding.Menu.MenuBuilder AddControls (Modding.Menu.IContentLayout layout, Modding.Menu.INavigationGraph navgraph, System.Action<Modding.Menu.ContentArea> action) =>
orig.AddControls(layout, navgraph, action);

public Modding.Menu.MenuBuilder AddControls (Modding.Menu.IContentLayout layout, System.Action<Modding.Menu.ContentArea> action) =>
orig.AddControls(layout, action);

public Modding.Menu.MenuBuilder CreateTitle (string title, Modding.Menu.Config.MenuTitleStyle style) =>
orig.CreateTitle(title, style);

public Modding.Menu.MenuBuilder CreateContentPane (Modding.Menu.RectTransformData style) =>
orig.CreateContentPane(style);

public Modding.Menu.MenuBuilder CreateControlPane (Modding.Menu.RectTransformData style) =>
orig.CreateControlPane(style);

public Modding.Menu.MenuBuilder SetDefaultNavGraph (Modding.Menu.INavigationGraph navGraph) =>
orig.SetDefaultNavGraph(navGraph);

}
}
