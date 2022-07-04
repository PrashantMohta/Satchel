using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UpdateTextWithSliderValue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UpdateTextWithSliderValueR : InstanceClassWrapper<UpdateTextWithSliderValue>
{
    public UpdateTextWithSliderValueR(UpdateTextWithSliderValue _orig) : base(_orig)
    {
    }

    public Slider slider
    {
        get => orig.slider;
        set => orig.slider = value;
    }

    public Text textUI
    {
        get => GetField<Text>();
        set => SetField(value);
    }

    public float value
    {
        get => orig.value;
        set => orig.value = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void UpdateValue()
    {
        orig.UpdateValue();
    }
}