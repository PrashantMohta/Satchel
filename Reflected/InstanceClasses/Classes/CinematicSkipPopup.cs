namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicSkipPopup allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicSkipPopupR : InstanceClassWrapper<CinematicSkipPopup>
{
    public CinematicSkipPopupR(CinematicSkipPopup _orig) : base(_orig)
    {
    }

    public CanvasGroup canvasGroup
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public GameObject[] textGroups
    {
        get => GetField<GameObject[]>();
        set => SetField(value);
    }

    public float fadeInDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float holdDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeOutDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isShowing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float showTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Show(CinematicSkipPopup.Texts text)
    {
        orig.Show(text);
    }

    public IEnumerator ShowRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public void Hide()
    {
        orig.Hide();
    }

    public void Update()
    {
        CallMethod();
    }
}