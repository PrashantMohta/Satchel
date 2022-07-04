namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TakeDamage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TakeDamageR : InstanceClassWrapper<TakeDamage>
{
    public TakeDamageR(TakeDamage _orig) : base(_orig)
    {
    }

    public FsmGameObject Target
    {
        get => orig.Target;
        set => orig.Target = value;
    }

    public FsmInt AttackType
    {
        get => orig.AttackType;
        set => orig.AttackType = value;
    }

    public FsmBool CircleDirection
    {
        get => orig.CircleDirection;
        set => orig.CircleDirection = value;
    }

    public FsmInt DamageDealt
    {
        get => orig.DamageDealt;
        set => orig.DamageDealt = value;
    }

    public FsmFloat Direction
    {
        get => orig.Direction;
        set => orig.Direction = value;
    }

    public FsmBool IgnoreInvulnerable
    {
        get => orig.IgnoreInvulnerable;
        set => orig.IgnoreInvulnerable = value;
    }

    public FsmFloat MagnitudeMultiplier
    {
        get => orig.MagnitudeMultiplier;
        set => orig.MagnitudeMultiplier = value;
    }

    public FsmFloat MoveAngle
    {
        get => orig.MoveAngle;
        set => orig.MoveAngle = value;
    }

    public FsmBool MoveDirection
    {
        get => orig.MoveDirection;
        set => orig.MoveDirection = value;
    }

    public FsmFloat Multiplier
    {
        get => orig.Multiplier;
        set => orig.Multiplier = value;
    }

    public FsmInt SpecialType
    {
        get => orig.SpecialType;
        set => orig.SpecialType = value;
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
}