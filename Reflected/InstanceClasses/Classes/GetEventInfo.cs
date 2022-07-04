namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetEventInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetEventInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetEventInfo>
{
public GetEventInfoR(HutongGames.PlayMaker.Actions.GetEventInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject sentByGameObject
{
get => orig.sentByGameObject;
set => orig.sentByGameObject = value;
}

public HutongGames.PlayMaker.FsmString fsmName
{
get => orig.fsmName;
set => orig.fsmName = value;
}

public HutongGames.PlayMaker.FsmBool getBoolData
{
get => orig.getBoolData;
set => orig.getBoolData = value;
}

public HutongGames.PlayMaker.FsmInt getIntData
{
get => orig.getIntData;
set => orig.getIntData = value;
}

public HutongGames.PlayMaker.FsmFloat getFloatData
{
get => orig.getFloatData;
set => orig.getFloatData = value;
}

public HutongGames.PlayMaker.FsmVector2 getVector2Data
{
get => orig.getVector2Data;
set => orig.getVector2Data = value;
}

public HutongGames.PlayMaker.FsmVector3 getVector3Data
{
get => orig.getVector3Data;
set => orig.getVector3Data = value;
}

public HutongGames.PlayMaker.FsmString getStringData
{
get => orig.getStringData;
set => orig.getStringData = value;
}

public HutongGames.PlayMaker.FsmGameObject getGameObjectData
{
get => orig.getGameObjectData;
set => orig.getGameObjectData = value;
}

public HutongGames.PlayMaker.FsmRect getRectData
{
get => orig.getRectData;
set => orig.getRectData = value;
}

public HutongGames.PlayMaker.FsmQuaternion getQuaternionData
{
get => orig.getQuaternionData;
set => orig.getQuaternionData = value;
}

public HutongGames.PlayMaker.FsmMaterial getMaterialData
{
get => orig.getMaterialData;
set => orig.getMaterialData = value;
}

public HutongGames.PlayMaker.FsmTexture getTextureData
{
get => orig.getTextureData;
set => orig.getTextureData = value;
}

public HutongGames.PlayMaker.FsmColor getColorData
{
get => orig.getColorData;
set => orig.getColorData = value;
}

public HutongGames.PlayMaker.FsmObject getObjectData
{
get => orig.getObjectData;
set => orig.getObjectData = value;
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

}
}
