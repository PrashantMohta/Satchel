namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorCage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorCageR:InstanceClassWrapper<BossDoorCage>
{
public BossDoorCageR(BossDoorCage _orig) : base(_orig) {}
public BossSequenceDoor[] requiredComplete
{
get => orig.requiredComplete;
set => orig.requiredComplete = value;
}

public TriggerEnterEvent unlockTrigger
{
get => orig.unlockTrigger;
set => orig.unlockTrigger = value;
}

public string playerData
{
get => orig.playerData;
set => orig.playerData = value;
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public CameraControlAnimationEvents cameraShake
{
get => GetField<CameraControlAnimationEvents>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Unlock () =>
CallMethod();

public System.Collections.IEnumerator UnlockRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public void StartShakeLock () =>
orig.StartShakeLock();

public void StopShakeLock () =>
orig.StopShakeLock();

}
}
