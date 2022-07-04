namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DebrisPiece allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DebrisPieceR:InstanceClassWrapper<DebrisPiece>
{
public DebrisPieceR(DebrisPiece _orig) : base(_orig) {}
public bool resetOnDisable
{
get => GetField<bool>();
set => SetField(value);
}

public bool didLaunch
{
get => GetField<bool>();
set => SetField(value);
}

public bool didSpin
{
get => GetField<bool>();
set => SetField(value);
}

public bool forceZ
{
get => GetField<bool>();
set => SetField(value);
}

public float forcedZ
{
get => GetField<float>();
set => SetField(value);
}

public bool randomStartRotation
{
get => GetField<bool>();
set => SetField(value);
}

public float zRandomRadius
{
get => GetField<float>();
set => SetField(value);
}

public float spinFactor
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Launch () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void Spin () =>
CallMethod();

}
}
