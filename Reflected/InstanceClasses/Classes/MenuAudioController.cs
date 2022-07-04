namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuAudioController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuAudioControllerR : InstanceClassWrapper<MenuAudioController>
{
    public MenuAudioControllerR(MenuAudioController _orig) : base(_orig)
    {
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public AudioClip select
    {
        get => orig.select;
        set => orig.select = value;
    }

    public AudioClip submit
    {
        get => orig.submit;
        set => orig.submit = value;
    }

    public AudioClip cancel
    {
        get => orig.cancel;
        set => orig.cancel = value;
    }

    public AudioClip slider
    {
        get => orig.slider;
        set => orig.slider = value;
    }

    public AudioClip startGame
    {
        get => orig.startGame;
        set => orig.startGame = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void PlaySelect()
    {
        orig.PlaySelect();
    }

    public void PlaySubmit()
    {
        orig.PlaySubmit();
    }

    public void PlayCancel()
    {
        orig.PlayCancel();
    }

    public void PlaySlider()
    {
        orig.PlaySlider();
    }

    public void PlayStartGame()
    {
        orig.PlayStartGame();
    }
}