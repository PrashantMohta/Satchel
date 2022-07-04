namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuStyleUnlock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuStyleUnlockR:InstanceClassWrapper<MenuStyleUnlock>
{
public MenuStyleUnlockR(MenuStyleUnlock _orig) : base(_orig) {}
public string unlockKey
{
get => orig.unlockKey;
set => orig.unlockKey = value;
}



public void Start () =>
CallMethod();

public void Unlock (string key) =>
MenuStyleUnlock.Unlock(key);

}
}
