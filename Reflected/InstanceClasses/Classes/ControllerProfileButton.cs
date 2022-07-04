using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerProfileButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerProfileButtonR : InstanceClassWrapper<ControllerProfileButton>
{
    public ControllerProfileButtonR(ControllerProfileButton _orig) : base(_orig)
    {
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

    public Image highlightCursor
    {
        get => orig.highlightCursor;
        set => orig.highlightCursor = value;
    }

    public MenuAudioController uiAudioPlayer
    {
        get => orig.uiAudioPlayer;
        set => orig.uiAudioPlayer = value;
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


    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public IEnumerator ValidateDeselect()
    {
        return CallMethod<IEnumerator>();
    }
}