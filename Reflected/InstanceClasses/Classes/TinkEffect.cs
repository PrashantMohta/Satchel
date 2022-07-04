namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TinkEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TinkEffectR:InstanceClassWrapper<TinkEffect>
{
public TinkEffectR(TinkEffect _orig) : base(_orig) {}
public UnityEngine.GameObject blockEffect
{
get => orig.blockEffect;
set => orig.blockEffect = value;
}

public bool useNailPosition
{
get => orig.useNailPosition;
set => orig.useNailPosition = value;
}

public bool sendFSMEvent
{
get => orig.sendFSMEvent;
set => orig.sendFSMEvent = value;
}

public string FSMEvent
{
get => orig.FSMEvent;
set => orig.FSMEvent = value;
}

public PlayMakerFSM fsm
{
get => orig.fsm;
set => orig.fsm = value;
}

public bool sendDirectionalFSMEvents
{
get => orig.sendDirectionalFSMEvents;
set => orig.sendDirectionalFSMEvents = value;
}

public UnityEngine.BoxCollider2D boxCollider
{
get => GetField<UnityEngine.BoxCollider2D>();
set => SetField(value);
}

public bool hasBoxCollider
{
get => GetField<bool>();
set => SetField(value);
}

public HeroController heroController
{
get => GetField<HeroController>();
set => SetField(value);
}

public GameCameras gameCam
{
get => GetField<GameCameras>();
set => SetField(value);
}

public UnityEngine.Vector2 centre
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float halfWidth
{
get => GetField<float>();
set => SetField(value);
}

public float halfHeight
{
get => GetField<float>();
set => SetField(value);
}

public float repeatDelay
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float nextTinkTime
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
