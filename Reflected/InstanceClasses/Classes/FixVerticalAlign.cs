namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FixVerticalAlign allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FixVerticalAlignR:InstanceClassWrapper<FixVerticalAlign>
{
public FixVerticalAlignR(FixVerticalAlign _orig) : base(_orig) {}
public UnityEngine.UI.Text text
{
get => GetField<UnityEngine.UI.Text>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void AlignText () =>
orig.AlignText();

public void AlignTextKeymap () =>
orig.AlignTextKeymap();

}
}
