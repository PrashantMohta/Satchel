namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InfectedBurstLarge allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InfectedBurstLargeR:InstanceClassWrapper<InfectedBurstLarge>
{
public InfectedBurstLargeR(InfectedBurstLarge _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => orig.audioSource;
set => orig.audioSource = value;
}

public UnityEngine.GameObject effects
{
get => orig.effects;
set => orig.effects = value;
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => orig.spriteRenderer;
set => orig.spriteRenderer = value;
}

public UnityEngine.Animator animator
{
get => orig.animator;
set => orig.animator = value;
}

public UnityEngine.CircleCollider2D circleCollider
{
get => orig.circleCollider;
set => orig.circleCollider = value;
}

public VibrationPlayer vibration
{
get => GetField<VibrationPlayer>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

}
}
