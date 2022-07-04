namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SoftLandEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoftLandEffectR:InstanceClassWrapper<SoftLandEffect>
{
public SoftLandEffectR(SoftLandEffect _orig) : base(_orig) {}
public UnityEngine.GameObject dustEffects
{
get => orig.dustEffects;
set => orig.dustEffects = value;
}

public UnityEngine.GameObject grassEffects
{
get => orig.grassEffects;
set => orig.grassEffects = value;
}

public UnityEngine.GameObject boneEffects
{
get => orig.boneEffects;
set => orig.boneEffects = value;
}

public UnityEngine.GameObject splash
{
get => orig.splash;
set => orig.splash = value;
}

public UnityEngine.AudioClip softLandClip
{
get => orig.softLandClip;
set => orig.softLandClip = value;
}

public UnityEngine.AudioClip wetLandClip
{
get => orig.wetLandClip;
set => orig.wetLandClip = value;
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

public void Update () =>
CallMethod();

}
}
