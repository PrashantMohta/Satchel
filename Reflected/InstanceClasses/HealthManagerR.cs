using System.Reflection;

namespace Satchel.Reflected
{
    /// <summary>
    ///     A class that contains all (public and private) fields and methods of HealthManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public class HealthManagerR : InstanceClassWrapper<HealthManager>
    {
        public HealthManagerR(HealthManager _orig) : base(_orig)
        {
        }

        public UnityEngine.BoxCollider2D boxCollider
        {
            get => GetField<UnityEngine.BoxCollider2D>();
            set => SetField(value);
        }

        public Recoil recoil
        {
            get => GetField<Recoil>();
            set => SetField(value);
        }

        public IHitEffectReciever hitEffectReceiver
        {
            get => GetField<IHitEffectReciever>();
            set => SetField(value);
        }

        public EnemyDeathEffects enemyDeathEffects
        {
            get => GetField<EnemyDeathEffects>();
            set => SetField(value);
        }

        public tk2dSpriteAnimator animator
        {
            get => GetField<tk2dSpriteAnimator>();
            set => SetField(value);
        }

        public tk2dSprite sprite
        {
            get => GetField<tk2dSprite>();
            set => SetField(value);
        }

        public DamageHero damageHero
        {
            get => GetField<DamageHero>();
            set => SetField(value);
        }

        public UnityEngine.AudioSource audioPlayerPrefab
        {
            get => GetField<UnityEngine.AudioSource>();
            set => SetField(value);
        }

        public AudioEvent regularInvincibleAudio
        {
            get => GetField<AudioEvent>();
            set => SetField(value);
        }

        public UnityEngine.GameObject blockHitPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject strikeNailPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject slashImpactPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject fireballHitPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject sharpShadowImpactPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject corpseSplatPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public AudioEvent enemyDeathSwordAudio
        {
            get => GetField<AudioEvent>();
            set => SetField(value);
        }

        public AudioEvent enemyDamageAudio
        {
            get => GetField<AudioEvent>();
            set => SetField(value);
        }

        public UnityEngine.GameObject smallGeoPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject mediumGeoPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject largeGeoPrefab
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public int hp
        {
            get => orig.hp;
            set => orig.hp = value;
        }

        public int enemyType
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public UnityEngine.Vector3 effectOrigin
        {
            get => GetField<UnityEngine.Vector3>();
            set => SetField(value);
        }

        public bool ignoreKillAll
        {
            get => GetField<bool>();
            set => SetField(value);
        }
        public int hpScale_level1
        {
            get
            {
                object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                return (int)obj.GetType().GetField("level1").GetValue(obj);
            }
            set
            {
                object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                obj.GetType().GetField("level1").SetValue(obj, value);
            }
        }
        public int hpScale_level2
        {
            get
            {
                object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                return (int)obj.GetType().GetField("level2").GetValue(obj);
            }
            set
            {
                object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                obj.GetType().GetField("level2").SetValue(obj, value);
            }
        }
        public int hpScale_level3
        {
            get
            {
                //object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                object obj = ReflectionHelper.GetField<HealthManager, object>(orig, "hpScale");
                return (int)obj.GetType().GetField("level3").GetValue(obj);
            }
            set
            {
                object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
                obj.GetType().GetField("level3").SetValue(obj, value);
            }
        }
        

        public int GetScaledHP(int originalHP)
        {
            object obj = typeof(HealthManager).GetField("hpScale", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(orig);
            return (int)obj.GetType().GetMethod("GetScaledHP").Invoke(obj, new object[] {});
            
        }

        public UnityEngine.GameObject battleScene
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject sendHitTo
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.GameObject sendKilledToObject
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public string sendKilledToName
        {
            get => GetField<string>();
            set => SetField(value);
        }

        public int smallGeoDrops
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public int mediumGeoDrops
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public int largeGeoDrops
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public bool megaFlingGeo
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool hasAlternateHitAnimation
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public string alternateHitAnimation
        {
            get => GetField<string>();
            set => SetField(value);
        }

        public bool invincible
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public int invincibleFromDirection
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public bool preventInvincibleEffect
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool hasAlternateInvincibleSound
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public UnityEngine.AudioClip alternateInvincibleSound
        {
            get => GetField<UnityEngine.AudioClip>();
            set => SetField(value);
        }

        public UnityEngine.Audio.AudioMixerSnapshot deathAudioSnapshot
        {
            get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
            set => SetField(value);
        }

        public bool hasSpecialDeath
        {
            get => orig.hasSpecialDeath;
            set => orig.hasSpecialDeath = value;
        }

        public bool deathReset
        {
            get => orig.deathReset;
            set => orig.deathReset = value;
        }

        public bool damageOverride
        {
            get => orig.damageOverride;
            set => orig.damageOverride = value;
        }

        public bool ignoreAcid
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool showGodfinderIcon
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public float showGodFinderDelay
        {
            get => GetField<float>();
            set => SetField(value);
        }

        public BossScene unlockBossScene
        {
            get => GetField<BossScene>();
            set => SetField(value);
        }

        public event HealthManager.DeathEvent OnDeath
        {
            add => orig.OnDeath += value;
            remove => orig.OnDeath += value;
        }

        public bool ignoreHazards
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool ignoreWater
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public float invulnerableTime
        {
            get => GetField<float>();
            set => SetField(value);
        }

        public bool semiPersistent
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool isDead
        {
            get => orig.isDead;
            set => orig.isDead = value;
        }

        public UnityEngine.GameObject sendKilledTo
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public float evasionByHitRemaining
        {
            get => GetField<float>();
            set => SetField(value);
        }

        public int directionOfLastAttack
        {
            get => GetField<int>();
            set => SetField(value);
        }

        public PlayMakerFSM stunControlFSM
        {
            get => GetField<PlayMakerFSM>();
            set => SetField(value);
        }

        public bool notifiedBattleScene
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public bool IsInvincible
        {
            get => orig.IsInvincible;
            set => orig.IsInvincible = value;
        }

        public int InvincibleFromDirection
        {
            get => orig.InvincibleFromDirection;
            set => orig.InvincibleFromDirection = value;
        }

        public bool useGUILayout
        {
            get => orig.useGUILayout;
            set => orig.useGUILayout = value;
        }

        public bool enabled
        {
            get => orig.enabled;
            set => orig.enabled = value;
        }

        public bool isActiveAndEnabled
        {
            get => orig.isActiveAndEnabled;
        }

        public UnityEngine.Transform transform
        {
            get => orig.transform;
        }

        public UnityEngine.GameObject gameObject
        {
            get => orig.gameObject;
        }

        public string tag
        {
            get => orig.tag;
            set => orig.tag = value;
        }

        public string name
        {
            get => orig.name;
            set => orig.name = value;
        }

        public UnityEngine.HideFlags hideFlags
        {
            get => orig.hideFlags;
            set => orig.hideFlags = value;
        }

        public void Awake() =>
            CallMethod();

        public void OnEnable() =>
            CallMethod();

        public void Start() =>
            CallMethod();

        public System.Collections.IEnumerator CheckPersistence() =>
            CallMethod<System.Collections.IEnumerator>();

        public void Update() =>
            CallMethod();

        public void Hit(HitInstance hitInstance) =>
            orig.Hit(hitInstance);

        public void Invincible(HitInstance hitInstance) =>
            CallMethod(new object[] { hitInstance });

        public void TakeDamage(HitInstance hitInstance) =>
            CallMethod(new object[] { hitInstance });

        public void NonFatalHit(bool ignoreEvasion) =>
            CallMethod(new object[] { ignoreEvasion });

        public void ApplyExtraDamage(int damageAmount) =>
            orig.ApplyExtraDamage(damageAmount);

        public void Die(System.Single? attackDirection, AttackTypes attackType, bool ignoreEvasion) =>
            orig.Die(attackDirection, attackType, ignoreEvasion);

        public void SendDeathEvent() =>
            orig.SendDeathEvent();

        public void SetGeoFlashing(UnityEngine.GameObject[] gameObjects, int originalAmount) =>
            CallMethod(new object[] { gameObjects, originalAmount });

        public bool IsBlockingByDirection(int cardinalDirection, AttackTypes attackType) =>
            orig.IsBlockingByDirection(cardinalDirection, attackType);

        public void SetBattleScene(UnityEngine.GameObject newBattleScene) =>
            orig.SetBattleScene(newBattleScene);

        public int GetAttackDirection() =>
            orig.GetAttackDirection();

        public void SetPreventInvincibleEffect(bool set) =>
            orig.SetPreventInvincibleEffect(set);

        public void SetGeoSmall(int amount) =>
            orig.SetGeoSmall(amount);

        public void SetGeoMedium(int amount) =>
            orig.SetGeoMedium(amount);

        public void SetGeoLarge(int amount) =>
            orig.SetGeoLarge(amount);

        public bool GetIsDead() =>
            orig.GetIsDead();

        public void SetIsDead(bool set) =>
            orig.SetIsDead(set);

        public void SetDamageOverride(bool set) =>
            orig.SetDamageOverride(set);

        public void SetSendKilledToObject(UnityEngine.GameObject killedObject) =>
            orig.SetSendKilledToObject(killedObject);

        public bool CheckInvincible() =>
            orig.CheckInvincible();
    }
}