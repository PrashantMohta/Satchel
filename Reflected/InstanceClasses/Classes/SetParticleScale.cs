namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetParticleScale allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetParticleScaleR : InstanceClassWrapper<SetParticleScale>
{
    public SetParticleScaleR(SetParticleScale _orig) : base(_orig)
    {
    }

    public bool grandParent
    {
        get => orig.grandParent;
        set => orig.grandParent = value;
    }

    public bool greatGrandParent
    {
        get => orig.greatGrandParent;
        set => orig.greatGrandParent = value;
    }

    public float parentXScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float selfXScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 scaleVector
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool unparented
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject parent
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}