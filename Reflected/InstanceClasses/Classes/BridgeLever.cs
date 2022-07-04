namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BridgeLever allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BridgeLeverR:InstanceClassWrapper<BridgeLever>
{
public BridgeLeverR(BridgeLever _orig) : base(_orig) {}
public string playerDataBool
{
get => orig.playerDataBool;
set => orig.playerDataBool = value;
}

public UnityEngine.Collider2D bridgeCollider
{
get => orig.bridgeCollider;
set => orig.bridgeCollider = value;
}

public BridgeSection[] sections
{
get => orig.sections;
set => orig.sections = value;
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

public UnityEngine.Transform hitOrigin
{
get => orig.hitOrigin;
set => orig.hitOrigin = value;
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.AudioSource source
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public System.Collections.IEnumerator OpenBridge () =>
CallMethod<System.Collections.IEnumerator>();

}
}
