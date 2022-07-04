using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CaptureMouseEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CaptureMouseEventsR : InstanceClassWrapper<CaptureMouseEvents>
{
    public CaptureMouseEventsR(CaptureMouseEvents _orig) : base(_orig)
    {
    }

    public Selectable forwardTarget
    {
        get => orig.forwardTarget;
        set => orig.forwardTarget = value;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        orig.OnPointerEnter(eventData);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        orig.OnPointerExit(eventData);
    }
}