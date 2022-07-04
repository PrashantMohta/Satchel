namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of StartManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StartManagerR:InstanceClassWrapper<StartManager>
{
public StartManagerR(StartManager _orig) : base(_orig) {}
public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Animator startManagerAnimator
{
get => orig.startManagerAnimator;
set => orig.startManagerAnimator = value;
}

public UnityEngine.UI.Slider progressIndicator
{
get => orig.progressIndicator;
set => orig.progressIndicator = value;
}

public StandaloneLoadingSpinner loadSpinnerPrefab
{
get => GetField<StandaloneLoadingSpinner>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer controllerImage
{
get => orig.controllerImage;
set => orig.controllerImage = value;
}

public UnityEngine.Sprite winController
{
get => orig.winController;
set => orig.winController = value;
}

public UnityEngine.Sprite osxController
{
get => orig.osxController;
set => orig.osxController = value;
}

public SetTextMeshProGameText controllerNoticeText
{
get => orig.controllerNoticeText;
set => orig.controllerNoticeText = value;
}

public UnityEngine.CanvasGroup languageSelect
{
get => orig.languageSelect;
set => orig.languageSelect = value;
}

public UnityEngine.Animator languageAnimator
{
get => orig.languageAnimator;
set => orig.languageAnimator = value;
}

public PreselectOption preselector
{
get => orig.preselector;
set => orig.preselector = value;
}

public UnityEngine.CanvasGroup languageConfirm
{
get => orig.languageConfirm;
set => orig.languageConfirm = value;
}

public string selectedLanguage
{
get => GetField<string>();
set => SetField(value);
}

public string oldLanguage
{
get => GetField<string>();
set => SetField(value);
}

public InControl.InControlInputModule inputModule
{
get => orig.inputModule;
set => orig.inputModule = value;
}

public MenuAudioController uiAudioPlayer
{
get => orig.uiAudioPlayer;
set => orig.uiAudioPlayer = value;
}

public bool showProgessIndicator
{
get => orig.showProgessIndicator;
set => orig.showProgessIndicator = value;
}

public UnityEngine.AsyncOperation loadop
{
get => GetField<UnityEngine.AsyncOperation>();
set => SetField(value);
}

public UnityEngine.RuntimePlatform platform
{
get => GetField<UnityEngine.RuntimePlatform>();
set => SetField(value);
}

public string logoTrigger
{
get => GetField<string>();
set => SetField(value);
}

public string controllerTrigger
{
get => GetField<string>();
set => SetField(value);
}

public string loadingIconTrigger
{
get => GetField<string>();
set => SetField(value);
}

public float fadeSpeed
{
get => GetField<float>();
set => SetField(value);
}

public bool confirmedLanguage
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public UnityEngine.Sprite GetControllerSpriteForPlatform (UnityEngine.RuntimePlatform runtimePlatform) =>
CallMethod<UnityEngine.Sprite>(new object[] {runtimePlatform});

public void SwitchToMenuScene () =>
orig.SwitchToMenuScene();

public void SetLanguage (string newLanguage) =>
orig.SetLanguage(newLanguage);

public System.Collections.IEnumerator FadeIn (UnityEngine.CanvasGroup group, float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {group, duration});

public System.Collections.IEnumerator FadeOut (UnityEngine.CanvasGroup group, float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {group, duration});

public bool CheckIsLanguageSet () =>
orig.CheckIsLanguageSet();

public void ConfirmLanguage () =>
orig.ConfirmLanguage();

public void CancelLanguage () =>
orig.CancelLanguage();

public System.Collections.IEnumerator ShowLanguageSelect () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator LanguageSettingDone () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator orig_Start () =>
CallMethod<System.Collections.IEnumerator>();

}
}
