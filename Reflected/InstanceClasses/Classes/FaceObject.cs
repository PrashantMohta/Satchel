namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FaceObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FaceObjectR : InstanceClassWrapper<FaceObject>
{
    public FaceObjectR(FaceObject _orig) : base(_orig)
    {
    }

    public FsmGameObject objectA
    {
        get => orig.objectA;
        set => orig.objectA = value;
    }

    public FsmGameObject objectB
    {
        get => orig.objectB;
        set => orig.objectB = value;
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

    public bool resetFrame
    {
        get => orig.resetFrame;
        set => orig.resetFrame = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public float xScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public FsmVector3 vector
    {
        get => GetField<FsmVector3>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator _sprite
    {
        get => GetField<tk2dSpriteAnimator>();
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