using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LogoLanguage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LogoLanguageR : InstanceClassWrapper<LogoLanguage>
{
    public LogoLanguageR(LogoLanguage _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
    {
        get => orig.spriteRenderer;
        set => orig.spriteRenderer = value;
    }

    public Image uiImage
    {
        get => orig.uiImage;
        set => orig.uiImage = value;
    }

    public bool setNativeSize
    {
        get => orig.setNativeSize;
        set => orig.setNativeSize = value;
    }

    public Sprite englishSprite
    {
        get => orig.englishSprite;
        set => orig.englishSprite = value;
    }

    public Sprite chineseSprite
    {
        get => orig.chineseSprite;
        set => orig.chineseSprite = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void SetSprite()
    {
        orig.SetSprite();
    }
}