namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Achievement allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementR : InstanceClassWrapper<Achievement>
{
    public AchievementR(Achievement _orig) : base(_orig)
    {
    }

    public string key
    {
        get => orig.key;
        set => orig.key = value;
    }

    public AchievementType type
    {
        get => orig.type;
        set => orig.type = value;
    }

    public Sprite earnedIcon
    {
        get => orig.earnedIcon;
        set => orig.earnedIcon = value;
    }

    public Sprite unearnedIcon
    {
        get => orig.unearnedIcon;
        set => orig.unearnedIcon = value;
    }

    public string localizedText
    {
        get => orig.localizedText;
        set => orig.localizedText = value;
    }

    public string localizedTitle
    {
        get => orig.localizedTitle;
        set => orig.localizedTitle = value;
    }
}