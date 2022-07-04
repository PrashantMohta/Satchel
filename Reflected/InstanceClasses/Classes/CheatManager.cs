namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CheatManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheatManagerR:InstanceClassWrapper<CheatManager>
{
public CheatManagerR(CheatManager _orig) : base(_orig) {}
public CheatManager instance
{
get => GetFieldStatic<CheatManager>();
set => SetField(value);
}

public bool wasEverOpened
{
get => GetField<bool>();
set => SetField(value);
}

public bool isOpen
{
get => GetField<bool>();
set => SetField(value);
}

public int selectedButtonIndex
{
get => GetField<int>();
set => SetField(value);
}

public int lastSelectDelta
{
get => GetField<int>();
set => SetField(value);
}

public float selectCooldown
{
get => GetField<float>();
set => SetField(value);
}

public float KeyRepeatInterval
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public bool isQuickHealEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public bool isRegenerating
{
get => GetField<bool>();
set => SetField(value);
}

public bool isInstaDeathEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public bool isInstaKillEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public int safetyCounter
{
get => GetField<int>();
set => SetField(value);
}

public int SafetyAmount
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public string transitionRobotStartScene
{
get => GetField<string>();
set => SetField(value);
}

public float slowOpenLeftStickTimer
{
get => GetField<float>();
set => SetField(value);
}

public float slowOpenRightStickTimer
{
get => GetField<float>();
set => SetField(value);
}

public bool IsCheatsEnabled
{
get => CheatManager.IsCheatsEnabled;
}

public bool IsInstaKillEnabled
{
get => CheatManager.IsInstaKillEnabled;
}



public void Init () =>
CallMethodStatic();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void OnDestroy () =>
CallMethod();

public void Update () =>
CallMethod();

public void ToggleCheatMenu () =>
CallMethod();

public void OnGUI () =>
CallMethod();

public void OpenStagStations () =>
CallMethodStatic();

public bool CheatButton (int buttonIndex, string content) =>
CallMethod<bool>(new object[] {buttonIndex, content});

public bool SafetyCheatButton (int buttonIndex, string content) =>
CallMethod<bool>(new object[] {buttonIndex, content});

public void Restore () =>
CallMethod();

public void Kill () =>
CallMethod();

public void GetGeo (int amount) =>
CallMethod(new object[] {amount});

}
}
