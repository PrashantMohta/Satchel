using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PreselectOption allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreselectOptionR : InstanceClassWrapper<PreselectOption>
{
    public PreselectOptionR(PreselectOption _orig) : base(_orig)
    {
    }

    public Selectable itemToHighlight
    {
        get => orig.itemToHighlight;
        set => orig.itemToHighlight = value;
    }


    public void HighlightDefault(bool deselect = false)
    {
        orig.HighlightDefault(deselect);
    }

    public void SetDefaultHighlight(Button button)
    {
        orig.SetDefaultHighlight(button);
    }

    public void DeselectAll()
    {
        orig.DeselectAll();
    }

    public IEnumerator ForceDeselect()
    {
        return CallMethod<IEnumerator>();
    }
}