namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PromptMarker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PromptMarkerR:InstanceClassWrapper<PromptMarker>
{
public PromptMarkerR(PromptMarker _orig) : base(_orig) {}
public UnityEngine.GameObject labels
{
get => orig.labels;
set => orig.labels = value;
}

public FadeGroup fadeGroup
{
get => GetField<FadeGroup>();
set => SetField(value);
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.GameObject owner
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool isVisible
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void RecycleOnLevelLoad () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void SetLabel (string labelName) =>
orig.SetLabel(labelName);

public void Show () =>
orig.Show();

public void Hide () =>
orig.Hide();

public System.Collections.IEnumerator RecycleDelayed (float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {delay});

public void SetOwner (UnityEngine.GameObject obj) =>
orig.SetOwner(obj);

}
}
