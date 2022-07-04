namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SimpleRock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SimpleRockR:InstanceClassWrapper<SimpleRock>
{
public SimpleRockR(SimpleRock _orig) : base(_orig) {}
public int stepCounter
{
get => GetField<int>();
set => SetField(value);
}

public bool spun
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public float setZ
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void OnTriggerEnter (UnityEngine.Collider other) =>
CallMethod(new object[] {other});

}
}
