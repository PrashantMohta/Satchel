namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TrackSpawnedEnemies allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TrackSpawnedEnemiesR:InstanceClassWrapper<TrackSpawnedEnemies>
{
public TrackSpawnedEnemiesR(TrackSpawnedEnemies _orig) : base(_orig) {}
public System.Collections.Generic.List<HealthManager> trackedEnemies
{
get => GetField<System.Collections.Generic.List<HealthManager>>();
set => SetField(value);
}

public int TotalTracked
{
get => orig.TotalTracked;
}

public int TotalAlive
{
get => orig.TotalAlive;
}



public void Add (HealthManager enemyHealthManager) =>
orig.Add(enemyHealthManager);

}
}
