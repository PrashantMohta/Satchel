namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrubBGControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrubBGControlR:InstanceClassWrapper<GrubBGControl>
{
public GrubBGControlR(GrubBGControl _orig) : base(_orig) {}
public int grubNumber
{
get => orig.grubNumber;
set => orig.grubNumber = value;
}

public TriggerEnterEvent waveRegion
{
get => orig.waveRegion;
set => orig.waveRegion = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public AudioEventRandom idleSounds
{
get => orig.idleSounds;
set => orig.idleSounds = value;
}

public AudioEventRandom waveSounds
{
get => orig.waveSounds;
set => orig.waveSounds = value;
}

public UnityEngine.Coroutine idleRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine waveRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator Idle () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Wave () =>
CallMethod<System.Collections.IEnumerator>();

}
}
