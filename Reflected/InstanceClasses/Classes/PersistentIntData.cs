namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PersistentIntData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PersistentIntDataR : InstanceClassWrapper<PersistentIntData>
{
    public PersistentIntDataR(PersistentIntData _orig) : base(_orig)
    {
    }

    public string id
    {
        get => orig.id;
        set => orig.id = value;
    }

    public string sceneName
    {
        get => orig.sceneName;
        set => orig.sceneName = value;
    }

    public int value
    {
        get => orig.value;
        set => orig.value = value;
    }

    public bool semiPersistent
    {
        get => orig.semiPersistent;
        set => orig.semiPersistent = value;
    }
}