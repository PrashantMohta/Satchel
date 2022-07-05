namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIDragItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIDragItemR : InstanceClassWrapper<tk2dUIDragItem>
{
    public tk2dUIDragItemR(tk2dUIDragItem _orig) : base(_orig)
    {
    }

    public tk2dUIManager uiManager
    {
        get => orig.uiManager;
        set => orig.uiManager = value;
    }

    public Vector3 offset
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool isBtnActive
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public tk2dUIItem uiItem
    {
        get => orig.uiItem;
        set => orig.uiItem = value;
    }

    public GameObject SendMessageTarget
    {
        get => orig.SendMessageTarget;
        set => orig.SendMessageTarget = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void UpdateBtnPosition()
    {
        CallMethod();
    }

    public Vector3 CalculateNewPos()
    {
        return CallMethod<Vector3>();
    }

    public void ButtonDown()
    {
        orig.ButtonDown();
    }

    public void ButtonRelease()
    {
        orig.ButtonRelease();
    }
}