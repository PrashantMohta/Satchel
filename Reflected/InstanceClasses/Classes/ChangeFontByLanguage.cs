using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ChangeFontByLanguage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ChangeFontByLanguageR : InstanceClassWrapper<ChangeFontByLanguage>
{
    public ChangeFontByLanguageR(ChangeFontByLanguage _orig) : base(_orig)
    {
    }

    public TMP_FontAsset defaultFont
    {
        get => orig.defaultFont;
        set => orig.defaultFont = value;
    }

    public TMP_FontAsset fontJA
    {
        get => orig.fontJA;
        set => orig.fontJA = value;
    }

    public TMP_FontAsset fontRU
    {
        get => orig.fontRU;
        set => orig.fontRU = value;
    }

    public TMP_FontAsset fontZH
    {
        get => orig.fontZH;
        set => orig.fontZH = value;
    }

    public TMP_FontAsset fontKO
    {
        get => orig.fontKO;
        set => orig.fontKO = value;
    }

    public bool onlyOnStart
    {
        get => orig.onlyOnStart;
        set => orig.onlyOnStart = value;
    }

    public TextMeshPro tmpro
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public float startFontSize
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void SetFont()
    {
        orig.SetFont();
    }

    public float GetFontScale(string lang)
    {
        return CallMethod<float>(new object[] { lang });
    }
}