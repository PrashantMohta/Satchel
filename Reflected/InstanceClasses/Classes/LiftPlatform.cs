namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LiftPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LiftPlatformR:InstanceClassWrapper<LiftPlatform>
{
public LiftPlatformR(LiftPlatform _orig) : base(_orig) {}
public UnityEngine.GameObject part1
{
get => orig.part1;
set => orig.part1 = value;
}

public UnityEngine.GameObject part2
{
get => orig.part2;
set => orig.part2 = value;
}

public UnityEngine.ParticleSystem dustParticle
{
get => orig.dustParticle;
set => orig.dustParticle = value;
}

public UnityEngine.AudioSource audioSource
{
get => orig.audioSource;
set => orig.audioSource = value;
}

public float part1_start_y
{
get => GetField<float>();
set => SetField(value);
}

public float part2_start_y
{
get => GetField<float>();
set => SetField(value);
}

public int state
{
get => GetField<int>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

}
}
