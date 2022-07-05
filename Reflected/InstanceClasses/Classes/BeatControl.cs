namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BeatControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BeatControlR : InstanceClassWrapper<BeatControl>
{
    public BeatControlR(BeatControl _orig) : base(_orig)
    {
    }

    public float beatIncrease
    {
        get => orig.beatIncrease;
        set => orig.beatIncrease = value;
    }

    public float oldBeatValue
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Update()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }
}