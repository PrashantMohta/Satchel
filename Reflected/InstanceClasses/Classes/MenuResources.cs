namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuResources allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuResourcesR:InstanceClassWrapper<Modding.Menu.MenuResources>
{
public MenuResourcesR(Modding.Menu.MenuResources _orig) : base(_orig) {}
public UnityEngine.Font TrajanRegular
{
get => Modding.Menu.MenuResources.TrajanRegular;
set => SetPropertyStatic(value);
}

public UnityEngine.Font TrajanBold
{
get => Modding.Menu.MenuResources.TrajanBold;
set => SetPropertyStatic(value);
}

public UnityEngine.Font Perpetua
{
get => Modding.Menu.MenuResources.Perpetua;
set => SetPropertyStatic(value);
}

public UnityEngine.Font NotoSerifCJKSCRegular
{
get => Modding.Menu.MenuResources.NotoSerifCJKSCRegular;
set => SetPropertyStatic(value);
}

public UnityEngine.RuntimeAnimatorController MenuTopFleurAnimator
{
get => Modding.Menu.MenuResources.MenuTopFleurAnimator;
set => SetPropertyStatic(value);
}

public UnityEngine.RuntimeAnimatorController MenuCursorAnimator
{
get => Modding.Menu.MenuResources.MenuCursorAnimator;
set => SetPropertyStatic(value);
}

public UnityEngine.RuntimeAnimatorController MenuButtonFlashAnimator
{
get => Modding.Menu.MenuResources.MenuButtonFlashAnimator;
set => SetPropertyStatic(value);
}

public UnityEngine.AnimatorOverrideController TextHideShowAnimator
{
get => Modding.Menu.MenuResources.TextHideShowAnimator;
set => SetPropertyStatic(value);
}

public UnityEngine.Sprite ScrollbarHandleSprite
{
get => Modding.Menu.MenuResources.ScrollbarHandleSprite;
set => SetPropertyStatic(value);
}

public UnityEngine.Sprite ScrollbarBackgroundSprite
{
get => Modding.Menu.MenuResources.ScrollbarBackgroundSprite;
set => SetPropertyStatic(value);
}

public void ReloadResources () =>
Modding.Menu.MenuResources.ReloadResources();

}
}
