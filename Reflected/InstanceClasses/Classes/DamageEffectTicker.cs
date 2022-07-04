namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DamageEffectTicker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DamageEffectTickerR:InstanceClassWrapper<DamageEffectTicker>
{
public DamageEffectTickerR(DamageEffectTicker _orig) : base(_orig) {}
public System.Collections.Generic.List<UnityEngine.GameObject> enemyList
{
get => orig.enemyList;
set => orig.enemyList = value;
}

public float damageInterval
{
get => orig.damageInterval;
set => orig.damageInterval = value;
}

public string damageEvent
{
get => orig.damageEvent;
set => orig.damageEvent = value;
}

public ExtraDamageTypes extraDamageType
{
get => orig.extraDamageType;
set => orig.extraDamageType = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerExit2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void EmptyDamageList () =>
orig.EmptyDamageList();

public void SetDamageEvent (string newEvent) =>
orig.SetDamageEvent(newEvent);

public void SetDamageInterval (float newInterval) =>
orig.SetDamageInterval(newInterval);

}
}
