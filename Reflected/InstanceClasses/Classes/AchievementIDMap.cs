namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementIDMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementIDMapR : InstanceClassWrapper<AchievementIDMap>
{
    public AchievementIDMapR(AchievementIDMap _orig) : base(_orig)
    {
    }

    public AchievementIDMap.AchievementIDPair[] pairs
    {
        get => GetField<AchievementIDMap.AchievementIDPair[]>();
        set => SetField(value);
    }

    public Dictionary<string, int> serviceIdsByInternalId
    {
        get => GetField<Dictionary<string, int>>();
        set => SetField(value);
    }

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

    public int? GetServiceIdForInternalId(string internalId)
    {
        return orig.GetServiceIdForInternalId(internalId);
    }
}