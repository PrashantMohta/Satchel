namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CinematicSkipPopup allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CinematicSkipPopupR:InstanceClassWrapper<CinematicSkipPopup>
{
public CinematicSkipPopupR(CinematicSkipPopup _orig) : base(_orig) {}
public UnityEngine.CanvasGroup canvasGroup
{
get => GetField<UnityEngine.CanvasGroup>();
set => SetField(value);
}

public UnityEngine.GameObject[] textGroups
{
get => GetField<UnityEngine.GameObject[]>();
set => SetField(value);
}

public float fadeInDuration
{
get => GetField<float>();
set => SetField(value);
}

public float holdDuration
{
get => GetField<float>();
set => SetField(value);
}

public float fadeOutDuration
{
get => GetField<float>();
set => SetField(value);
}

public bool isShowing
{
get => GetField<bool>();
set => SetField(value);
}

public float showTimer
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Show (CinematicSkipPopup.Texts text) =>
orig.Show(text);

public System.Collections.IEnumerator ShowRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public void Hide () =>
orig.Hide();

public void Update () =>
CallMethod();

}
}
