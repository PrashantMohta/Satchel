namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetZRandom allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetZRandomR:InstanceClassWrapper<SetZRandom>
{
public SetZRandomR(SetZRandom _orig) : base(_orig) {}
public float zMin
{
get => orig.zMin;
set => orig.zMin = value;
}

public float zMax
{
get => orig.zMax;
set => orig.zMax = value;
}



public void OnEnable () =>
CallMethod();

}
}
