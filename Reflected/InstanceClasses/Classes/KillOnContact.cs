namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of KillOnContact allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KillOnContactR:InstanceClassWrapper<KillOnContact>
{
public KillOnContactR(KillOnContact _orig) : base(_orig) {}


public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

}
}
