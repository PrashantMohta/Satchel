namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetAngleToVelocity allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetAngleToVelocityR:InstanceClassWrapper<SetAngleToVelocity>
{
public SetAngleToVelocityR(SetAngleToVelocity _orig) : base(_orig) {}
public UnityEngine.Rigidbody2D rb
{
get => orig.rb;
set => orig.rb = value;
}

public float angleOffset
{
get => orig.angleOffset;
set => orig.angleOffset = value;
}



public void Update () =>
CallMethod();

}
}
