namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BigCentipede allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BigCentipedeR:InstanceClassWrapper<BigCentipede>
{
public BigCentipedeR(BigCentipede _orig) : base(_orig) {}
public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public BigCentipedeSection[] sections
{
get => GetField<BigCentipedeSection[]>();
set => SetField(value);
}

public UnityEngine.ParticleSystem entryDust
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public UnityEngine.ParticleSystem exitDust
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public UnityEngine.Vector2 entryPoint
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 exitPoint
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float burrowTime
{
get => GetField<float>();
set => SetField(value);
}

public float moveSpeed
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 direction
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool fadingAudio
{
get => GetField<bool>();
set => SetField(value);
}

public bool isBurrowing
{
get => GetField<bool>();
set => SetField(value);
}

public float burrowTimer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform entry
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Transform exit
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector2 EntryPoint
{
get => orig.EntryPoint;
}

public UnityEngine.Vector2 ExitPoint
{
get => orig.ExitPoint;
}

public UnityEngine.Vector2 Direction
{
get => orig.Direction;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void UnBurrow (bool changePosition) =>
CallMethod(new object[] {changePosition});

public void Burrow () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
