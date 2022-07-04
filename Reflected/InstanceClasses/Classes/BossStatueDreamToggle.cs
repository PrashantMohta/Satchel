namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueDreamToggle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueDreamToggleR:InstanceClassWrapper<BossStatueDreamToggle>
{
public BossStatueDreamToggleR(BossStatueDreamToggle _orig) : base(_orig) {}
public UnityEngine.GameObject litPieces
{
get => orig.litPieces;
set => orig.litPieces = value;
}

public UnityEngine.ParticleSystem[] particles
{
get => orig.particles;
set => orig.particles = value;
}

public UnityEngine.GameObject dreamImpactPrefab
{
get => orig.dreamImpactPrefab;
set => orig.dreamImpactPrefab = value;
}

public UnityEngine.Vector3 dreamImpactScale
{
get => orig.dreamImpactScale;
set => orig.dreamImpactScale = value;
}

public UnityEngine.Transform dreamImpactPoint
{
get => orig.dreamImpactPoint;
set => orig.dreamImpactPoint = value;
}

public bool canToggle
{
get => GetField<bool>();
set => SetField(value);
}

public ColorFader[] colorFaders
{
get => GetField<ColorFader[]>();
set => SetField(value);
}

public int waitingForFade
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.GameObject dreamBurstEffectPrefab
{
get => orig.dreamBurstEffectPrefab;
set => orig.dreamBurstEffectPrefab = value;
}

public UnityEngine.GameObject dreamBurstEffectOffPrefab
{
get => orig.dreamBurstEffectOffPrefab;
set => orig.dreamBurstEffectOffPrefab = value;
}

public UnityEngine.Transform dreamBurstSpawnPoint
{
get => orig.dreamBurstSpawnPoint;
set => orig.dreamBurstSpawnPoint = value;
}

public UnityEngine.GameObject dreamBurstEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject dreamBurstEffectOff
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public BossStatue bossStatue
{
get => GetField<BossStatue>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public System.Collections.IEnumerator Fade (bool usingDreamVersion) =>
CallMethod<System.Collections.IEnumerator>(new object[] {usingDreamVersion});

public void SetOwner (BossStatue statue) =>
orig.SetOwner(statue);

public void SetState (bool value) =>
orig.SetState(value);

}
}
