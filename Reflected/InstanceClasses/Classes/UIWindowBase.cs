namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UIWindowBase allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIWindowBaseR:InstanceClassWrapper<UIWindowBase>
{
public UIWindowBaseR(UIWindowBase _orig) : base(_orig) {}
public UnityEngine.RectTransform m_transform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnDrag (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnDrag(eventData);

public void ChangeStrength (float value) =>
orig.ChangeStrength(value);

public void ChangeVibrancy (float value) =>
orig.ChangeVibrancy(value);

}
}
