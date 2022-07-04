namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of VinePlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VinePlatformR:InstanceClassWrapper<VinePlatform>
{
public VinePlatformR(VinePlatform _orig) : base(_orig) {}
public UnityEngine.GameObject platformSprite
{
get => orig.platformSprite;
set => orig.platformSprite = value;
}

public UnityEngine.GameObject activatedSprite
{
get => orig.activatedSprite;
set => orig.activatedSprite = value;
}

public UnityEngine.Collider2D collider
{
get => orig.collider;
set => orig.collider = value;
}

public UnityEngine.AudioClip playerLandSound
{
get => orig.playerLandSound;
set => orig.playerLandSound = value;
}

public UnityEngine.ParticleSystem playerLandParticles
{
get => orig.playerLandParticles;
set => orig.playerLandParticles = value;
}

public UnityEngine.AnimationCurve playerLandAnimCurve
{
get => orig.playerLandAnimCurve;
set => orig.playerLandAnimCurve = value;
}

public float playerLandAnimLength
{
get => orig.playerLandAnimLength;
set => orig.playerLandAnimLength = value;
}

public UnityEngine.Coroutine landRoutine
{
get => orig.landRoutine;
set => orig.landRoutine = value;
}

public bool respondOnLand
{
get => orig.respondOnLand;
set => orig.respondOnLand = value;
}

public System.Action landReturnAction
{
get => GetField<System.Action>();
set => SetField(value);
}

public TriggerEnterEvent landingDetector
{
get => orig.landingDetector;
set => orig.landingDetector = value;
}

public UnityEngine.AudioClip landSound
{
get => orig.landSound;
set => orig.landSound = value;
}

public UnityEngine.ParticleSystem[] landParticles
{
get => orig.landParticles;
set => orig.landParticles = value;
}

public UnityEngine.GameObject slamEffect
{
get => orig.slamEffect;
set => orig.slamEffect = value;
}

public TriggerEnterEvent enemyDetector
{
get => orig.enemyDetector;
set => orig.enemyDetector = value;
}

public bool acidLander
{
get => orig.acidLander;
set => orig.acidLander = value;
}

public float acidTargetY
{
get => orig.acidTargetY;
set => orig.acidTargetY = value;
}

public UnityEngine.AudioClip acidSplashSound
{
get => orig.acidSplashSound;
set => orig.acidSplashSound = value;
}

public UnityEngine.GameObject acidSplashPrefab
{
get => orig.acidSplashPrefab;
set => orig.acidSplashPrefab = value;
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
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

public void Update () =>
CallMethod();

public void Land () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void PlaySound (UnityEngine.AudioClip clip) =>
CallMethod(new object[] {clip});

public System.Collections.IEnumerator PlayerLand () =>
CallMethod<System.Collections.IEnumerator>();

public void OnDrawGizmosSelected () =>
CallMethod();

}
}
