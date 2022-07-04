namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementPopupHandler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementPopupHandlerR : InstanceClassWrapper<AchievementPopupHandler>
{
    public AchievementPopupHandlerR(AchievementPopupHandler _orig) : base(_orig)
    {
    }

    public AchievementPopupHandler Instance
    {
        get => AchievementPopupHandler.Instance;
        set => AchievementPopupHandler.Instance = value;
    }

    public AchievementPopup template
    {
        get => orig.template;
        set => orig.template = value;
    }

    public List<AchievementPopup> popups
    {
        get => GetField<List<AchievementPopup>>();
        set => SetField(value);
    }

    public bool reverseOrder
    {
        get => orig.reverseOrder;
        set => orig.reverseOrder = value;
    }

    public AchievementHandler achievements
    {
        get => GetField<AchievementHandler>();
        set => SetField(value);
    }

    public AchievementPopup lastPopup
    {
        get => GetField<AchievementPopup>();
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

    public void Setup(AchievementHandler handler)
    {
        orig.Setup(handler);
    }

    public void HandleAchievementEvent(string key)
    {
        CallMethod(new object[] { key });
    }

    public AchievementPopup GetPooledPopup()
    {
        return CallMethod<AchievementPopup>();
    }

    public void DisableAll(AchievementPopup sender)
    {
        CallMethod(new object[] { sender });
    }
}