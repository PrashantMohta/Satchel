namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetEventData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetEventDataR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetEventData>
{
public SetEventDataR(HutongGames.PlayMaker.Actions.SetEventData _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject setGameObjectData
{
get => orig.setGameObjectData;
set => orig.setGameObjectData = value;
}

public HutongGames.PlayMaker.FsmInt setIntData
{
get => orig.setIntData;
set => orig.setIntData = value;
}

public HutongGames.PlayMaker.FsmFloat setFloatData
{
get => orig.setFloatData;
set => orig.setFloatData = value;
}

public HutongGames.PlayMaker.FsmString setStringData
{
get => orig.setStringData;
set => orig.setStringData = value;
}

public HutongGames.PlayMaker.FsmBool setBoolData
{
get => orig.setBoolData;
set => orig.setBoolData = value;
}

public HutongGames.PlayMaker.FsmVector2 setVector2Data
{
get => orig.setVector2Data;
set => orig.setVector2Data = value;
}

public HutongGames.PlayMaker.FsmVector3 setVector3Data
{
get => orig.setVector3Data;
set => orig.setVector3Data = value;
}

public HutongGames.PlayMaker.FsmRect setRectData
{
get => orig.setRectData;
set => orig.setRectData = value;
}

public HutongGames.PlayMaker.FsmQuaternion setQuaternionData
{
get => orig.setQuaternionData;
set => orig.setQuaternionData = value;
}

public HutongGames.PlayMaker.FsmColor setColorData
{
get => orig.setColorData;
set => orig.setColorData = value;
}

public HutongGames.PlayMaker.FsmMaterial setMaterialData
{
get => orig.setMaterialData;
set => orig.setMaterialData = value;
}

public HutongGames.PlayMaker.FsmTexture setTextureData
{
get => orig.setTextureData;
set => orig.setTextureData = value;
}

public HutongGames.PlayMaker.FsmObject setObjectData
{
get => orig.setObjectData;
set => orig.setObjectData = value;
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
