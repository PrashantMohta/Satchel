namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvVesselFragments allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvVesselFragmentsR : InstanceClassWrapper<InvVesselFragments>
{
    public InvVesselFragmentsR(InvVesselFragments _orig) : base(_orig)
    {
    }

    public SpriteRenderer self
    {
        get => orig.self;
        set => orig.self = value;
    }

    public SpriteRenderer piece1
    {
        get => orig.piece1;
        set => orig.piece1 = value;
    }

    public SpriteRenderer piece2
    {
        get => orig.piece2;
        set => orig.piece2 = value;
    }

    public SpriteRenderer full
    {
        get => orig.full;
        set => orig.full = value;
    }

    public Sprite backboardSprite
    {
        get => orig.backboardSprite;
        set => orig.backboardSprite = value;
    }

    public Sprite singlePieceSprite
    {
        get => orig.singlePieceSprite;
        set => orig.singlePieceSprite = value;
    }

    public Sprite doublePieceSprite
    {
        get => orig.doublePieceSprite;
        set => orig.doublePieceSprite = value;
    }

    public Sprite fullSprite
    {
        get => orig.fullSprite;
        set => orig.fullSprite = value;
    }

    public Sprite emptySprite
    {
        get => orig.emptySprite;
        set => orig.emptySprite = value;
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}