namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PreMenuInputModuleActionAdaptor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreMenuInputModuleActionAdaptorR:InstanceClassWrapper<PreMenuInputModuleActionAdaptor>
{
public PreMenuInputModuleActionAdaptorR(PreMenuInputModuleActionAdaptor _orig) : base(_orig) {}


public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void CreateActions () =>
CallMethod();

public void DestroyActions () =>
CallMethod();

}
}
