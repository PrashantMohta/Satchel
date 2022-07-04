namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NextSceneOnInput allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NextSceneOnInputR:InstanceClassWrapper<NextSceneOnInput>
{
public NextSceneOnInputR(NextSceneOnInput _orig) : base(_orig) {}
public UnityEngine.Events.UnityEvent onBeforeSave
{
get => GetField<UnityEngine.Events.UnityEvent>();
set => SetField(value);
}

public bool doSaveOnStart
{
get => GetField<bool>();
set => SetField(value);
}

public bool acceptingInput
{
get => GetField<bool>();
set => SetField(value);
}

public float maxInputBlockDelay
{
get => GetField<float>();
set => SetField(value);
}

public float inputAcceptTime
{
get => GetField<float>();
set => SetField(value);
}

public bool hasSkipped
{
get => GetField<bool>();
set => SetField(value);
}

public bool AcceptingInput
{
get => orig.AcceptingInput;
}

public bool ButtonPressed
{
get => GetProperty<bool>();
}



public void Start () =>
CallMethod();

public void UnlockSkip () =>
orig.UnlockSkip();

public void Update () =>
CallMethod();

public void Skip () =>
CallMethod();

}
}
