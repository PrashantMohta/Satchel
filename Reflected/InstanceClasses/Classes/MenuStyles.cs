namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuStyles allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuStylesR : InstanceClassWrapper<MenuStyles>
{
    public MenuStylesR(MenuStyles _orig) : base(_orig)
    {
    }

    public MenuStyles Instance
    {
        get => MenuStyles.Instance;
        set => MenuStyles.Instance = value;
    }

    public MenuStyles.MenuStyle[] styles
    {
        get => orig.styles;
        set => orig.styles = value;
    }

    public MenuStyles.StyleSettingsPlatform[] StylePlatforms
    {
        get => orig.StylePlatforms;
        set => orig.StylePlatforms = value;
    }

    public SpriteRenderer blackSolid
    {
        get => orig.blackSolid;
        set => orig.blackSolid = value;
    }

    public float fadeTime
    {
        get => orig.fadeTime;
        set => orig.fadeTime = value;
    }

    public Coroutine fadeRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public MenuStyleTitle title
    {
        get => orig.title;
        set => orig.title = value;
    }

    public bool subscribed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int CurrentStyle => orig.CurrentStyle;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void LoadStyle(bool force, bool fade)
    {
        orig.LoadStyle(force, fade);
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void SetStyle(int index, bool fade, bool save = true)
    {
        orig.SetStyle(index, fade, save);
    }

    public IEnumerator SwitchStyle(int index, bool fade, int oldIndex)
    {
        return CallMethod<IEnumerator>(new object[] { index, fade, oldIndex });
    }

    public void StopAudio()
    {
        orig.StopAudio();
    }

    public IEnumerator FadeOutAudio(AudioSource[] audioSources)
    {
        return CallMethod<IEnumerator>(new object[] { audioSources });
    }

    public void UnlockFromAchievements()
    {
        orig.UnlockFromAchievements();
    }

    public void UpdateTitle()
    {
        orig.UpdateTitle();
    }
}