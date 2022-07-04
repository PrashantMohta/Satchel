namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnumeratorLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnumeratorLayoutR:InstanceClassWrapper<Modding.Menu.EnumeratorLayout>
{
public EnumeratorLayoutR(Modding.Menu.EnumeratorLayout _orig) : base(_orig) {}
public System.Collections.Generic.IEnumerator<Modding.Menu.AnchoredPosition> generator
{
get => GetField<System.Collections.Generic.IEnumerator<Modding.Menu.AnchoredPosition>>();
set => SetField(value);
}

public void ModifyNext (UnityEngine.RectTransform rt) =>
orig.ModifyNext(rt);

}
}
