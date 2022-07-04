namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CursorHighlight allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CursorHighlightR:InstanceClassWrapper<CursorHighlight>
{
public CursorHighlightR(CursorHighlight _orig) : base(_orig) {}
public UnityEngine.RectTransform myRect
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.Vector2 startPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 targetPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float lerpTime
{
get => orig.lerpTime;
set => orig.lerpTime = value;
}

public float cursorCooldown
{
get => orig.cursorCooldown;
set => orig.cursorCooldown = value;
}

public float lerpTimer
{
get => GetField<float>();
set => SetField(value);
}

public float cooldownTimer
{
get => GetField<float>();
set => SetField(value);
}

public bool coolingDown
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
orig.Awake();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void MoveCursor (UnityEngine.RectTransform buttonRect) =>
orig.MoveCursor(buttonRect);

}
}
