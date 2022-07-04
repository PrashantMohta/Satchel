namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BigCentipedeSection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BigCentipedeSectionR:InstanceClassWrapper<BigCentipedeSection>
{
public BigCentipedeSectionR(BigCentipedeSection _orig) : base(_orig) {}
public BigCentipede parent
{
get => GetField<BigCentipede>();
set => SetField(value);
}

public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.Collider2D bodyCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public bool hasLeft
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
