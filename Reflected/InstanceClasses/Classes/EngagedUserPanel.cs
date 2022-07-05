using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EngagedUserPanel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EngagedUserPanelR : InstanceClassWrapper<EngagedUserPanel>
{
    public EngagedUserPanelR(EngagedUserPanel _orig) : base(_orig)
    {
    }

    public CanvasGroup canvasGroup
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public Text displayNameText
    {
        get => GetField<Text>();
        set => SetField(value);
    }

    public RawImage displayImageImage
    {
        get => GetField<RawImage>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UpdateContent()
    {
        CallMethod();
    }
}