using InControl;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StartManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StartManagerR : InstanceClassWrapper<StartManager>
{
    public StartManagerR(StartManager _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Animator startManagerAnimator
    {
        get => orig.startManagerAnimator;
        set => orig.startManagerAnimator = value;
    }

    public Slider progressIndicator
    {
        get => orig.progressIndicator;
        set => orig.progressIndicator = value;
    }

    public StandaloneLoadingSpinner loadSpinnerPrefab
    {
        get => GetField<StandaloneLoadingSpinner>();
        set => SetField(value);
    }

    public SpriteRenderer controllerImage
    {
        get => orig.controllerImage;
        set => orig.controllerImage = value;
    }

    public Sprite winController
    {
        get => orig.winController;
        set => orig.winController = value;
    }

    public Sprite osxController
    {
        get => orig.osxController;
        set => orig.osxController = value;
    }

    public SetTextMeshProGameText controllerNoticeText
    {
        get => orig.controllerNoticeText;
        set => orig.controllerNoticeText = value;
    }

    public CanvasGroup languageSelect
    {
        get => orig.languageSelect;
        set => orig.languageSelect = value;
    }

    public Animator languageAnimator
    {
        get => orig.languageAnimator;
        set => orig.languageAnimator = value;
    }

    public PreselectOption preselector
    {
        get => orig.preselector;
        set => orig.preselector = value;
    }

    public CanvasGroup languageConfirm
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

    public InControlInputModule inputModule
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

    public AsyncOperation loadop
    {
        get => GetField<AsyncOperation>();
        set => SetField(value);
    }

    public RuntimePlatform platform
    {
        get => GetField<RuntimePlatform>();
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


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public Sprite GetControllerSpriteForPlatform(RuntimePlatform runtimePlatform)
    {
        return CallMethod<Sprite>(new object[] { runtimePlatform });
    }

    public void SwitchToMenuScene()
    {
        orig.SwitchToMenuScene();
    }

    public void SetLanguage(string newLanguage)
    {
        orig.SetLanguage(newLanguage);
    }

    public IEnumerator FadeIn(CanvasGroup group, float duration)
    {
        return CallMethod<IEnumerator>(new object[] { group, duration });
    }

    public IEnumerator FadeOut(CanvasGroup group, float duration)
    {
        return CallMethod<IEnumerator>(new object[] { group, duration });
    }

    public bool CheckIsLanguageSet()
    {
        return orig.CheckIsLanguageSet();
    }

    public void ConfirmLanguage()
    {
        orig.ConfirmLanguage();
    }

    public void CancelLanguage()
    {
        orig.CancelLanguage();
    }

    public IEnumerator ShowLanguageSelect()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator LanguageSettingDone()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator orig_Start()
    {
        return CallMethod<IEnumerator>();
    }
}