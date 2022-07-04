namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ObjectBounce allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ObjectBounceR:InstanceClassWrapper<ObjectBounce>
{
public ObjectBounceR(ObjectBounce _orig) : base(_orig) {}
public float bounceFactor
{
get => orig.bounceFactor;
set => orig.bounceFactor = value;
}

public float speedThreshold
{
get => orig.speedThreshold;
set => orig.speedThreshold = value;
}

public bool playSound
{
get => orig.playSound;
set => orig.playSound = value;
}

public UnityEngine.AudioClip[] clips
{
get => orig.clips;
set => orig.clips = value;
}

public int chanceToPlay
{
get => orig.chanceToPlay;
set => orig.chanceToPlay = value;
}

public float pitchMin
{
get => orig.pitchMin;
set => orig.pitchMin = value;
}

public float pitchMax
{
get => orig.pitchMax;
set => orig.pitchMax = value;
}

public bool playAnimationOnBounce
{
get => orig.playAnimationOnBounce;
set => orig.playAnimationOnBounce = value;
}

public string animationName
{
get => orig.animationName;
set => orig.animationName = value;
}

public float animPause
{
get => orig.animPause;
set => orig.animPause = value;
}

public bool sendFSMEvent
{
get => orig.sendFSMEvent;
set => orig.sendFSMEvent = value;
}

public float speed
{
get => GetField<float>();
set => SetField(value);
}

public float animTimer
{
get => GetField<float>();
set => SetField(value);
}

public tk2dSpriteAnimator animator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public PlayMakerFSM fsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public UnityEngine.Vector2 velocity
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 lastPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.AudioSource audio
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public int chooser
{
get => GetField<int>();
set => SetField(value);
}

public bool bouncing
{
get => GetField<bool>();
set => SetField(value);
}

public int stepCounter
{
get => GetField<int>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D col) =>
CallMethod(new object[] {col});

public void StopBounce () =>
orig.StopBounce();

public void StartBounce () =>
orig.StartBounce();

public void SetBounceFactor (float value) =>
orig.SetBounceFactor(value);

public void SetBounceAnimation (bool set) =>
orig.SetBounceAnimation(set);

}
}
