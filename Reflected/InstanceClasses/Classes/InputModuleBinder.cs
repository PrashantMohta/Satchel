namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputModuleBinder allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputModuleBinderR : InstanceClassWrapper<InputModuleBinder>
{
    public InputModuleBinderR(InputModuleBinder _orig) : base(_orig)
    {
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnAcceptRejectInputStyleChanged()
    {
        CallMethod();
    }

    public void BindAndApplyActions()
    {
        CallMethod();
    }
}