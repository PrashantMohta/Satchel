namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SecureplayerPrefsDemoClass allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecureplayerPrefsDemoClassR : InstanceClassWrapper<SecureplayerPrefsDemoClass>
{
    public SecureplayerPrefsDemoClassR(SecureplayerPrefsDemoClass _orig) : base(_orig)
    {
    }

    public string playID
    {
        get => orig.playID;
        set => orig.playID = value;
    }

    public int type
    {
        get => orig.type;
        set => orig.type = value;
    }

    public bool incremental
    {
        get => orig.incremental;
        set => orig.incremental = value;
    }
}