namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CameraFade allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraFadeR:InstanceClassWrapper<CameraFade>
{
public CameraFadeR(CameraFade _orig) : base(_orig) {}
public UnityEngine.GUIStyle backgroundStyle
{
get => GetField<UnityEngine.GUIStyle>();
set => SetField(value);
}

public UnityEngine.Texture2D fadeTexture
{
get => GetField<UnityEngine.Texture2D>();
set => SetField(value);
}

public UnityEngine.Color currentScreenOverlayColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public UnityEngine.Color targetScreenOverlayColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public UnityEngine.Color deltaColor
{
get => GetField<UnityEngine.Color>();
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



public void Awake () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void OnGUI () =>
CallMethod();

public void SetScreenOverlayColor (UnityEngine.Color newScreenOverlayColor) =>
orig.SetScreenOverlayColor(newScreenOverlayColor);

public void StartFade (UnityEngine.Color newScreenOverlayColor, float fadeDuration) =>
orig.StartFade(newScreenOverlayColor, fadeDuration);

public void FadeToBlack (float duration) =>
orig.FadeToBlack(duration);

public void FadeToTransparent (float duration) =>
orig.FadeToTransparent(duration);

}
}
