namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CharmDisplay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmDisplayR : InstanceClassWrapper<CharmDisplay>
{
    public CharmDisplayR(CharmDisplay _orig) : base(_orig)
    {
    }

    public int id
    {
        get => orig.id;
        set => orig.id = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => orig.spriteRenderer;
        set => orig.spriteRenderer = value;
    }

    public SpriteRenderer flashSpriteRenderer
    {
        get => orig.flashSpriteRenderer;
        set => orig.flashSpriteRenderer = value;
    }

    public Sprite brokenGlassHP
    {
        get => orig.brokenGlassHP;
        set => orig.brokenGlassHP = value;
    }

    public Sprite brokenGlassGeo
    {
        get => orig.brokenGlassGeo;
        set => orig.brokenGlassGeo = value;
    }

    public Sprite brokenGlassAttack
    {
        get => orig.brokenGlassAttack;
        set => orig.brokenGlassAttack = value;
    }

    public Sprite whiteCharm
    {
        get => orig.whiteCharm;
        set => orig.whiteCharm = value;
    }

    public Sprite blackCharm
    {
        get => orig.blackCharm;
        set => orig.blackCharm = value;
    }

    public GameObject charmPlaceEffect
    {
        get => orig.charmPlaceEffect;
        set => orig.charmPlaceEffect = value;
    }

    public PlayMakerFSM charmsMenuFsm
    {
        get => GetFieldStatic<PlayMakerFSM>();
        set => SetField(value);
    }

    public bool doJitter
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3 startPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float jitterX
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float jitterY
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Check()
    {
        orig.Check();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }
}