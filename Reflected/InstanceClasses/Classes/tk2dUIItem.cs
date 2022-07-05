namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIItemR : InstanceClassWrapper<tk2dUIItem>
{
    public tk2dUIItemR(tk2dUIItem _orig) : base(_orig)
    {
    }

    public Action OnDown
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnUp
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnClick
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnRelease
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnHoverOver
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action OnHoverOut
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnDownUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnUpUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnClickUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnReleaseUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnHoverOverUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public Action<tk2dUIItem> OnHoverOutUIItem
    {
        get => GetField<Action<tk2dUIItem>>();
        set => SetField(value);
    }

    public GameObject sendMessageTarget
    {
        get => orig.sendMessageTarget;
        set => orig.sendMessageTarget = value;
    }

    public string SendMessageOnDownMethodName
    {
        get => orig.SendMessageOnDownMethodName;
        set => orig.SendMessageOnDownMethodName = value;
    }

    public string SendMessageOnUpMethodName
    {
        get => orig.SendMessageOnUpMethodName;
        set => orig.SendMessageOnUpMethodName = value;
    }

    public string SendMessageOnClickMethodName
    {
        get => orig.SendMessageOnClickMethodName;
        set => orig.SendMessageOnClickMethodName = value;
    }

    public string SendMessageOnReleaseMethodName
    {
        get => orig.SendMessageOnReleaseMethodName;
        set => orig.SendMessageOnReleaseMethodName = value;
    }

    public bool isChildOfAnotherUIItem
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool registerPressFromChildren
    {
        get => orig.registerPressFromChildren;
        set => orig.registerPressFromChildren = value;
    }

    public bool isHoverEnabled
    {
        get => orig.isHoverEnabled;
        set => orig.isHoverEnabled = value;
    }

    public Transform[] editorExtraBounds
    {
        get => orig.editorExtraBounds;
        set => orig.editorExtraBounds = value;
    }

    public Transform[] editorIgnoreBounds
    {
        get => orig.editorIgnoreBounds;
        set => orig.editorIgnoreBounds = value;
    }

    public bool isPressed
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isHoverOver
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public tk2dUITouch touch
    {
        get => GetField<tk2dUITouch>();
        set => SetField(value);
    }

    public tk2dUIItem parentUIItem
    {
        get => GetField<tk2dUIItem>();
        set => SetField(value);
    }

    public bool IsPressed => orig.IsPressed;

    public tk2dUITouch Touch => orig.Touch;

    public tk2dUIItem ParentUIItem => orig.ParentUIItem;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UpdateParent()
    {
        orig.UpdateParent();
    }

    public void ManuallySetParent(tk2dUIItem newParentUIItem)
    {
        orig.ManuallySetParent(newParentUIItem);
    }

    public void RemoveParent()
    {
        orig.RemoveParent();
    }

    public bool Press(tk2dUITouch touch)
    {
        return orig.Press(touch);
    }

    public bool Press(tk2dUITouch touch, tk2dUIItem sentFromChild)
    {
        return orig.Press(touch, sentFromChild);
    }

    public void UpdateTouch(tk2dUITouch touch)
    {
        orig.UpdateTouch(touch);
    }

    public void DoSendMessage(string methodName)
    {
        CallMethod(new object[] { methodName });
    }

    public void Release()
    {
        orig.Release();
    }

    public void CurrentOverUIItem(tk2dUIItem overUIItem)
    {
        orig.CurrentOverUIItem(overUIItem);
    }

    public bool CheckIsUIItemChildOfMe(tk2dUIItem uiItem)
    {
        return orig.CheckIsUIItemChildOfMe(uiItem);
    }

    public void Exit()
    {
        orig.Exit();
    }

    public bool HoverOver(tk2dUIItem prevHover)
    {
        return orig.HoverOver(prevHover);
    }

    public void HoverOut(tk2dUIItem currHoverButton)
    {
        orig.HoverOut(currHoverButton);
    }

    public tk2dUIItem GetParentUIItem()
    {
        return CallMethod<tk2dUIItem>();
    }

    public void SimulateClick()
    {
        orig.SimulateClick();
    }

    public void InternalSetIsChildOfAnotherUIItem(bool state)
    {
        orig.InternalSetIsChildOfAnotherUIItem(state);
    }

    public bool InternalGetIsChildOfAnotherUIItem()
    {
        return orig.InternalGetIsChildOfAnotherUIItem();
    }
}