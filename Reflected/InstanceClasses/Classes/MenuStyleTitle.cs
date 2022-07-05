namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuStyleTitle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuStyleTitleR : InstanceClassWrapper<MenuStyleTitle>
{
    public MenuStyleTitleR(MenuStyleTitle _orig) : base(_orig)
    {
    }

    public SpriteRenderer Title
    {
        get => orig.Title;
        set => orig.Title = value;
    }

    public MenuStyleTitle.TitleSpriteCollection[] TitleSprites
    {
        get => orig.TitleSprites;
        set => orig.TitleSprites = value;
    }


    public void SetTitle(int index)
    {
        orig.SetTitle(index);
    }
}