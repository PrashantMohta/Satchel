using System.Text;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SteamManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SteamManagerR : InstanceClassWrapper<SteamManager>
{
    public SteamManagerR(SteamManager _orig) : base(_orig)
    {
    }

    public bool s_EverInitialized
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public SteamManager s_instance
    {
        get => GetFieldStatic<SteamManager>();
        set => SetField(value);
    }

    public bool m_bInitialized
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public SteamManager Instance => GetPropertyStatic<SteamManager>();

    public bool Initialized => SteamManager.Initialized;


    public void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
    {
        CallMethodStatic(new object[] { nSeverity, pchDebugText });
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}