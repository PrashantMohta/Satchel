namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GlowResponse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GlowResponseR:InstanceClassWrapper<GlowResponse>
{
public GlowResponseR(GlowResponse _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer fadeSprite
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.SpriteRenderer> FadeSprites
{
get => orig.FadeSprites;
set => orig.FadeSprites = value;
}

public float fadeTime
{
get => orig.fadeTime;
set => orig.fadeTime = value;
}

public UnityEngine.ParticleSystem particles
{
get => orig.particles;
set => orig.particles = value;
}

public UnityEngine.Light light
{
get => orig.light;
set => orig.light = value;
}

public float lightStart
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => orig.audioPlayerPrefab;
set => orig.audioPlayerPrefab = value;
}

public AudioEventRandom soundEffect
{
get => orig.soundEffect;
set => orig.soundEffect = value;
}

public System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,UnityEngine.Coroutine> fadeRoutines
{
get => GetField<System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,UnityEngine.Coroutine>>();
set => SetField(value);
}



public void OnValidate () =>
CallMethod();

public void Awake () =>
CallMethod();

public void HandleUpgrade () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void FadeTo (float alpha) =>
CallMethod(new object[] {alpha});

public System.Collections.IEnumerator Fade (float toAlpha, UnityEngine.SpriteRenderer sprite) =>
CallMethod<System.Collections.IEnumerator>(new object[] {toAlpha, sprite});

public void FadeEnd () =>
orig.FadeEnd();

}
}
