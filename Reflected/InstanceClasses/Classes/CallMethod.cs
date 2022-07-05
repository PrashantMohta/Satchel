using System.Reflection;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CallMethod allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CallMethodR : InstanceClassWrapper<CallMethod>
{
    public CallMethodR(CallMethod _orig) : base(_orig)
    {
    }

    public FsmObject behaviour
    {
        get => orig.behaviour;
        set => orig.behaviour = value;
    }

    public FsmString methodName
    {
        get => orig.methodName;
        set => orig.methodName = value;
    }

    public FsmVar[] parameters
    {
        get => orig.parameters;
        set => orig.parameters = value;
    }

    public FsmVar storeResult
    {
        get => orig.storeResult;
        set => orig.storeResult = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public bool manualUI
    {
        get => orig.manualUI;
        set => orig.manualUI = value;
    }

    public FsmObject cachedBehaviour
    {
        get => GetField<FsmObject>();
        set => SetField(value);
    }

    public FsmString cachedMethodName
    {
        get => GetField<FsmString>();
        set => SetField(value);
    }

    public Type cachedType
    {
        get => GetField<Type>();
        set => SetField(value);
    }

    public MethodInfo cachedMethodInfo
    {
        get => GetField<MethodInfo>();
        set => SetField(value);
    }

    public ParameterInfo[] cachedParameterInfo
    {
        get => GetField<ParameterInfo[]>();
        set => SetField(value);
    }

    public object[] parametersArray
    {
        get => GetField<object[]>();
        set => SetField(value);
    }

    public string errorString
    {
        get => GetField<string>();
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

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
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

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoMethodCall()
    {
        CallMethod();
    }

    public bool NeedToUpdateCache()
    {
        return CallMethod<bool>();
    }

    public void ClearCache()
    {
        CallMethod();
    }

    public bool DoCache()
    {
        return CallMethod<bool>();
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}