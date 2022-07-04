namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueCompletionStates allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueCompletionStatesR : InstanceClassWrapper<BossStatueCompletionStates>
{
    public BossStatueCompletionStatesR(BossStatueCompletionStates _orig) : base(_orig)
    {
    }

    public BossSummaryBoard bossListSource
    {
        get => orig.bossListSource;
        set => orig.bossListSource = value;
    }

    public BossStatueCompletionStates.State[] tierStates
    {
        get => orig.tierStates;
        set => orig.tierStates = value;
    }

    public bool checkTiersAdditive
    {
        get => orig.checkTiersAdditive;
        set => orig.checkTiersAdditive = value;
    }


    public void OnValidate()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public BossStatueCompletionStates.Tiers? GetHighestCompletedTier()
    {
        return orig.GetHighestCompletedTier();
    }

    public bool GetIsTierCompleted(BossStatueCompletionStates.Tiers tier)
    {
        return orig.GetIsTierCompleted(tier);
    }

    public void CountCompletion(BossStatueCompletionStates.Tiers tier, out int completed, out int total)
    {
        orig.CountCompletion(tier, out completed, out total);
    }

    public bool HasCompletedTier(BossStatue.Completion completion, BossStatueCompletionStates.Tiers tier)
    {
        return CallMethod<bool>(new object[] { completion, tier });
    }
}