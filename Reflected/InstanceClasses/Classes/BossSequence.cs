namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSequenceR : InstanceClassWrapper<BossSequence>
{
    public BossSequenceR(BossSequence _orig) : base(_orig)
    {
    }

    public BossScene[] bossScenes
    {
        get => GetField<BossScene[]>();
        set => SetField(value);
    }

    public bool useSceneUnlocks
    {
        get => orig.useSceneUnlocks;
        set => orig.useSceneUnlocks = value;
    }

    public BossScene.BossTest[] tests
    {
        get => orig.tests;
        set => orig.tests = value;
    }

    public string achievementKey
    {
        get => orig.achievementKey;
        set => orig.achievementKey = value;
    }

    public string customEndScene
    {
        get => orig.customEndScene;
        set => orig.customEndScene = value;
    }

    public string customEndScenePlayerData
    {
        get => orig.customEndScenePlayerData;
        set => orig.customEndScenePlayerData = value;
    }

    public int nailDamage
    {
        get => orig.nailDamage;
        set => orig.nailDamage = value;
    }

    public float lowerNailDamagePercentage
    {
        get => orig.lowerNailDamagePercentage;
        set => orig.lowerNailDamagePercentage = value;
    }

    public int maxHealth
    {
        get => orig.maxHealth;
        set => orig.maxHealth = value;
    }

    public int Count => orig.Count;

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public string GetSceneAt(int index)
    {
        return orig.GetSceneAt(index);
    }

    public string GetSceneObjectName(int index)
    {
        return orig.GetSceneObjectName(index);
    }

    public bool CanLoad(int index)
    {
        return orig.CanLoad(index);
    }

    public BossScene GetBossScene(int index)
    {
        return orig.GetBossScene(index);
    }

    public bool IsUnlocked()
    {
        return orig.IsUnlocked();
    }

    public bool IsSceneHidden(int index)
    {
        return orig.IsSceneHidden(index);
    }
}