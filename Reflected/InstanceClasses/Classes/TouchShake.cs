namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchShake allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchShakeR:InstanceClassWrapper<TouchShake>
{
public TouchShakeR(TouchShake _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer spriteRenderer
{
get => orig.spriteRenderer;
set => orig.spriteRenderer = value;
}

public BasicSpriteAnimator anim
{
get => orig.anim;
set => orig.anim = value;
}

public tk2dSpriteAnimator tk2dAnim
{
get => orig.tk2dAnim;
set => orig.tk2dAnim = value;
}

public UnityEngine.Coroutine animateRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.ParticleSystem particles
{
get => orig.particles;
set => orig.particles = value;
}

public int emitParticles
{
get => orig.emitParticles;
set => orig.emitParticles = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public RandomAudioClipTable audioTable
{
get => orig.audioTable;
set => orig.audioTable = value;
}



public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public System.Collections.IEnumerator DoAnimation () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator SpriteAnimation () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator tk2dAnimation () =>
CallMethod<System.Collections.IEnumerator>();

}
}
