namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of IdleBuzzing allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class IdleBuzzingR:InstanceClassWrapper<IdleBuzzing>
{
public IdleBuzzingR(IdleBuzzing _orig) : base(_orig) {}
public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public float waitMin
{
get => GetField<float>();
set => SetField(value);
}

public float waitMax
{
get => GetField<float>();
set => SetField(value);
}

public float speedMax
{
get => GetField<float>();
set => SetField(value);
}

public float accelerationMax
{
get => GetField<float>();
set => SetField(value);
}

public float roamingRange
{
get => GetField<float>();
set => SetField(value);
}

public float dampener
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 start2D
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 acceleration2D
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float waitTimer
{
get => GetField<float>();
set => SetField(value);
}

public float InspectorAccelerationConstant
{
get => GetFieldStatic<float>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void Buzz (float deltaTime) =>
CallMethod(new object[] {deltaTime});

}
}
