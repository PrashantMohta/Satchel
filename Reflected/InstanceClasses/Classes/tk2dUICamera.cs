namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUICamera allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUICameraR : InstanceClassWrapper<tk2dUICamera>
{
    public tk2dUICameraR(tk2dUICamera _orig) : base(_orig)
    {
    }

    public LayerMask raycastLayerMask
    {
        get => GetField<LayerMask>();
        set => SetField(value);
    }

    public LayerMask FilteredMask => orig.FilteredMask;

    public Camera HostCamera => orig.HostCamera;


    public void AssignRaycastLayerMask(LayerMask mask)
    {
        orig.AssignRaycastLayerMask(mask);
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }
}