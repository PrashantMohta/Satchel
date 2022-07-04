namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UpdateHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UpdateHelperR : InstanceClassWrapper<UpdateHelper>
{
    public UpdateHelperR(UpdateHelper _orig) : base(_orig)
    {
    }

    public void SetDirty(Fsm fsm)
    {
        UpdateHelper.SetDirty(fsm);
    }
}