namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUnity2DProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUnity2DProxyR : InstanceClassWrapper<PlayMakerUnity2DProxy>
{
    public PlayMakerUnity2DProxyR(PlayMakerUnity2DProxy _orig) : base(_orig)
    {
    }

    public bool debug
    {
        get => orig.debug;
        set => orig.debug = value;
    }

    public bool HandleCollisionEnter2D
    {
        get => orig.HandleCollisionEnter2D;
        set => orig.HandleCollisionEnter2D = value;
    }

    public bool HandleCollisionExit2D
    {
        get => orig.HandleCollisionExit2D;
        set => orig.HandleCollisionExit2D = value;
    }

    public bool HandleCollisionStay2D
    {
        get => orig.HandleCollisionStay2D;
        set => orig.HandleCollisionStay2D = value;
    }

    public bool HandleTriggerEnter2D
    {
        get => orig.HandleTriggerEnter2D;
        set => orig.HandleTriggerEnter2D = value;
    }

    public bool HandleTriggerExit2D
    {
        get => orig.HandleTriggerExit2D;
        set => orig.HandleTriggerExit2D = value;
    }

    public bool HandleTriggerStay2D
    {
        get => orig.HandleTriggerStay2D;
        set => orig.HandleTriggerStay2D = value;
    }

    public Collision2D lastCollision2DInfo
    {
        get => orig.lastCollision2DInfo;
        set => orig.lastCollision2DInfo = value;
    }

    public Collider2D lastTrigger2DInfo
    {
        get => orig.lastTrigger2DInfo;
        set => orig.lastTrigger2DInfo = value;
    }


    public void AddOnCollisionEnter2dDelegate(PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate del)
    {
        orig.AddOnCollisionEnter2dDelegate(del);
    }

    public void RemoveOnCollisionEnter2dDelegate(PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate del)
    {
        orig.RemoveOnCollisionEnter2dDelegate(del);
    }

    public void AddOnCollisionStay2dDelegate(PlayMakerUnity2DProxy.OnCollisionStay2dDelegate del)
    {
        orig.AddOnCollisionStay2dDelegate(del);
    }

    public void RemoveOnCollisionStay2dDelegate(PlayMakerUnity2DProxy.OnCollisionStay2dDelegate del)
    {
        orig.RemoveOnCollisionStay2dDelegate(del);
    }

    public void AddOnCollisionExit2dDelegate(PlayMakerUnity2DProxy.OnCollisionExit2dDelegate del)
    {
        orig.AddOnCollisionExit2dDelegate(del);
    }

    public void RemoveOnCollisionExit2dDelegate(PlayMakerUnity2DProxy.OnCollisionExit2dDelegate del)
    {
        orig.RemoveOnCollisionExit2dDelegate(del);
    }

    public void AddOnTriggerEnter2dDelegate(PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate del)
    {
        orig.AddOnTriggerEnter2dDelegate(del);
    }

    public void RemoveOnTriggerEnter2dDelegate(PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate del)
    {
        orig.RemoveOnTriggerEnter2dDelegate(del);
    }

    public void AddOnTriggerStay2dDelegate(PlayMakerUnity2DProxy.OnTriggerStay2dDelegate del)
    {
        orig.AddOnTriggerStay2dDelegate(del);
    }

    public void RemoveOnTriggerStay2dDelegate(PlayMakerUnity2DProxy.OnTriggerStay2dDelegate del)
    {
        orig.RemoveOnTriggerStay2dDelegate(del);
    }

    public void AddOnTriggerExit2dDelegate(PlayMakerUnity2DProxy.OnTriggerExit2dDelegate del)
    {
        orig.AddOnTriggerExit2dDelegate(del);
    }

    public void RemoveOnTriggerExit2dDelegate(PlayMakerUnity2DProxy.OnTriggerExit2dDelegate del)
    {
        orig.RemoveOnTriggerExit2dDelegate(del);
    }

    public void help()
    {
        orig.help();
    }

    public void Start()
    {
        orig.Start();
    }

    public void RefreshImplementation()
    {
        orig.RefreshImplementation();
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void OnCollisionStay2D(Collision2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void OnCollisionExit2D(Collision2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void OnTriggerStay2D(Collider2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void OnTriggerExit2D(Collider2D coll)
    {
        CallMethod(new object[] { coll });
    }

    public void CheckGameObjectEventsImplementation()
    {
        CallMethod();
    }

    public void CheckFsmEventsImplementation(PlayMakerFSM fsm)
    {
        CallMethod(new object[] { fsm });
    }

    public void CheckTransition(string transitionName)
    {
        CallMethod(new object[] { transitionName });
    }

    public void orig_Start()
    {
        orig.orig_Start();
    }
}