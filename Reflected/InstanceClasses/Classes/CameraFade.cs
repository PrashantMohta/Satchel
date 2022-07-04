namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CameraFade allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraFadeR : InstanceClassWrapper<CameraFade>
{
    public CameraFadeR(CameraFade _orig) : base(_orig)
    {
    }

    public GUIStyle backgroundStyle
    {
        get => GetField<GUIStyle>();
        set => SetField(value);
    }

    public Texture2D fadeTexture
    {
        get => GetField<Texture2D>();
        set => SetField(value);
    }

    public Color currentScreenOverlayColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color targetScreenOverlayColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color deltaColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public int fadeGUIDepth
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float startDelay
    {
        get => orig.startDelay;
        set => orig.startDelay = value;
    }

    public float fadeTime
    {
        get => orig.fadeTime;
        set => orig.fadeTime = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void SetScreenOverlayColor(Color newScreenOverlayColor)
    {
        orig.SetScreenOverlayColor(newScreenOverlayColor);
    }

    public void StartFade(Color newScreenOverlayColor, float fadeDuration)
    {
        orig.StartFade(newScreenOverlayColor, fadeDuration);
    }

    public void FadeToBlack(float duration)
    {
        orig.FadeToBlack(duration);
    }

    public void FadeToTransparent(float duration)
    {
        orig.FadeToTransparent(duration);
    }
}