using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ResolutionCountdownTimer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ResolutionCountdownTimerR : InstanceClassWrapper<ResolutionCountdownTimer>
{
    public ResolutionCountdownTimerR(ResolutionCountdownTimer _orig) : base(_orig)
    {
    }

    public int timerDuration
    {
        get => orig.timerDuration;
        set => orig.timerDuration = value;
    }

    public Text timerText
    {
        get => orig.timerText;
        set => orig.timerText = value;
    }

    public int currentTime
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool running
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public InputHandler ih
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void StartTimer()
    {
        orig.StartTimer();
    }

    public void CancelTimer()
    {
        orig.CancelTimer();
    }

    public void TickDown()
    {
        CallMethod();
    }

    public IEnumerator CountDown()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator RollbackRes()
    {
        return CallMethod<IEnumerator>();
    }
}