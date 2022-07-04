namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EventTargetVariable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EventTargetVariableR:InstanceClassWrapper<HutongGames.PlayMaker.Ecosystem.Utils.EventTargetVariable>
{
public EventTargetVariableR(HutongGames.PlayMaker.Ecosystem.Utils.EventTargetVariable _orig) : base(_orig) {}
public string variable
{
get => orig.variable;
set => orig.variable = value;
}

public System.Object TypeId
{
get => orig.TypeId;
}

}
}
