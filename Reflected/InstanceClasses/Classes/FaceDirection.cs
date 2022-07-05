namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FaceDirection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FaceDirectionR : InstanceClassWrapper<FaceDirection>
{
    public FaceDirectionR(FaceDirection _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmBool spriteFacesRight
    {
        get => orig.spriteFacesRight;
        set => orig.spriteFacesRight = value;
    }

    public bool playNewAnimation
    {
        get => orig.playNewAnimation;
        set => orig.playNewAnimation = value;
    }

    public FsmString newAnimationClip
    {
        get => orig.newAnimationClip;
        set => orig.newAnimationClip = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public bool pauseBetweenTurns
    {
        get => orig.pauseBetweenTurns;
        set => orig.pauseBetweenTurns = value;
    }

    public FsmFloat pauseTime
    {
        get => orig.pauseTime;
        set => orig.pauseTime = value;
    }

    public FsmGameObject target
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator _sprite
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public float xScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float pauseTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Rigidbody2D rb2d
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoFace()
    {
        CallMethod();
    }
}