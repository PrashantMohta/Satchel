namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Drip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DripR:InstanceClassWrapper<Drip>
{
public DripR(Drip _orig) : base(_orig) {}
public float minWaitTime
{
get => orig.minWaitTime;
set => orig.minWaitTime = value;
}

public float maxWaitTime
{
get => orig.maxWaitTime;
set => orig.maxWaitTime = value;
}

public UnityEngine.GameObject idleSprite
{
get => orig.idleSprite;
set => orig.idleSprite = value;
}

public UnityEngine.GameObject dripSprite
{
get => orig.dripSprite;
set => orig.dripSprite = value;
}

public UnityEngine.Animator dripAnimator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.Transform dripSpawnPoint
{
get => orig.dripSpawnPoint;
set => orig.dripSpawnPoint = value;
}

public float dripDelay
{
get => orig.dripDelay;
set => orig.dripDelay = value;
}

public UnityEngine.GameObject dripPrefab
{
get => orig.dripPrefab;
set => orig.dripPrefab = value;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator DripRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator DropDrip () =>
CallMethod<System.Collections.IEnumerator>();

}
}
