using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuPreventDeselect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuPreventDeselectR : InstanceClassWrapper<MenuPreventDeselect>
{
    public MenuPreventDeselectR(MenuPreventDeselect _orig) : base(_orig)
    {
    }

    public CancelAction cancelAction
    {
        get => orig.cancelAction;
        set => orig.cancelAction = value;
    }

    public Animator leftCursor
    {
        get => orig.leftCursor;
        set => orig.leftCursor = value;
    }

    public Animator rightCursor
    {
        get => orig.rightCursor;
        set => orig.rightCursor = value;
    }

    public MenuAudioController uiAudioPlayer
    {
        get => GetField<MenuAudioController>();
        set => SetField(value);
    }

    public GameObject prevSelectedObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool dontPlaySelectSound
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool deselectWasForced
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Action<MenuPreventDeselect> customCancelAction
    {
        get => orig.customCancelAction;
        set => orig.customCancelAction = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public IEnumerator ValidateDeselect()
    {
        return CallMethod<IEnumerator>();
    }

    public void HookUpAudioPlayer()
    {
        CallMethod();
    }

    public void ForceDeselect()
    {
        orig.ForceDeselect();
    }

    public void SimulateSubmit()
    {
        orig.SimulateSubmit();
    }

    public void orig_OnCancel(BaseEventData eventData)
    {
        orig.orig_OnCancel(eventData);
    }
}