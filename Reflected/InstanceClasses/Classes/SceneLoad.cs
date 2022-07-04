namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneLoad allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneLoadR:InstanceClassWrapper<SceneLoad>
{
public SceneLoadR(SceneLoad _orig) : base(_orig) {}
public UnityEngine.MonoBehaviour runner
{
get => GetField<UnityEngine.MonoBehaviour>();
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

public string TargetSceneName
{
get => orig.TargetSceneName;
}

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

public System.Single? BeginTime
{
get => orig.BeginTime;
}

public void RecordBeginTime (SceneLoad.Phases phase) =>
CallMethod(new object[] {phase});

public void RecordEndTime (SceneLoad.Phases phase) =>
CallMethod(new object[] {phase});

public System.Single? GetDuration (SceneLoad.Phases phase) =>
orig.GetDuration(phase);

public void Begin () =>
orig.Begin();

public System.Collections.IEnumerator BeginRoutine () =>
CallMethod<System.Collections.IEnumerator>();

}
}
