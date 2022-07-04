namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of JumpEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JumpEffectsR:InstanceClassWrapper<JumpEffects>
{
public JumpEffectsR(JumpEffects _orig) : base(_orig) {}
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

public UnityEngine.GameObject jumpPuff
{
get => orig.jumpPuff;
set => orig.jumpPuff = value;
}

public UnityEngine.GameObject dustTrail
{
get => orig.dustTrail;
set => orig.dustTrail = value;
}

public UnityEngine.GameObject spatterWhitePrefab
{
get => orig.spatterWhitePrefab;
set => orig.spatterWhitePrefab = value;
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

public float fallTimer
{
get => GetField<float>();
set => SetField(value);
}

public float dripTimer
{
get => GetField<float>();
set => SetField(value);
}

public float dripEndTimer
{
get => GetField<float>();
set => SetField(value);
}

public bool dripping
{
get => GetField<bool>();
set => SetField(value);
}

public bool checkForFall
{
get => GetField<bool>();
set => SetField(value);
}

public bool trailAttached
{
get => GetField<bool>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void GetHero () =>
CallMethod();

public void CheckForFall () =>
CallMethod();

public void PlayTrail () =>
CallMethod();

public void PlayJumpPuff () =>
CallMethod();

public void SplashOut () =>
CallMethod();

}
}
