namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PersistentBoolData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PersistentBoolDataR:InstanceClassWrapper<PersistentBoolData>
{
public PersistentBoolDataR(PersistentBoolData _orig) : base(_orig) {}
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

public bool activated
{
get => orig.activated;
set => orig.activated = value;
}

public bool semiPersistent
{
get => orig.semiPersistent;
set => orig.semiPersistent = value;
}

}
}
