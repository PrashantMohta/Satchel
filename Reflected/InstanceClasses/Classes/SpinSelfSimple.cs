namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpinSelfSimple allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpinSelfSimpleR:InstanceClassWrapper<SpinSelfSimple>
{
public SpinSelfSimpleR(SpinSelfSimple _orig) : base(_orig) {}
public bool randomStartRotation
{
get => orig.randomStartRotation;
set => orig.randomStartRotation = value;
}

public float spinFactor
{
get => orig.spinFactor;
set => orig.spinFactor = value;
}

public bool waitForCall
{
get => orig.waitForCall;
set => orig.waitForCall = value;
}

public UnityEngine.Rigidbody2D rb
{
get => orig.rb;
set => orig.rb = value;
}

public bool timing
{
get => GetField<bool>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}



public void Update () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void DoSpin () =>
orig.DoSpin();

}
}
