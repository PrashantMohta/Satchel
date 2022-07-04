namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ExtraDamageable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ExtraDamageableR : InstanceClassWrapper<ExtraDamageable>
{
    public ExtraDamageableR(ExtraDamageable _orig) : base(_orig)
    {
    }

    public PlayMakerFSM healthManagerFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public FsmBool invincibleVar
    {
        get => GetField<FsmBool>();
        set => SetField(value);
    }

    public FsmInt hpVar
    {
        get => GetField<FsmInt>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public bool isSpellVulnerable
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public HealthManager healthManager
    {
        get => GetField<HealthManager>();
        set => SetField(value);
    }

    public RandomAudioClipTable impactClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public bool damagedThisFrame
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void RecieveExtraDamage(ExtraDamageTypes extraDamageType)
    {
        orig.RecieveExtraDamage(extraDamageType);
    }

    public int GetDamageOfType(ExtraDamageTypes extraDamageTypes)
    {
        return ExtraDamageable.GetDamageOfType(extraDamageTypes);
    }

    public void ApplyExtraDamageToHealthManager(int damageAmount)
    {
        CallMethod(new object[] { damageAmount });
    }
}