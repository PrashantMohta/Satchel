namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerActivateGameObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerActivateGameObjectR : InstanceClassWrapper<TriggerActivateGameObject>
{
    public TriggerActivateGameObjectR(TriggerActivateGameObject _orig) : base(_orig)
    {
    }

    public bool deactivateObjectOnLoad
    {
        get => orig.deactivateObjectOnLoad;
        set => orig.deactivateObjectOnLoad = value;
    }

    public bool active
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject gameObjectToSet
    {
        get => orig.gameObjectToSet;
        set => orig.gameObjectToSet = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        orig.OnTriggerEnter2D(otherCollider);
    }

    public void OnTriggerStay2D(Collider2D otherCollider)
    {
        orig.OnTriggerStay2D(otherCollider);
    }

    public void OnTriggerExit2D(Collider2D otherCollider)
    {
        orig.OnTriggerExit2D(otherCollider);
    }
}