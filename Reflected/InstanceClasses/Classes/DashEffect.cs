namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DashEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DashEffectR:InstanceClassWrapper<DashEffect>
{
public DashEffectR(DashEffect _orig) : base(_orig) {}
public UnityEngine.GameObject heroDashPuff
{
get => orig.heroDashPuff;
set => orig.heroDashPuff = value;
}

public UnityEngine.GameObject dashDust
{
get => orig.dashDust;
set => orig.dashDust = value;
}

public UnityEngine.GameObject dashBone
{
get => orig.dashBone;
set => orig.dashBone = value;
}

public UnityEngine.GameObject dashGrass
{
get => orig.dashGrass;
set => orig.dashGrass = value;
}

public UnityEngine.GameObject waterCut
{
get => orig.waterCut;
set => orig.waterCut = value;
}

public tk2dSpriteAnimator heroDashPuff_anim
{
get => orig.heroDashPuff_anim;
set => orig.heroDashPuff_anim = value;
}

public UnityEngine.AudioClip splashClip
{
get => orig.splashClip;
set => orig.splashClip = value;
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public UnityEngine.GameObject heroObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D heroRigidBody
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public tk2dSpriteAnimator jumpPuffAnimator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public float recycleTimer
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void PlayDashPuff () =>
CallMethod();

public void PlayDust () =>
CallMethod();

public void PlayGrass () =>
CallMethod();

public void PlayBone () =>
CallMethod();

public void PlaySpaEffects () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
