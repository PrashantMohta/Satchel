namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GCManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GCManagerR : InstanceClassWrapper<GCManager>
{
    public GCManagerR(GCManager _orig) : base(_orig)
    {
    }

    public long GCPanicLimit
    {
        get => GetFieldStatic<long>();
        set => SetField(value);
    }

    public int GCPanicFrameLimit
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public int framesSinceCollect
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public bool IsSupported => GCManager.IsSupported;

    public bool IsAutomaticCollectionEnabled
    {
        get => GCManager.IsAutomaticCollectionEnabled;
        set => GCManager.IsAutomaticCollectionEnabled = value;
    }


    public void Collect()
    {
        GCManager.Collect();
    }

    public void Init()
    {
        CallMethodStatic();
    }

    public long GetMemoryUsage()
    {
        return GCManager.GetMemoryUsage();
    }

    public void Update()
    {
        CallMethod();
    }
}