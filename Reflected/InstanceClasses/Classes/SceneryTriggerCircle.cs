namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneryTriggerCircle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneryTriggerCircleR:InstanceClassWrapper<SceneryTriggerCircle>
{
public SceneryTriggerCircleR(SceneryTriggerCircle _orig) : base(_orig) {}
public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.CircleCollider2D[] col2ds
{
get => GetField<UnityEngine.CircleCollider2D[]>();
set => SetField(value);
}

public int enterCount
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => orig.audioSource;
set => orig.audioSource = value;
}

public UnityEngine.AudioClip activateSound
{
get => orig.activateSound;
set => orig.activateSound = value;
}

public UnityEngine.AudioClip deactivateSound
{
get => orig.deactivateSound;
set => orig.deactivateSound = value;
}

public bool active
{
get => orig.active;
set => SetProperty(value);
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public void OnTriggerStay2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public void OnTriggerExit2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public void RandomizePitch (UnityEngine.AudioSource src, float minPitch, float maxPitch) =>
CallMethod(new object[] {src, minPitch, maxPitch});

public void ResetPitch (UnityEngine.AudioSource src) =>
CallMethod(new object[] {src});

}
}
