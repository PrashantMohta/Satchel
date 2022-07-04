namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HeroController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroControllerRR:InstanceClassWrapper<HeroController>
{
public HeroControllerRR(HeroController _orig) : base(_orig) {}
public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}

public GlobalEnums.HeroType heroType
{
get => orig.heroType;
set => orig.heroType = value;
}

public float RUN_SPEED
{
get => orig.RUN_SPEED;
set => orig.RUN_SPEED = value;
}

public float RUN_SPEED_CH
{
get => orig.RUN_SPEED_CH;
set => orig.RUN_SPEED_CH = value;
}

public float RUN_SPEED_CH_COMBO
{
get => orig.RUN_SPEED_CH_COMBO;
set => orig.RUN_SPEED_CH_COMBO = value;
}

public float WALK_SPEED
{
get => orig.WALK_SPEED;
set => orig.WALK_SPEED = value;
}

public float UNDERWATER_SPEED
{
get => orig.UNDERWATER_SPEED;
set => orig.UNDERWATER_SPEED = value;
}

public float JUMP_SPEED
{
get => orig.JUMP_SPEED;
set => orig.JUMP_SPEED = value;
}

public float JUMP_SPEED_UNDERWATER
{
get => orig.JUMP_SPEED_UNDERWATER;
set => orig.JUMP_SPEED_UNDERWATER = value;
}

public float MIN_JUMP_SPEED
{
get => orig.MIN_JUMP_SPEED;
set => orig.MIN_JUMP_SPEED = value;
}

public int JUMP_STEPS
{
get => orig.JUMP_STEPS;
set => orig.JUMP_STEPS = value;
}

public int JUMP_STEPS_MIN
{
get => orig.JUMP_STEPS_MIN;
set => orig.JUMP_STEPS_MIN = value;
}

public int JUMP_TIME
{
get => orig.JUMP_TIME;
set => orig.JUMP_TIME = value;
}

public int DOUBLE_JUMP_STEPS
{
get => orig.DOUBLE_JUMP_STEPS;
set => orig.DOUBLE_JUMP_STEPS = value;
}

public int WJLOCK_STEPS_SHORT
{
get => orig.WJLOCK_STEPS_SHORT;
set => orig.WJLOCK_STEPS_SHORT = value;
}

public int WJLOCK_STEPS_LONG
{
get => orig.WJLOCK_STEPS_LONG;
set => orig.WJLOCK_STEPS_LONG = value;
}

public float WJ_KICKOFF_SPEED
{
get => orig.WJ_KICKOFF_SPEED;
set => orig.WJ_KICKOFF_SPEED = value;
}

public int WALL_STICKY_STEPS
{
get => orig.WALL_STICKY_STEPS;
set => orig.WALL_STICKY_STEPS = value;
}

public float DASH_SPEED
{
get => orig.DASH_SPEED;
set => orig.DASH_SPEED = value;
}

public float DASH_SPEED_SHARP
{
get => orig.DASH_SPEED_SHARP;
set => orig.DASH_SPEED_SHARP = value;
}

public float DASH_TIME
{
get => orig.DASH_TIME;
set => orig.DASH_TIME = value;
}

public int DASH_QUEUE_STEPS
{
get => orig.DASH_QUEUE_STEPS;
set => orig.DASH_QUEUE_STEPS = value;
}

public float BACK_DASH_SPEED
{
get => orig.BACK_DASH_SPEED;
set => orig.BACK_DASH_SPEED = value;
}

public float BACK_DASH_TIME
{
get => orig.BACK_DASH_TIME;
set => orig.BACK_DASH_TIME = value;
}

public float SHADOW_DASH_SPEED
{
get => orig.SHADOW_DASH_SPEED;
set => orig.SHADOW_DASH_SPEED = value;
}

public float SHADOW_DASH_TIME
{
get => orig.SHADOW_DASH_TIME;
set => orig.SHADOW_DASH_TIME = value;
}

public float SHADOW_DASH_COOLDOWN
{
get => orig.SHADOW_DASH_COOLDOWN;
set => orig.SHADOW_DASH_COOLDOWN = value;
}

public float SUPER_DASH_SPEED
{
get => orig.SUPER_DASH_SPEED;
set => orig.SUPER_DASH_SPEED = value;
}

public float DASH_COOLDOWN
{
get => orig.DASH_COOLDOWN;
set => orig.DASH_COOLDOWN = value;
}

public float DASH_COOLDOWN_CH
{
get => orig.DASH_COOLDOWN_CH;
set => orig.DASH_COOLDOWN_CH = value;
}

public float BACKDASH_COOLDOWN
{
get => orig.BACKDASH_COOLDOWN;
set => orig.BACKDASH_COOLDOWN = value;
}

public float WALLSLIDE_SPEED
{
get => orig.WALLSLIDE_SPEED;
set => orig.WALLSLIDE_SPEED = value;
}

public float WALLSLIDE_DECEL
{
get => orig.WALLSLIDE_DECEL;
set => orig.WALLSLIDE_DECEL = value;
}

public float NAIL_CHARGE_TIME_DEFAULT
{
get => orig.NAIL_CHARGE_TIME_DEFAULT;
set => orig.NAIL_CHARGE_TIME_DEFAULT = value;
}

public float NAIL_CHARGE_TIME_CHARM
{
get => orig.NAIL_CHARGE_TIME_CHARM;
set => orig.NAIL_CHARGE_TIME_CHARM = value;
}

public float CYCLONE_HORIZONTAL_SPEED
{
get => orig.CYCLONE_HORIZONTAL_SPEED;
set => orig.CYCLONE_HORIZONTAL_SPEED = value;
}

public float SWIM_ACCEL
{
get => orig.SWIM_ACCEL;
set => orig.SWIM_ACCEL = value;
}

public float SWIM_MAX_SPEED
{
get => orig.SWIM_MAX_SPEED;
set => orig.SWIM_MAX_SPEED = value;
}

public float TIME_TO_ENTER_SCENE_BOT
{
get => orig.TIME_TO_ENTER_SCENE_BOT;
set => orig.TIME_TO_ENTER_SCENE_BOT = value;
}

public float TIME_TO_ENTER_SCENE_HOR
{
get => orig.TIME_TO_ENTER_SCENE_HOR;
set => orig.TIME_TO_ENTER_SCENE_HOR = value;
}

public float SPEED_TO_ENTER_SCENE_HOR
{
get => orig.SPEED_TO_ENTER_SCENE_HOR;
set => orig.SPEED_TO_ENTER_SCENE_HOR = value;
}

public float SPEED_TO_ENTER_SCENE_UP
{
get => orig.SPEED_TO_ENTER_SCENE_UP;
set => orig.SPEED_TO_ENTER_SCENE_UP = value;
}

public float SPEED_TO_ENTER_SCENE_DOWN
{
get => orig.SPEED_TO_ENTER_SCENE_DOWN;
set => orig.SPEED_TO_ENTER_SCENE_DOWN = value;
}

public float DEFAULT_GRAVITY
{
get => orig.DEFAULT_GRAVITY;
set => orig.DEFAULT_GRAVITY = value;
}

public float UNDERWATER_GRAVITY
{
get => orig.UNDERWATER_GRAVITY;
set => orig.UNDERWATER_GRAVITY = value;
}

public float ATTACK_DURATION
{
get => orig.ATTACK_DURATION;
set => orig.ATTACK_DURATION = value;
}

public float ATTACK_DURATION_CH
{
get => orig.ATTACK_DURATION_CH;
set => orig.ATTACK_DURATION_CH = value;
}

public float ALT_ATTACK_RESET
{
get => orig.ALT_ATTACK_RESET;
set => orig.ALT_ATTACK_RESET = value;
}

public float ATTACK_RECOVERY_TIME
{
get => orig.ATTACK_RECOVERY_TIME;
set => orig.ATTACK_RECOVERY_TIME = value;
}

public float ATTACK_COOLDOWN_TIME
{
get => orig.ATTACK_COOLDOWN_TIME;
set => orig.ATTACK_COOLDOWN_TIME = value;
}

public float ATTACK_COOLDOWN_TIME_CH
{
get => orig.ATTACK_COOLDOWN_TIME_CH;
set => orig.ATTACK_COOLDOWN_TIME_CH = value;
}

public float BOUNCE_TIME
{
get => orig.BOUNCE_TIME;
set => orig.BOUNCE_TIME = value;
}

public float BOUNCE_SHROOM_TIME
{
get => orig.BOUNCE_SHROOM_TIME;
set => orig.BOUNCE_SHROOM_TIME = value;
}

public float BOUNCE_VELOCITY
{
get => orig.BOUNCE_VELOCITY;
set => orig.BOUNCE_VELOCITY = value;
}

public float SHROOM_BOUNCE_VELOCITY
{
get => orig.SHROOM_BOUNCE_VELOCITY;
set => orig.SHROOM_BOUNCE_VELOCITY = value;
}

public float RECOIL_HOR_TIME
{
get => orig.RECOIL_HOR_TIME;
set => orig.RECOIL_HOR_TIME = value;
}

public float RECOIL_HOR_VELOCITY
{
get => orig.RECOIL_HOR_VELOCITY;
set => orig.RECOIL_HOR_VELOCITY = value;
}

public float RECOIL_HOR_VELOCITY_LONG
{
get => orig.RECOIL_HOR_VELOCITY_LONG;
set => orig.RECOIL_HOR_VELOCITY_LONG = value;
}

public float RECOIL_HOR_STEPS
{
get => orig.RECOIL_HOR_STEPS;
set => orig.RECOIL_HOR_STEPS = value;
}

public float RECOIL_DOWN_VELOCITY
{
get => orig.RECOIL_DOWN_VELOCITY;
set => orig.RECOIL_DOWN_VELOCITY = value;
}

public float RUN_PUFF_TIME
{
get => orig.RUN_PUFF_TIME;
set => orig.RUN_PUFF_TIME = value;
}

public float BIG_FALL_TIME
{
get => orig.BIG_FALL_TIME;
set => orig.BIG_FALL_TIME = value;
}

public float HARD_LANDING_TIME
{
get => orig.HARD_LANDING_TIME;
set => orig.HARD_LANDING_TIME = value;
}

public float DOWN_DASH_TIME
{
get => orig.DOWN_DASH_TIME;
set => orig.DOWN_DASH_TIME = value;
}

public float MAX_FALL_VELOCITY
{
get => orig.MAX_FALL_VELOCITY;
set => orig.MAX_FALL_VELOCITY = value;
}

public float MAX_FALL_VELOCITY_UNDERWATER
{
get => orig.MAX_FALL_VELOCITY_UNDERWATER;
set => orig.MAX_FALL_VELOCITY_UNDERWATER = value;
}

public float RECOIL_DURATION
{
get => orig.RECOIL_DURATION;
set => orig.RECOIL_DURATION = value;
}

public float RECOIL_DURATION_STAL
{
get => orig.RECOIL_DURATION_STAL;
set => orig.RECOIL_DURATION_STAL = value;
}

public float RECOIL_VELOCITY
{
get => orig.RECOIL_VELOCITY;
set => orig.RECOIL_VELOCITY = value;
}

public float DAMAGE_FREEZE_DOWN
{
get => orig.DAMAGE_FREEZE_DOWN;
set => orig.DAMAGE_FREEZE_DOWN = value;
}

public float DAMAGE_FREEZE_WAIT
{
get => orig.DAMAGE_FREEZE_WAIT;
set => orig.DAMAGE_FREEZE_WAIT = value;
}

public float DAMAGE_FREEZE_UP
{
get => orig.DAMAGE_FREEZE_UP;
set => orig.DAMAGE_FREEZE_UP = value;
}

public float INVUL_TIME
{
get => orig.INVUL_TIME;
set => orig.INVUL_TIME = value;
}

public float INVUL_TIME_STAL
{
get => orig.INVUL_TIME_STAL;
set => orig.INVUL_TIME_STAL = value;
}

public float INVUL_TIME_PARRY
{
get => orig.INVUL_TIME_PARRY;
set => orig.INVUL_TIME_PARRY = value;
}

public float INVUL_TIME_QUAKE
{
get => orig.INVUL_TIME_QUAKE;
set => orig.INVUL_TIME_QUAKE = value;
}

public float INVUL_TIME_CYCLONE
{
get => orig.INVUL_TIME_CYCLONE;
set => orig.INVUL_TIME_CYCLONE = value;
}

public float CAST_TIME
{
get => orig.CAST_TIME;
set => orig.CAST_TIME = value;
}

public float CAST_RECOIL_TIME
{
get => orig.CAST_RECOIL_TIME;
set => orig.CAST_RECOIL_TIME = value;
}

public float CAST_RECOIL_VELOCITY
{
get => orig.CAST_RECOIL_VELOCITY;
set => orig.CAST_RECOIL_VELOCITY = value;
}

public float WALLSLIDE_CLIP_DELAY
{
get => orig.WALLSLIDE_CLIP_DELAY;
set => orig.WALLSLIDE_CLIP_DELAY = value;
}

public int GRUB_SOUL_MP
{
get => orig.GRUB_SOUL_MP;
set => orig.GRUB_SOUL_MP = value;
}

public int GRUB_SOUL_MP_COMBO
{
get => orig.GRUB_SOUL_MP_COMBO;
set => orig.GRUB_SOUL_MP_COMBO = value;
}

public int JUMP_QUEUE_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public int JUMP_RELEASE_QUEUE_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public int DOUBLE_JUMP_QUEUE_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public int ATTACK_QUEUE_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public float DELAY_BEFORE_ENTER
{
get => GetField<float>();
set => SetField(value);
}

public float LOOK_DELAY
{
get => GetField<float>();
set => SetField(value);
}

public float LOOK_ANIM_DELAY
{
get => GetField<float>();
set => SetField(value);
}

public float DEATH_WAIT
{
get => GetField<float>();
set => SetField(value);
}

public float HAZARD_DEATH_CHECK_TIME
{
get => GetField<float>();
set => SetField(value);
}

public float FLOATING_CHECK_TIME
{
get => GetField<float>();
set => SetField(value);
}

public float NAIL_TERRAIN_CHECK_TIME
{
get => GetField<float>();
set => SetField(value);
}

public float BUMP_VELOCITY
{
get => GetField<float>();
set => SetField(value);
}

public float BUMP_VELOCITY_DASH
{
get => GetField<float>();
set => SetField(value);
}

public int LANDING_BUFFER_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public int LEDGE_BUFFER_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public int HEAD_BUMP_STEPS
{
get => GetField<int>();
set => SetField(value);
}

public float MANTIS_CHARM_SCALE
{
get => GetField<float>();
set => SetField(value);
}

public float FIND_GROUND_POINT_DISTANCE
{
get => GetField<float>();
set => SetField(value);
}

public float FIND_GROUND_POINT_DISTANCE_EXT
{
get => GetField<float>();
set => SetField(value);
}

public GlobalEnums.ActorStates hero_state
{
get => orig.hero_state;
set => orig.hero_state = value;
}

public GlobalEnums.ActorStates prev_hero_state
{
get => orig.prev_hero_state;
set => orig.prev_hero_state = value;
}

public GlobalEnums.HeroTransitionState transitionState
{
get => orig.transitionState;
set => orig.transitionState = value;
}

public GlobalEnums.DamageMode damageMode
{
get => orig.damageMode;
set => orig.damageMode = value;
}

public float move_input
{
get => orig.move_input;
set => orig.move_input = value;
}

public float vertical_input
{
get => orig.vertical_input;
set => orig.vertical_input = value;
}

public float controller_deadzone
{
get => orig.controller_deadzone;
set => orig.controller_deadzone = value;
}

public UnityEngine.Vector2 current_velocity
{
get => orig.current_velocity;
set => orig.current_velocity = value;
}

public bool isGameplayScene
{
get => GetField<bool>();
set => SetField(value);
}

public bool isEnteringFirstLevel
{
get => orig.isEnteringFirstLevel;
set => orig.isEnteringFirstLevel = value;
}

public UnityEngine.Vector2 slashOffset
{
get => orig.slashOffset;
set => orig.slashOffset = value;
}

public UnityEngine.Vector2 upSlashOffset
{
get => orig.upSlashOffset;
set => orig.upSlashOffset = value;
}

public UnityEngine.Vector2 downwardSlashOffset
{
get => orig.downwardSlashOffset;
set => orig.downwardSlashOffset = value;
}

public UnityEngine.Vector2 spell1Offset
{
get => orig.spell1Offset;
set => orig.spell1Offset = value;
}

public int jump_steps
{
get => GetField<int>();
set => SetField(value);
}

public int jumped_steps
{
get => GetField<int>();
set => SetField(value);
}

public int doubleJump_steps
{
get => GetField<int>();
set => SetField(value);
}

public float dash_timer
{
get => GetField<float>();
set => SetField(value);
}

public float back_dash_timer
{
get => GetField<float>();
set => SetField(value);
}

public float shadow_dash_timer
{
get => GetField<float>();
set => SetField(value);
}

public float attack_time
{
get => GetField<float>();
set => SetField(value);
}

public float attack_cooldown
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 transition_vel
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float altAttackTime
{
get => GetField<float>();
set => SetField(value);
}

public float lookDelayTimer
{
get => GetField<float>();
set => SetField(value);
}

public float bounceTimer
{
get => GetField<float>();
set => SetField(value);
}

public float recoilHorizontalTimer
{
get => GetField<float>();
set => SetField(value);
}

public float runPuffTimer
{
get => GetField<float>();
set => SetField(value);
}

public float hardLandingTimer
{
get => GetField<float>();
set => SetField(value);
}

public float dashLandingTimer
{
get => GetField<float>();
set => SetField(value);
}

public float recoilTimer
{
get => GetField<float>();
set => SetField(value);
}

public int recoilSteps
{
get => GetField<int>();
set => SetField(value);
}

public int landingBufferSteps
{
get => GetField<int>();
set => SetField(value);
}

public int dashQueueSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool dashQueuing
{
get => GetField<bool>();
set => SetField(value);
}

public float shadowDashTimer
{
get => GetField<float>();
set => SetField(value);
}

public float dashCooldownTimer
{
get => GetField<float>();
set => SetField(value);
}

public float nailChargeTimer
{
get => GetField<float>();
set => SetField(value);
}

public int wallLockSteps
{
get => GetField<int>();
set => SetField(value);
}

public float wallslideClipTimer
{
get => GetField<float>();
set => SetField(value);
}

public float hardLandFailSafeTimer
{
get => GetField<float>();
set => SetField(value);
}

public float hazardDeathTimer
{
get => GetField<float>();
set => SetField(value);
}

public float floatingBufferTimer
{
get => GetField<float>();
set => SetField(value);
}

public float attackDuration
{
get => GetField<float>();
set => SetField(value);
}

public float parryInvulnTimer
{
get => orig.parryInvulnTimer;
set => orig.parryInvulnTimer = value;
}

public UnityEngine.GameObject slashPrefab
{
get => orig.slashPrefab;
set => orig.slashPrefab = value;
}

public UnityEngine.GameObject slashAltPrefab
{
get => orig.slashAltPrefab;
set => orig.slashAltPrefab = value;
}

public UnityEngine.GameObject upSlashPrefab
{
get => orig.upSlashPrefab;
set => orig.upSlashPrefab = value;
}

public UnityEngine.GameObject downSlashPrefab
{
get => orig.downSlashPrefab;
set => orig.downSlashPrefab = value;
}

public UnityEngine.GameObject wallSlashPrefab
{
get => orig.wallSlashPrefab;
set => orig.wallSlashPrefab = value;
}

public NailSlash normalSlash
{
get => orig.normalSlash;
set => orig.normalSlash = value;
}

public NailSlash alternateSlash
{
get => orig.alternateSlash;
set => orig.alternateSlash = value;
}

public NailSlash upSlash
{
get => orig.upSlash;
set => orig.upSlash = value;
}

public NailSlash downSlash
{
get => orig.downSlash;
set => orig.downSlash = value;
}

public NailSlash wallSlash
{
get => orig.wallSlash;
set => orig.wallSlash = value;
}

public PlayMakerFSM normalSlashFsm
{
get => orig.normalSlashFsm;
set => orig.normalSlashFsm = value;
}

public PlayMakerFSM alternateSlashFsm
{
get => orig.alternateSlashFsm;
set => orig.alternateSlashFsm = value;
}

public PlayMakerFSM upSlashFsm
{
get => orig.upSlashFsm;
set => orig.upSlashFsm = value;
}

public PlayMakerFSM downSlashFsm
{
get => orig.downSlashFsm;
set => orig.downSlashFsm = value;
}

public PlayMakerFSM wallSlashFsm
{
get => orig.wallSlashFsm;
set => orig.wallSlashFsm = value;
}

public UnityEngine.GameObject nailTerrainImpactEffectPrefab
{
get => orig.nailTerrainImpactEffectPrefab;
set => orig.nailTerrainImpactEffectPrefab = value;
}

public UnityEngine.GameObject spell1Prefab
{
get => orig.spell1Prefab;
set => orig.spell1Prefab = value;
}

public UnityEngine.GameObject takeHitPrefab
{
get => orig.takeHitPrefab;
set => orig.takeHitPrefab = value;
}

public UnityEngine.GameObject takeHitDoublePrefab
{
get => orig.takeHitDoublePrefab;
set => orig.takeHitDoublePrefab = value;
}

public UnityEngine.GameObject softLandingEffectPrefab
{
get => orig.softLandingEffectPrefab;
set => orig.softLandingEffectPrefab = value;
}

public UnityEngine.GameObject hardLandingEffectPrefab
{
get => orig.hardLandingEffectPrefab;
set => orig.hardLandingEffectPrefab = value;
}

public UnityEngine.GameObject runEffectPrefab
{
get => orig.runEffectPrefab;
set => orig.runEffectPrefab = value;
}

public UnityEngine.GameObject backDashPrefab
{
get => orig.backDashPrefab;
set => orig.backDashPrefab = value;
}

public UnityEngine.GameObject jumpEffectPrefab
{
get => orig.jumpEffectPrefab;
set => orig.jumpEffectPrefab = value;
}

public UnityEngine.GameObject jumpTrailPrefab
{
get => orig.jumpTrailPrefab;
set => orig.jumpTrailPrefab = value;
}

public UnityEngine.GameObject fallEffectPrefab
{
get => orig.fallEffectPrefab;
set => orig.fallEffectPrefab = value;
}

public UnityEngine.ParticleSystem wallslideDustPrefab
{
get => orig.wallslideDustPrefab;
set => orig.wallslideDustPrefab = value;
}

public UnityEngine.GameObject artChargeEffect
{
get => orig.artChargeEffect;
set => orig.artChargeEffect = value;
}

public UnityEngine.GameObject artChargedEffect
{
get => orig.artChargedEffect;
set => orig.artChargedEffect = value;
}

public UnityEngine.GameObject artChargedFlash
{
get => orig.artChargedFlash;
set => orig.artChargedFlash = value;
}

public tk2dSpriteAnimator artChargedEffectAnim
{
get => orig.artChargedEffectAnim;
set => orig.artChargedEffectAnim = value;
}

public UnityEngine.GameObject shadowdashBurstPrefab
{
get => orig.shadowdashBurstPrefab;
set => orig.shadowdashBurstPrefab = value;
}

public UnityEngine.GameObject shadowdashDownBurstPrefab
{
get => orig.shadowdashDownBurstPrefab;
set => orig.shadowdashDownBurstPrefab = value;
}

public UnityEngine.GameObject dashParticlesPrefab
{
get => orig.dashParticlesPrefab;
set => orig.dashParticlesPrefab = value;
}

public UnityEngine.GameObject shadowdashParticlesPrefab
{
get => orig.shadowdashParticlesPrefab;
set => orig.shadowdashParticlesPrefab = value;
}

public UnityEngine.GameObject shadowRingPrefab
{
get => orig.shadowRingPrefab;
set => orig.shadowRingPrefab = value;
}

public UnityEngine.GameObject shadowRechargePrefab
{
get => orig.shadowRechargePrefab;
set => orig.shadowRechargePrefab = value;
}

public UnityEngine.GameObject dJumpWingsPrefab
{
get => orig.dJumpWingsPrefab;
set => orig.dJumpWingsPrefab = value;
}

public UnityEngine.GameObject dJumpFlashPrefab
{
get => orig.dJumpFlashPrefab;
set => orig.dJumpFlashPrefab = value;
}

public UnityEngine.ParticleSystem dJumpFeathers
{
get => orig.dJumpFeathers;
set => orig.dJumpFeathers = value;
}

public UnityEngine.GameObject wallPuffPrefab
{
get => orig.wallPuffPrefab;
set => orig.wallPuffPrefab = value;
}

public UnityEngine.GameObject sharpShadowPrefab
{
get => orig.sharpShadowPrefab;
set => orig.sharpShadowPrefab = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabL
{
get => orig.grubberFlyBeamPrefabL;
set => orig.grubberFlyBeamPrefabL = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabR
{
get => orig.grubberFlyBeamPrefabR;
set => orig.grubberFlyBeamPrefabR = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabU
{
get => orig.grubberFlyBeamPrefabU;
set => orig.grubberFlyBeamPrefabU = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabD
{
get => orig.grubberFlyBeamPrefabD;
set => orig.grubberFlyBeamPrefabD = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabL_fury
{
get => orig.grubberFlyBeamPrefabL_fury;
set => orig.grubberFlyBeamPrefabL_fury = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabR_fury
{
get => orig.grubberFlyBeamPrefabR_fury;
set => orig.grubberFlyBeamPrefabR_fury = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabU_fury
{
get => orig.grubberFlyBeamPrefabU_fury;
set => orig.grubberFlyBeamPrefabU_fury = value;
}

public UnityEngine.GameObject grubberFlyBeamPrefabD_fury
{
get => orig.grubberFlyBeamPrefabD_fury;
set => orig.grubberFlyBeamPrefabD_fury = value;
}

public UnityEngine.GameObject carefreeShield
{
get => orig.carefreeShield;
set => orig.carefreeShield = value;
}

public UnityEngine.GameObject corpsePrefab
{
get => orig.corpsePrefab;
set => orig.corpsePrefab = value;
}

public UnityEngine.GameObject spikeDeathPrefab
{
get => orig.spikeDeathPrefab;
set => orig.spikeDeathPrefab = value;
}

public UnityEngine.GameObject acidDeathPrefab
{
get => orig.acidDeathPrefab;
set => orig.acidDeathPrefab = value;
}

public UnityEngine.GameObject lavaDeathPrefab
{
get => orig.lavaDeathPrefab;
set => orig.lavaDeathPrefab = value;
}

public UnityEngine.GameObject heroDeathPrefab
{
get => orig.heroDeathPrefab;
set => orig.heroDeathPrefab = value;
}

public UnityEngine.GameObject cutscenePrefab
{
get => orig.cutscenePrefab;
set => orig.cutscenePrefab = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D rb2d
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Collider2D col2d
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.MeshRenderer renderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public UnityEngine.Transform transform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public HeroAnimationController animCtrl
{
get => GetField<HeroAnimationController>();
set => SetField(value);
}

public HeroControllerStates cState
{
get => orig.cState;
set => orig.cState = value;
}

public PlayerData playerData
{
get => orig.playerData;
set => orig.playerData = value;
}

public HeroAudioController audioCtrl
{
get => GetField<HeroAudioController>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UIManager ui
{
get => orig.ui;
set => orig.ui = value;
}

public InputHandler inputHandler
{
get => GetField<InputHandler>();
set => SetField(value);
}

public PlayMakerFSM damageEffectFSM
{
get => orig.damageEffectFSM;
set => orig.damageEffectFSM = value;
}

public UnityEngine.ParticleSystem dashParticleSystem
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public InvulnerablePulse invPulse
{
get => GetField<InvulnerablePulse>();
set => SetField(value);
}

public SpriteFlash spriteFlash
{
get => GetField<SpriteFlash>();
set => SetField(value);
}

public UnityEngine.AudioSource footStepsRunAudioSource
{
get => orig.footStepsRunAudioSource;
set => orig.footStepsRunAudioSource = value;
}

public UnityEngine.AudioSource footStepsWalkAudioSource
{
get => orig.footStepsWalkAudioSource;
set => orig.footStepsWalkAudioSource = value;
}

public float prevGravityScale
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 recoilVector
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 lastInputState
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public GlobalEnums.GatePosition gatePosition
{
get => orig.gatePosition;
set => orig.gatePosition = value;
}

public bool runMsgSent
{
get => GetField<bool>();
set => SetField(value);
}

public bool hardLanded
{
get => GetField<bool>();
set => SetField(value);
}

public bool fallRumble
{
get => GetField<bool>();
set => SetField(value);
}

public bool acceptingInput
{
get => orig.acceptingInput;
set => orig.acceptingInput = value;
}

public bool fallTrailGenerated
{
get => GetField<bool>();
set => SetField(value);
}

public bool drainMP
{
get => GetField<bool>();
set => SetField(value);
}

public float drainMP_timer
{
get => GetField<float>();
set => SetField(value);
}

public float drainMP_time
{
get => GetField<float>();
set => SetField(value);
}

public float MP_drained
{
get => GetField<float>();
set => SetField(value);
}

public float drainMP_seconds
{
get => GetField<float>();
set => SetField(value);
}

public float focusMP_amount
{
get => GetField<float>();
set => SetField(value);
}

public float dashBumpCorrection
{
get => GetField<float>();
set => SetField(value);
}

public bool controlReqlinquished
{
get => orig.controlReqlinquished;
set => orig.controlReqlinquished = value;
}

public bool enterWithoutInput
{
get => orig.enterWithoutInput;
set => orig.enterWithoutInput = value;
}

public bool lookingUpAnim
{
get => orig.lookingUpAnim;
set => orig.lookingUpAnim = value;
}

public bool lookingDownAnim
{
get => orig.lookingDownAnim;
set => orig.lookingDownAnim = value;
}

public bool carefreeShieldEquipped
{
get => orig.carefreeShieldEquipped;
set => orig.carefreeShieldEquipped = value;
}

public int hitsSinceShielded
{
get => GetField<int>();
set => SetField(value);
}

public EndBeta endBeta
{
get => GetField<EndBeta>();
set => SetField(value);
}

public int jumpQueueSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool jumpQueuing
{
get => GetField<bool>();
set => SetField(value);
}

public int doubleJumpQueueSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool doubleJumpQueuing
{
get => GetField<bool>();
set => SetField(value);
}

public int jumpReleaseQueueSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool jumpReleaseQueuing
{
get => GetField<bool>();
set => SetField(value);
}

public int attackQueueSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool attackQueuing
{
get => GetField<bool>();
set => SetField(value);
}

public bool touchingWallL
{
get => orig.touchingWallL;
set => orig.touchingWallL = value;
}

public bool touchingWallR
{
get => orig.touchingWallR;
set => orig.touchingWallR = value;
}

public bool wallSlidingL
{
get => orig.wallSlidingL;
set => orig.wallSlidingL = value;
}

public bool wallSlidingR
{
get => orig.wallSlidingR;
set => orig.wallSlidingR = value;
}

public bool airDashed
{
get => GetField<bool>();
set => SetField(value);
}

public bool dashingDown
{
get => orig.dashingDown;
set => orig.dashingDown = value;
}

public bool wieldingLantern
{
get => orig.wieldingLantern;
set => orig.wieldingLantern = value;
}

public bool startWithWallslide
{
get => GetField<bool>();
set => SetField(value);
}

public bool startWithJump
{
get => GetField<bool>();
set => SetField(value);
}

public bool startWithFullJump
{
get => GetField<bool>();
set => SetField(value);
}

public bool startWithDash
{
get => GetField<bool>();
set => SetField(value);
}

public bool startWithAttack
{
get => GetField<bool>();
set => SetField(value);
}

public bool nailArt_cyclone
{
get => GetField<bool>();
set => SetField(value);
}

public bool wallSlashing
{
get => GetField<bool>();
set => SetField(value);
}

public bool doubleJumped
{
get => GetField<bool>();
set => SetField(value);
}

public bool inAcid
{
get => orig.inAcid;
set => orig.inAcid = value;
}

public bool wallJumpedR
{
get => GetField<bool>();
set => SetField(value);
}

public bool wallJumpedL
{
get => GetField<bool>();
set => SetField(value);
}

public bool wallLocked
{
get => orig.wallLocked;
set => orig.wallLocked = value;
}

public float currentWalljumpSpeed
{
get => GetField<float>();
set => SetField(value);
}

public float walljumpSpeedDecel
{
get => GetField<float>();
set => SetField(value);
}

public int wallUnstickSteps
{
get => GetField<int>();
set => SetField(value);
}

public bool recoilLarge
{
get => GetField<bool>();
set => SetField(value);
}

public float conveyorSpeed
{
get => orig.conveyorSpeed;
set => orig.conveyorSpeed = value;
}

public float conveyorSpeedV
{
get => orig.conveyorSpeedV;
set => orig.conveyorSpeedV = value;
}

public bool enteringVertically
{
get => GetField<bool>();
set => SetField(value);
}

public bool playingWallslideClip
{
get => GetField<bool>();
set => SetField(value);
}

public bool playedMantisClawClip
{
get => GetField<bool>();
set => SetField(value);
}

public bool exitedSuperDashing
{
get => orig.exitedSuperDashing;
set => orig.exitedSuperDashing = value;
}

public bool exitedQuake
{
get => orig.exitedQuake;
set => orig.exitedQuake = value;
}

public bool fallCheckFlagged
{
get => GetField<bool>();
set => SetField(value);
}

public int ledgeBufferSteps
{
get => GetField<int>();
set => SetField(value);
}

public int headBumpSteps
{
get => GetField<int>();
set => SetField(value);
}

public float nailChargeTime
{
get => GetField<float>();
set => SetField(value);
}

public bool takeNoDamage
{
get => orig.takeNoDamage;
set => orig.takeNoDamage = value;
}

public bool joniBeam
{
get => GetField<bool>();
set => SetField(value);
}

public bool fadedSceneIn
{
get => orig.fadedSceneIn;
set => orig.fadedSceneIn = value;
}

public bool stopWalkingOut
{
get => GetField<bool>();
set => SetField(value);
}

public bool boundsChecking
{
get => GetField<bool>();
set => SetField(value);
}

public bool blockerFix
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2[] positionHistory
{
get => GetField<UnityEngine.Vector2[]>();
set => SetField(value);
}

public bool tilemapTestActive
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 groundRayOriginC
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 groundRayOriginL
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 groundRayOriginR
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Coroutine takeDamageCoroutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine tilemapTestCoroutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.AudioClip footstepsRunDust
{
get => orig.footstepsRunDust;
set => orig.footstepsRunDust = value;
}

public UnityEngine.AudioClip footstepsRunGrass
{
get => orig.footstepsRunGrass;
set => orig.footstepsRunGrass = value;
}

public UnityEngine.AudioClip footstepsRunBone
{
get => orig.footstepsRunBone;
set => orig.footstepsRunBone = value;
}

public UnityEngine.AudioClip footstepsRunSpa
{
get => orig.footstepsRunSpa;
set => orig.footstepsRunSpa = value;
}

public UnityEngine.AudioClip footstepsRunMetal
{
get => orig.footstepsRunMetal;
set => orig.footstepsRunMetal = value;
}

public UnityEngine.AudioClip footstepsRunWater
{
get => orig.footstepsRunWater;
set => orig.footstepsRunWater = value;
}

public UnityEngine.AudioClip footstepsWalkDust
{
get => orig.footstepsWalkDust;
set => orig.footstepsWalkDust = value;
}

public UnityEngine.AudioClip footstepsWalkGrass
{
get => orig.footstepsWalkGrass;
set => orig.footstepsWalkGrass = value;
}

public UnityEngine.AudioClip footstepsWalkBone
{
get => orig.footstepsWalkBone;
set => orig.footstepsWalkBone = value;
}

public UnityEngine.AudioClip footstepsWalkSpa
{
get => orig.footstepsWalkSpa;
set => orig.footstepsWalkSpa = value;
}

public UnityEngine.AudioClip footstepsWalkMetal
{
get => orig.footstepsWalkMetal;
set => orig.footstepsWalkMetal = value;
}

public UnityEngine.AudioClip nailArtCharge
{
get => orig.nailArtCharge;
set => orig.nailArtCharge = value;
}

public UnityEngine.AudioClip nailArtChargeComplete
{
get => orig.nailArtChargeComplete;
set => orig.nailArtChargeComplete = value;
}

public UnityEngine.AudioClip blockerImpact
{
get => orig.blockerImpact;
set => orig.blockerImpact = value;
}

public UnityEngine.AudioClip shadowDashClip
{
get => orig.shadowDashClip;
set => orig.shadowDashClip = value;
}

public UnityEngine.AudioClip sharpShadowClip
{
get => orig.sharpShadowClip;
set => orig.sharpShadowClip = value;
}

public UnityEngine.AudioClip doubleJumpClip
{
get => orig.doubleJumpClip;
set => orig.doubleJumpClip = value;
}

public UnityEngine.AudioClip mantisClawClip
{
get => orig.mantisClawClip;
set => orig.mantisClawClip = value;
}

public UnityEngine.GameObject slash
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public NailSlash slashComponent
{
get => GetField<NailSlash>();
set => SetField(value);
}

public PlayMakerFSM slashFsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}

public UnityEngine.GameObject runEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject backDash
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject jumpEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject fallEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject dashEffect
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject grubberFlyBeam
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject hazardCorpe
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public PlayMakerFSM vignetteFSM
{
get => orig.vignetteFSM;
set => orig.vignetteFSM = value;
}

public UnityEngine.SpriteRenderer heroLight
{
get => orig.heroLight;
set => orig.heroLight = value;
}

public UnityEngine.SpriteRenderer vignette
{
get => orig.vignette;
set => orig.vignette = value;
}

public PlayMakerFSM dashBurst
{
get => orig.dashBurst;
set => orig.dashBurst = value;
}

public PlayMakerFSM superDash
{
get => orig.superDash;
set => orig.superDash = value;
}

public PlayMakerFSM fsm_thornCounter
{
get => orig.fsm_thornCounter;
set => orig.fsm_thornCounter = value;
}

public PlayMakerFSM spellControl
{
get => orig.spellControl;
set => orig.spellControl = value;
}

public PlayMakerFSM fsm_fallTrail
{
get => orig.fsm_fallTrail;
set => orig.fsm_fallTrail = value;
}

public PlayMakerFSM fsm_orbitShield
{
get => orig.fsm_orbitShield;
set => orig.fsm_orbitShield = value;
}

public VibrationData softLandVibration
{
get => orig.softLandVibration;
set => orig.softLandVibration = value;
}

public VibrationData wallJumpVibration
{
get => orig.wallJumpVibration;
set => orig.wallJumpVibration = value;
}

public VibrationPlayer wallSlideVibrationPlayer
{
get => orig.wallSlideVibrationPlayer;
set => orig.wallSlideVibrationPlayer = value;
}

public VibrationData dashVibration
{
get => orig.dashVibration;
set => orig.dashVibration = value;
}

public VibrationData shadowDashVibration
{
get => orig.shadowDashVibration;
set => orig.shadowDashVibration = value;
}

public VibrationData doubleJumpVibration
{
get => orig.doubleJumpVibration;
set => orig.doubleJumpVibration = value;
}

public bool isHeroInPosition
{
get => orig.isHeroInPosition;
set => orig.isHeroInPosition = value;
}

public bool jumpReleaseQueueingEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public HeroController _instance
{
get => GetFieldStatic<HeroController>();
set => SetField(value);
}

public float PreventCastByDialogueEndDuration
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float preventCastByDialogueEndTimer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 oldPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float fallTimer
{
get => orig.fallTimer;
set => SetProperty(value);
}

public GeoCounter geoCounter
{
get => orig.geoCounter;
set => SetProperty(value);
}

public PlayMakerFSM proxyFSM
{
get => orig.proxyFSM;
set => SetProperty(value);
}

public TransitionPoint sceneEntryGate
{
get => orig.sceneEntryGate;
set => SetProperty(value);
}

public bool IsDreamReturning
{
get => orig.IsDreamReturning;
}

public HeroController instance
{
get => HeroController.instance;
}

public HeroController SilentInstance
{
get => HeroController.SilentInstance;
}

public HeroController UnsafeInstance
{
get => HeroController.UnsafeInstance;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void SceneInit () =>
orig.SceneInit();

public void Update () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void Update10 () =>
CallMethod();

public void OnLevelUnload () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Move (float move_direction) =>
CallMethod(new object[] {move_direction});

public void Jump () =>
CallMethod();

public void DoubleJump () =>
CallMethod();

public void Attack (GlobalEnums.AttackDirection attackDir) =>
orig.Attack(attackDir);

public void Dash () =>
CallMethod();

public void BackDash () =>
CallMethod();

public void ShadowDash () =>
CallMethod();

public void SuperDash () =>
CallMethod();

public void FaceRight () =>
orig.FaceRight();

public void FaceLeft () =>
orig.FaceLeft();

public void StartMPDrain (float time) =>
orig.StartMPDrain(time);

public void StopMPDrain () =>
orig.StopMPDrain();

public void SetBackOnGround () =>
orig.SetBackOnGround();

public void SetStartWithWallslide () =>
orig.SetStartWithWallslide();

public void SetStartWithJump () =>
orig.SetStartWithJump();

public void SetStartWithFullJump () =>
orig.SetStartWithFullJump();

public void SetStartWithDash () =>
orig.SetStartWithDash();

public void SetStartWithAttack () =>
orig.SetStartWithAttack();

public void SetSuperDashExit () =>
orig.SetSuperDashExit();

public void SetQuakeExit () =>
orig.SetQuakeExit();

public void SetTakeNoDamage () =>
orig.SetTakeNoDamage();

public void EndTakeNoDamage () =>
orig.EndTakeNoDamage();

public void SetHeroParent (UnityEngine.Transform newParent) =>
orig.SetHeroParent(newParent);

public void IsSwimming () =>
orig.IsSwimming();

public void NotSwimming () =>
orig.NotSwimming();

public void EnableRenderer () =>
orig.EnableRenderer();

public void ResetAirMoves () =>
orig.ResetAirMoves();

public void SetConveyorSpeed (float speed) =>
orig.SetConveyorSpeed(speed);

public void SetConveyorSpeedV (float speed) =>
orig.SetConveyorSpeedV(speed);

public void EnterWithoutInput (bool flag) =>
orig.EnterWithoutInput(flag);

public void SetDarkness (int darkness) =>
orig.SetDarkness(darkness);

public void CancelHeroJump () =>
orig.CancelHeroJump();

public void CharmUpdate () =>
orig.CharmUpdate();

public void checkEnvironment () =>
orig.checkEnvironment();

public void SetBenchRespawn (string spawnMarker, string sceneName, int spawnType, bool facingRight) =>
orig.SetBenchRespawn(spawnMarker, sceneName, spawnType, facingRight);

public void SetHazardRespawn (UnityEngine.Vector3 position, bool facingRight) =>
orig.SetHazardRespawn(position, facingRight);

public void AddGeo (int amount) =>
orig.AddGeo(amount);

public void ToZero () =>
orig.ToZero();

public void AddGeoQuietly (int amount) =>
orig.AddGeoQuietly(amount);

public void AddGeoToCounter (int amount) =>
orig.AddGeoToCounter(amount);

public void TakeGeo (int amount) =>
orig.TakeGeo(amount);

public void UpdateGeo () =>
orig.UpdateGeo();

public bool CanInput () =>
orig.CanInput();

public bool CanTalk () =>
orig.CanTalk();

public void FlipSprite () =>
orig.FlipSprite();

public void NailParry () =>
orig.NailParry();

public void NailParryRecover () =>
orig.NailParryRecover();

public void QuakeInvuln () =>
orig.QuakeInvuln();

public void CancelParryInvuln () =>
orig.CancelParryInvuln();

public void CycloneInvuln () =>
orig.CycloneInvuln();

public void SetWieldingLantern (bool set) =>
orig.SetWieldingLantern(set);

public void TakeDamage (UnityEngine.GameObject go, GlobalEnums.CollisionSide damageSide, int damageAmount, int hazardType) =>
orig.TakeDamage(go, damageSide, damageAmount, hazardType);

public string GetEntryGateName () =>
orig.GetEntryGateName();

public void AddMPCharge (int amount) =>
orig.AddMPCharge(amount);

public void SoulGain () =>
orig.SoulGain();

public void AddMPChargeSpa (int amount) =>
orig.AddMPChargeSpa(amount);

public bool TryAddMPChargeSpa (int amount) =>
orig.TryAddMPChargeSpa(amount);

public void SetMPCharge (int amount) =>
orig.SetMPCharge(amount);

public void TakeMP (int amount) =>
orig.TakeMP(amount);

public void TakeMPQuick (int amount) =>
orig.TakeMPQuick(amount);

public void TakeReserveMP (int amount) =>
orig.TakeReserveMP(amount);

public void AddHealth (int amount) =>
orig.AddHealth(amount);

public void TakeHealth (int amount) =>
orig.TakeHealth(amount);

public void MaxHealth () =>
orig.MaxHealth();

public void MaxHealthKeepBlue () =>
orig.MaxHealthKeepBlue();

public void AddToMaxHealth (int amount) =>
orig.AddToMaxHealth(amount);

public void ClearMP () =>
orig.ClearMP();

public void ClearMPSendEvents () =>
orig.ClearMPSendEvents();

public void AddToMaxMPReserve (int amount) =>
orig.AddToMaxMPReserve(amount);

public void Bounce () =>
orig.Bounce();

public void BounceHigh () =>
orig.BounceHigh();

public void ShroomBounce () =>
orig.ShroomBounce();

public void RecoilLeft () =>
orig.RecoilLeft();

public void RecoilRight () =>
orig.RecoilRight();

public void RecoilRightLong () =>
orig.RecoilRightLong();

public void RecoilLeftLong () =>
orig.RecoilLeftLong();

public void RecoilDown () =>
orig.RecoilDown();

public void ForceHardLanding () =>
orig.ForceHardLanding();

public void EnterSceneDreamGate () =>
orig.EnterSceneDreamGate();

public System.Collections.IEnumerator EnterScene (TransitionPoint enterGate, float delayBeforeEnter) =>
orig.EnterScene(enterGate, delayBeforeEnter);

public void LeaveScene (GlobalEnums.GatePosition? gate = null) =>
orig.LeaveScene(gate);

public System.Collections.IEnumerator BetaLeave (EndBeta betaEndTrigger) =>
orig.BetaLeave(betaEndTrigger);

public System.Collections.IEnumerator BetaReturn () =>
orig.BetaReturn();

public System.Collections.IEnumerator Respawn () =>
orig.Respawn();

public System.Collections.IEnumerator HazardRespawn () =>
orig.HazardRespawn();

public void StartCyclone () =>
orig.StartCyclone();

public void EndCyclone () =>
orig.EndCyclone();

public bool GetState (string stateName) =>
orig.GetState(stateName);

public bool GetCState (string stateName) =>
orig.GetCState(stateName);

public void SetCState (string stateName, bool value) =>
orig.SetCState(stateName, value);

public void ResetHardLandingTimer () =>
orig.ResetHardLandingTimer();

public void CancelSuperDash () =>
orig.CancelSuperDash();

public void RelinquishControlNotVelocity () =>
orig.RelinquishControlNotVelocity();

public void RelinquishControl () =>
orig.RelinquishControl();

public void RegainControl () =>
orig.RegainControl();

public void PreventCastByDialogueEnd () =>
orig.PreventCastByDialogueEnd();

public bool CanCast () =>
orig.CanCast();

public bool CanFocus () =>
orig.CanFocus();

public bool CanNailArt () =>
orig.CanNailArt();

public bool CanQuickMap () =>
orig.CanQuickMap();

public bool CanInspect () =>
orig.CanInspect();

public bool CanBackDash () =>
orig.CanBackDash();

public bool CanSuperDash () =>
orig.CanSuperDash();

public bool CanDreamNail () =>
orig.CanDreamNail();

public bool CanDreamGate () =>
orig.CanDreamGate();

public bool CanInteract () =>
orig.CanInteract();

public bool CanOpenInventory () =>
orig.CanOpenInventory();

public void SetDamageMode (int invincibilityType) =>
orig.SetDamageMode(invincibilityType);

public void SetDamageModeFSM (int invincibilityType) =>
orig.SetDamageModeFSM(invincibilityType);

public void ResetQuakeDamage () =>
orig.ResetQuakeDamage();

public void SetDamageMode (GlobalEnums.DamageMode newDamageMode) =>
orig.SetDamageMode(newDamageMode);

public void StopAnimationControl () =>
orig.StopAnimationControl();

public void StartAnimationControl () =>
orig.StartAnimationControl();

public void IgnoreInput () =>
orig.IgnoreInput();

public void IgnoreInputWithoutReset () =>
orig.IgnoreInputWithoutReset();

public void AcceptInput () =>
orig.AcceptInput();

public void Pause () =>
orig.Pause();

public void UnPause () =>
orig.UnPause();

public void NearBench (bool isNearBench) =>
orig.NearBench(isNearBench);

public void SetWalkZone (bool inWalkZone) =>
orig.SetWalkZone(inWalkZone);

public void ResetState () =>
orig.ResetState();

public void StopPlayingAudio () =>
orig.StopPlayingAudio();

public void PauseAudio () =>
orig.PauseAudio();

public void UnPauseAudio () =>
orig.UnPauseAudio();

public void PauseInput () =>
CallMethod();

public void UnPauseInput () =>
CallMethod();

public void SpawnSoftLandingPrefab () =>
orig.SpawnSoftLandingPrefab();

public void AffectedByGravity (bool gravityApplies) =>
orig.AffectedByGravity(gravityApplies);

public void LookForInput () =>
CallMethod();

public void LookForQueueInput () =>
CallMethod();

public void HeroJump () =>
CallMethod();

public void HeroJumpNoEffect () =>
CallMethod();

public void DoWallJump () =>
CallMethod();

public void DoDoubleJump () =>
CallMethod();

public void DoHardLanding () =>
CallMethod();

public void DoAttack () =>
CallMethod();

public void HeroDash () =>
CallMethod();

public void StartFallRumble () =>
CallMethod();

public void SetState (GlobalEnums.ActorStates newState) =>
CallMethod(new object[] {newState});

public void FinishedEnteringScene (bool setHazardMarker = true, bool preventRunBob = false) =>
CallMethod(new object[] {setHazardMarker, preventRunBob});

public System.Collections.IEnumerator Die () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator DieFromHazard (GlobalEnums.HazardType hazardType, float angle) =>
CallMethod<System.Collections.IEnumerator>(new object[] {hazardType, angle});

public System.Collections.IEnumerator StartRecoil (GlobalEnums.CollisionSide impactSide, bool spawnDamageEffect, int damageAmount) =>
CallMethod<System.Collections.IEnumerator>(new object[] {impactSide, spawnDamageEffect, damageAmount});

public System.Collections.IEnumerator Invulnerable (float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {duration});

public System.Collections.IEnumerator FirstFadeIn () =>
CallMethod<System.Collections.IEnumerator>();

public void FallCheck () =>
CallMethod();

public void OutOfBoundsCheck () =>
CallMethod();

public void ConfirmOutOfBounds () =>
CallMethod();

public void FailSafeChecks () =>
CallMethod();

public UnityEngine.Transform LocateSpawnPoint () =>
orig.LocateSpawnPoint();

public void CancelJump () =>
CallMethod();

public void CancelDoubleJump () =>
CallMethod();

public void CancelDash () =>
CallMethod();

public void CancelWallsliding () =>
CallMethod();

public void CancelBackDash () =>
CallMethod();

public void CancelDownAttack () =>
CallMethod();

public void CancelAttack () =>
CallMethod();

public void CancelBounce () =>
CallMethod();

public void CancelRecoilHorizontal () =>
CallMethod();

public void CancelDamageRecoil () =>
CallMethod();

public void CancelFallEffects () =>
CallMethod();

public void ResetAttacks () =>
CallMethod();

public void ResetAttacksDash () =>
CallMethod();

public void ResetMotion () =>
CallMethod();

public void ResetMotionNotVelocity () =>
CallMethod();

public void ResetLook () =>
CallMethod();

public void ResetInput () =>
CallMethod();

public void BackOnGround () =>
CallMethod();

public void JumpReleased () =>
CallMethod();

public void FinishedDashing () =>
CallMethod();

public void SetStartingMotionState () =>
CallMethod();

public void SetStartingMotionState (bool preventRunDip) =>
CallMethod(new object[] {preventRunDip});

public void EnterAcid () =>
CallMethod();

public void ExitAcid () =>
CallMethod();

public void TileMapTest () =>
CallMethod();

public System.Collections.IEnumerator TilemapTestPause () =>
CallMethod<System.Collections.IEnumerator>();

public void StopTilemapTest () =>
CallMethod();

public System.Collections.IEnumerator CheckForTerrainThunk (GlobalEnums.AttackDirection attackDir) =>
orig.CheckForTerrainThunk(attackDir);

public bool CheckStillTouchingWall (GlobalEnums.CollisionSide side, bool checkTop = false) =>
CallMethod<bool>(new object[] {side, checkTop});

public bool CheckForBump (GlobalEnums.CollisionSide side) =>
orig.CheckForBump(side);

public bool CheckNearRoof () =>
orig.CheckNearRoof();

public bool CheckTouchingGround () =>
orig.CheckTouchingGround();

public System.Collections.Generic.List<GlobalEnums.CollisionSide> CheckTouching (GlobalEnums.PhysLayers layer) =>
CallMethod<System.Collections.Generic.List<GlobalEnums.CollisionSide>>(new object[] {layer});

public System.Collections.Generic.List<GlobalEnums.CollisionSide> CheckTouchingAdvanced (GlobalEnums.PhysLayers layer) =>
CallMethod<System.Collections.Generic.List<GlobalEnums.CollisionSide>>(new object[] {layer});

public GlobalEnums.CollisionSide FindCollisionDirection (UnityEngine.Collision2D collision) =>
CallMethod<GlobalEnums.CollisionSide>(new object[] {collision});

public bool CanJump () =>
CallMethod<bool>();

public bool CanDoubleJump () =>
CallMethod<bool>();

public bool CanInfiniteAirJump () =>
CallMethod<bool>();

public bool CanSwim () =>
CallMethod<bool>();

public bool CanDash () =>
CallMethod<bool>();

public bool CanAttack () =>
CallMethod<bool>();

public bool CanNailCharge () =>
CallMethod<bool>();

public bool CanWallSlide () =>
CallMethod<bool>();

public bool CanTakeDamage () =>
CallMethod<bool>();

public bool CanWallJump () =>
CallMethod<bool>();

public bool ShouldHardLand (UnityEngine.Collision2D collision) =>
CallMethod<bool>(new object[] {collision});

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnCollisionStay2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnCollisionExit2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void SetupGameRefs () =>
CallMethod();

public void SetupPools () =>
CallMethod();

public void FilterInput () =>
CallMethod();

public UnityEngine.Vector3 FindGroundPoint (UnityEngine.Vector2 startPoint, bool useExtended = false) =>
orig.FindGroundPoint(startPoint, useExtended);

public float FindGroundPointY (float x, float y, bool useExtended = false) =>
CallMethod<float>(new object[] {x, y, useExtended});

public void orig_StartMPDrain (float time) =>
orig.orig_StartMPDrain(time);

public void orig_Update () =>
CallMethod();

public UnityEngine.Vector2 OrigDashVector () =>
CallMethod<UnityEngine.Vector2>();

public void orig_Dash () =>
CallMethod();

public void orig_CharmUpdate () =>
orig.orig_CharmUpdate();

public void orig_DoAttack () =>
CallMethod();

}
}
