namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableWithExternalDebris allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableWithExternalDebrisR : InstanceClassWrapper<BreakableWithExternalDebris>
{
    public BreakableWithExternalDebrisR(BreakableWithExternalDebris _orig) : base(_orig)
    {
    }

    public float debrisPrefabPositionVariance
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public BreakableWithExternalDebris.ExternalDebris[] externalDebris
    {
        get => GetField<BreakableWithExternalDebris.ExternalDebris[]>();
        set => SetField(value);
    }

    public BreakableWithExternalDebris.WeightedExternalDebrisItem[] externalDebrisVariants
    {
        get => GetField<BreakableWithExternalDebris.WeightedExternalDebrisItem[]>();
        set => SetField(value);
    }

    public List<IExternalDebris> externalDebrisResponders
    {
        get => GetFieldStatic<List<IExternalDebris>>();
        set => SetField(value);
    }

    public Probability.ProbabilityGameObject[] containingParticles
    {
        get => orig.containingParticles;
        set => orig.containingParticles = value;
    }

    public Breakable.FlingObject[] flingObjectRegister
    {
        get => orig.flingObjectRegister;
        set => orig.flingObjectRegister = value;
    }


    public void CreateAdditionalDebrisParts(List<GameObject> debrisParts)
    {
        CallMethod(new object[] { debrisParts });
    }

    public void Spawn(BreakableWithExternalDebris.ExternalDebris externalDebris, List<GameObject> debrisParts)
    {
        CallMethod(new object[] { externalDebris, debrisParts });
    }
}