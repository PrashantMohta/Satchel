namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldInfoR:InstanceClassWrapper<WorldInfo>
{
public WorldInfoR(WorldInfo _orig) : base(_orig) {}
public WorldInfo.SceneInfo[] Scenes
{
get => orig.Scenes;
set => orig.Scenes = value;
}

public System.String[] NonGameplaySceneName
{
get => GetFieldStatic<System.String[]>();
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

public bool NameLooksLikeGameplayScene (string sceneName) =>
WorldInfo.NameLooksLikeGameplayScene(sceneName);

}
}
