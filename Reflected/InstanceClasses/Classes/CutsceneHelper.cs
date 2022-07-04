namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CutsceneHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CutsceneHelperR:InstanceClassWrapper<CutsceneHelper>
{
public CutsceneHelperR(CutsceneHelper _orig) : base(_orig) {}
public float waitBeforeFadeIn
{
get => orig.waitBeforeFadeIn;
set => orig.waitBeforeFadeIn = value;
}

public GlobalEnums.CameraFadeInType fadeInSpeed
{
get => orig.fadeInSpeed;
set => orig.fadeInSpeed = value;
}

public GlobalEnums.SkipPromptMode skipMode
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



public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void LoadNextScene () =>
orig.LoadNextScene();

public System.Collections.IEnumerator SkipCutscene () =>
orig.SkipCutscene();

public void UnlockSkip () =>
orig.UnlockSkip();

public void DoSceneLoad () =>
CallMethod();

}
}
