namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Explosion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ExplosionR : InstanceClassWrapper<HutongGames.PlayMaker.Actions.Explosion>
{
    public ExplosionR(HutongGames.PlayMaker.Actions.Explosion _orig) : base(_orig)
    {
    }

    public FsmVector3 center
    {
        get => orig.center;
        set => orig.center = value;
    }

    public FsmFloat force
    {
        get => orig.force;
        set => orig.force = value;
    }

    public FsmFloat radius
    {
        get => orig.radius;
        set => orig.radius = value;
    }

    public FsmFloat upwardsModifier
    {
        get => orig.upwardsModifier;
        set => orig.upwardsModifier = value;
    }

    public ForceMode forceMode
    {
        get => orig.forceMode;
        set => orig.forceMode = value;
    }

    public FsmInt layer
    {
        get => orig.layer;
        set => orig.layer = value;
    }

    public FsmInt[] layerMask
    {
        get => orig.layerMask;
        set => orig.layerMask = value;
    }

    public FsmBool invertMask
    {
        get => orig.invertMask;
        set => orig.invertMask = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoExplosion()
    {
        CallMethod();
    }

    public bool ShouldApplyForce(GameObject go)
    {
        return CallMethod<bool>(new object[] { go });
    }
}