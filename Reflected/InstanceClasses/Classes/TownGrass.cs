namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TownGrass allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TownGrassR : InstanceClassWrapper<TownGrass>
{
    public TownGrassR(TownGrass _orig) : base(_orig)
    {
    }

    public GameObject[] debris
    {
        get => orig.debris;
        set => orig.debris = value;
    }

    public GameObject nailEffectPrefab
    {
        get => orig.nailEffectPrefab;
        set => orig.nailEffectPrefab = value;
    }

    public AudioClip[] cutSound
    {
        get => orig.cutSound;
        set => orig.cutSound = value;
    }

    public AudioSource source
    {
        get => orig.source;
        set => orig.source = value;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}