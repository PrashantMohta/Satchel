namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetEventData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetEventDataR : InstanceClassWrapper<SetEventData>
{
    public SetEventDataR(SetEventData _orig) : base(_orig)
    {
    }

    public FsmGameObject setGameObjectData
    {
        get => orig.setGameObjectData;
        set => orig.setGameObjectData = value;
    }

    public FsmInt setIntData
    {
        get => orig.setIntData;
        set => orig.setIntData = value;
    }

    public FsmFloat setFloatData
    {
        get => orig.setFloatData;
        set => orig.setFloatData = value;
    }

    public FsmString setStringData
    {
        get => orig.setStringData;
        set => orig.setStringData = value;
    }

    public FsmBool setBoolData
    {
        get => orig.setBoolData;
        set => orig.setBoolData = value;
    }

    public FsmVector2 setVector2Data
    {
        get => orig.setVector2Data;
        set => orig.setVector2Data = value;
    }

    public FsmVector3 setVector3Data
    {
        get => orig.setVector3Data;
        set => orig.setVector3Data = value;
    }

    public FsmRect setRectData
    {
        get => orig.setRectData;
        set => orig.setRectData = value;
    }

    public FsmQuaternion setQuaternionData
    {
        get => orig.setQuaternionData;
        set => orig.setQuaternionData = value;
    }

    public FsmColor setColorData
    {
        get => orig.setColorData;
        set => orig.setColorData = value;
    }

    public FsmMaterial setMaterialData
    {
        get => orig.setMaterialData;
        set => orig.setMaterialData = value;
    }

    public FsmTexture setTextureData
    {
        get => orig.setTextureData;
        set => orig.setTextureData = value;
    }

    public FsmObject setObjectData
    {
        get => orig.setObjectData;
        set => orig.setObjectData = value;
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
}