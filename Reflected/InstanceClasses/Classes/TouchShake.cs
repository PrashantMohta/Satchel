namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchShake allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchShakeR : InstanceClassWrapper<TouchShake>
{
    public TouchShakeR(TouchShake _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
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

    public Coroutine animateRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public ParticleSystem particles
    {
        get => orig.particles;
        set => orig.particles = value;
    }

    public int emitParticles
    {
        get => orig.emitParticles;
        set => orig.emitParticles = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public RandomAudioClipTable audioTable
    {
        get => orig.audioTable;
        set => orig.audioTable = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public IEnumerator DoAnimation()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator SpriteAnimation()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator tk2dAnimation()
    {
        return CallMethod<IEnumerator>();
    }
}