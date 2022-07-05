namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MapNextAreaDisplay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MapNextAreaDisplayR : InstanceClassWrapper<MapNextAreaDisplay>
{
    public MapNextAreaDisplayR(MapNextAreaDisplay _orig) : base(_orig)
    {
    }

    public GameMap gameMap
    {
        get => orig.gameMap;
        set => orig.gameMap = value;
    }

    public string visitedString
    {
        get => orig.visitedString;
        set => orig.visitedString = value;
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool areaVisited
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void ActivateChildren()
    {
        CallMethod();
    }

    public void DeactivateChildren()
    {
        CallMethod();
    }
}