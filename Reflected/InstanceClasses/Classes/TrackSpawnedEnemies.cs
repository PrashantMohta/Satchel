namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TrackSpawnedEnemies allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TrackSpawnedEnemiesR : InstanceClassWrapper<TrackSpawnedEnemies>
{
    public TrackSpawnedEnemiesR(TrackSpawnedEnemies _orig) : base(_orig)
    {
    }

    public List<HealthManager> trackedEnemies
    {
        get => GetField<List<HealthManager>>();
        set => SetField(value);
    }

    public int TotalTracked => orig.TotalTracked;

    public int TotalAlive => orig.TotalAlive;


    public void Add(HealthManager enemyHealthManager)
    {
        orig.Add(enemyHealthManager);
    }
}