namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UIAnimationEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIAnimationEventsR:InstanceClassWrapper<UIAnimationEvents>
{
public UIAnimationEventsR(UIAnimationEvents _orig) : base(_orig) {}
public UnityEngine.Animator animator
{
get => orig.animator;
set => orig.animator = value;
}

public UIManager ui
{
get => GetField<UIManager>();
set => SetField(value);
}



public void OnEnable () =>
orig.OnEnable();

public void OnDisable () =>
orig.OnDisable();

public void AnimateIn () =>
CallMethod();

public void AnimateOut () =>
CallMethod();

}
}
