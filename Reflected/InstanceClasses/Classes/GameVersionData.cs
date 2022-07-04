namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GameVersionData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameVersionDataR:InstanceClassWrapper<GameVersionData>
{
public GameVersionDataR(GameVersionData _orig) : base(_orig) {}
public GameVersion gameVersion
{
get => orig.gameVersion;
set => orig.gameVersion = value;
}

public string version
{
get => orig.version;
set => orig.version = value;
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

public string GetGameVersionString () =>
orig.GetGameVersionString();

}
}
