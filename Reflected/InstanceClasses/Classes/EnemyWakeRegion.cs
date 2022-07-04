namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyWakeRegion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyWakeRegionR:InstanceClassWrapper<EnemyWakeRegion>
{
public EnemyWakeRegionR(EnemyWakeRegion _orig) : base(_orig) {}
public PlayMakerFSM fsm
{
get => orig.fsm;
set => orig.fsm = value;
}

public string enterEvent
{
get => orig.enterEvent;
set => orig.enterEvent = value;
}

public string exitEvent
{
get => orig.exitEvent;
set => orig.exitEvent = value;
}



public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
