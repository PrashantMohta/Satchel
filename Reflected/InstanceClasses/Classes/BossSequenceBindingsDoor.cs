namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequenceBindingsDoor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSequenceBindingsDoorR:InstanceClassWrapper<BossSequenceBindingsDoor>
{
public BossSequenceBindingsDoorR(BossSequenceBindingsDoor _orig) : base(_orig) {}
public string playerData
{
get => orig.playerData;
set => orig.playerData = value;
}

public UnityEngine.GameObject[] bindingIcons
{
get => orig.bindingIcons;
set => orig.bindingIcons = value;
}

public UnityEngine.GameObject transitionPointDoor
{
get => orig.transitionPointDoor;
set => orig.transitionPointDoor = value;
}

public float doorEnableAnimDelay
{
get => orig.doorEnableAnimDelay;
set => orig.doorEnableAnimDelay = value;
}

public string unlockAnimation
{
get => orig.unlockAnimation;
set => orig.unlockAnimation = value;
}

public string unlockedAnimation
{
get => orig.unlockedAnimation;
set => orig.unlockedAnimation = value;
}

public bool isUnlocked
{
get => GetField<bool>();
set => SetField(value);
}

public bool shouldBeUnlocked
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void SetUnlocked (bool value, bool doUnlockAnimation = false) =>
CallMethod(new object[] {value, doUnlockAnimation});

public System.Collections.IEnumerator DoUnlockAnimation () =>
CallMethod<System.Collections.IEnumerator>();

}
}
