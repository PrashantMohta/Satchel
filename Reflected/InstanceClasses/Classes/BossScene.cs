namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossScene allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSceneR : InstanceClassWrapper<BossScene>
{
    public BossSceneR(BossScene _orig) : base(_orig)
    {
    }

    public string sceneName
    {
        get => orig.sceneName;
        set => orig.sceneName = value;
    }

    public BossScene.BossTest[] bossTests
    {
        get => orig.bossTests;
        set => orig.bossTests = value;
    }

    public BossScene baseBoss
    {
        get => orig.baseBoss;
        set => orig.baseBoss = value;
    }

    public bool substituteBoss
    {
        get => orig.substituteBoss;
        set => orig.substituteBoss = value;
    }

    public Sprite displayIcon
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public bool isHidden
    {
        get => orig.isHidden;
        set => orig.isHidden = value;
    }

    public bool forceAssetUnload
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool requireUnlock
    {
        get => orig.requireUnlock;
        set => orig.requireUnlock = value;
    }

    public BossScene tier1Scene
    {
        get => GetField<BossScene>();
        set => SetField(value);
    }

    public BossScene tier2Scene
    {
        get => GetField<BossScene>();
        set => SetField(value);
    }

    public BossScene tier3Scene
    {
        get => GetField<BossScene>();
        set => SetField(value);
    }

    public Sprite DisplayIcon => orig.DisplayIcon;

    public bool ForceAssetUnload => orig.ForceAssetUnload;

    public string Tier1Scene => orig.Tier1Scene;

    public string Tier2Scene => orig.Tier2Scene;

    public string Tier3Scene => orig.Tier3Scene;

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

    public bool IsUnlocked(BossSceneCheckSource source)
    {
        return orig.IsUnlocked(source);
    }

    public bool IsUnlockedSelf(BossSceneCheckSource source)
    {
        return orig.IsUnlockedSelf(source);
    }
}