namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AreaTitle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AreaTitleR:InstanceClassWrapper<AreaTitle>
{
public AreaTitleR(AreaTitle _orig) : base(_orig) {}
public AreaTitle instance
{
get => AreaTitle.instance;
set => AreaTitle.instance = value;
}



public void Awake () =>
CallMethod();

}
}
