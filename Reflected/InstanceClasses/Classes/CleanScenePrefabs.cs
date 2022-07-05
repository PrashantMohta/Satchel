using TeamCherry;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CleanScenePrefabs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CleanScenePrefabsR : InstanceClassWrapper<CleanScenePrefabs>
{
    public CleanScenePrefabsR(CleanScenePrefabs _orig) : base(_orig)
    {
    }

    public GameObject gameManager
    {
        get => orig.gameManager;
        set => orig.gameManager = value;
    }

    public GameObject sceneManager
    {
        get => orig.sceneManager;
        set => orig.sceneManager = value;
    }

    public GameObject uiManager
    {
        get => orig.uiManager;
        set => orig.uiManager = value;
    }

    public GameObject gameCameras
    {
        get => orig.gameCameras;
        set => orig.gameCameras = value;
    }

    public GameObject knight
    {
        get => orig.knight;
        set => orig.knight = value;
    }

    public GameObject hornet
    {
        get => orig.hornet;
        set => orig.hornet = value;
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
}