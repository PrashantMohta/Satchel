namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroAudioController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroAudioControllerR : InstanceClassWrapper<HeroAudioController>
{
    public HeroAudioControllerR(HeroAudioController _orig) : base(_orig)
    {
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public AudioSource softLanding
    {
        get => orig.softLanding;
        set => orig.softLanding = value;
    }

    public AudioSource hardLanding
    {
        get => orig.hardLanding;
        set => orig.hardLanding = value;
    }

    public AudioSource jump
    {
        get => orig.jump;
        set => orig.jump = value;
    }

    public AudioSource takeHit
    {
        get => orig.takeHit;
        set => orig.takeHit = value;
    }

    public AudioSource backDash
    {
        get => orig.backDash;
        set => orig.backDash = value;
    }

    public AudioSource dash
    {
        get => orig.dash;
        set => orig.dash = value;
    }

    public AudioSource footStepsRun
    {
        get => orig.footStepsRun;
        set => orig.footStepsRun = value;
    }

    public AudioSource footStepsWalk
    {
        get => orig.footStepsWalk;
        set => orig.footStepsWalk = value;
    }

    public AudioSource wallslide
    {
        get => orig.wallslide;
        set => orig.wallslide = value;
    }

    public AudioSource nailArtCharge
    {
        get => orig.nailArtCharge;
        set => orig.nailArtCharge = value;
    }

    public AudioSource nailArtReady
    {
        get => orig.nailArtReady;
        set => orig.nailArtReady = value;
    }

    public AudioSource falling
    {
        get => orig.falling;
        set => orig.falling = value;
    }

    public AudioSource walljump
    {
        get => orig.walljump;
        set => orig.walljump = value;
    }

    public Coroutine fallingCo
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void PlaySound(HeroSounds soundEffect)
    {
        orig.PlaySound(soundEffect);
    }

    public void StopSound(HeroSounds soundEffect)
    {
        orig.StopSound(soundEffect);
    }

    public void StopAllSounds()
    {
        orig.StopAllSounds();
    }

    public void PauseAllSounds()
    {
        orig.PauseAllSounds();
    }

    public void UnPauseAllSounds()
    {
        orig.UnPauseAllSounds();
    }

    public void RandomizePitch(AudioSource src, float minPitch, float maxPitch)
    {
        CallMethod(new object[] { src, minPitch, maxPitch });
    }

    public void ResetPitch(AudioSource src)
    {
        CallMethod(new object[] { src });
    }

    public IEnumerator FadeInVolume(AudioSource src, float duration)
    {
        return CallMethod<IEnumerator>(new object[] { src, duration });
    }
}