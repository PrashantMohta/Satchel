namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSystem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSystemR:InstanceClassWrapper<tk2dSystem>
{
public tk2dSystemR(tk2dSystem _orig) : base(_orig) {}
public string guidPrefix
{
get => tk2dSystem.guidPrefix;
set => SetField(value);
}

public string assetName
{
get => tk2dSystem.assetName;
set => SetField(value);
}

public string assetFileName
{
get => tk2dSystem.assetFileName;
set => SetField(value);
}

public tk2dAssetPlatform[] assetPlatforms
{
get => orig.assetPlatforms;
set => orig.assetPlatforms = value;
}

public tk2dSystem _inst
{
get => GetFieldStatic<tk2dSystem>();
set => SetField(value);
}

public string currentPlatform
{
get => GetFieldStatic<string>();
set => SetField(value);
}

public tk2dResourceTocEntry[] allResourceEntries
{
get => GetField<tk2dResourceTocEntry[]>();
set => SetField(value);
}

public tk2dSystem inst
{
get => tk2dSystem.inst;
}

public tk2dSystem inst_NoCreate
{
get => tk2dSystem.inst_NoCreate;
}

public string CurrentPlatform
{
get => tk2dSystem.CurrentPlatform;
set => tk2dSystem.CurrentPlatform = value;
}

public bool OverrideBuildMaterial
{
get => tk2dSystem.OverrideBuildMaterial;
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

public tk2dAssetPlatform GetAssetPlatform (string platform) =>
tk2dSystem.GetAssetPlatform(platform);

public T LoadResourceByGUIDImpl<T>(string guid) =>
CallMethod<T>(new object[] {guid});

public T LoadResourceByNameImpl <T>(string name) =>
CallMethod<T>(new object[] {name});

public T LoadResourceByGUID <T>(string guid) where T : UnityEngine.Object =>
tk2dSystem.LoadResourceByGUID<T>(guid);

public T LoadResourceByName <T>(string guid) where T : UnityEngine.Object =>
tk2dSystem.LoadResourceByName<T>(guid);

}
}
