namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of JellyEgg allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JellyEggR:InstanceClassWrapper<JellyEgg>
{
public JellyEggR(JellyEgg _orig) : base(_orig) {}
public bool bomb
{
get => orig.bomb;
set => orig.bomb = value;
}

public UnityEngine.GameObject explosionObject
{
get => orig.explosionObject;
set => orig.explosionObject = value;
}

public UnityEngine.ParticleSystem popEffect
{
get => orig.popEffect;
set => orig.popEffect = value;
}

public UnityEngine.GameObject strikeEffect
{
get => orig.strikeEffect;
set => orig.strikeEffect = value;
}

public UnityEngine.MeshRenderer meshRenderer
{
get => orig.meshRenderer;
set => orig.meshRenderer = value;
}

public UnityEngine.AudioSource audioSource
{
get => orig.audioSource;
set => orig.audioSource = value;
}

public VibrationData popVibration
{
get => orig.popVibration;
set => orig.popVibration = value;
}

public UnityEngine.CircleCollider2D circleCollider
{
get => orig.circleCollider;
set => orig.circleCollider = value;
}

public UnityEngine.GameObject falseShiny
{
get => orig.falseShiny;
set => orig.falseShiny = value;
}

public UnityEngine.GameObject shinyItem
{
get => orig.shinyItem;
set => orig.shinyItem = value;
}



public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void Burst () =>
CallMethod();

}
}
