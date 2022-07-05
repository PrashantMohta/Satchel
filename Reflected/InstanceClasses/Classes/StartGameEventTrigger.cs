using UnityEngine.EventSystems;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StartGameEventTrigger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StartGameEventTriggerR : InstanceClassWrapper<StartGameEventTrigger>
{
    public StartGameEventTriggerR(StartGameEventTrigger _orig) : base(_orig)
    {
    }

    public bool permaDeath
    {
        get => orig.permaDeath;
        set => orig.permaDeath = value;
    }

    public bool bossRush
    {
        get => orig.bossRush;
        set => orig.bossRush = value;
    }


    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public bool IsFulfilled()
    {
        return orig.IsFulfilled();
    }
}