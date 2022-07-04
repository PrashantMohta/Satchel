using UnityEngine.Audio;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuAudioSlider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuAudioSliderR : InstanceClassWrapper<MenuAudioSlider>
{
    public MenuAudioSliderR(MenuAudioSlider _orig) : base(_orig)
    {
    }

    public Slider slider
    {
        get => orig.slider;
        set => orig.slider = value;
    }

    public Text textUI
    {
        get => orig.textUI;
        set => orig.textUI = value;
    }

    public AudioMixer masterMixer
    {
        get => orig.masterMixer;
        set => orig.masterMixer = value;
    }

    public GameSettings gs
    {
        get => GetField<GameSettings>();
        set => SetField(value);
    }

    public float value
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void UpdateValue()
    {
        orig.UpdateValue();
    }

    public void RefreshValueFromSettings()
    {
        orig.RefreshValueFromSettings();
    }

    public void UpdateTextValue(float value)
    {
        orig.UpdateTextValue(value);
    }

    public void SetMasterLevel(float masterLevel)
    {
        orig.SetMasterLevel(masterLevel);
    }

    public void SetMusicLevel(float musicLevel)
    {
        orig.SetMusicLevel(musicLevel);
    }

    public void SetSoundLevel(float soundLevel)
    {
        orig.SetSoundLevel(soundLevel);
    }

    public float GetVolumeLevel(float x)
    {
        return CallMethod<float>(new object[] { x });
    }
}