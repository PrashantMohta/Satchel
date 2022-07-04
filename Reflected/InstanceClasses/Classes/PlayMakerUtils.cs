namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUtils allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUtilsR:InstanceClassWrapper<PlayMakerUtils>
{
public PlayMakerUtilsR(PlayMakerUtils _orig) : base(_orig) {}
public void SendEventToGameObject (PlayMakerFSM fromFsm, UnityEngine.GameObject target, string fsmEvent, bool includeChildren) =>
PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, includeChildren);

public void SendEventToGameObject (PlayMakerFSM fromFsm, UnityEngine.GameObject target, string fsmEvent) =>
PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent);

public void SendEventToGameObject (PlayMakerFSM fromFsm, UnityEngine.GameObject target, string fsmEvent, HutongGames.PlayMaker.FsmEventData eventData) =>
PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, eventData);

public void SendEventToGameObject (PlayMakerFSM fromFsm, UnityEngine.GameObject target, string fsmEvent, bool includeChildren, HutongGames.PlayMaker.FsmEventData eventData) =>
PlayMakerUtils.SendEventToGameObject(fromFsm, target, fsmEvent, includeChildren, eventData);

public bool DoesTargetImplementsEvent (HutongGames.PlayMaker.FsmEventTarget target, string eventName) =>
PlayMakerUtils.DoesTargetImplementsEvent(target, eventName);

public bool DoesGameObjectImplementsEvent (UnityEngine.GameObject go, string fsmEvent) =>
PlayMakerUtils.DoesGameObjectImplementsEvent(go, fsmEvent);

public bool DoesGameObjectImplementsEvent (UnityEngine.GameObject go, string fsmName, string fsmEvent) =>
PlayMakerUtils.DoesGameObjectImplementsEvent(go, fsmName, fsmEvent);

public bool DoesFsmImplementsEvent (PlayMakerFSM fsm, string fsmEvent) =>
PlayMakerUtils.DoesFsmImplementsEvent(fsm, fsmEvent);

public PlayMakerFSM FindFsmOnGameObject (UnityEngine.GameObject go, string fsmName) =>
PlayMakerUtils.FindFsmOnGameObject(go, fsmName);

public void RefreshValueFromFsmVar (HutongGames.PlayMaker.Fsm fromFsm, HutongGames.PlayMaker.FsmVar fsmVar) =>
PlayMakerUtils.RefreshValueFromFsmVar(fromFsm, fsmVar);

public System.Object GetValueFromFsmVar (HutongGames.PlayMaker.Fsm fromFsm, HutongGames.PlayMaker.FsmVar fsmVar) =>
PlayMakerUtils.GetValueFromFsmVar(fromFsm, fsmVar);

public bool ApplyValueToFsmVar (HutongGames.PlayMaker.Fsm fromFsm, HutongGames.PlayMaker.FsmVar fsmVar, System.Object value) =>
PlayMakerUtils.ApplyValueToFsmVar(fromFsm, fsmVar, value);

public float GetFloatFromObject (System.Object _obj, HutongGames.PlayMaker.VariableType targetType, bool fastProcessingIfPossible) =>
PlayMakerUtils.GetFloatFromObject(_obj, targetType, fastProcessingIfPossible);

public string ParseFsmVarToString (HutongGames.PlayMaker.Fsm fsm, HutongGames.PlayMaker.FsmVar fsmVar) =>
PlayMakerUtils.ParseFsmVarToString(fsm, fsmVar);

public string ParseValueToString (System.Object item, bool useBytes) =>
PlayMakerUtils.ParseValueToString(item, useBytes);

public string ParseValueToString (System.Object item) =>
PlayMakerUtils.ParseValueToString(item);

public System.Object ParseValueFromString (string source, bool useBytes) =>
PlayMakerUtils.ParseValueFromString(source, useBytes);

public System.Object ParseValueFromString (string source, HutongGames.PlayMaker.VariableType type) =>
PlayMakerUtils.ParseValueFromString(source, type);

public System.Object ParseValueFromString (string source, System.Type type) =>
PlayMakerUtils.ParseValueFromString(source, type);

public System.Object ParseValueFromString (string source) =>
PlayMakerUtils.ParseValueFromString(source);

}
}
