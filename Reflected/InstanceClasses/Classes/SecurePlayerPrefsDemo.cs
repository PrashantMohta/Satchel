namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SecurePlayerPrefsDemo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecurePlayerPrefsDemoR:InstanceClassWrapper<SecurePlayerPrefsDemo>
{
public SecurePlayerPrefsDemoR(SecurePlayerPrefsDemo _orig) : base(_orig) {}


public void Start () =>
CallMethod();

}
}
