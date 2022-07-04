namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GodfinderIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GodfinderIconR:InstanceClassWrapper<GodfinderIcon>
{
public GodfinderIconR(GodfinderIcon _orig) : base(_orig) {}
public GodfinderIcon instance
{
get => GetFieldStatic<GodfinderIcon>();
set => SetField(value);
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => orig.audioPlayerPrefab;
set => orig.audioPlayerPrefab = value;
}

public AudioEvent showSound
{
get => orig.showSound;
set => orig.showSound = value;
}

public bool isVisible
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.MeshRenderer renderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public tk2dSpriteAnimator spriteAnimator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void ShowIcon (float delay, BossScene bossScene) =>
GodfinderIcon.ShowIcon(delay, bossScene);

public void ShowIconQueued (float delay) =>
GodfinderIcon.ShowIconQueued(delay);

public System.Collections.IEnumerator Show (float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {delay});

public void Hide () =>
CallMethod();

}
}
