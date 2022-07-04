namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dSpriteSetId allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dSpriteSetIdR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Tk2dSpriteSetId>
{
public Tk2dSpriteSetIdR(HutongGames.PlayMaker.Actions.Tk2dSpriteSetId _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmInt spriteID
{
get => orig.spriteID;
set => orig.spriteID = value;
}

public HutongGames.PlayMaker.FsmString ORSpriteName
{
get => orig.ORSpriteName;
set => orig.ORSpriteName = value;
}

public HutongGames.PlayMaker.FsmGameObject spriteCollection
{
get => orig.spriteCollection;
set => orig.spriteCollection = value;
}

public tk2dBaseSprite _sprite
{
get => GetField<tk2dBaseSprite>();
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

public void _getSprite () =>
CallMethod();

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void DoSetSpriteID () =>
CallMethod();

}
}
