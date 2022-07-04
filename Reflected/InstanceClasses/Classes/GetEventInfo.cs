namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetEventInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetEventInfoR : InstanceClassWrapper<GetEventInfo>
{
    public GetEventInfoR(GetEventInfo _orig) : base(_orig)
    {
    }

    public FsmGameObject sentByGameObject
    {
        get => orig.sentByGameObject;
        set => orig.sentByGameObject = value;
    }

    public FsmString fsmName
    {
        get => orig.fsmName;
        set => orig.fsmName = value;
    }

    public FsmBool getBoolData
    {
        get => orig.getBoolData;
        set => orig.getBoolData = value;
    }

    public FsmInt getIntData
    {
        get => orig.getIntData;
        set => orig.getIntData = value;
    }

    public FsmFloat getFloatData
    {
        get => orig.getFloatData;
        set => orig.getFloatData = value;
    }

    public FsmVector2 getVector2Data
    {
        get => orig.getVector2Data;
        set => orig.getVector2Data = value;
    }

    public FsmVector3 getVector3Data
    {
        get => orig.getVector3Data;
        set => orig.getVector3Data = value;
    }

    public FsmString getStringData
    {
        get => orig.getStringData;
        set => orig.getStringData = value;
    }

    public FsmGameObject getGameObjectData
    {
        get => orig.getGameObjectData;
        set => orig.getGameObjectData = value;
    }

    public FsmRect getRectData
    {
        get => orig.getRectData;
        set => orig.getRectData = value;
    }

    public FsmQuaternion getQuaternionData
    {
        get => orig.getQuaternionData;
        set => orig.getQuaternionData = value;
    }

    public FsmMaterial getMaterialData
    {
        get => orig.getMaterialData;
        set => orig.getMaterialData = value;
    }

    public FsmTexture getTextureData
    {
        get => orig.getTextureData;
        set => orig.getTextureData = value;
    }

    public FsmColor getColorData
    {
        get => orig.getColorData;
        set => orig.getColorData = value;
    }

    public FsmObject getObjectData
    {
        get => orig.getObjectData;
        set => orig.getObjectData = value;
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