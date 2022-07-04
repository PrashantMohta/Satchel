namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueTrophyPlaque allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueTrophyPlaqueR : InstanceClassWrapper<BossStatueTrophyPlaque>
{
    public BossStatueTrophyPlaqueR(BossStatueTrophyPlaque _orig) : base(_orig)
    {
    }

    public GameObject[] displayObjects
    {
        get => orig.displayObjects;
        set => orig.displayObjects = value;
    }

    public Transform tierCompleteEffectPoint
    {
        get => orig.tierCompleteEffectPoint;
        set => orig.tierCompleteEffectPoint = value;
    }

    public float tierCompleteEffectDelay
    {
        get => orig.tierCompleteEffectDelay;
        set => orig.tierCompleteEffectDelay = value;
    }

    public GameObject[] tierCompleteEffectPrefabs
    {
        get => orig.tierCompleteEffectPrefabs;
        set => orig.tierCompleteEffectPrefabs = value;
    }

    public GameObject spawnedCompleteEffect
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }


    public void SetDisplay(BossStatueTrophyPlaque.DisplayType type)
    {
        orig.SetDisplay(type);
    }

    public void DoTierCompleteEffect(BossStatueTrophyPlaque.DisplayType type)
    {
        orig.DoTierCompleteEffect(type);
    }

    public IEnumerator TierCompleteEffectDelayed()
    {
        return CallMethod<IEnumerator>();
    }

    public void SetDisplayObject(BossStatueTrophyPlaque.DisplayType type)
    {
        CallMethod(new object[] { type });
    }
}