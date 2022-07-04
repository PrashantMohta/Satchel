namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SaveGameData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveGameDataR : InstanceClassWrapper<SaveGameData>
{
    public SaveGameDataR(SaveGameData _orig) : base(_orig)
    {
    }

    public PlayerData playerData
    {
        get => orig.playerData;
        set => orig.playerData = value;
    }

    public SceneData sceneData
    {
        get => orig.sceneData;
        set => orig.sceneData = value;
    }
}