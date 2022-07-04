namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorLockUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorLockUIR:InstanceClassWrapper<BossDoorLockUI>
{
public BossDoorLockUIR(BossDoorLockUI _orig) : base(_orig) {}
public UnityEngine.GameObject iconParent
{
get => orig.iconParent;
set => orig.iconParent = value;
}

public BossDoorLockUIIcon[] bossIcons
{
get => GetField<BossDoorLockUIIcon[]>();
set => SetField(value);
}

public UnityEngine.CanvasGroup buttonPrompts
{
get => orig.buttonPrompts;
set => orig.buttonPrompts = value;
}

public float buttonPromptFadeTime
{
get => orig.buttonPromptFadeTime;
set => orig.buttonPromptFadeTime = value;
}

public UnityEngine.Coroutine fadeRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine fadeButtonRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.CanvasGroup group
{
get => GetField<UnityEngine.CanvasGroup>();
set => SetField(value);
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Show (BossSequenceDoor door) =>
orig.Show(door);

public void Hide () =>
orig.Hide();

public System.Collections.IEnumerator ShowRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator HideRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator FadeButtonPrompts (float toAlpha, float time) =>
CallMethod<System.Collections.IEnumerator>(new object[] {toAlpha, time});

}
}
