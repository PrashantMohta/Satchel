namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ReceivedDamage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ReceivedDamageR : InstanceClassWrapper<ReceivedDamage>
{
    public ReceivedDamageR(ReceivedDamage _orig) : base(_orig)
    {
    }

    public FsmString collideTag
    {
        get => orig.collideTag;
        set => orig.collideTag = value;
    }

    public FsmEvent sendEvent
    {
        get => orig.sendEvent;
        set => orig.sendEvent = value;
    }

    public FsmString fsmName
    {
        get => orig.fsmName;
        set => orig.fsmName = value;
    }

    public FsmGameObject storeGameObject
    {
        get => orig.storeGameObject;
        set => orig.storeGameObject = value;
    }

    public FsmBool ignoreAcid
    {
        get => orig.ignoreAcid;
        set => orig.ignoreAcid = value;
    }

    public FsmBool ignoreWater
    {
        get => orig.ignoreWater;
        set => orig.ignoreWater = value;
    }

    public PlayMakerUnity2DProxy _proxy
    {
        get => GetField<PlayMakerUnity2DProxy>();
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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void DoCollisionEnter2D(Collision2D collisionInfo)
    {
        orig.DoCollisionEnter2D(collisionInfo);
    }

    public void DoTriggerEnter2D(Collider2D collisionInfo)
    {
        orig.DoTriggerEnter2D(collisionInfo);
    }

    public void DoTriggerStay2D(Collider2D collisionInfo)
    {
        orig.DoTriggerStay2D(collisionInfo);
    }

    public void StoreCollisionInfo(Collision2D collisionInfo)
    {
        CallMethod(new object[] { collisionInfo });
    }

    public void StoreTriggerInfo(Collider2D collisionInfo)
    {
        CallMethod(new object[] { collisionInfo });
    }

    public void StoreIfDamagingObject(GameObject go)
    {
        CallMethod(new object[] { go });
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}