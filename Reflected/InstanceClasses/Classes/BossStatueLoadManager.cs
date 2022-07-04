namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueLoadManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueLoadManagerR:InstanceClassWrapper<BossStatueLoadManager>
{
public BossStatueLoadManagerR(BossStatueLoadManager _orig) : base(_orig) {}
public BossScene currentBossScene
{
get => GetFieldStatic<BossScene>();
set => SetField(value);
}

public BossScene previousBossScene
{
get => GetFieldStatic<BossScene>();
set => SetField(value);
}

public int activeCount
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public bool ShouldUnload
{
get => BossStatueLoadManager.ShouldUnload;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Clear () =>
BossStatueLoadManager.Clear();

public void RecordBossScene (BossScene bossScene) =>
BossStatueLoadManager.RecordBossScene(bossScene);

}
}
