namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OpeningSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OpeningSequenceR:InstanceClassWrapper<OpeningSequence>
{
public OpeningSequenceR(OpeningSequence _orig) : base(_orig) {}
public ChainSequence chainSequence
{
get => GetField<ChainSequence>();
set => SetField(value);
}

public UnityEngine.ThreadPriority streamingLoadPriority
{
get => GetField<UnityEngine.ThreadPriority>();
set => SetField(value);
}

public UnityEngine.ThreadPriority completedLoadPriority
{
get => GetField<UnityEngine.ThreadPriority>();
set => SetField(value);
}

public float skipChargeDuration
{
get => GetField<float>();
set => SetField(value);
}

public bool isAsync
{
get => GetField<bool>();
set => SetField(value);
}

public bool isLevelReady
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.AsyncOperation asyncKnightLoad
{
get => GetField<UnityEngine.AsyncOperation>();
set => SetField(value);
}

public UnityEngine.AsyncOperation asyncWorldLoad
{
get => GetField<UnityEngine.AsyncOperation>();
set => SetField(value);
}

public float skipChargeTimer
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator StartAsync () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator StartSync () =>
CallMethod<System.Collections.IEnumerator>();

public void Update () =>
CallMethod();

public bool IsLevelReady (UnityEngine.AsyncOperation operation) =>
CallMethodStatic<bool>(new object[] {operation});

public System.Collections.IEnumerator Skip () =>
orig.Skip();

public void OnChangingSequences () =>
CallMethod();

}
}
