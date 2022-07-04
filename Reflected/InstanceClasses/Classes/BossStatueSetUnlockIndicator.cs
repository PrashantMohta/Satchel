namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueSetUnlockIndicator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueSetUnlockIndicatorR:InstanceClassWrapper<BossStatueSetUnlockIndicator>
{
public BossStatueSetUnlockIndicatorR(BossStatueSetUnlockIndicator _orig) : base(_orig) {}
public int newStatueCount
{
get => GetField<int>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public bool CheckIfNewBossStatue (BossStatue.Completion completion) =>
CallMethod<bool>(new object[] {completion});

}
}
