namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PreInstantiateGameObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreInstantiateGameObjectR:InstanceClassWrapper<PreInstantiateGameObject>
{
public PreInstantiateGameObjectR(PreInstantiateGameObject _orig) : base(_orig) {}
public UnityEngine.GameObject prefab
{
get => orig.prefab;
set => orig.prefab = value;
}

public UnityEngine.GameObject instantiatedGameObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject InstantiatedGameObject
{
get => orig.InstantiatedGameObject;
}



public void Awake () =>
CallMethod();

}
}
