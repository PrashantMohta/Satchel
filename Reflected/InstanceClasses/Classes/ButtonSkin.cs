namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ButtonSkin allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ButtonSkinR : InstanceClassWrapper<ButtonSkin>
{
    public ButtonSkinR(ButtonSkin _orig) : base(_orig)
    {
    }

    public Sprite sprite
    {
        get => orig.sprite;
        set => orig.sprite = value;
    }

    public string symbol
    {
        get => orig.symbol;
        set => orig.symbol = value;
    }

    public ButtonSkinType skinType
    {
        get => orig.skinType;
        set => orig.skinType = value;
    }
}