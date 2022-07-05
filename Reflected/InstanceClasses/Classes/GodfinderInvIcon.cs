namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GodfinderInvIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GodfinderInvIconR : InstanceClassWrapper<GodfinderInvIcon>
{
    public GodfinderInvIconR(GodfinderInvIcon _orig) : base(_orig)
    {
    }

    public Sprite normalSprite
    {
        get => orig.normalSprite;
        set => orig.normalSprite = value;
    }

    public Sprite newBossSprite
    {
        get => orig.newBossSprite;
        set => orig.newBossSprite = value;
    }

    public Sprite allBossesSprite
    {
        get => orig.allBossesSprite;
        set => orig.allBossesSprite = value;
    }

    public BossScene[] bosses
    {
        get => orig.bosses;
        set => orig.bosses = value;
    }

    public GodfinderInvIcon.BossSceneExtra[] extraBosses
    {
        get => orig.extraBosses;
        set => orig.extraBosses = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }
}