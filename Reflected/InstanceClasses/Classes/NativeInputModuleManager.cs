namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of NativeInputModuleManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NativeInputModuleManagerR : InstanceClassWrapper<NativeInputModuleManager>
{
    public NativeInputModuleManagerR(NativeInputModuleManager _orig) : base(_orig)
    {
    }

    public NativeInputModuleManager _instance
    {
        get => GetFieldStatic<NativeInputModuleManager>();
        set => SetField(value);
    }

    public bool _isUsedAtStart
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public bool _isUsed
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public bool IsUsed
    {
        get => NativeInputModuleManager.IsUsed;
        set => NativeInputModuleManager.IsUsed = value;
    }

    public bool IsRestartRequired => NativeInputModuleManager.IsRestartRequired;


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void ChangeIsUsed(bool willUse)
    {
        CallMethodStatic(new object[] { willUse });
    }
}