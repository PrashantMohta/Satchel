using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ActionButtonIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActionButtonIconR : InstanceClassWrapper<ActionButtonIcon>
{
    public ActionButtonIconR(ActionButtonIcon _orig) : base(_orig)
    {
    }

    public HeroActionButton action
    {
        get => orig.action;
        set => orig.action = value;
    }

    public bool showForControllerOnly
    {
        get => orig.showForControllerOnly;
        set => orig.showForControllerOnly = value;
    }

    public Vector3? initialScale
    {
        get => GetField<Vector3?>();
        set => SetField(value);
    }

    public bool liveUpdate
    {
        get => orig.liveUpdate;
        set => orig.liveUpdate = value;
    }

    public TextMeshPro label
    {
        get => orig.label;
        set => orig.label = value;
    }

    public TextContainer textContainer
    {
        get => orig.textContainer;
        set => orig.textContainer = value;
    }

    public SpriteRenderer sr
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public HeroActionButton Action => orig.Action;


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void CheckHideIcon()
    {
        CallMethod();
    }

    public void SetAction(HeroActionButton action)
    {
        orig.SetAction(action);
    }

    public void SetActionString(string action)
    {
        orig.SetActionString(action);
    }
}