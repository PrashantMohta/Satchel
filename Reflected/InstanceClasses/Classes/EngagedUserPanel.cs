namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EngagedUserPanel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EngagedUserPanelR:InstanceClassWrapper<EngagedUserPanel>
{
public EngagedUserPanelR(EngagedUserPanel _orig) : base(_orig) {}
public UnityEngine.CanvasGroup canvasGroup
{
get => GetField<UnityEngine.CanvasGroup>();
set => SetField(value);
}

public UnityEngine.UI.Text displayNameText
{
get => GetField<UnityEngine.UI.Text>();
set => SetField(value);
}

public UnityEngine.UI.RawImage displayImageImage
{
get => GetField<UnityEngine.UI.RawImage>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Start () =>
CallMethod();

public void UpdateContent () =>
CallMethod();

}
}
