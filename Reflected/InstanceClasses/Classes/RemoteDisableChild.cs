namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RemoteDisableChild allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RemoteDisableChildR : InstanceClassWrapper<RemoteDisableChild>
{
    public RemoteDisableChildR(RemoteDisableChild _orig) : base(_orig)
    {
    }

    public GameObject child
    {
        get => orig.child;
        set => orig.child = value;
    }


    public void RemoteDisableObject()
    {
        orig.RemoteDisableObject();
    }

    public void RemoteEnableObject()
    {
        orig.RemoteEnableObject();
    }
}