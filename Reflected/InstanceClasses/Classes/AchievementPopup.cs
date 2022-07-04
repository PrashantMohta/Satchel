namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AchievementPopup allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AchievementPopupR:InstanceClassWrapper<AchievementPopup>
{
public AchievementPopupR(AchievementPopup _orig) : base(_orig) {}
public UnityEngine.UI.Image image
{
get => orig.image;
set => orig.image = value;
}

public UnityEngine.UI.Text nameText
{
get => orig.nameText;
set => orig.nameText = value;
}

public UnityEngine.UI.Text descriptionText
{
get => orig.descriptionText;
set => orig.descriptionText = value;
}

public UnityEngine.CanvasGroup group
{
get => GetField<UnityEngine.CanvasGroup>();
set => SetField(value);
}

public float fadeInTime
{
get => orig.fadeInTime;
set => orig.fadeInTime = value;
}

public float holdTime
{
get => orig.holdTime;
set => orig.holdTime = value;
}

public float fadeOutTime
{
get => orig.fadeOutTime;
set => orig.fadeOutTime = value;
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => orig.audioPlayerPrefab;
set => orig.audioPlayerPrefab = value;
}

public AudioEvent sound
{
get => orig.sound;
set => orig.sound = value;
}

public UnityEngine.Animator fluerAnimator
{
get => orig.fluerAnimator;
set => orig.fluerAnimator = value;
}

public string fluerCloseName
{
get => orig.fluerCloseName;
set => orig.fluerCloseName = value;
}

public float elapsed
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Setup (UnityEngine.Sprite icon, string name, string description) =>
orig.Setup(icon, name, description);

public void Update () =>
CallMethod();

}
}
