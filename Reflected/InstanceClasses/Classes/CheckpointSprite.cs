namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CheckpointSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckpointSpriteR:InstanceClassWrapper<CheckpointSprite>
{
public CheckpointSpriteR(CheckpointSprite _orig) : base(_orig) {}
public UnityEngine.UI.Image image
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Sprite[] startSprites
{
get => GetField<UnityEngine.Sprite[]>();
set => SetField(value);
}

public UnityEngine.Sprite[] loopSprites
{
get => GetField<UnityEngine.Sprite[]>();
set => SetField(value);
}

public UnityEngine.Sprite[] endSprites
{
get => GetField<UnityEngine.Sprite[]>();
set => SetField(value);
}

public float framesPerSecond
{
get => GetField<float>();
set => SetField(value);
}

public bool isShowing
{
get => GetField<bool>();
set => SetField(value);
}

public float frameTimer
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void Show () =>
orig.Show();

public void Hide () =>
orig.Hide();

public void Update () =>
CallMethod();

public void Update (float deltaTime) =>
CallMethod(new object[] {deltaTime});

}
}
