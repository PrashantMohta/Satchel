namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StagTravel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StagTravelR : InstanceClassWrapper<StagTravel>
{
    public StagTravelR(StagTravel _orig) : base(_orig)
    {
    }

    public CinematicSequence cinematicSequence
    {
        get => GetField<CinematicSequence>();
        set => SetField(value);
    }

    public float minimumDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isAsync
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float currentDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isFetchComplete
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isReadyToActivate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isSkipping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isSkipFadeComplete
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool IsReadyToActivate => GetProperty<bool>();


    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator FadeInRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public void NotifyFetchComplete()
    {
        CallMethod();
    }

    public IEnumerator Skip()
    {
        return orig.Skip();
    }
}