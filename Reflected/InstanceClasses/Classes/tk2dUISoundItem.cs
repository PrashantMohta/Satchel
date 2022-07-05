namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUISoundItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUISoundItemR : InstanceClassWrapper<tk2dUISoundItem>
{
    public tk2dUISoundItemR(tk2dUISoundItem _orig) : base(_orig)
    {
    }

    public AudioClip downButtonSound
    {
        get => orig.downButtonSound;
        set => orig.downButtonSound = value;
    }

    public AudioClip upButtonSound
    {
        get => orig.upButtonSound;
        set => orig.upButtonSound = value;
    }

    public AudioClip clickButtonSound
    {
        get => orig.clickButtonSound;
        set => orig.clickButtonSound = value;
    }

    public AudioClip releaseButtonSound
    {
        get => orig.releaseButtonSound;
        set => orig.releaseButtonSound = value;
    }

    public tk2dUIItem uiItem
    {
        get => orig.uiItem;
        set => orig.uiItem = value;
    }

    public GameObject SendMessageTarget
    {
        get => orig.SendMessageTarget;
        set => orig.SendMessageTarget = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void PlayDownSound()
    {
        CallMethod();
    }

    public void PlayUpSound()
    {
        CallMethod();
    }

    public void PlayClickSound()
    {
        CallMethod();
    }

    public void PlayReleaseSound()
    {
        CallMethod();
    }

    public void PlaySound(AudioClip source)
    {
        CallMethod(new object[] { source });
    }
}