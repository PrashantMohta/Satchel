namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetChild allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetChildR : InstanceClassWrapper<GetChild>
{
    public GetChildR(GetChild _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString childName
    {
        get => orig.childName;
        set => orig.childName = value;
    }

    public FsmString withTag
    {
        get => orig.withTag;
        set => orig.withTag = value;
    }

    public FsmGameObject storeResult
    {
        get => orig.storeResult;
        set => orig.storeResult = value;
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public GameObject DoGetChildByName(GameObject root, string name, string tag)
    {
        return CallMethodStatic<GameObject>(new object[] { root, name, tag });
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}