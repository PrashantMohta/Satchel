namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneDataR : InstanceClassWrapper<SceneData>
{
    public SceneDataR(SceneData _orig) : base(_orig)
    {
    }

    public List<GeoRockData> geoRocks
    {
        get => orig.geoRocks;
        set => orig.geoRocks = value;
    }

    public List<PersistentBoolData> persistentBoolItems
    {
        get => orig.persistentBoolItems;
        set => orig.persistentBoolItems = value;
    }

    public List<PersistentIntData> persistentIntItems
    {
        get => orig.persistentIntItems;
        set => orig.persistentIntItems = value;
    }

    public SceneData _instance
    {
        get => GetFieldStatic<SceneData>();
        set => SetField(value);
    }

    public SceneData instance
    {
        get => SceneData.instance;
        set => SceneData.instance = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void SaveMyState(GeoRockData geoRockData)
    {
        orig.SaveMyState(geoRockData);
    }

    public void SaveMyState(PersistentBoolData persistentBoolData)
    {
        orig.SaveMyState(persistentBoolData);
    }

    public void SaveMyState(PersistentIntData persistentIntData)
    {
        orig.SaveMyState(persistentIntData);
    }

    public void ResetSemiPersistentItems()
    {
        orig.ResetSemiPersistentItems();
    }

    public GeoRockData FindMyState(GeoRockData grd)
    {
        return orig.FindMyState(grd);
    }

    public PersistentBoolData FindMyState(PersistentBoolData persistentBoolData)
    {
        return orig.FindMyState(persistentBoolData);
    }

    public PersistentIntData FindMyState(PersistentIntData persistentIntData)
    {
        return orig.FindMyState(persistentIntData);
    }

    public void SetupNewSceneData()
    {
        CallMethod();
    }

    public int FindGeoRockInList(GeoRockData grd)
    {
        return CallMethod<int>(new object[] { grd });
    }

    public int FindPersistentBoolItemInList(PersistentBoolData pbd)
    {
        return CallMethod<int>(new object[] { pbd });
    }

    public int FindPersistentIntItemInList(PersistentIntData pid)
    {
        return CallMethod<int>(new object[] { pid });
    }
}