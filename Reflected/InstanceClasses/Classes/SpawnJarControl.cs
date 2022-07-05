namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnJarControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnJarControlR : InstanceClassWrapper<SpawnJarControl>
{
    public SpawnJarControlR(SpawnJarControl _orig) : base(_orig)
    {
    }

    public float spawnY
    {
        get => orig.spawnY;
        set => orig.spawnY = value;
    }

    public float breakY
    {
        get => orig.breakY;
        set => orig.breakY = value;
    }

    public ParticleSystem readyDust
    {
        get => orig.readyDust;
        set => orig.readyDust = value;
    }

    public ParticleSystem dustTrail
    {
        get => orig.dustTrail;
        set => orig.dustTrail = value;
    }

    public ParticleSystem ptBreakS
    {
        get => orig.ptBreakS;
        set => orig.ptBreakS = value;
    }

    public ParticleSystem ptBreakL
    {
        get => orig.ptBreakL;
        set => orig.ptBreakL = value;
    }

    public GameObject strikeNailR
    {
        get => orig.strikeNailR;
        set => orig.strikeNailR = value;
    }

    public AudioEventRandom breakSound
    {
        get => orig.breakSound;
        set => orig.breakSound = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public GameObject enemyToSpawn
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public int enemyHealth
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public CircleCollider2D col
    {
        get => GetField<CircleCollider2D>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public SpriteRenderer sprite
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

    public IEnumerator Behaviour()
    {
        return CallMethod<IEnumerator>();
    }

    public void SetEnemySpawn(GameObject prefab, int health)
    {
        orig.SetEnemySpawn(prefab, health);
    }
}