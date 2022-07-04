namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueLever allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueLeverR:InstanceClassWrapper<BossStatueLever>
{
public BossStatueLeverR(BossStatueLever _orig) : base(_orig) {}
public UnityEngine.Transform hitOrigin
{
get => orig.hitOrigin;
set => orig.hitOrigin = value;
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => orig.audioPlayerPrefab;
set => orig.audioPlayerPrefab = value;
}

public AudioEvent switchSound
{
get => orig.switchSound;
set => orig.switchSound = value;
}

public UnityEngine.GameObject strikeNailPrefab
{
get => orig.strikeNailPrefab;
set => orig.strikeNailPrefab = value;
}

public bool canToggle
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Animator leverAnimator
{
get => orig.leverAnimator;
set => orig.leverAnimator = value;
}

public BossStatue bossStatue
{
get => GetField<BossStatue>();
set => SetField(value);
}



public void Enable () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void SetOwner (BossStatue statue) =>
orig.SetOwner(statue);

public void SetState (bool value) =>
orig.SetState(value);

}
}
