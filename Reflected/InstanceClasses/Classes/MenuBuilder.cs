using Modding.Menu;
using Modding.Menu.Config;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuBuilder allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuBuilderR : InstanceClassWrapper<MenuBuilder>
{
    public MenuBuilderR(MenuBuilder _orig) : base(_orig)
    {
    }

    public Action<MenuBuilder> OnBuild
    {
        get => GetField<Action<MenuBuilder>>();
        set => SetField(value);
    }

    public GameObject MenuObject
    {
        get => orig.MenuObject;
        set => orig.MenuObject = value;
    }

    public MenuScreen Screen
    {
        get => orig.Screen;
        set => orig.Screen = value;
    }

    public INavigationGraph DefaultNavGraph
    {
        get => orig.DefaultNavGraph;
        set => SetProperty(value);
    }

    public MenuScreen Build()
    {
        return orig.Build();
    }

    public MenuBuilder AddContent(IContentLayout layout, INavigationGraph navgraph, Action<ContentArea> action)
    {
        return orig.AddContent(layout, navgraph, action);
    }

    public MenuBuilder AddContent(IContentLayout layout, Action<ContentArea> action)
    {
        return orig.AddContent(layout, action);
    }

    public MenuBuilder AddControls(IContentLayout layout, INavigationGraph navgraph, Action<ContentArea> action)
    {
        return orig.AddControls(layout, navgraph, action);
    }

    public MenuBuilder AddControls(IContentLayout layout, Action<ContentArea> action)
    {
        return orig.AddControls(layout, action);
    }

    public MenuBuilder CreateTitle(string title, MenuTitleStyle style)
    {
        return orig.CreateTitle(title, style);
    }

    public MenuBuilder CreateContentPane(RectTransformData style)
    {
        return orig.CreateContentPane(style);
    }

    public MenuBuilder CreateControlPane(RectTransformData style)
    {
        return orig.CreateControlPane(style);
    }

    public MenuBuilder SetDefaultNavGraph(INavigationGraph navGraph)
    {
        return orig.SetDefaultNavGraph(navGraph);
    }
}