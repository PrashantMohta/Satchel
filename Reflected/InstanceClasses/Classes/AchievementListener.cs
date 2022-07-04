using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementListenerR : InstanceClassWrapper<AchievementListener>
{
    public AchievementListenerR(AchievementListener _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public SpriteRenderer icon
    {
        get => orig.icon;
        set => orig.icon = value;
    }

    public TextMeshPro title
    {
        get => orig.title;
        set => orig.title = value;
    }

    public TextMeshPro text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public PlayMakerFSM fsmToSendEvent
    {
        get => orig.fsmToSendEvent;
        set => orig.fsmToSendEvent = value;
    }

    public string eventName
    {
        get => orig.eventName;
        set => orig.eventName = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void CaptureAchievementEvent(string achievementKey)
    {
        CallMethod(new object[] { achievementKey });
    }
}