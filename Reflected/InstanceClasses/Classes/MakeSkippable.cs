namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MakeSkippable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MakeSkippableR : InstanceClassWrapper<MakeSkippable>
{
    public MakeSkippableR(MakeSkippable _orig) : base(_orig)
    {
    }

    public float unlockAfterSec
    {
        get => orig.unlockAfterSec;
        set => orig.unlockAfterSec = value;
    }

    public CinematicPlayer cinematicPlayer
    {
        get => GetField<CinematicPlayer>();
        set => SetField(value);
    }

    public CutsceneHelper cutsceneHelper
    {
        get => GetField<CutsceneHelper>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UnlockSkip()
    {
        CallMethod();
    }
}