namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementIDMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementIDMapR:InstanceClassWrapper<AchievementIDMap>
{
public AchievementIDMapR(AchievementIDMap _orig) : base(_orig) {}
public AchievementIDMap.AchievementIDPair[] pairs
{
get => GetField<AchievementIDMap.AchievementIDPair[]>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.String,System.Int32> serviceIdsByInternalId
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Int32>>();
set => SetField(value);
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public System.Int32? GetServiceIdForInternalId (string internalId) =>
orig.GetServiceIdForInternalId(internalId);

}
}
