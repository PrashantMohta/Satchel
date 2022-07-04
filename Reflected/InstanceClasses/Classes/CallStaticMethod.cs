using System.Reflection;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CallStaticMethod allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CallStaticMethodR : InstanceClassWrapper<CallStaticMethod>
{
    public CallStaticMethodR(CallStaticMethod _orig) : base(_orig)
    {
    }

    public FsmString className
    {
        get => orig.className;
        set => orig.className = value;
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

    public Type cachedType
    {
        get => GetField<Type>();
        set => SetField(value);
    }

    public string cachedClassName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string cachedMethodName
    {
        get => GetField<string>();
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

    public bool DoCache()
    {
        return CallMethod<bool>();
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}