using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AutoLocalizeTextUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoLocalizeTextUIR : InstanceClassWrapper<AutoLocalizeTextUI>
{
    public AutoLocalizeTextUIR(AutoLocalizeTextUI _orig) : base(_orig)
    {
    }

    public Text textField
    {
        get => orig.textField;
        set => orig.textField = value;
    }

    public string sheetTitle
    {
        get => orig.sheetTitle;
        set => orig.sheetTitle = value;
    }

    public string textKey
    {
        get => orig.textKey;
        set => orig.textKey = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public FixVerticalAlign textAligner
    {
        get => GetField<FixVerticalAlign>();
        set => SetField(value);
    }

    public bool hasTextAligner
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void RefreshTextFromLocalization()
    {
        orig.RefreshTextFromLocalization();
    }
}