namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuScreen allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuScreenR:InstanceClassWrapper<MenuScreen>
{
public MenuScreenR(MenuScreen _orig) : base(_orig) {}
public UnityEngine.CanvasGroup title
{
get => orig.title;
set => orig.title = value;
}

public UnityEngine.Animator topFleur
{
get => orig.topFleur;
set => orig.topFleur = value;
}

public UnityEngine.CanvasGroup content
{
get => orig.content;
set => orig.content = value;
}

public UnityEngine.CanvasGroup controls
{
get => orig.controls;
set => orig.controls = value;
}

public UnityEngine.UI.Selectable defaultHighlight
{
get => orig.defaultHighlight;
set => orig.defaultHighlight = value;
}

public UnityEngine.Animator bottomFleur
{
get => orig.bottomFleur;
set => orig.bottomFleur = value;
}

public UnityEngine.CanvasGroup screenCanvasGroup
{
get => orig.screenCanvasGroup;
}



public void HighlightDefault () =>
orig.HighlightDefault();

}
}
