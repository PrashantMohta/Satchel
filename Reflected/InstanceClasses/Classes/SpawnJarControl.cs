namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnJarControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnJarControlR:InstanceClassWrapper<SpawnJarControl>
{
public SpawnJarControlR(SpawnJarControl _orig) : base(_orig) {}
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

public UnityEngine.ParticleSystem readyDust
{
get => orig.readyDust;
set => orig.readyDust = value;
}

public UnityEngine.ParticleSystem dustTrail
{
get => orig.dustTrail;
set => orig.dustTrail = value;
}

public UnityEngine.ParticleSystem ptBreakS
{
get => orig.ptBreakS;
set => orig.ptBreakS = value;
}

public UnityEngine.ParticleSystem ptBreakL
{
get => orig.ptBreakL;
set => orig.ptBreakL = value;
}

public UnityEngine.GameObject strikeNailR
{
get => orig.strikeNailR;
set => orig.strikeNailR = value;
}

public AudioEventRandom breakSound
{
get => orig.breakSound;
set => orig.breakSound = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public UnityEngine.GameObject enemyToSpawn
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public int enemyHealth
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.CircleCollider2D col
{
get => GetField<UnityEngine.CircleCollider2D>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer sprite
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public System.Collections.IEnumerator Behaviour () =>
CallMethod<System.Collections.IEnumerator>();

public void SetEnemySpawn (UnityEngine.GameObject prefab, int health) =>
orig.SetEnemySpawn(prefab, health);

}
}
