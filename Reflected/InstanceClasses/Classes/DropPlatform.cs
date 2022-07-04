namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DropPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DropPlatformR:InstanceClassWrapper<DropPlatform>
{
public DropPlatformR(DropPlatform _orig) : base(_orig) {}
public tk2dSpriteAnimator spriteAnimator
{
get => orig.spriteAnimator;
set => orig.spriteAnimator = value;
}

public string idleAnim
{
get => orig.idleAnim;
set => orig.idleAnim = value;
}

public string dropAnim
{
get => orig.dropAnim;
set => orig.dropAnim = value;
}

public string raiseAnim
{
get => orig.raiseAnim;
set => orig.raiseAnim = value;
}

public UnityEngine.AudioClip landSound
{
get => orig.landSound;
set => orig.landSound = value;
}

public UnityEngine.AudioClip dropSound
{
get => orig.dropSound;
set => orig.dropSound = value;
}

public UnityEngine.AudioClip flipUpSound
{
get => orig.flipUpSound;
set => orig.flipUpSound = value;
}

public UnityEngine.GameObject strikeEffect
{
get => orig.strikeEffect;
set => orig.strikeEffect = value;
}

public UnityEngine.Collider2D collider
{
get => orig.collider;
set => orig.collider = value;
}

public UnityEngine.Coroutine flipRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void PlaySound (UnityEngine.AudioClip clip) =>
CallMethod(new object[] {clip});

public void Idle () =>
CallMethod();

public System.Collections.IEnumerator Flip () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Jitter (float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {duration});

}
}
