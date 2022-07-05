namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUtils allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUtilsR : InstanceClassWrapper<PlayMakerUtils>
{
    public PlayMakerUtilsR(PlayMakerUtils _orig) : base(_orig)
    {
    }

    public void SendEventToGameObject(PlayMakerFSM fromFsm, GameObject target, string fsmEvent, bool includeChildren)
    {
        PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, includeChildren);
    }

    public void SendEventToGameObject(PlayMakerFSM fromFsm, GameObject target, string fsmEvent)
    {
        PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent);
    }

    public void SendEventToGameObject(PlayMakerFSM fromFsm, GameObject target, string fsmEvent, FsmEventData eventData)
    {
        PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, eventData);
    }

    public void SendEventToGameObject(PlayMakerFSM fromFsm, GameObject target, string fsmEvent, bool includeChildren,
        FsmEventData eventData)
    {
        PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, includeChildren, eventData);
    }

    public bool DoesTargetImplementsEvent(FsmEventTarget target, string eventName)
    {
        return PlayMakerUtils.DoesTargetImplementsEvent(target, eventName);
    }

    public bool DoesGameObjectImplementsEvent(GameObject go, string fsmEvent)
    {
        return PlayMakerUtils.DoesGameObjectImplementsEvent(go, fsmEvent);
    }

    public bool DoesGameObjectImplementsEvent(GameObject go, string fsmName, string fsmEvent)
    {
        return PlayMakerUtils.DoesGameObjectImplementsEvent(go, fsmName, fsmEvent);
    }

    public bool DoesFsmImplementsEvent(PlayMakerFSM fsm, string fsmEvent)
    {
        return PlayMakerUtils.DoesFsmImplementsEvent(fsm, fsmEvent);
    }

    public PlayMakerFSM FindFsmOnGameObject(GameObject go, string fsmName)
    {
        return PlayMakerUtils.FindFsmOnGameObject(go, fsmName);
    }

    public void RefreshValueFromFsmVar(Fsm fromFsm, FsmVar fsmVar)
    {
        PlayMakerUtils.RefreshValueFromFsmVar(fromFsm, fsmVar);
    }

    public object GetValueFromFsmVar(Fsm fromFsm, FsmVar fsmVar)
    {
        return PlayMakerUtils.GetValueFromFsmVar(fromFsm, fsmVar);
    }

    public bool ApplyValueToFsmVar(Fsm fromFsm, FsmVar fsmVar, object value)
    {
        return PlayMakerUtils.ApplyValueToFsmVar(fromFsm, fsmVar, value);
    }

    public float GetFloatFromObject(object _obj, VariableType targetType, bool fastProcessingIfPossible)
    {
        return PlayMakerUtils.GetFloatFromObject(_obj, targetType, fastProcessingIfPossible);
    }

    public string ParseFsmVarToString(Fsm fsm, FsmVar fsmVar)
    {
        return PlayMakerUtils.ParseFsmVarToString(fsm, fsmVar);
    }

    public string ParseValueToString(object item, bool useBytes)
    {
        return PlayMakerUtils.ParseValueToString(item, useBytes);
    }

    public string ParseValueToString(object item)
    {
        return PlayMakerUtils.ParseValueToString(item);
    }

    public object ParseValueFromString(string source, bool useBytes)
    {
        return PlayMakerUtils.ParseValueFromString(source, useBytes);
    }

    public object ParseValueFromString(string source, VariableType type)
    {
        return PlayMakerUtils.ParseValueFromString(source, type);
    }

    public object ParseValueFromString(string source, Type type)
    {
        return PlayMakerUtils.ParseValueFromString(source, type);
    }

    public object ParseValueFromString(string source)
    {
        return PlayMakerUtils.ParseValueFromString(source);
    }
}