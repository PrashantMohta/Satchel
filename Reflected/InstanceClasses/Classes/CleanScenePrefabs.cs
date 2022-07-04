namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CleanScenePrefabs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CleanScenePrefabsR:InstanceClassWrapper<TeamCherry.CleanScenePrefabs>
{
public CleanScenePrefabsR(TeamCherry.CleanScenePrefabs _orig) : base(_orig) {}
public UnityEngine.GameObject gameManager
{
get => orig.gameManager;
set => orig.gameManager = value;
}

public UnityEngine.GameObject sceneManager
{
get => orig.sceneManager;
set => orig.sceneManager = value;
}

public UnityEngine.GameObject uiManager
{
get => orig.uiManager;
set => orig.uiManager = value;
}

public UnityEngine.GameObject gameCameras
{
get => orig.gameCameras;
set => orig.gameCameras = value;
}

public UnityEngine.GameObject knight
{
get => orig.knight;
set => orig.knight = value;
}

public UnityEngine.GameObject hornet
{
get => orig.hornet;
set => orig.hornet = value;
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

}
}
