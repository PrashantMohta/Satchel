namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MegaJellyZap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MegaJellyZapR:InstanceClassWrapper<MegaJellyZap>
{
public MegaJellyZapR(MegaJellyZap _orig) : base(_orig) {}
public UnityEngine.ParticleSystem ptAttack
{
get => orig.ptAttack;
set => orig.ptAttack = value;
}

public UnityEngine.ParticleSystem ptAntic
{
get => orig.ptAntic;
set => orig.ptAntic = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public AudioEvent zapBugPt1
{
get => orig.zapBugPt1;
set => orig.zapBugPt1 = value;
}

public AudioEvent zapBugPt2
{
get => orig.zapBugPt2;
set => orig.zapBugPt2 = value;
}

public tk2dSpriteAnimator anim
{
get => orig.anim;
set => orig.anim = value;
}

public UnityEngine.MeshRenderer animMesh
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.CircleCollider2D col
{
get => GetField<UnityEngine.CircleCollider2D>();
set => SetField(value);
}

public ColorFader fade
{
get => GetField<ColorFader>();
set => SetField(value);
}

public UnityEngine.Coroutine routine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator ZapSequence () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator MultiZapSequence () =>
CallMethod<System.Collections.IEnumerator>();

}
}
