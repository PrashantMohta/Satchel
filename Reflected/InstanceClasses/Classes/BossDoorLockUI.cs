namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorLockUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorLockUIR : InstanceClassWrapper<BossDoorLockUI>
{
    public BossDoorLockUIR(BossDoorLockUI _orig) : base(_orig)
    {
    }

    public GameObject iconParent
    {
        get => orig.iconParent;
        set => orig.iconParent = value;
    }

    public BossDoorLockUIIcon[] bossIcons
    {
        get => GetField<BossDoorLockUIIcon[]>();
        set => SetField(value);
    }

    public CanvasGroup buttonPrompts
    {
        get => orig.buttonPrompts;
        set => orig.buttonPrompts = value;
    }

    public float buttonPromptFadeTime
    {
        get => orig.buttonPromptFadeTime;
        set => orig.buttonPromptFadeTime = value;
    }

    public Coroutine fadeRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine fadeButtonRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public CanvasGroup group
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Show(BossSequenceDoor door)
    {
        orig.Show(door);
    }

    public void Hide()
    {
        orig.Hide();
    }

    public IEnumerator ShowRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator HideRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator FadeButtonPrompts(float toAlpha, float time)
    {
        return CallMethod<IEnumerator>(new object[] { toAlpha, time });
    }
}