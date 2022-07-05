namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ExtraDamageableProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ExtraDamageableProxyR : InstanceClassWrapper<ExtraDamageableProxy>
{
    public ExtraDamageableProxyR(ExtraDamageableProxy _orig) : base(_orig)
    {
    }

    public ExtraDamageable passTo
    {
        get => orig.passTo;
        set => orig.passTo = value;
    }
}