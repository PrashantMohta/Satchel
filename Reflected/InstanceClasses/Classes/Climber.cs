namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Climber allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ClimberR:InstanceClassWrapper<Climber>
{
public ClimberR(Climber _orig) : base(_orig) {}
public bool startRight
{
get => orig.startRight;
set => orig.startRight = value;
}

public bool clockwise
{
get => GetField<bool>();
set => SetField(value);
}

public float speed
{
get => orig.speed;
set => orig.speed = value;
}

public float spinTime
{
get => orig.spinTime;
set => orig.spinTime = value;
}

public float wallRayPadding
{
get => orig.wallRayPadding;
set => orig.wallRayPadding = value;
}

public UnityEngine.Vector2 constrain
{
get => orig.constrain;
set => orig.constrain = value;
}

public UnityEngine.Vector2 previousPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float minTurnDistance
{
get => orig.minTurnDistance;
set => orig.minTurnDistance = value;
}

public UnityEngine.Vector2 previousTurnPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Coroutine turnRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.BoxCollider2D col
{
get => GetField<UnityEngine.BoxCollider2D>();
set => SetField(value);
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator Walk () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Turn (bool turnClockwise, bool tweenPos = false) =>
CallMethod<System.Collections.IEnumerator>(new object[] {turnClockwise, tweenPos});

public bool CheckGround () =>
CallMethod<bool>();

public bool CheckWall () =>
CallMethod<bool>();

public void Stun () =>
orig.Stun();

public System.Collections.IEnumerator DoStun () =>
CallMethod<System.Collections.IEnumerator>();

public UnityEngine.RaycastHit2D FireRayLocal (UnityEngine.Vector2 direction, float length) =>
CallMethod<UnityEngine.RaycastHit2D>(new object[] {direction, length});

public void StickToGround () =>
CallMethod();

}
}
