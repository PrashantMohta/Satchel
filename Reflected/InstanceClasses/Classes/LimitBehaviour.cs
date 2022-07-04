namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LimitBehaviour allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LimitBehaviourR:InstanceClassWrapper<LimitBehaviour>
{
public LimitBehaviourR(LimitBehaviour _orig) : base(_orig) {}
public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.GameObject>> behaviourLists
{
get => LimitBehaviour.behaviourLists;
set => LimitBehaviour.behaviourLists = value;
}

public string id
{
get => orig.id;
set => orig.id = value;
}

public int limit
{
get => orig.limit;
set => orig.limit = value;
}

public string forceRemoveEvent
{
get => orig.forceRemoveEvent;
set => orig.forceRemoveEvent = value;
}



public void OnDisable () =>
CallMethod();

public void Add () =>
orig.Add();

public void RemoveFirst () =>
orig.RemoveFirst();

public void RemoveSelf () =>
orig.RemoveSelf();

}
}
