namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HeroAudioController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroAudioControllerR:InstanceClassWrapper<HeroAudioController>
{
public HeroAudioControllerR(HeroAudioController _orig) : base(_orig) {}
public HeroController heroCtrl
{
get => GetField<HeroController>();
set => SetField(value);
}

public UnityEngine.AudioSource softLanding
{
get => orig.softLanding;
set => orig.softLanding = value;
}

public UnityEngine.AudioSource hardLanding
{
get => orig.hardLanding;
set => orig.hardLanding = value;
}

public UnityEngine.AudioSource jump
{
get => orig.jump;
set => orig.jump = value;
}

public UnityEngine.AudioSource takeHit
{
get => orig.takeHit;
set => orig.takeHit = value;
}

public UnityEngine.AudioSource backDash
{
get => orig.backDash;
set => orig.backDash = value;
}

public UnityEngine.AudioSource dash
{
get => orig.dash;
set => orig.dash = value;
}

public UnityEngine.AudioSource footStepsRun
{
get => orig.footStepsRun;
set => orig.footStepsRun = value;
}

public UnityEngine.AudioSource footStepsWalk
{
get => orig.footStepsWalk;
set => orig.footStepsWalk = value;
}

public UnityEngine.AudioSource wallslide
{
get => orig.wallslide;
set => orig.wallslide = value;
}

public UnityEngine.AudioSource nailArtCharge
{
get => orig.nailArtCharge;
set => orig.nailArtCharge = value;
}

public UnityEngine.AudioSource nailArtReady
{
get => orig.nailArtReady;
set => orig.nailArtReady = value;
}

public UnityEngine.AudioSource falling
{
get => orig.falling;
set => orig.falling = value;
}

public UnityEngine.AudioSource walljump
{
get => orig.walljump;
set => orig.walljump = value;
}

public UnityEngine.Coroutine fallingCo
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void PlaySound (GlobalEnums.HeroSounds soundEffect) =>
orig.PlaySound(soundEffect);

public void StopSound (GlobalEnums.HeroSounds soundEffect) =>
orig.StopSound(soundEffect);

public void StopAllSounds () =>
orig.StopAllSounds();

public void PauseAllSounds () =>
orig.PauseAllSounds();

public void UnPauseAllSounds () =>
orig.UnPauseAllSounds();

public void RandomizePitch (UnityEngine.AudioSource src, float minPitch, float maxPitch) =>
CallMethod(new object[] {src, minPitch, maxPitch});

public void ResetPitch (UnityEngine.AudioSource src) =>
CallMethod(new object[] {src});

public System.Collections.IEnumerator FadeInVolume (UnityEngine.AudioSource src, float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {src, duration});

}
}
