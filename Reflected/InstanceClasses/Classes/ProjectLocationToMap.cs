namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ProjectLocationToMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ProjectLocationToMapR : InstanceClassWrapper<ProjectLocationToMap>
{
    public ProjectLocationToMapR(ProjectLocationToMap _orig) : base(_orig)
    {
    }

    public FsmVector3 GPSLocation
    {
        get => orig.GPSLocation;
        set => orig.GPSLocation = value;
    }

    public FsmFloat minLongitude
    {
        get => orig.minLongitude;
        set => orig.minLongitude = value;
    }

    public FsmFloat maxLongitude
    {
        get => orig.maxLongitude;
        set => orig.maxLongitude = value;
    }

    public FsmFloat minLatitude
    {
        get => orig.minLatitude;
        set => orig.minLatitude = value;
    }

    public FsmFloat maxLatitude
    {
        get => orig.maxLatitude;
        set => orig.maxLatitude = value;
    }

    public FsmFloat minX
    {
        get => orig.minX;
        set => orig.minX = value;
    }

    public FsmFloat minY
    {
        get => orig.minY;
        set => orig.minY = value;
    }

    public FsmFloat width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmFloat projectedX
    {
        get => orig.projectedX;
        set => orig.projectedX = value;
    }

    public FsmFloat projectedY
    {
        get => orig.projectedY;
        set => orig.projectedY = value;
    }

    public FsmBool normalized
    {
        get => orig.normalized;
        set => orig.normalized = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public float x
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float y
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoProjectGPSLocation()
    {
        CallMethod();
    }

    public void DoEquidistantCylindrical()
    {
        CallMethod();
    }

    public void DoMercatorProjection()
    {
        CallMethod();
    }

    public float LatitudeToMercator(float latitudeInDegrees)
    {
        return CallMethodStatic<float>(new object[] { latitudeInDegrees });
    }
}