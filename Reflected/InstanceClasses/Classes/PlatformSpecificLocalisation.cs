namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlatformSpecificLocalisation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlatformSpecificLocalisationR : InstanceClassWrapper<PlatformSpecificLocalisation>
{
    public PlatformSpecificLocalisationR(PlatformSpecificLocalisation _orig) : base(_orig)
    {
    }

    public PlatformSpecificLocalisation.PlatformKey[] platformKeys
    {
        get => orig.platformKeys;
        set => orig.platformKeys = value;
    }


    public void Awake()
    {
        CallMethod();
    }
}