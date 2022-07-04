namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DreamPlant allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DreamPlantR:InstanceClassWrapper<DreamPlant>
{
public DreamPlantR(DreamPlant _orig) : base(_orig) {}
public HeroDetect heroDetector
{
get => orig.heroDetector;
set => orig.heroDetector = value;
}

public UnityEngine.AudioClip glowSound
{
get => orig.glowSound;
set => orig.glowSound = value;
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.ParticleSystem wiltedParticles
{
get => orig.wiltedParticles;
set => orig.wiltedParticles = value;
}

public ColorFader glowFader
{
get => orig.glowFader;
set => orig.glowFader = value;
}

public ColorFader completeGlowFader
{
get => orig.completeGlowFader;
set => orig.completeGlowFader = value;
}

public UnityEngine.AudioClip hitSound
{
get => orig.hitSound;
set => orig.hitSound = value;
}

public UnityEngine.GameObject dreamImpact
{
get => orig.dreamImpact;
set => orig.dreamImpact = value;
}

public UnityEngine.GameObject dreamAreaEffect
{
get => orig.dreamAreaEffect;
set => orig.dreamAreaEffect = value;
}

public UnityEngine.GameObject spawnedDreamAreaEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.ParticleSystem activateParticles
{
get => orig.activateParticles;
set => orig.activateParticles = value;
}

public UnityEngine.ParticleSystem activatedParticles
{
get => orig.activatedParticles;
set => orig.activatedParticles = value;
}

public UnityEngine.GameObject whiteFlash
{
get => orig.whiteFlash;
set => orig.whiteFlash = value;
}

public UnityEngine.AudioClip growChargeSound
{
get => orig.growChargeSound;
set => orig.growChargeSound = value;
}

public UnityEngine.AudioClip growSound
{
get => orig.growSound;
set => orig.growSound = value;
}

public UnityEngine.ParticleSystem completeChargeParticles
{
get => orig.completeChargeParticles;
set => orig.completeChargeParticles = value;
}

public UnityEngine.ParticleSystem growParticles
{
get => orig.growParticles;
set => orig.growParticles = value;
}

public UnityEngine.GameObject dreamDialogue
{
get => orig.dreamDialogue;
set => orig.dreamDialogue = value;
}

public string playerdataBool
{
get => orig.playerdataBool;
set => orig.playerdataBool = value;
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}

public bool completed
{
get => GetField<bool>();
set => SetField(value);
}

public bool hasDreamNail
{
get => GetField<bool>();
set => SetField(value);
}

public bool seenDreamNailPrompt
{
get => GetField<bool>();
set => SetField(value);
}

public int spawnedOrbs
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Coroutine checkOrbRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public DreamPlantOrb[] dreamOrbs
{
get => GetField<DreamPlantOrb[]>();
set => SetField(value);
}

public SpriteFlash spriteFlash
{
get => GetField<SpriteFlash>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void AddOrbCount () =>
orig.AddOrbCount();

public void RemoveOrbCount () =>
orig.RemoveOrbCount();

public void ShowPrompt (bool show) =>
CallMethod(new object[] {show});

public System.Collections.IEnumerator CheckOrbs () =>
CallMethod<System.Collections.IEnumerator>();

}
}
