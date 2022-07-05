namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dPlayAnimationV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dPlayAnimationV2R : InstanceClassWrapper<Tk2dPlayAnimationV2>
{
    public Tk2dPlayAnimationV2R(Tk2dPlayAnimationV2 _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString animLibName
    {
        get => orig.animLibName;
        set => orig.animLibName = value;
    }

    public FsmString clipName
    {
        get => orig.clipName;
        set => orig.clipName = value;
    }

    public bool doNotResetCurrentClip
    {
        get => orig.doNotResetCurrentClip;
        set => orig.doNotResetCurrentClip = value;
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

    public void _getSprite()
    {
        CallMethod();
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void DoPlayAnimation()
    {
        CallMethod();
    }
}