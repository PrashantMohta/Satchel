namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RotationController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RotationControllerR:InstanceClassWrapper<RotationController>
{
public RotationControllerR(RotationController _orig) : base(_orig) {}
public float speed
{
get => orig.speed;
set => orig.speed = value;
}



public void Update () =>
CallMethod();

}
}
