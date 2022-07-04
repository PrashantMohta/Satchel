namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnlockGGMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnlockGGModeR:InstanceClassWrapper<UnlockGGMode>
{
public UnlockGGModeR(UnlockGGMode _orig) : base(_orig) {}


public void Start () =>
CallMethod();

public void SetUnlocked () =>
orig.SetUnlocked();

}
}
