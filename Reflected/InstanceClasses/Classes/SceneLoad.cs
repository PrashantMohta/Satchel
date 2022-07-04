namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneLoad allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneLoadR : InstanceClassWrapper<SceneLoad>
{
    public SceneLoadR(SceneLoad _orig) : base(_orig)
    {
    }

    public MonoBehaviour runner
    {
        get => GetField<MonoBehaviour>();
        set => SetField(value);
    }

    public string targetSceneName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int PhaseCount
    {
        get => SceneLoad.PhaseCount;
        set => SetField(value);
    }

    public string TargetSceneName => orig.TargetSceneName;

    public bool IsFetchAllowed
    {
        get => orig.IsFetchAllowed;
        set => orig.IsFetchAllowed = value;
    }

    public bool IsActivationAllowed
    {
        get => orig.IsActivationAllowed;
        set => orig.IsActivationAllowed = value;
    }

    public bool IsUnloadAssetsRequired
    {
        get => orig.IsUnloadAssetsRequired;
        set => orig.IsUnloadAssetsRequired = value;
    }

    public bool IsGarbageCollectRequired
    {
        get => orig.IsGarbageCollectRequired;
        set => orig.IsGarbageCollectRequired = value;
    }

    public bool IsFinished
    {
        get => orig.IsFinished;
        set => SetProperty(value);
    }

    public float? BeginTime => orig.BeginTime;

    public void RecordBeginTime(SceneLoad.Phases phase)
    {
        CallMethod(new object[] { phase });
    }

    public void RecordEndTime(SceneLoad.Phases phase)
    {
        CallMethod(new object[] { phase });
    }

    public float? GetDuration(SceneLoad.Phases phase)
    {
        return orig.GetDuration(phase);
    }

    public void Begin()
    {
        orig.Begin();
    }

    public IEnumerator BeginRoutine()
    {
        return CallMethod<IEnumerator>();
    }
}