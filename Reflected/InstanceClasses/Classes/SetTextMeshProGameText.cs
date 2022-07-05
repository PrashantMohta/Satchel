using Language;
using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetTextMeshProGameText allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetTextMeshProGameTextR : InstanceClassWrapper<SetTextMeshProGameText>
{
    public SetTextMeshProGameTextR(SetTextMeshProGameText _orig) : base(_orig)
    {
    }

    public TextMeshPro textMesh
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public string sheetName
    {
        get => orig.sheetName;
        set => orig.sheetName = value;
    }

    public string convName
    {
        get => orig.convName;
        set => orig.convName = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UpdateText()
    {
        orig.UpdateText();
    }

    public void ChangedLanguage(LanguageCode code)
    {
        CallMethod(new object[] { code });
    }
}