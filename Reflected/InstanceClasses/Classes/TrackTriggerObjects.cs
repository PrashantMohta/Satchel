namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TrackTriggerObjects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TrackTriggerObjectsR : InstanceClassWrapper<TrackTriggerObjects>
{
    public TrackTriggerObjectsR(TrackTriggerObjects _orig) : base(_orig)
    {
    }

    public LayerMask ignoreLayers
    {
        get => GetField<LayerMask>();
        set => SetField(value);
    }

    public List<GameObject> insideGameObjects
    {
        get => GetField<List<GameObject>>();
        set => SetField(value);
    }

    public int layerMask
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool gottenOverlappedColliders
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool subscribed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Collider2D[] _tempResults
    {
        get => GetFieldStatic<Collider2D[]>();
        set => SetField(value);
    }

    public List<GameObject> _refreshTemp
    {
        get => GetFieldStatic<List<GameObject>>();
        set => SetField(value);
    }

    public int InsideCount => orig.InsideCount;


    public void OnDisable()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void OnHeroInPosition(bool forceDirect)
    {
        CallMethod(new object[] { forceDirect });
    }

    public void GetOverlappedColliders(bool isRefresh = false)
    {
        CallMethod(new object[] { isRefresh });
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnExit(GameObject obj)
    {
        CallMethod(new object[] { obj });
    }

    public bool IsIgnored(GameObject obj)
    {
        return CallMethod<bool>(new object[] { obj });
    }
}