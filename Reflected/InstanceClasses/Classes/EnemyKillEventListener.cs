namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyKillEventListener allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyKillEventListenerR : InstanceClassWrapper<EnemyKillEventListener>
{
    public EnemyKillEventListenerR(EnemyKillEventListener _orig) : base(_orig)
    {
    }

    public EventRegister killEvent
    {
        get => orig.killEvent;
        set => orig.killEvent = value;
    }

    public HealthManager healthManager
    {
        get => GetField<HealthManager>();
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

    public void OnDisable()
    {
        CallMethod();
    }

    public void Die()
    {
        CallMethod();
    }
}