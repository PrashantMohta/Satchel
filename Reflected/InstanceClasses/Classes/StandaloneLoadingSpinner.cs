namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of StandaloneLoadingSpinner allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StandaloneLoadingSpinnerR:InstanceClassWrapper<StandaloneLoadingSpinner>
{
public StandaloneLoadingSpinnerR(StandaloneLoadingSpinner _orig) : base(_orig) {}
public UnityEngine.Camera renderingCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public UnityEngine.UI.Image backgroundImage
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public UnityEngine.UI.Image image
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public float displayDelay
{
get => GetField<float>();
set => SetField(value);
}

public float fadeDuration
{
get => GetField<float>();
set => SetField(value);
}

public float fadeAmount
{
get => GetField<float>();
set => SetField(value);
}

public float fadeVariance
{
get => GetField<float>();
set => SetField(value);
}

public float fadePulseDuration
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Sprite[] sprites
{
get => GetField<UnityEngine.Sprite[]>();
set => SetField(value);
}

public float frameRate
{
get => GetField<float>();
set => SetField(value);
}

public float fadeFactor
{
get => GetField<float>();
set => SetField(value);
}

public float frameTimer
{
get => GetField<float>();
set => SetField(value);
}

public int frameIndex
{
get => GetField<int>();
set => SetField(value);
}

public float timeRunning
{
get => GetField<float>();
set => SetField(value);
}

public bool isComplete
{
get => GetField<bool>();
set => SetField(value);
}

public GameManager lastGameManager
{
get => GetField<GameManager>();
set => SetField(value);
}



public void Setup (GameManager lastGameManager) =>
orig.Setup(lastGameManager);

public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void LateUpdate () =>
CallMethod();

}
}
