namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TimeScaleIndependentUpdate allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TimeScaleIndependentUpdateR : InstanceClassWrapper<TimeScaleIndependentUpdate>
{
    public TimeScaleIndependentUpdateR(TimeScaleIndependentUpdate _orig) : base(_orig)
    {
    }

    public float previousTimeSinceStartup
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float deltaTime
    {
        get => orig.deltaTime;
        set => SetProperty(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public IEnumerator TimeScaleIndependentWaitForSeconds(float seconds)
    {
        return orig.TimeScaleIndependentWaitForSeconds(seconds);
    }
}