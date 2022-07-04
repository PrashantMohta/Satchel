namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InfectedEnemyEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InfectedEnemyEffectsR:InstanceClassWrapper<InfectedEnemyEffects>
{
public InfectedEnemyEffectsR(InfectedEnemyEffects _orig) : base(_orig) {}
public SpriteFlash spriteFlash
{
get => GetField<SpriteFlash>();
set => SetField(value);
}

public UnityEngine.Vector3 effectOrigin
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public AudioEvent impactAudio
{
get => GetField<AudioEvent>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.GameObject hitFlashOrangePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject spatterOrangePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject hitPuffPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool noBlood
{
get => GetField<bool>();
set => SetField(value);
}

public bool didFireThisFrame
{
get => GetField<bool>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void RecieveHitEffect (float attackDirection) =>
orig.RecieveHitEffect(attackDirection);

public void Update () =>
CallMethod();

}
}
