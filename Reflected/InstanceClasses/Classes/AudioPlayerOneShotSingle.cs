namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AudioPlayerOneShotSingle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioPlayerOneShotSingleR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle>
{
public AudioPlayerOneShotSingleR(HutongGames.PlayMaker.Actions.AudioPlayerOneShotSingle _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmGameObject audioPlayer
{
get => orig.audioPlayer;
set => orig.audioPlayer = value;
}

public HutongGames.PlayMaker.FsmGameObject spawnPoint
{
get => orig.spawnPoint;
set => orig.spawnPoint = value;
}

public HutongGames.PlayMaker.FsmObject audioClip
{
get => orig.audioClip;
set => orig.audioClip = value;
}

public HutongGames.PlayMaker.FsmFloat pitchMin
{
get => orig.pitchMin;
set => orig.pitchMin = value;
}

public HutongGames.PlayMaker.FsmFloat pitchMax
{
get => orig.pitchMax;
set => orig.pitchMax = value;
}

public HutongGames.PlayMaker.FsmFloat volume
{
get => orig.volume;
set => orig.volume = value;
}

public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public HutongGames.PlayMaker.FsmGameObject storePlayer
{
get => orig.storePlayer;
set => orig.storePlayer = value;
}

public UnityEngine.AudioSource audio
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
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

public void DoPlayRandomClip () =>
CallMethod();

}
}
