namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuAudioController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuAudioControllerR:InstanceClassWrapper<MenuAudioController>
{
public MenuAudioControllerR(MenuAudioController _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.AudioClip select
{
get => orig.select;
set => orig.select = value;
}

public UnityEngine.AudioClip submit
{
get => orig.submit;
set => orig.submit = value;
}

public UnityEngine.AudioClip cancel
{
get => orig.cancel;
set => orig.cancel = value;
}

public UnityEngine.AudioClip slider
{
get => orig.slider;
set => orig.slider = value;
}

public UnityEngine.AudioClip startGame
{
get => orig.startGame;
set => orig.startGame = value;
}



public void Awake () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void PlaySelect () =>
orig.PlaySelect();

public void PlaySubmit () =>
orig.PlaySubmit();

public void PlayCancel () =>
orig.PlayCancel();

public void PlaySlider () =>
orig.PlaySlider();

public void PlayStartGame () =>
orig.PlayStartGame();

}
}
