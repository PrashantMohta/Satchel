namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ActionButtonIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActionButtonIconR:InstanceClassWrapper<ActionButtonIcon>
{
public ActionButtonIconR(ActionButtonIcon _orig) : base(_orig) {}
public GlobalEnums.HeroActionButton action
{
get => orig.action;
set => orig.action = value;
}

public bool showForControllerOnly
{
get => orig.showForControllerOnly;
set => orig.showForControllerOnly = value;
}

public UnityEngine.Vector3? initialScale
{
get => GetField<UnityEngine.Vector3?>();
set => SetField(value);
}

public bool liveUpdate
{
get => orig.liveUpdate;
set => orig.liveUpdate = value;
}

public TMPro.TextMeshPro label
{
get => orig.label;
set => orig.label = value;
}

public TMPro.TextContainer textContainer
{
get => orig.textContainer;
set => orig.textContainer = value;
}

public UnityEngine.SpriteRenderer sr
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public GlobalEnums.HeroActionButton Action
{
get => orig.Action;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void CheckHideIcon () =>
CallMethod();

public void SetAction (GlobalEnums.HeroActionButton action) =>
orig.SetAction(action);

public void SetActionString (string action) =>
orig.SetActionString(action);

}
}
