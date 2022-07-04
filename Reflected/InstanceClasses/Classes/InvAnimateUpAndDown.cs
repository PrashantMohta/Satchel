namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvAnimateUpAndDown allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvAnimateUpAndDownR : InstanceClassWrapper<InvAnimateUpAndDown>
{
    public InvAnimateUpAndDownR(InvAnimateUpAndDown _orig) : base(_orig)
    {
    }

    public string upAnimation
    {
        get => orig.upAnimation;
        set => orig.upAnimation = value;
    }

    public string downAnimation
    {
        get => orig.downAnimation;
        set => orig.downAnimation = value;
    }

    public float upDelay
    {
        get => orig.upDelay;
        set => orig.upDelay = value;
    }

    public int randomStartFrameSpriteMax
    {
        get => orig.randomStartFrameSpriteMax;
        set => orig.randomStartFrameSpriteMax = value;
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool animatingDown
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool readyingAnimUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void AnimateUp()
    {
        orig.AnimateUp();
    }

    public void AnimateDown()
    {
        orig.AnimateDown();
    }

    public void ReplayUpAnim()
    {
        orig.ReplayUpAnim();
    }
}