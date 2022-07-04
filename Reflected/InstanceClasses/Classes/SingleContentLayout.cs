namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SingleContentLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SingleContentLayoutR:InstanceClassWrapper<Modding.Menu.SingleContentLayout>
{
public SingleContentLayoutR(Modding.Menu.SingleContentLayout _orig) : base(_orig) {}
public Modding.Menu.AnchoredPosition Position
{
get => orig.Position;
set => orig.Position = value;
}

public void ModifyNext (UnityEngine.RectTransform rt) =>
orig.ModifyNext(rt);

}
}
