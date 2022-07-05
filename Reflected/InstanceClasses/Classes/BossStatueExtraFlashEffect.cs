namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueExtraFlashEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueExtraFlashEffectR : InstanceClassWrapper<BossStatueExtraFlashEffect>
{
    public BossStatueExtraFlashEffectR(BossStatueExtraFlashEffect _orig) : base(_orig)
    {
    }

    public BossStatueFlashEffect mainEffect
    {
        get => orig.mainEffect;
        set => orig.mainEffect = value;
    }

    public float flashSequenceDelay
    {
        get => orig.flashSequenceDelay;
        set => orig.flashSequenceDelay = value;
    }

    public TriggerEnterEvent triggerUnlockEvent
    {
        get => orig.triggerUnlockEvent;
        set => orig.triggerUnlockEvent = value;
    }

    public float toggleEnableTime
    {
        get => orig.toggleEnableTime;
        set => orig.toggleEnableTime = value;
    }

    public GameObject toggle
    {
        get => orig.toggle;
        set => orig.toggle = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void DoAppear()
    {
        CallMethod();
    }

    public IEnumerator AppearRoutine(GameObject toggle)
    {
        return CallMethod<IEnumerator>(new object[] { toggle });
    }
}