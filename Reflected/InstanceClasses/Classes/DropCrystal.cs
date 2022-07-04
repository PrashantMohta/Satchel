namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DropCrystal allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DropCrystalR:InstanceClassWrapper<DropCrystal>
{
public DropCrystalR(DropCrystal _orig) : base(_orig) {}
public float bounceFactor
{
get => orig.bounceFactor;
set => orig.bounceFactor = value;
}

public float speedThreshold
{
get => orig.speedThreshold;
set => orig.speedThreshold = value;
}

public float speed
{
get => GetField<float>();
set => SetField(value);
}

public float animTimer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 velocity
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 lastPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public int chooser
{
get => GetField<int>();
set => SetField(value);
}

public bool bouncing
{
get => GetField<bool>();
set => SetField(value);
}

public int stepCounter
{
get => GetField<int>();
set => SetField(value);
}

public float xSpeed
{
get => GetField<float>();
set => SetField(value);
}

public float ySpeed
{
get => GetField<float>();
set => SetField(value);
}

public bool onConveyor
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector3 startPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnEnable () =>
orig.OnEnable();

public void FixedUpdate () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D col) =>
CallMethod(new object[] {col});

public void LateUpdate () =>
CallMethod();

public void StartConveyorMove (float c_xSpeed, float c_ySpeed) =>
orig.StartConveyorMove(c_xSpeed, c_ySpeed);

public void StopConveyorMove () =>
orig.StopConveyorMove();

}
}
