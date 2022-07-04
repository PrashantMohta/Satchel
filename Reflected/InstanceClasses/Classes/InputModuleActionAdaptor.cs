namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InputModuleActionAdaptor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputModuleActionAdaptorR:InstanceClassWrapper<InputModuleActionAdaptor>
{
public InputModuleActionAdaptorR(InputModuleActionAdaptor _orig) : base(_orig) {}
public InputHandler inputHandler
{
get => GetField<InputHandler>();
set => SetField(value);
}

public InControl.HollowKnightInputModule inputModule
{
get => GetField<InControl.HollowKnightInputModule>();
set => SetField(value);
}



public void Start () =>
CallMethod();

}
}
