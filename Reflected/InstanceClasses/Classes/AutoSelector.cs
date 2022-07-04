namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AutoSelector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoSelectorR:InstanceClassWrapper<Modding.Menu.Components.AutoSelector>
{
public AutoSelectorR(Modding.Menu.Components.AutoSelector _orig) : base(_orig) {}
public UnityEngine.UI.Selectable Start
{
get => orig.Start;
set => orig.Start = value;
}



public void OnEnable () =>
CallMethod();

public System.Collections.IEnumerator SelectDelayed (UnityEngine.UI.Selectable selectable) =>
CallMethod<System.Collections.IEnumerator>(new object[] {selectable});

}
}
