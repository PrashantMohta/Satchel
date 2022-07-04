namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueFlashEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueFlashEffectR:InstanceClassWrapper<BossStatueFlashEffect>
{
public BossStatueFlashEffectR(BossStatueFlashEffect _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer templateSprite
{
get => orig.templateSprite;
set => orig.templateSprite = value;
}

public UnityEngine.GameObject statueSpritesParent
{
get => orig.statueSpritesParent;
set => orig.statueSpritesParent = value;
}

public UnityEngine.SpriteRenderer[] statueSprites
{
get => GetField<UnityEngine.SpriteRenderer[]>();
set => SetField(value);
}

public UnityEngine.GameObject inspect
{
get => orig.inspect;
set => orig.inspect = value;
}

public TriggerEnterEvent triggerEvent
{
get => orig.triggerEvent;
set => orig.triggerEvent = value;
}

public BossStatue parentStatue
{
get => GetField<BossStatue>();
set => SetField(value);
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.Material mat
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.MaterialPropertyBlock propBlock
{
get => GetField<UnityEngine.MaterialPropertyBlock>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator FlashRoutine () =>
CallMethod<System.Collections.IEnumerator>();

public void FlashApex () =>
orig.FlashApex();

}
}
