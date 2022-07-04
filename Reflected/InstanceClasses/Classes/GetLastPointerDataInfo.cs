using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetLastPointerDataInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetLastPointerDataInfoR : InstanceClassWrapper<GetLastPointerDataInfo>
{
    public GetLastPointerDataInfoR(GetLastPointerDataInfo _orig) : base(_orig)
    {
    }

    public PointerEventData lastPointeEventData
    {
        get => GetLastPointerDataInfo.lastPointeEventData;
        set => GetLastPointerDataInfo.lastPointeEventData = value;
    }

    public FsmInt clickCount
    {
        get => orig.clickCount;
        set => orig.clickCount = value;
    }

    public FsmFloat clickTime
    {
        get => orig.clickTime;
        set => orig.clickTime = value;
    }

    public FsmVector2 delta
    {
        get => orig.delta;
        set => orig.delta = value;
    }

    public FsmBool dragging
    {
        get => orig.dragging;
        set => orig.dragging = value;
    }

    public FsmBool eligibleForClick
    {
        get => orig.eligibleForClick;
        set => orig.eligibleForClick = value;
    }

    public FsmGameObject enterEventCamera
    {
        get => orig.enterEventCamera;
        set => orig.enterEventCamera = value;
    }

    public FsmGameObject pressEventCamera
    {
        get => orig.pressEventCamera;
        set => orig.pressEventCamera = value;
    }

    public FsmBool isPointerMoving
    {
        get => orig.isPointerMoving;
        set => orig.isPointerMoving = value;
    }

    public FsmBool isScrolling
    {
        get => orig.isScrolling;
        set => orig.isScrolling = value;
    }

    public FsmGameObject lastPress
    {
        get => orig.lastPress;
        set => orig.lastPress = value;
    }

    public FsmGameObject pointerDrag
    {
        get => orig.pointerDrag;
        set => orig.pointerDrag = value;
    }

    public FsmGameObject pointerEnter
    {
        get => orig.pointerEnter;
        set => orig.pointerEnter = value;
    }

    public FsmInt pointerId
    {
        get => orig.pointerId;
        set => orig.pointerId = value;
    }

    public FsmGameObject pointerPress
    {
        get => orig.pointerPress;
        set => orig.pointerPress = value;
    }

    public FsmVector2 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public FsmVector2 pressPosition
    {
        get => orig.pressPosition;
        set => orig.pressPosition = value;
    }

    public FsmGameObject rawPointerPress
    {
        get => orig.rawPointerPress;
        set => orig.rawPointerPress = value;
    }

    public FsmVector2 scrollDelta
    {
        get => orig.scrollDelta;
        set => orig.scrollDelta = value;
    }

    public FsmBool used
    {
        get => orig.used;
        set => orig.used = value;
    }

    public FsmBool useDragThreshold
    {
        get => orig.useDragThreshold;
        set => orig.useDragThreshold = value;
    }

    public FsmVector3 worldNormal
    {
        get => orig.worldNormal;
        set => orig.worldNormal = value;
    }

    public FsmVector3 worldPosition
    {
        get => orig.worldPosition;
        set => orig.worldPosition = value;
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