namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of VinePlatformCut allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VinePlatformCutR:InstanceClassWrapper<VinePlatformCut>
{
public VinePlatformCutR(VinePlatformCut _orig) : base(_orig) {}
public UnityEngine.Rigidbody2D body
{
get => orig.body;
set => orig.body = value;
}

public UnityEngine.GameObject sprites
{
get => orig.sprites;
set => orig.sprites = value;
}

public UnityEngine.GameObject cutParticles
{
get => orig.cutParticles;
set => orig.cutParticles = value;
}

public UnityEngine.GameObject cutPointParticles
{
get => orig.cutPointParticles;
set => orig.cutPointParticles = value;
}

public UnityEngine.GameObject cutEffectPrefab
{
get => orig.cutEffectPrefab;
set => orig.cutEffectPrefab = value;
}

public UnityEngine.AudioClip cutSound
{
get => orig.cutSound;
set => orig.cutSound = value;
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}

public VinePlatform platform
{
get => GetField<VinePlatform>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Collider2D col
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void Cut () =>
orig.Cut();

public void Disable (bool disableAll = false) =>
orig.Disable(disableAll);

}
}
