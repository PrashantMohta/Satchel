namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BigCentipedeSection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BigCentipedeSectionR : InstanceClassWrapper<BigCentipedeSection>
{
    public BigCentipedeSectionR(BigCentipedeSection _orig) : base(_orig)
    {
    }

    public BigCentipede parent
    {
        get => GetField<BigCentipede>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public bool hasLeft
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}