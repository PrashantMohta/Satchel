namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BasicSpriteAnimator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BasicSpriteAnimatorR : InstanceClassWrapper<BasicSpriteAnimator>
{
    public BasicSpriteAnimatorR(BasicSpriteAnimator _orig) : base(_orig)
    {
    }

    public float fps
    {
        get => orig.fps;
        set => orig.fps = value;
    }

    public Sprite[] frames
    {
        get => orig.frames;
        set => orig.frames = value;
    }

    public bool startRandom
    {
        get => orig.startRandom;
        set => orig.startRandom = value;
    }

    public bool looping
    {
        get => orig.looping;
        set => orig.looping = value;
    }

    public SpriteRenderer rend
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public Coroutine animRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float Length => orig.Length;


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator Animate()
    {
        return CallMethod<IEnumerator>();
    }
}