namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnStagMenu allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnStagMenuR : InstanceClassWrapper<SpawnStagMenu>
{
    public SpawnStagMenuR(SpawnStagMenu _orig) : base(_orig)
    {
    }

    public PlayMakerFSM fsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SendEvent()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }
}