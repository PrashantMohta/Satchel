using Modding.Menu;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuResources allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuResourcesR : InstanceClassWrapper<MenuResources>
{
    public MenuResourcesR(MenuResources _orig) : base(_orig)
    {
    }

    public Font TrajanRegular
    {
        get => MenuResources.TrajanRegular;
        set => SetPropertyStatic(value);
    }

    public Font TrajanBold
    {
        get => MenuResources.TrajanBold;
        set => SetPropertyStatic(value);
    }

    public Font Perpetua
    {
        get => MenuResources.Perpetua;
        set => SetPropertyStatic(value);
    }

    public Font NotoSerifCJKSCRegular
    {
        get => MenuResources.NotoSerifCJKSCRegular;
        set => SetPropertyStatic(value);
    }

    public RuntimeAnimatorController MenuTopFleurAnimator
    {
        get => MenuResources.MenuTopFleurAnimator;
        set => SetPropertyStatic(value);
    }

    public RuntimeAnimatorController MenuCursorAnimator
    {
        get => MenuResources.MenuCursorAnimator;
        set => SetPropertyStatic(value);
    }

    public RuntimeAnimatorController MenuButtonFlashAnimator
    {
        get => MenuResources.MenuButtonFlashAnimator;
        set => SetPropertyStatic(value);
    }

    public AnimatorOverrideController TextHideShowAnimator
    {
        get => MenuResources.TextHideShowAnimator;
        set => SetPropertyStatic(value);
    }

    public Sprite ScrollbarHandleSprite
    {
        get => MenuResources.ScrollbarHandleSprite;
        set => SetPropertyStatic(value);
    }

    public Sprite ScrollbarBackgroundSprite
    {
        get => MenuResources.ScrollbarBackgroundSprite;
        set => SetPropertyStatic(value);
    }

    public void ReloadResources()
    {
        MenuResources.ReloadResources();
    }
}