namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CallMethodProper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CallMethodProperR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CallMethodProper>
{
public CallMethodProperR(HutongGames.PlayMaker.Actions.CallMethodProper _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmString behaviour
{
get => orig.behaviour;
set => orig.behaviour = value;
}

public HutongGames.PlayMaker.FsmString methodName
{
get => orig.methodName;
set => orig.methodName = value;
}

public HutongGames.PlayMaker.FsmVar[] parameters
{
get => orig.parameters;
set => orig.parameters = value;
}

public HutongGames.PlayMaker.FsmVar storeResult
{
get => orig.storeResult;
set => orig.storeResult = value;
}

public UnityEngine.Object cachedBehaviour
{
get => GetField<UnityEngine.Object>();
set => SetField(value);
}

public System.Type cachedType
{
get => GetField<System.Type>();
set => SetField(value);
}

public System.Reflection.MethodInfo cachedMethodInfo
{
get => GetField<System.Reflection.MethodInfo>();
set => SetField(value);
}

public System.Reflection.ParameterInfo[] cachedParameterInfo
{
get => GetField<System.Reflection.ParameterInfo[]>();
set => SetField(value);
}

public System.Object[] parametersArray
{
get => GetField<System.Object[]>();
set => SetField(value);
}

public string errorString
{
get => GetField<string>();
set => SetField(value);
}

public UnityEngine.MonoBehaviour component
{
get => GetField<UnityEngine.MonoBehaviour>();
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

public void OnEnter () =>
orig.OnEnter();

public void DoMethodCall () =>
CallMethod();

public bool DoCache () =>
CallMethod<bool>();

}
}
