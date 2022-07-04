namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiInputFieldSetAsterixChar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiInputFieldSetAsterixCharR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.uGuiInputFieldSetAsterixChar>
{
public uGuiInputFieldSetAsterixCharR(HutongGames.PlayMaker.Actions.uGuiInputFieldSetAsterixChar _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString asterixChar
{
get => orig.asterixChar;
set => orig.asterixChar = value;
}

public HutongGames.PlayMaker.FsmBool resetOnExit
{
get => orig.resetOnExit;
set => orig.resetOnExit = value;
}

public UnityEngine.UI.InputField _inputField
{
get => GetField<UnityEngine.UI.InputField>();
set => SetField(value);
}

public System.Char _originalValue
{
get => GetField<System.Char>();
set => SetField(value);
}

public System.Char __char__
{
get => GetFieldStatic<System.Char>();
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

public HutongGames.PlayMaker.Fsm Fsm
{
get => orig.Fsm;
set => orig.Fsm = value;
}

public UnityEngine.GameObject Owner
{
get => orig.Owner;
set => orig.Owner = value;
}

public HutongGames.PlayMaker.FsmState State
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

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void DoSetValue () =>
CallMethod();

public void OnExit () =>
orig.OnExit();

}
}
