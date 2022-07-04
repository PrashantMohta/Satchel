namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HiveKnightStinger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HiveKnightStingerR:InstanceClassWrapper<HiveKnightStinger>
{
public HiveKnightStingerR(HiveKnightStinger _orig) : base(_orig) {}
public float direction
{
get => orig.direction;
set => orig.direction = value;
}

public float speed
{
get => GetField<float>();
set => SetField(value);
}

public float time
{
get => GetField<float>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public bool initialised
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Vector3 startPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
