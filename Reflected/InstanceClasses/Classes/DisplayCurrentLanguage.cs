using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DisplayCurrentLanguage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DisplayCurrentLanguageR : InstanceClassWrapper<DisplayCurrentLanguage>
{
    public DisplayCurrentLanguageR(DisplayCurrentLanguage _orig) : base(_orig)
    {
    }

    public Text textObject
    {
        get => orig.textObject;
        set => orig.textObject = value;
    }

    public string replaceText
    {
        get => orig.replaceText;
        set => orig.replaceText = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }
}