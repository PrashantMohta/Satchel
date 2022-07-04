using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiLayoutElementGetValues allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiLayoutElementGetValuesR : InstanceClassWrapper<uGuiLayoutElementGetValues>
{
    public uGuiLayoutElementGetValuesR(uGuiLayoutElementGetValues _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmBool ignoreLayout
    {
        get => orig.ignoreLayout;
        set => orig.ignoreLayout = value;
    }

    public FsmBool minWidthEnabled
    {
        get => orig.minWidthEnabled;
        set => orig.minWidthEnabled = value;
    }

    public FsmFloat minWidth
    {
        get => orig.minWidth;
        set => orig.minWidth = value;
    }

    public FsmBool minHeightEnabled
    {
        get => orig.minHeightEnabled;
        set => orig.minHeightEnabled = value;
    }

    public FsmFloat minHeight
    {
        get => orig.minHeight;
        set => orig.minHeight = value;
    }

    public FsmBool preferredWidthEnabled
    {
        get => orig.preferredWidthEnabled;
        set => orig.preferredWidthEnabled = value;
    }

    public FsmFloat preferredWidth
    {
        get => orig.preferredWidth;
        set => orig.preferredWidth = value;
    }

    public FsmBool preferredHeightEnabled
    {
        get => orig.preferredHeightEnabled;
        set => orig.preferredHeightEnabled = value;
    }

    public FsmFloat preferredHeight
    {
        get => orig.preferredHeight;
        set => orig.preferredHeight = value;
    }

    public FsmBool flexibleWidthEnabled
    {
        get => orig.flexibleWidthEnabled;
        set => orig.flexibleWidthEnabled = value;
    }

    public FsmFloat flexibleWidth
    {
        get => orig.flexibleWidth;
        set => orig.flexibleWidth = value;
    }

    public FsmBool flexibleHeightEnabled
    {
        get => orig.flexibleHeightEnabled;
        set => orig.flexibleHeightEnabled = value;
    }

    public FsmFloat flexibleHeight
    {
        get => orig.flexibleHeight;
        set => orig.flexibleHeight = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public LayoutElement _layoutElement
    {
        get => GetField<LayoutElement>();
        set => SetField(value);
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoGetValues()
    {
        CallMethod();
    }
}