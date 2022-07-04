namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpinSelf allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpinSelfR:InstanceClassWrapper<SpinSelf>
{
public SpinSelfR(SpinSelf _orig) : base(_orig) {}
public float spinFactor
{
get => orig.spinFactor;
set => orig.spinFactor = value;
}

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



public void Start () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

}
}
