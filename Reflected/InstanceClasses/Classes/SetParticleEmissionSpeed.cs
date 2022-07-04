namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetParticleEmissionSpeed allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetParticleEmissionSpeedR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetParticleEmissionSpeed>
{
public SetParticleEmissionSpeedR(HutongGames.PlayMaker.Actions.SetParticleEmissionSpeed _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat emissionSpeed
{
get => orig.emissionSpeed;
set => orig.emissionSpeed = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.ParticleSystem emitter
{
get => GetField<UnityEngine.ParticleSystem>();
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

public void OnUpdate () =>
orig.OnUpdate();

public void DoSetEmitSpeed () =>
CallMethod();

}
}
