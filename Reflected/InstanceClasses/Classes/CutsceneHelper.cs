namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CutsceneHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CutsceneHelperR : InstanceClassWrapper<CutsceneHelper>
{
    public CutsceneHelperR(CutsceneHelper _orig) : base(_orig)
    {
    }

    public float waitBeforeFadeIn
    {
        get => orig.waitBeforeFadeIn;
        set => orig.waitBeforeFadeIn = value;
    }

    public CameraFadeInType fadeInSpeed
    {
        get => orig.fadeInSpeed;
        set => orig.fadeInSpeed = value;
    }

    public SkipPromptMode skipMode
    {
        get => orig.skipMode;
        set => orig.skipMode = value;
    }

    public bool startSkipLocked
    {
        get => orig.startSkipLocked;
        set => orig.startSkipLocked = value;
    }

    public bool resetOnStart
    {
        get => orig.resetOnStart;
        set => orig.resetOnStart = value;
    }

    public string nextScene
    {
        get => orig.nextScene;
        set => orig.nextScene = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }


    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void LoadNextScene()
    {
        orig.LoadNextScene();
    }

    public IEnumerator SkipCutscene()
    {
        return orig.SkipCutscene();
    }

    public void UnlockSkip()
    {
        orig.UnlockSkip();
    }

    public void DoSceneLoad()
    {
        CallMethod();
    }
}