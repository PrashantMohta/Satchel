namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PaintBullet allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PaintBulletR:InstanceClassWrapper<PaintBullet>
{
public PaintBulletR(PaintBullet _orig) : base(_orig) {}
public float scaleMin
{
get => orig.scaleMin;
set => orig.scaleMin = value;
}

public float scaleMax
{
get => orig.scaleMax;
set => orig.scaleMax = value;
}

public float scale
{
get => GetField<float>();
set => SetField(value);
}

public float stretchFactor
{
get => orig.stretchFactor;
set => orig.stretchFactor = value;
}

public float stretchMinX
{
get => orig.stretchMinX;
set => orig.stretchMinX = value;
}

public float stretchMaxY
{
get => orig.stretchMaxY;
set => orig.stretchMaxY = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public System.Collections.Generic.List<UnityEngine.AudioClip> splatClips
{
get => orig.splatClips;
set => orig.splatClips = value;
}

public UnityEngine.ParticleSystem impactParticle
{
get => orig.impactParticle;
set => orig.impactParticle = value;
}

public UnityEngine.ParticleSystem trailParticle
{
get => orig.trailParticle;
set => orig.trailParticle = value;
}

public UnityEngine.GameObject splatEffect
{
get => orig.splatEffect;
set => orig.splatEffect = value;
}

public tk2dSprite splatEffectSprite
{
get => orig.splatEffectSprite;
set => orig.splatEffectSprite = value;
}

public UnityEngine.Color colourBlue
{
get => orig.colourBlue;
set => orig.colourBlue = value;
}

public UnityEngine.Color colourRed
{
get => orig.colourRed;
set => orig.colourRed = value;
}

public UnityEngine.Color colourPink
{
get => orig.colourPink;
set => orig.colourPink = value;
}

public bool active
{
get => GetField<bool>();
set => SetField(value);
}

public int colour
{
get => orig.colour;
set => orig.colour = value;
}

public System.Collections.Generic.List<UnityEngine.SpriteRenderer> splatList
{
get => GetField<System.Collections.Generic.List<UnityEngine.SpriteRenderer>>();
set => SetField(value);
}

public int chance
{
get => GetField<int>();
set => SetField(value);
}

public bool painting
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Collider2D col
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer sprite
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OrbitShieldHit (UnityEngine.Transform shield) =>
orig.OrbitShieldHit(shield);

public System.Collections.IEnumerator Collision (UnityEngine.Vector2 normal, bool doRotation) =>
CallMethod<System.Collections.IEnumerator>(new object[] {normal, doRotation});

public void SetColourBlue () =>
orig.SetColourBlue();

public void SetColourRed () =>
orig.SetColourRed();

public void SetBlue () =>
orig.SetBlue();

public void SetRed () =>
orig.SetRed();

public void SetPink () =>
orig.SetPink();

}
}
