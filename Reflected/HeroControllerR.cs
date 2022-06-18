namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class HeroControllerR
{
    public static bool verboseMode
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "verboseMode");
        set => ReflectionHelper.SetField(HeroController.instance, "verboseMode", value);
    }

    public static HeroType heroType
    {
        get => HeroController.instance.heroType;
        set => HeroController.instance.heroType = value;
    }

    public static float RUN_SPEED
    {
        get => HeroController.instance.RUN_SPEED;
        set => HeroController.instance.RUN_SPEED = value;
    }

    public static float RUN_SPEED_CH
    {
        get => HeroController.instance.RUN_SPEED_CH;
        set => HeroController.instance.RUN_SPEED_CH = value;
    }

    public static float RUN_SPEED_CH_COMBO
    {
        get => HeroController.instance.RUN_SPEED_CH_COMBO;
        set => HeroController.instance.RUN_SPEED_CH_COMBO = value;
    }

    public static float WALK_SPEED
    {
        get => HeroController.instance.WALK_SPEED;
        set => HeroController.instance.WALK_SPEED = value;
    }

    public static float UNDERWATER_SPEED
    {
        get => HeroController.instance.UNDERWATER_SPEED;
        set => HeroController.instance.UNDERWATER_SPEED = value;
    }

    public static float JUMP_SPEED
    {
        get => HeroController.instance.JUMP_SPEED;
        set => HeroController.instance.JUMP_SPEED = value;
    }

    public static float JUMP_SPEED_UNDERWATER
    {
        get => HeroController.instance.JUMP_SPEED_UNDERWATER;
        set => HeroController.instance.JUMP_SPEED_UNDERWATER = value;
    }

    public static float MIN_JUMP_SPEED
    {
        get => HeroController.instance.MIN_JUMP_SPEED;
        set => HeroController.instance.MIN_JUMP_SPEED = value;
    }

    public static int JUMP_STEPS
    {
        get => HeroController.instance.JUMP_STEPS;
        set => HeroController.instance.JUMP_STEPS = value;
    }

    public static int JUMP_STEPS_MIN
    {
        get => HeroController.instance.JUMP_STEPS_MIN;
        set => HeroController.instance.JUMP_STEPS_MIN = value;
    }

    public static int JUMP_TIME
    {
        get => HeroController.instance.JUMP_TIME;
        set => HeroController.instance.JUMP_TIME = value;
    }

    public static int DOUBLE_JUMP_STEPS
    {
        get => HeroController.instance.DOUBLE_JUMP_STEPS;
        set => HeroController.instance.DOUBLE_JUMP_STEPS = value;
    }

    public static int WJLOCK_STEPS_SHORT
    {
        get => HeroController.instance.WJLOCK_STEPS_SHORT;
        set => HeroController.instance.WJLOCK_STEPS_SHORT = value;
    }

    public static int WJLOCK_STEPS_LONG
    {
        get => HeroController.instance.WJLOCK_STEPS_LONG;
        set => HeroController.instance.WJLOCK_STEPS_LONG = value;
    }

    public static float WJ_KICKOFF_SPEED
    {
        get => HeroController.instance.WJ_KICKOFF_SPEED;
        set => HeroController.instance.WJ_KICKOFF_SPEED = value;
    }

    public static int WALL_STICKY_STEPS
    {
        get => HeroController.instance.WALL_STICKY_STEPS;
        set => HeroController.instance.WALL_STICKY_STEPS = value;
    }

    public static float DASH_SPEED
    {
        get => HeroController.instance.DASH_SPEED;
        set => HeroController.instance.DASH_SPEED = value;
    }

    public static float DASH_SPEED_SHARP
    {
        get => HeroController.instance.DASH_SPEED_SHARP;
        set => HeroController.instance.DASH_SPEED_SHARP = value;
    }

    public static float DASH_TIME
    {
        get => HeroController.instance.DASH_TIME;
        set => HeroController.instance.DASH_TIME = value;
    }

    public static int DASH_QUEUE_STEPS
    {
        get => HeroController.instance.DASH_QUEUE_STEPS;
        set => HeroController.instance.DASH_QUEUE_STEPS = value;
    }

    public static float BACK_DASH_SPEED
    {
        get => HeroController.instance.BACK_DASH_SPEED;
        set => HeroController.instance.BACK_DASH_SPEED = value;
    }

    public static float BACK_DASH_TIME
    {
        get => HeroController.instance.BACK_DASH_TIME;
        set => HeroController.instance.BACK_DASH_TIME = value;
    }

    public static float SHADOW_DASH_SPEED
    {
        get => HeroController.instance.SHADOW_DASH_SPEED;
        set => HeroController.instance.SHADOW_DASH_SPEED = value;
    }

    public static float SHADOW_DASH_TIME
    {
        get => HeroController.instance.SHADOW_DASH_TIME;
        set => HeroController.instance.SHADOW_DASH_TIME = value;
    }

    public static float SHADOW_DASH_COOLDOWN
    {
        get => HeroController.instance.SHADOW_DASH_COOLDOWN;
        set => HeroController.instance.SHADOW_DASH_COOLDOWN = value;
    }

    public static float SUPER_DASH_SPEED
    {
        get => HeroController.instance.SUPER_DASH_SPEED;
        set => HeroController.instance.SUPER_DASH_SPEED = value;
    }

    public static float DASH_COOLDOWN
    {
        get => HeroController.instance.DASH_COOLDOWN;
        set => HeroController.instance.DASH_COOLDOWN = value;
    }

    public static float DASH_COOLDOWN_CH
    {
        get => HeroController.instance.DASH_COOLDOWN_CH;
        set => HeroController.instance.DASH_COOLDOWN_CH = value;
    }

    public static float BACKDASH_COOLDOWN
    {
        get => HeroController.instance.BACKDASH_COOLDOWN;
        set => HeroController.instance.BACKDASH_COOLDOWN = value;
    }

    public static float WALLSLIDE_SPEED
    {
        get => HeroController.instance.WALLSLIDE_SPEED;
        set => HeroController.instance.WALLSLIDE_SPEED = value;
    }

    public static float WALLSLIDE_DECEL
    {
        get => HeroController.instance.WALLSLIDE_DECEL;
        set => HeroController.instance.WALLSLIDE_DECEL = value;
    }

    public static float NAIL_CHARGE_TIME_DEFAULT
    {
        get => HeroController.instance.NAIL_CHARGE_TIME_DEFAULT;
        set => HeroController.instance.NAIL_CHARGE_TIME_DEFAULT = value;
    }

    public static float NAIL_CHARGE_TIME_CHARM
    {
        get => HeroController.instance.NAIL_CHARGE_TIME_CHARM;
        set => HeroController.instance.NAIL_CHARGE_TIME_CHARM = value;
    }

    public static float CYCLONE_HORIZONTAL_SPEED
    {
        get => HeroController.instance.CYCLONE_HORIZONTAL_SPEED;
        set => HeroController.instance.CYCLONE_HORIZONTAL_SPEED = value;
    }

    public static float SWIM_ACCEL
    {
        get => HeroController.instance.SWIM_ACCEL;
        set => HeroController.instance.SWIM_ACCEL = value;
    }

    public static float SWIM_MAX_SPEED
    {
        get => HeroController.instance.SWIM_MAX_SPEED;
        set => HeroController.instance.SWIM_MAX_SPEED = value;
    }

    public static float TIME_TO_ENTER_SCENE_BOT
    {
        get => HeroController.instance.TIME_TO_ENTER_SCENE_BOT;
        set => HeroController.instance.TIME_TO_ENTER_SCENE_BOT = value;
    }

    public static float TIME_TO_ENTER_SCENE_HOR
    {
        get => HeroController.instance.TIME_TO_ENTER_SCENE_HOR;
        set => HeroController.instance.TIME_TO_ENTER_SCENE_HOR = value;
    }

    public static float SPEED_TO_ENTER_SCENE_HOR
    {
        get => HeroController.instance.SPEED_TO_ENTER_SCENE_HOR;
        set => HeroController.instance.SPEED_TO_ENTER_SCENE_HOR = value;
    }

    public static float SPEED_TO_ENTER_SCENE_UP
    {
        get => HeroController.instance.SPEED_TO_ENTER_SCENE_UP;
        set => HeroController.instance.SPEED_TO_ENTER_SCENE_UP = value;
    }

    public static float SPEED_TO_ENTER_SCENE_DOWN
    {
        get => HeroController.instance.SPEED_TO_ENTER_SCENE_DOWN;
        set => HeroController.instance.SPEED_TO_ENTER_SCENE_DOWN = value;
    }

    public static float DEFAULT_GRAVITY
    {
        get => HeroController.instance.DEFAULT_GRAVITY;
        set => HeroController.instance.DEFAULT_GRAVITY = value;
    }

    public static float UNDERWATER_GRAVITY
    {
        get => HeroController.instance.UNDERWATER_GRAVITY;
        set => HeroController.instance.UNDERWATER_GRAVITY = value;
    }

    public static float ATTACK_DURATION
    {
        get => HeroController.instance.ATTACK_DURATION;
        set => HeroController.instance.ATTACK_DURATION = value;
    }

    public static float ATTACK_DURATION_CH
    {
        get => HeroController.instance.ATTACK_DURATION_CH;
        set => HeroController.instance.ATTACK_DURATION_CH = value;
    }

    public static float ALT_ATTACK_RESET
    {
        get => HeroController.instance.ALT_ATTACK_RESET;
        set => HeroController.instance.ALT_ATTACK_RESET = value;
    }

    public static float ATTACK_RECOVERY_TIME
    {
        get => HeroController.instance.ATTACK_RECOVERY_TIME;
        set => HeroController.instance.ATTACK_RECOVERY_TIME = value;
    }

    public static float ATTACK_COOLDOWN_TIME
    {
        get => HeroController.instance.ATTACK_COOLDOWN_TIME;
        set => HeroController.instance.ATTACK_COOLDOWN_TIME = value;
    }

    public static float ATTACK_COOLDOWN_TIME_CH
    {
        get => HeroController.instance.ATTACK_COOLDOWN_TIME_CH;
        set => HeroController.instance.ATTACK_COOLDOWN_TIME_CH = value;
    }

    public static float BOUNCE_TIME
    {
        get => HeroController.instance.BOUNCE_TIME;
        set => HeroController.instance.BOUNCE_TIME = value;
    }

    public static float BOUNCE_SHROOM_TIME
    {
        get => HeroController.instance.BOUNCE_SHROOM_TIME;
        set => HeroController.instance.BOUNCE_SHROOM_TIME = value;
    }

    public static float BOUNCE_VELOCITY
    {
        get => HeroController.instance.BOUNCE_VELOCITY;
        set => HeroController.instance.BOUNCE_VELOCITY = value;
    }

    public static float SHROOM_BOUNCE_VELOCITY
    {
        get => HeroController.instance.SHROOM_BOUNCE_VELOCITY;
        set => HeroController.instance.SHROOM_BOUNCE_VELOCITY = value;
    }

    public static float RECOIL_HOR_TIME
    {
        get => HeroController.instance.RECOIL_HOR_TIME;
        set => HeroController.instance.RECOIL_HOR_TIME = value;
    }

    public static float RECOIL_HOR_VELOCITY
    {
        get => HeroController.instance.RECOIL_HOR_VELOCITY;
        set => HeroController.instance.RECOIL_HOR_VELOCITY = value;
    }

    public static float RECOIL_HOR_VELOCITY_LONG
    {
        get => HeroController.instance.RECOIL_HOR_VELOCITY_LONG;
        set => HeroController.instance.RECOIL_HOR_VELOCITY_LONG = value;
    }

    public static float RECOIL_HOR_STEPS
    {
        get => HeroController.instance.RECOIL_HOR_STEPS;
        set => HeroController.instance.RECOIL_HOR_STEPS = value;
    }

    public static float RECOIL_DOWN_VELOCITY
    {
        get => HeroController.instance.RECOIL_DOWN_VELOCITY;
        set => HeroController.instance.RECOIL_DOWN_VELOCITY = value;
    }

    public static float RUN_PUFF_TIME
    {
        get => HeroController.instance.RUN_PUFF_TIME;
        set => HeroController.instance.RUN_PUFF_TIME = value;
    }

    public static float BIG_FALL_TIME
    {
        get => HeroController.instance.BIG_FALL_TIME;
        set => HeroController.instance.BIG_FALL_TIME = value;
    }

    public static float HARD_LANDING_TIME
    {
        get => HeroController.instance.HARD_LANDING_TIME;
        set => HeroController.instance.HARD_LANDING_TIME = value;
    }

    public static float DOWN_DASH_TIME
    {
        get => HeroController.instance.DOWN_DASH_TIME;
        set => HeroController.instance.DOWN_DASH_TIME = value;
    }

    public static float MAX_FALL_VELOCITY
    {
        get => HeroController.instance.MAX_FALL_VELOCITY;
        set => HeroController.instance.MAX_FALL_VELOCITY = value;
    }

    public static float MAX_FALL_VELOCITY_UNDERWATER
    {
        get => HeroController.instance.MAX_FALL_VELOCITY_UNDERWATER;
        set => HeroController.instance.MAX_FALL_VELOCITY_UNDERWATER = value;
    }

    public static float RECOIL_DURATION
    {
        get => HeroController.instance.RECOIL_DURATION;
        set => HeroController.instance.RECOIL_DURATION = value;
    }

    public static float RECOIL_DURATION_STAL
    {
        get => HeroController.instance.RECOIL_DURATION_STAL;
        set => HeroController.instance.RECOIL_DURATION_STAL = value;
    }

    public static float RECOIL_VELOCITY
    {
        get => HeroController.instance.RECOIL_VELOCITY;
        set => HeroController.instance.RECOIL_VELOCITY = value;
    }

    public static float DAMAGE_FREEZE_DOWN
    {
        get => HeroController.instance.DAMAGE_FREEZE_DOWN;
        set => HeroController.instance.DAMAGE_FREEZE_DOWN = value;
    }

    public static float DAMAGE_FREEZE_WAIT
    {
        get => HeroController.instance.DAMAGE_FREEZE_WAIT;
        set => HeroController.instance.DAMAGE_FREEZE_WAIT = value;
    }

    public static float DAMAGE_FREEZE_UP
    {
        get => HeroController.instance.DAMAGE_FREEZE_UP;
        set => HeroController.instance.DAMAGE_FREEZE_UP = value;
    }

    public static float INVUL_TIME
    {
        get => HeroController.instance.INVUL_TIME;
        set => HeroController.instance.INVUL_TIME = value;
    }

    public static float INVUL_TIME_STAL
    {
        get => HeroController.instance.INVUL_TIME_STAL;
        set => HeroController.instance.INVUL_TIME_STAL = value;
    }

    public static float INVUL_TIME_PARRY
    {
        get => HeroController.instance.INVUL_TIME_PARRY;
        set => HeroController.instance.INVUL_TIME_PARRY = value;
    }

    public static float INVUL_TIME_QUAKE
    {
        get => HeroController.instance.INVUL_TIME_QUAKE;
        set => HeroController.instance.INVUL_TIME_QUAKE = value;
    }

    public static float INVUL_TIME_CYCLONE
    {
        get => HeroController.instance.INVUL_TIME_CYCLONE;
        set => HeroController.instance.INVUL_TIME_CYCLONE = value;
    }

    public static float CAST_TIME
    {
        get => HeroController.instance.CAST_TIME;
        set => HeroController.instance.CAST_TIME = value;
    }

    public static float CAST_RECOIL_TIME
    {
        get => HeroController.instance.CAST_RECOIL_TIME;
        set => HeroController.instance.CAST_RECOIL_TIME = value;
    }

    public static float CAST_RECOIL_VELOCITY
    {
        get => HeroController.instance.CAST_RECOIL_VELOCITY;
        set => HeroController.instance.CAST_RECOIL_VELOCITY = value;
    }

    public static float WALLSLIDE_CLIP_DELAY
    {
        get => HeroController.instance.WALLSLIDE_CLIP_DELAY;
        set => HeroController.instance.WALLSLIDE_CLIP_DELAY = value;
    }

    public static int GRUB_SOUL_MP
    {
        get => HeroController.instance.GRUB_SOUL_MP;
        set => HeroController.instance.GRUB_SOUL_MP = value;
    }

    public static int GRUB_SOUL_MP_COMBO
    {
        get => HeroController.instance.GRUB_SOUL_MP_COMBO;
        set => HeroController.instance.GRUB_SOUL_MP_COMBO = value;
    }

    public static int JUMP_QUEUE_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "JUMP_QUEUE_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "JUMP_QUEUE_STEPS", value);
    }

    public static int JUMP_RELEASE_QUEUE_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "JUMP_RELEASE_QUEUE_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "JUMP_RELEASE_QUEUE_STEPS", value);
    }

    public static int DOUBLE_JUMP_QUEUE_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "DOUBLE_JUMP_QUEUE_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "DOUBLE_JUMP_QUEUE_STEPS", value);
    }

    public static int ATTACK_QUEUE_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "ATTACK_QUEUE_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "ATTACK_QUEUE_STEPS", value);
    }

    public static float DELAY_BEFORE_ENTER
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "DELAY_BEFORE_ENTER");
        set => ReflectionHelper.SetField(HeroController.instance, "DELAY_BEFORE_ENTER", value);
    }

    public static float LOOK_DELAY
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "LOOK_DELAY");
        set => ReflectionHelper.SetField(HeroController.instance, "LOOK_DELAY", value);
    }

    public static float LOOK_ANIM_DELAY
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "LOOK_ANIM_DELAY");
        set => ReflectionHelper.SetField(HeroController.instance, "LOOK_ANIM_DELAY", value);
    }

    public static float DEATH_WAIT
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "DEATH_WAIT");
        set => ReflectionHelper.SetField(HeroController.instance, "DEATH_WAIT", value);
    }

    public static float HAZARD_DEATH_CHECK_TIME
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "HAZARD_DEATH_CHECK_TIME");
        set => ReflectionHelper.SetField(HeroController.instance, "HAZARD_DEATH_CHECK_TIME", value);
    }

    public static float FLOATING_CHECK_TIME
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "FLOATING_CHECK_TIME");
        set => ReflectionHelper.SetField(HeroController.instance, "FLOATING_CHECK_TIME", value);
    }

    public static float NAIL_TERRAIN_CHECK_TIME
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "NAIL_TERRAIN_CHECK_TIME");
        set => ReflectionHelper.SetField(HeroController.instance, "NAIL_TERRAIN_CHECK_TIME", value);
    }

    public static float BUMP_VELOCITY
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "BUMP_VELOCITY");
        set => ReflectionHelper.SetField(HeroController.instance, "BUMP_VELOCITY", value);
    }

    public static float BUMP_VELOCITY_DASH
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "BUMP_VELOCITY_DASH");
        set => ReflectionHelper.SetField(HeroController.instance, "BUMP_VELOCITY_DASH", value);
    }

    public static int LANDING_BUFFER_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "LANDING_BUFFER_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "LANDING_BUFFER_STEPS", value);
    }

    public static int LEDGE_BUFFER_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "LEDGE_BUFFER_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "LEDGE_BUFFER_STEPS", value);
    }

    public static int HEAD_BUMP_STEPS
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "HEAD_BUMP_STEPS");
        set => ReflectionHelper.SetField(HeroController.instance, "HEAD_BUMP_STEPS", value);
    }

    public static float MANTIS_CHARM_SCALE
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "MANTIS_CHARM_SCALE");
        set => ReflectionHelper.SetField(HeroController.instance, "MANTIS_CHARM_SCALE", value);
    }

    public static float FIND_GROUND_POINT_DISTANCE
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance,
            "FIND_GROUND_POINT_DISTANCE");
        set => ReflectionHelper.SetField(HeroController.instance, "FIND_GROUND_POINT_DISTANCE", value);
    }

    public static float FIND_GROUND_POINT_DISTANCE_EXT
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance,
            "FIND_GROUND_POINT_DISTANCE_EXT");
        set => ReflectionHelper.SetField(HeroController.instance, "FIND_GROUND_POINT_DISTANCE_EXT", value);
    }

    public static ActorStates hero_state
    {
        get => HeroController.instance.hero_state;
        set => HeroController.instance.hero_state = value;
    }

    public static ActorStates prev_hero_state
    {
        get => HeroController.instance.prev_hero_state;
        set => HeroController.instance.prev_hero_state = value;
    }

    public static HeroTransitionState transitionState
    {
        get => HeroController.instance.transitionState;
        set => HeroController.instance.transitionState = value;
    }

    public static DamageMode damageMode
    {
        get => HeroController.instance.damageMode;
        set => HeroController.instance.damageMode = value;
    }

    public static float move_input
    {
        get => HeroController.instance.move_input;
        set => HeroController.instance.move_input = value;
    }

    public static float vertical_input
    {
        get => HeroController.instance.vertical_input;
        set => HeroController.instance.vertical_input = value;
    }

    public static float controller_deadzone
    {
        get => HeroController.instance.controller_deadzone;
        set => HeroController.instance.controller_deadzone = value;
    }

    public static Vector2 current_velocity
    {
        get => HeroController.instance.current_velocity;
        set => HeroController.instance.current_velocity = value;
    }

    public static bool isGameplayScene
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "isGameplayScene");
        set => ReflectionHelper.SetField(HeroController.instance, "isGameplayScene", value);
    }

    public static bool isEnteringFirstLevel
    {
        get => HeroController.instance.isEnteringFirstLevel;
        set => HeroController.instance.isEnteringFirstLevel = value;
    }

    public static Vector2 slashOffset
    {
        get => HeroController.instance.slashOffset;
        set => HeroController.instance.slashOffset = value;
    }

    public static Vector2 upSlashOffset
    {
        get => HeroController.instance.upSlashOffset;
        set => HeroController.instance.upSlashOffset = value;
    }

    public static Vector2 downwardSlashOffset
    {
        get => HeroController.instance.downwardSlashOffset;
        set => HeroController.instance.downwardSlashOffset = value;
    }

    public static Vector2 spell1Offset
    {
        get => HeroController.instance.spell1Offset;
        set => HeroController.instance.spell1Offset = value;
    }

    public static int jump_steps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "jump_steps");
        set => ReflectionHelper.SetField(HeroController.instance, "jump_steps", value);
    }

    public static int jumped_steps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "jumped_steps");
        set => ReflectionHelper.SetField(HeroController.instance, "jumped_steps", value);
    }

    public static int doubleJump_steps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "doubleJump_steps");
        set => ReflectionHelper.SetField(HeroController.instance, "doubleJump_steps", value);
    }

    public static float dash_timer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "dash_timer");
        set => ReflectionHelper.SetField(HeroController.instance, "dash_timer", value);
    }

    public static float back_dash_timer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "back_dash_timer");
        set => ReflectionHelper.SetField(HeroController.instance, "back_dash_timer", value);
    }

    public static float shadow_dash_timer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "shadow_dash_timer");
        set => ReflectionHelper.SetField(HeroController.instance, "shadow_dash_timer", value);
    }

    public static float attack_time
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "attack_time");
        set => ReflectionHelper.SetField(HeroController.instance, "attack_time", value);
    }

    public static float attack_cooldown
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "attack_cooldown");
        set => ReflectionHelper.SetField(HeroController.instance, "attack_cooldown", value);
    }

    public static Vector2 transition_vel
    {
        get =>
            ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
                "transition_vel");
        set => ReflectionHelper.SetField(HeroController.instance, "transition_vel", value);
    }

    public static float altAttackTime
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "altAttackTime");
        set => ReflectionHelper.SetField(HeroController.instance, "altAttackTime", value);
    }

    public static float lookDelayTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "lookDelayTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "lookDelayTimer", value);
    }

    public static float bounceTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "bounceTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "bounceTimer", value);
    }

    public static float recoilHorizontalTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "recoilHorizontalTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "recoilHorizontalTimer", value);
    }

    public static float runPuffTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "runPuffTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "runPuffTimer", value);
    }

//manual edit
    public static float fallTimer
    {
        get => HeroController.instance.fallTimer;
        set => ReflectionHelper.SetProperty(HeroController.instance, "fallTimer", value);
    }

    public static float hardLandingTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "hardLandingTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "hardLandingTimer", value);
    }

    public static float dashLandingTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "dashLandingTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "dashLandingTimer", value);
    }

    public static float recoilTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "recoilTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "recoilTimer", value);
    }

    public static int recoilSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "recoilSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "recoilSteps", value);
    }

    public static int landingBufferSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "landingBufferSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "landingBufferSteps", value);
    }

    public static int dashQueueSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "dashQueueSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "dashQueueSteps", value);
    }

    public static bool dashQueuing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "dashQueuing");
        set => ReflectionHelper.SetField(HeroController.instance, "dashQueuing", value);
    }

    public static float shadowDashTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "shadowDashTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "shadowDashTimer", value);
    }

    public static float dashCooldownTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "dashCooldownTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "dashCooldownTimer", value);
    }

    public static float nailChargeTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "nailChargeTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "nailChargeTimer", value);
    }

    public static int wallLockSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "wallLockSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "wallLockSteps", value);
    }

    public static float wallslideClipTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "wallslideClipTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "wallslideClipTimer", value);
    }

    public static float hardLandFailSafeTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "hardLandFailSafeTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "hardLandFailSafeTimer", value);
    }

    public static float hazardDeathTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "hazardDeathTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "hazardDeathTimer", value);
    }

    public static float floatingBufferTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "floatingBufferTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "floatingBufferTimer", value);
    }

    public static float attackDuration
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "attackDuration");
        set => ReflectionHelper.SetField(HeroController.instance, "attackDuration", value);
    }

    public static float parryInvulnTimer
    {
        get => HeroController.instance.parryInvulnTimer;
        set => HeroController.instance.parryInvulnTimer = value;
    }

    public static GameObject slashPrefab
    {
        get => HeroController.instance.slashPrefab;
        set => HeroController.instance.slashPrefab = value;
    }

    public static GameObject slashAltPrefab
    {
        get => HeroController.instance.slashAltPrefab;
        set => HeroController.instance.slashAltPrefab = value;
    }

    public static GameObject upSlashPrefab
    {
        get => HeroController.instance.upSlashPrefab;
        set => HeroController.instance.upSlashPrefab = value;
    }

    public static GameObject downSlashPrefab
    {
        get => HeroController.instance.downSlashPrefab;
        set => HeroController.instance.downSlashPrefab = value;
    }

    public static GameObject wallSlashPrefab
    {
        get => HeroController.instance.wallSlashPrefab;
        set => HeroController.instance.wallSlashPrefab = value;
    }

    public static NailSlash normalSlash
    {
        get => HeroController.instance.normalSlash;
        set => HeroController.instance.normalSlash = value;
    }

    public static NailSlash alternateSlash
    {
        get => HeroController.instance.alternateSlash;
        set => HeroController.instance.alternateSlash = value;
    }

    public static NailSlash upSlash
    {
        get => HeroController.instance.upSlash;
        set => HeroController.instance.upSlash = value;
    }

    public static NailSlash downSlash
    {
        get => HeroController.instance.downSlash;
        set => HeroController.instance.downSlash = value;
    }

    public static NailSlash wallSlash
    {
        get => HeroController.instance.wallSlash;
        set => HeroController.instance.wallSlash = value;
    }

    public static PlayMakerFSM normalSlashFsm
    {
        get => HeroController.instance.normalSlashFsm;
        set => HeroController.instance.normalSlashFsm = value;
    }

    public static PlayMakerFSM alternateSlashFsm
    {
        get => HeroController.instance.alternateSlashFsm;
        set => HeroController.instance.alternateSlashFsm = value;
    }

    public static PlayMakerFSM upSlashFsm
    {
        get => HeroController.instance.upSlashFsm;
        set => HeroController.instance.upSlashFsm = value;
    }

    public static PlayMakerFSM downSlashFsm
    {
        get => HeroController.instance.downSlashFsm;
        set => HeroController.instance.downSlashFsm = value;
    }

    public static PlayMakerFSM wallSlashFsm
    {
        get => HeroController.instance.wallSlashFsm;
        set => HeroController.instance.wallSlashFsm = value;
    }

    public static GameObject nailTerrainImpactEffectPrefab
    {
        get => HeroController.instance.nailTerrainImpactEffectPrefab;
        set => HeroController.instance.nailTerrainImpactEffectPrefab = value;
    }

    public static GameObject spell1Prefab
    {
        get => HeroController.instance.spell1Prefab;
        set => HeroController.instance.spell1Prefab = value;
    }

    public static GameObject takeHitPrefab
    {
        get => HeroController.instance.takeHitPrefab;
        set => HeroController.instance.takeHitPrefab = value;
    }

    public static GameObject takeHitDoublePrefab
    {
        get => HeroController.instance.takeHitDoublePrefab;
        set => HeroController.instance.takeHitDoublePrefab = value;
    }

    public static GameObject softLandingEffectPrefab
    {
        get => HeroController.instance.softLandingEffectPrefab;
        set => HeroController.instance.softLandingEffectPrefab = value;
    }

    public static GameObject hardLandingEffectPrefab
    {
        get => HeroController.instance.hardLandingEffectPrefab;
        set => HeroController.instance.hardLandingEffectPrefab = value;
    }

    public static GameObject runEffectPrefab
    {
        get => HeroController.instance.runEffectPrefab;
        set => HeroController.instance.runEffectPrefab = value;
    }

    public static GameObject backDashPrefab
    {
        get => HeroController.instance.backDashPrefab;
        set => HeroController.instance.backDashPrefab = value;
    }

    public static GameObject jumpEffectPrefab
    {
        get => HeroController.instance.jumpEffectPrefab;
        set => HeroController.instance.jumpEffectPrefab = value;
    }

    public static GameObject jumpTrailPrefab
    {
        get => HeroController.instance.jumpTrailPrefab;
        set => HeroController.instance.jumpTrailPrefab = value;
    }

    public static GameObject fallEffectPrefab
    {
        get => HeroController.instance.fallEffectPrefab;
        set => HeroController.instance.fallEffectPrefab = value;
    }

    public static ParticleSystem wallslideDustPrefab
    {
        get => HeroController.instance.wallslideDustPrefab;
        set => HeroController.instance.wallslideDustPrefab = value;
    }

    public static GameObject artChargeEffect
    {
        get => HeroController.instance.artChargeEffect;
        set => HeroController.instance.artChargeEffect = value;
    }

    public static GameObject artChargedEffect
    {
        get => HeroController.instance.artChargedEffect;
        set => HeroController.instance.artChargedEffect = value;
    }

    public static GameObject artChargedFlash
    {
        get => HeroController.instance.artChargedFlash;
        set => HeroController.instance.artChargedFlash = value;
    }

    public static tk2dSpriteAnimator artChargedEffectAnim
    {
        get => HeroController.instance.artChargedEffectAnim;
        set => HeroController.instance.artChargedEffectAnim = value;
    }

    public static GameObject shadowdashBurstPrefab
    {
        get => HeroController.instance.shadowdashBurstPrefab;
        set => HeroController.instance.shadowdashBurstPrefab = value;
    }

    public static GameObject shadowdashDownBurstPrefab
    {
        get => HeroController.instance.shadowdashDownBurstPrefab;
        set => HeroController.instance.shadowdashDownBurstPrefab = value;
    }

    public static GameObject dashParticlesPrefab
    {
        get => HeroController.instance.dashParticlesPrefab;
        set => HeroController.instance.dashParticlesPrefab = value;
    }

    public static GameObject shadowdashParticlesPrefab
    {
        get => HeroController.instance.shadowdashParticlesPrefab;
        set => HeroController.instance.shadowdashParticlesPrefab = value;
    }

    public static GameObject shadowRingPrefab
    {
        get => HeroController.instance.shadowRingPrefab;
        set => HeroController.instance.shadowRingPrefab = value;
    }

    public static GameObject shadowRechargePrefab
    {
        get => HeroController.instance.shadowRechargePrefab;
        set => HeroController.instance.shadowRechargePrefab = value;
    }

    public static GameObject dJumpWingsPrefab
    {
        get => HeroController.instance.dJumpWingsPrefab;
        set => HeroController.instance.dJumpWingsPrefab = value;
    }

    public static GameObject dJumpFlashPrefab
    {
        get => HeroController.instance.dJumpFlashPrefab;
        set => HeroController.instance.dJumpFlashPrefab = value;
    }

    public static ParticleSystem dJumpFeathers
    {
        get => HeroController.instance.dJumpFeathers;
        set => HeroController.instance.dJumpFeathers = value;
    }

    public static GameObject wallPuffPrefab
    {
        get => HeroController.instance.wallPuffPrefab;
        set => HeroController.instance.wallPuffPrefab = value;
    }

    public static GameObject sharpShadowPrefab
    {
        get => HeroController.instance.sharpShadowPrefab;
        set => HeroController.instance.sharpShadowPrefab = value;
    }

    public static GameObject grubberFlyBeamPrefabL
    {
        get => HeroController.instance.grubberFlyBeamPrefabL;
        set => HeroController.instance.grubberFlyBeamPrefabL = value;
    }

    public static GameObject grubberFlyBeamPrefabR
    {
        get => HeroController.instance.grubberFlyBeamPrefabR;
        set => HeroController.instance.grubberFlyBeamPrefabR = value;
    }

    public static GameObject grubberFlyBeamPrefabU
    {
        get => HeroController.instance.grubberFlyBeamPrefabU;
        set => HeroController.instance.grubberFlyBeamPrefabU = value;
    }

    public static GameObject grubberFlyBeamPrefabD
    {
        get => HeroController.instance.grubberFlyBeamPrefabD;
        set => HeroController.instance.grubberFlyBeamPrefabD = value;
    }

    public static GameObject grubberFlyBeamPrefabL_fury
    {
        get => HeroController.instance.grubberFlyBeamPrefabL_fury;
        set => HeroController.instance.grubberFlyBeamPrefabL_fury = value;
    }

    public static GameObject grubberFlyBeamPrefabR_fury
    {
        get => HeroController.instance.grubberFlyBeamPrefabR_fury;
        set => HeroController.instance.grubberFlyBeamPrefabR_fury = value;
    }

    public static GameObject grubberFlyBeamPrefabU_fury
    {
        get => HeroController.instance.grubberFlyBeamPrefabU_fury;
        set => HeroController.instance.grubberFlyBeamPrefabU_fury = value;
    }

    public static GameObject grubberFlyBeamPrefabD_fury
    {
        get => HeroController.instance.grubberFlyBeamPrefabD_fury;
        set => HeroController.instance.grubberFlyBeamPrefabD_fury = value;
    }

    public static GameObject carefreeShield
    {
        get => HeroController.instance.carefreeShield;
        set => HeroController.instance.carefreeShield = value;
    }

    public static GameObject corpsePrefab
    {
        get => HeroController.instance.corpsePrefab;
        set => HeroController.instance.corpsePrefab = value;
    }

    public static GameObject spikeDeathPrefab
    {
        get => HeroController.instance.spikeDeathPrefab;
        set => HeroController.instance.spikeDeathPrefab = value;
    }

    public static GameObject acidDeathPrefab
    {
        get => HeroController.instance.acidDeathPrefab;
        set => HeroController.instance.acidDeathPrefab = value;
    }

    public static GameObject lavaDeathPrefab
    {
        get => HeroController.instance.lavaDeathPrefab;
        set => HeroController.instance.lavaDeathPrefab = value;
    }

    public static GameObject heroDeathPrefab
    {
        get => HeroController.instance.heroDeathPrefab;
        set => HeroController.instance.heroDeathPrefab = value;
    }

    public static GameObject cutscenePrefab
    {
        get => HeroController.instance.cutscenePrefab;
        set => HeroController.instance.cutscenePrefab = value;
    }

    public static GameManager gm
    {
        get => ReflectionHelper.GetField<HeroController, GameManager>(HeroController.instance, "gm");
        set => ReflectionHelper.SetField(HeroController.instance, "gm", value);
    }

    public static Rigidbody2D rb2d
    {
        get => ReflectionHelper.GetField<HeroController, Rigidbody2D>(HeroController.instance, "rb2d");
        set => ReflectionHelper.SetField(HeroController.instance, "rb2d", value);
    }

    public static Collider2D col2d
    {
        get => ReflectionHelper.GetField<HeroController, Collider2D>(HeroController.instance, "col2d");
        set => ReflectionHelper.SetField(HeroController.instance, "col2d", value);
    }

    public static MeshRenderer renderer
    {
        get => ReflectionHelper.GetField<HeroController, MeshRenderer>(HeroController.instance,
            "renderer");
        set => ReflectionHelper.SetField(HeroController.instance, "renderer", value);
    }

    public static Transform transform
    {
        get => ReflectionHelper.GetField<HeroController, Transform>(HeroController.instance,
            "transform");
        set => ReflectionHelper.SetField(HeroController.instance, "transform", value);
    }

    public static HeroAnimationController animCtrl
    {
        get => ReflectionHelper.GetField<HeroController, HeroAnimationController>(HeroController.instance,
            "animCtrl");
        set => ReflectionHelper.SetField(HeroController.instance, "animCtrl", value);
    }

    public static HeroControllerStates cState
    {
        get => HeroController.instance.cState;
        set => HeroController.instance.cState = value;
    }

    public static PlayerData playerData
    {
        get => HeroController.instance.playerData;
        set => HeroController.instance.playerData = value;
    }

    public static HeroAudioController audioCtrl
    {
        get => ReflectionHelper.GetField<HeroController, HeroAudioController>(HeroController.instance, "audioCtrl");
        set => ReflectionHelper.SetField(HeroController.instance, "audioCtrl", value);
    }

    public static AudioSource audioSource
    {
        get => ReflectionHelper.GetField<HeroController, AudioSource>(HeroController.instance,
            "audioSource");
        set => ReflectionHelper.SetField(HeroController.instance, "audioSource", value);
    }

    public static UIManager ui
    {
        get => HeroController.instance.ui;
        set => HeroController.instance.ui = value;
    }

    public static InputHandler inputHandler
    {
        get => ReflectionHelper.GetField<HeroController, InputHandler>(HeroController.instance, "inputHandler");
        set => ReflectionHelper.SetField(HeroController.instance, "inputHandler", value);
    }

    //manual edit
    public static GeoCounter geoCounter
    {
        get => HeroController.instance.geoCounter;
        set => ReflectionHelper.SetProperty(HeroController.instance, "geoCounter", value);
    }

    //manual edit
    public static PlayMakerFSM proxyFSM
    {
        get => HeroController.instance.proxyFSM;
        set => ReflectionHelper.SetProperty(HeroController.instance, "proxyFSM", value);
    }

    public static PlayMakerFSM damageEffectFSM
    {
        get => HeroController.instance.damageEffectFSM;
        set => HeroController.instance.damageEffectFSM = value;
    }

    public static ParticleSystem dashParticleSystem
    {
        get => ReflectionHelper.GetField<HeroController, ParticleSystem>(HeroController.instance,
            "dashParticleSystem");
        set => ReflectionHelper.SetField(HeroController.instance, "dashParticleSystem", value);
    }

    public static InvulnerablePulse invPulse
    {
        get => ReflectionHelper.GetField<HeroController, InvulnerablePulse>(HeroController.instance, "invPulse");
        set => ReflectionHelper.SetField(HeroController.instance, "invPulse", value);
    }

    public static SpriteFlash spriteFlash
    {
        get => ReflectionHelper.GetField<HeroController, SpriteFlash>(HeroController.instance, "spriteFlash");
        set => ReflectionHelper.SetField(HeroController.instance, "spriteFlash", value);
    }

    public static AudioSource footStepsRunAudioSource
    {
        get => HeroController.instance.footStepsRunAudioSource;
        set => HeroController.instance.footStepsRunAudioSource = value;
    }

    public static AudioSource footStepsWalkAudioSource
    {
        get => HeroController.instance.footStepsWalkAudioSource;
        set => HeroController.instance.footStepsWalkAudioSource = value;
    }

    public static float prevGravityScale
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "prevGravityScale");
        set => ReflectionHelper.SetField(HeroController.instance, "prevGravityScale", value);
    }

    public static Vector2 recoilVector
    {
        get => ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
            "recoilVector");
        set => ReflectionHelper.SetField(HeroController.instance, "recoilVector", value);
    }

    public static Vector2 lastInputState
    {
        get =>
            ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
                "lastInputState");
        set => ReflectionHelper.SetField(HeroController.instance, "lastInputState", value);
    }

    public static GatePosition gatePosition
    {
        get => HeroController.instance.gatePosition;
        set => HeroController.instance.gatePosition = value;
    }

    //manual edit
    public static TransitionPoint sceneEntryGate
    {
        get => HeroController.instance.sceneEntryGate;
        set => ReflectionHelper.SetProperty(HeroController.instance, "sceneEntryGate", value);
    }

    //manual edit
    public static bool IsDreamReturning => HeroController.instance.IsDreamReturning;

    //vanilla has no setter so this shouldnt have one too
    public static bool runMsgSent
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "runMsgSent");
        set => ReflectionHelper.SetField(HeroController.instance, "runMsgSent", value);
    }

    public static bool hardLanded
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "hardLanded");
        set => ReflectionHelper.SetField(HeroController.instance, "hardLanded", value);
    }

    public static bool fallRumble
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "fallRumble");
        set => ReflectionHelper.SetField(HeroController.instance, "fallRumble", value);
    }

    public static bool acceptingInput
    {
        get => HeroController.instance.acceptingInput;
        set => HeroController.instance.acceptingInput = value;
    }

    public static bool fallTrailGenerated
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "fallTrailGenerated");
        set => ReflectionHelper.SetField(HeroController.instance, "fallTrailGenerated", value);
    }

    public static bool drainMP
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "drainMP");
        set => ReflectionHelper.SetField(HeroController.instance, "drainMP", value);
    }

    public static float drainMP_timer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "drainMP_timer");
        set => ReflectionHelper.SetField(HeroController.instance, "drainMP_timer", value);
    }

    public static float drainMP_time
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "drainMP_time");
        set => ReflectionHelper.SetField(HeroController.instance, "drainMP_time", value);
    }

    public static float MP_drained
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "MP_drained");
        set => ReflectionHelper.SetField(HeroController.instance, "MP_drained", value);
    }

    public static float drainMP_seconds
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "drainMP_seconds");
        set => ReflectionHelper.SetField(HeroController.instance, "drainMP_seconds", value);
    }

    public static float focusMP_amount
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "focusMP_amount");
        set => ReflectionHelper.SetField(HeroController.instance, "focusMP_amount", value);
    }

    public static float dashBumpCorrection
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "dashBumpCorrection");
        set => ReflectionHelper.SetField(HeroController.instance, "dashBumpCorrection", value);
    }

    public static bool controlReqlinquished
    {
        get => HeroController.instance.controlReqlinquished;
        set => HeroController.instance.controlReqlinquished = value;
    }

    public static bool enterWithoutInput
    {
        get => HeroController.instance.enterWithoutInput;
        set => HeroController.instance.enterWithoutInput = value;
    }

    public static bool lookingUpAnim
    {
        get => HeroController.instance.lookingUpAnim;
        set => HeroController.instance.lookingUpAnim = value;
    }

    public static bool lookingDownAnim
    {
        get => HeroController.instance.lookingDownAnim;
        set => HeroController.instance.lookingDownAnim = value;
    }

    public static bool carefreeShieldEquipped
    {
        get => HeroController.instance.carefreeShieldEquipped;
        set => HeroController.instance.carefreeShieldEquipped = value;
    }

    public static int hitsSinceShielded
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "hitsSinceShielded");
        set => ReflectionHelper.SetField(HeroController.instance, "hitsSinceShielded", value);
    }

    public static EndBeta endBeta
    {
        get => ReflectionHelper.GetField<HeroController, EndBeta>(HeroController.instance, "endBeta");
        set => ReflectionHelper.SetField(HeroController.instance, "endBeta", value);
    }

    public static int jumpQueueSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "jumpQueueSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpQueueSteps", value);
    }

    public static bool jumpQueuing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "jumpQueuing");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpQueuing", value);
    }

    public static int doubleJumpQueueSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "doubleJumpQueueSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "doubleJumpQueueSteps", value);
    }

    public static bool doubleJumpQueuing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "doubleJumpQueuing");
        set => ReflectionHelper.SetField(HeroController.instance, "doubleJumpQueuing", value);
    }

    public static int jumpReleaseQueueSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "jumpReleaseQueueSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpReleaseQueueSteps", value);
    }

    public static bool jumpReleaseQueuing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "jumpReleaseQueuing");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpReleaseQueuing", value);
    }

    public static int attackQueueSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "attackQueueSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "attackQueueSteps", value);
    }

    public static bool attackQueuing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "attackQueuing");
        set => ReflectionHelper.SetField(HeroController.instance, "attackQueuing", value);
    }

    public static bool touchingWallL
    {
        get => HeroController.instance.touchingWallL;
        set => HeroController.instance.touchingWallL = value;
    }

    public static bool touchingWallR
    {
        get => HeroController.instance.touchingWallR;
        set => HeroController.instance.touchingWallR = value;
    }

    public static bool wallSlidingL
    {
        get => HeroController.instance.wallSlidingL;
        set => HeroController.instance.wallSlidingL = value;
    }

    public static bool wallSlidingR
    {
        get => HeroController.instance.wallSlidingR;
        set => HeroController.instance.wallSlidingR = value;
    }

    public static bool airDashed
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "airDashed");
        set => ReflectionHelper.SetField(HeroController.instance, "airDashed", value);
    }

    public static bool dashingDown
    {
        get => HeroController.instance.dashingDown;
        set => HeroController.instance.dashingDown = value;
    }

    public static bool wieldingLantern
    {
        get => HeroController.instance.wieldingLantern;
        set => HeroController.instance.wieldingLantern = value;
    }

    public static bool startWithWallslide
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "startWithWallslide");
        set => ReflectionHelper.SetField(HeroController.instance, "startWithWallslide", value);
    }

    public static bool startWithJump
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "startWithJump");
        set => ReflectionHelper.SetField(HeroController.instance, "startWithJump", value);
    }

    public static bool startWithFullJump
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "startWithFullJump");
        set => ReflectionHelper.SetField(HeroController.instance, "startWithFullJump", value);
    }

    public static bool startWithDash
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "startWithDash");
        set => ReflectionHelper.SetField(HeroController.instance, "startWithDash", value);
    }

    public static bool startWithAttack
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "startWithAttack");
        set => ReflectionHelper.SetField(HeroController.instance, "startWithAttack", value);
    }

    public static bool nailArt_cyclone
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "nailArt_cyclone");
        set => ReflectionHelper.SetField(HeroController.instance, "nailArt_cyclone", value);
    }

    public static bool wallSlashing
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "wallSlashing");
        set => ReflectionHelper.SetField(HeroController.instance, "wallSlashing", value);
    }

    public static bool doubleJumped
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "doubleJumped");
        set => ReflectionHelper.SetField(HeroController.instance, "doubleJumped", value);
    }

    public static bool inAcid
    {
        get => HeroController.instance.inAcid;
        set => HeroController.instance.inAcid = value;
    }

    public static bool wallJumpedR
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "wallJumpedR");
        set => ReflectionHelper.SetField(HeroController.instance, "wallJumpedR", value);
    }

    public static bool wallJumpedL
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "wallJumpedL");
        set => ReflectionHelper.SetField(HeroController.instance, "wallJumpedL", value);
    }

    public static bool wallLocked
    {
        get => HeroController.instance.wallLocked;
        set => HeroController.instance.wallLocked = value;
    }

    public static float currentWalljumpSpeed
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "currentWalljumpSpeed");
        set => ReflectionHelper.SetField(HeroController.instance, "currentWalljumpSpeed", value);
    }

    public static float walljumpSpeedDecel
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "walljumpSpeedDecel");
        set => ReflectionHelper.SetField(HeroController.instance, "walljumpSpeedDecel", value);
    }

    public static int wallUnstickSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "wallUnstickSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "wallUnstickSteps", value);
    }

    public static bool recoilLarge
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "recoilLarge");
        set => ReflectionHelper.SetField(HeroController.instance, "recoilLarge", value);
    }

    public static float conveyorSpeed
    {
        get => HeroController.instance.conveyorSpeed;
        set => HeroController.instance.conveyorSpeed = value;
    }

    public static float conveyorSpeedV
    {
        get => HeroController.instance.conveyorSpeedV;
        set => HeroController.instance.conveyorSpeedV = value;
    }

    public static bool enteringVertically
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "enteringVertically");
        set => ReflectionHelper.SetField(HeroController.instance, "enteringVertically", value);
    }

    public static bool playingWallslideClip
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "playingWallslideClip");
        set => ReflectionHelper.SetField(HeroController.instance, "playingWallslideClip", value);
    }

    public static bool playedMantisClawClip
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "playedMantisClawClip");
        set => ReflectionHelper.SetField(HeroController.instance, "playedMantisClawClip", value);
    }

    public static bool exitedSuperDashing
    {
        get => HeroController.instance.exitedSuperDashing;
        set => HeroController.instance.exitedSuperDashing = value;
    }

    public static bool exitedQuake
    {
        get => HeroController.instance.exitedQuake;
        set => HeroController.instance.exitedQuake = value;
    }

    public static bool fallCheckFlagged
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "fallCheckFlagged");
        set => ReflectionHelper.SetField(HeroController.instance, "fallCheckFlagged", value);
    }

    public static int ledgeBufferSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "ledgeBufferSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "ledgeBufferSteps", value);
    }

    public static int headBumpSteps
    {
        get => ReflectionHelper.GetField<HeroController, int>(HeroController.instance, "headBumpSteps");
        set => ReflectionHelper.SetField(HeroController.instance, "headBumpSteps", value);
    }

    public static float nailChargeTime
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance, "nailChargeTime");
        set => ReflectionHelper.SetField(HeroController.instance, "nailChargeTime", value);
    }

    public static bool takeNoDamage
    {
        get => HeroController.instance.takeNoDamage;
        set => HeroController.instance.takeNoDamage = value;
    }

    public static bool joniBeam
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "joniBeam");
        set => ReflectionHelper.SetField(HeroController.instance, "joniBeam", value);
    }

    public static bool fadedSceneIn
    {
        get => HeroController.instance.fadedSceneIn;
        set => HeroController.instance.fadedSceneIn = value;
    }

    public static bool stopWalkingOut
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "stopWalkingOut");
        set => ReflectionHelper.SetField(HeroController.instance, "stopWalkingOut", value);
    }

    public static bool boundsChecking
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "boundsChecking");
        set => ReflectionHelper.SetField(HeroController.instance, "boundsChecking", value);
    }

    public static bool blockerFix
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "blockerFix");
        set => ReflectionHelper.SetField(HeroController.instance, "blockerFix", value);
    }

    public static Vector2[] positionHistory
    {
        get => ReflectionHelper.GetField<HeroController, Vector2[]>(HeroController.instance,
            "positionHistory");
        set => ReflectionHelper.SetField(HeroController.instance, "positionHistory", value);
    }

    public static bool tilemapTestActive
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance, "tilemapTestActive");
        set => ReflectionHelper.SetField(HeroController.instance, "tilemapTestActive", value);
    }

    public static Vector2 groundRayOriginC
    {
        get => ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
            "groundRayOriginC");
        set => ReflectionHelper.SetField(HeroController.instance, "groundRayOriginC", value);
    }

    public static Vector2 groundRayOriginL
    {
        get => ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
            "groundRayOriginL");
        set => ReflectionHelper.SetField(HeroController.instance, "groundRayOriginL", value);
    }

    public static Vector2 groundRayOriginR
    {
        get => ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance,
            "groundRayOriginR");
        set => ReflectionHelper.SetField(HeroController.instance, "groundRayOriginR", value);
    }

    public static Coroutine takeDamageCoroutine
    {
        get => ReflectionHelper.GetField<HeroController, Coroutine>(HeroController.instance,
            "takeDamageCoroutine");
        set => ReflectionHelper.SetField(HeroController.instance, "takeDamageCoroutine", value);
    }

    public static Coroutine tilemapTestCoroutine
    {
        get => ReflectionHelper.GetField<HeroController, Coroutine>(HeroController.instance,
            "tilemapTestCoroutine");
        set => ReflectionHelper.SetField(HeroController.instance, "tilemapTestCoroutine", value);
    }

    public static AudioClip footstepsRunDust
    {
        get => HeroController.instance.footstepsRunDust;
        set => HeroController.instance.footstepsRunDust = value;
    }

    public static AudioClip footstepsRunGrass
    {
        get => HeroController.instance.footstepsRunGrass;
        set => HeroController.instance.footstepsRunGrass = value;
    }

    public static AudioClip footstepsRunBone
    {
        get => HeroController.instance.footstepsRunBone;
        set => HeroController.instance.footstepsRunBone = value;
    }

    public static AudioClip footstepsRunSpa
    {
        get => HeroController.instance.footstepsRunSpa;
        set => HeroController.instance.footstepsRunSpa = value;
    }

    public static AudioClip footstepsRunMetal
    {
        get => HeroController.instance.footstepsRunMetal;
        set => HeroController.instance.footstepsRunMetal = value;
    }

    public static AudioClip footstepsRunWater
    {
        get => HeroController.instance.footstepsRunWater;
        set => HeroController.instance.footstepsRunWater = value;
    }

    public static AudioClip footstepsWalkDust
    {
        get => HeroController.instance.footstepsWalkDust;
        set => HeroController.instance.footstepsWalkDust = value;
    }

    public static AudioClip footstepsWalkGrass
    {
        get => HeroController.instance.footstepsWalkGrass;
        set => HeroController.instance.footstepsWalkGrass = value;
    }

    public static AudioClip footstepsWalkBone
    {
        get => HeroController.instance.footstepsWalkBone;
        set => HeroController.instance.footstepsWalkBone = value;
    }

    public static AudioClip footstepsWalkSpa
    {
        get => HeroController.instance.footstepsWalkSpa;
        set => HeroController.instance.footstepsWalkSpa = value;
    }

    public static AudioClip footstepsWalkMetal
    {
        get => HeroController.instance.footstepsWalkMetal;
        set => HeroController.instance.footstepsWalkMetal = value;
    }

    public static AudioClip nailArtCharge
    {
        get => HeroController.instance.nailArtCharge;
        set => HeroController.instance.nailArtCharge = value;
    }

    public static AudioClip nailArtChargeComplete
    {
        get => HeroController.instance.nailArtChargeComplete;
        set => HeroController.instance.nailArtChargeComplete = value;
    }

    public static AudioClip blockerImpact
    {
        get => HeroController.instance.blockerImpact;
        set => HeroController.instance.blockerImpact = value;
    }

    public static AudioClip shadowDashClip
    {
        get => HeroController.instance.shadowDashClip;
        set => HeroController.instance.shadowDashClip = value;
    }

    public static AudioClip sharpShadowClip
    {
        get => HeroController.instance.sharpShadowClip;
        set => HeroController.instance.sharpShadowClip = value;
    }

    public static AudioClip doubleJumpClip
    {
        get => HeroController.instance.doubleJumpClip;
        set => HeroController.instance.doubleJumpClip = value;
    }

    public static AudioClip mantisClawClip
    {
        get => HeroController.instance.mantisClawClip;
        set => HeroController.instance.mantisClawClip = value;
    }

    public static GameObject slash
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance, "slash");
        set => ReflectionHelper.SetField(HeroController.instance, "slash", value);
    }

    public static NailSlash slashComponent
    {
        get => ReflectionHelper.GetField<HeroController, NailSlash>(HeroController.instance, "slashComponent");
        set => ReflectionHelper.SetField(HeroController.instance, "slashComponent", value);
    }

    public static PlayMakerFSM slashFsm
    {
        get => ReflectionHelper.GetField<HeroController, PlayMakerFSM>(HeroController.instance, "slashFsm");
        set => ReflectionHelper.SetField(HeroController.instance, "slashFsm", value);
    }

    public static GameObject runEffect
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "runEffect");
        set => ReflectionHelper.SetField(HeroController.instance, "runEffect", value);
    }

    public static GameObject backDash
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "backDash");
        set => ReflectionHelper.SetField(HeroController.instance, "backDash", value);
    }

    public static GameObject jumpEffect
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "jumpEffect");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpEffect", value);
    }

    public static GameObject fallEffect
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "fallEffect");
        set => ReflectionHelper.SetField(HeroController.instance, "fallEffect", value);
    }

    public static GameObject dashEffect
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "dashEffect");
        set => ReflectionHelper.SetField(HeroController.instance, "dashEffect", value);
    }

    public static GameObject grubberFlyBeam
    {
        get => ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
            "grubberFlyBeam");
        set => ReflectionHelper.SetField(HeroController.instance, "grubberFlyBeam", value);
    }

    public static GameObject hazardCorpe
    {
        get =>
            ReflectionHelper.GetField<HeroController, GameObject>(HeroController.instance,
                "hazardCorpe");
        set => ReflectionHelper.SetField(HeroController.instance, "hazardCorpe", value);
    }

    public static PlayMakerFSM vignetteFSM
    {
        get => HeroController.instance.vignetteFSM;
        set => HeroController.instance.vignetteFSM = value;
    }

    public static SpriteRenderer heroLight
    {
        get => HeroController.instance.heroLight;
        set => HeroController.instance.heroLight = value;
    }

    public static SpriteRenderer vignette
    {
        get => HeroController.instance.vignette;
        set => HeroController.instance.vignette = value;
    }

    public static PlayMakerFSM dashBurst
    {
        get => HeroController.instance.dashBurst;
        set => HeroController.instance.dashBurst = value;
    }

    public static PlayMakerFSM superDash
    {
        get => HeroController.instance.superDash;
        set => HeroController.instance.superDash = value;
    }

    public static PlayMakerFSM fsm_thornCounter
    {
        get => HeroController.instance.fsm_thornCounter;
        set => HeroController.instance.fsm_thornCounter = value;
    }

    public static PlayMakerFSM spellControl
    {
        get => HeroController.instance.spellControl;
        set => HeroController.instance.spellControl = value;
    }

    public static PlayMakerFSM fsm_fallTrail
    {
        get => HeroController.instance.fsm_fallTrail;
        set => HeroController.instance.fsm_fallTrail = value;
    }

    public static PlayMakerFSM fsm_orbitShield
    {
        get => HeroController.instance.fsm_orbitShield;
        set => HeroController.instance.fsm_orbitShield = value;
    }

    public static VibrationData softLandVibration
    {
        get => HeroController.instance.softLandVibration;
        set => HeroController.instance.softLandVibration = value;
    }

    public static VibrationData wallJumpVibration
    {
        get => HeroController.instance.wallJumpVibration;
        set => HeroController.instance.wallJumpVibration = value;
    }

    public static VibrationPlayer wallSlideVibrationPlayer
    {
        get => HeroController.instance.wallSlideVibrationPlayer;
        set => HeroController.instance.wallSlideVibrationPlayer = value;
    }

    public static VibrationData dashVibration
    {
        get => HeroController.instance.dashVibration;
        set => HeroController.instance.dashVibration = value;
    }

    public static VibrationData shadowDashVibration
    {
        get => HeroController.instance.shadowDashVibration;
        set => HeroController.instance.shadowDashVibration = value;
    }

    public static VibrationData doubleJumpVibration
    {
        get => HeroController.instance.doubleJumpVibration;
        set => HeroController.instance.doubleJumpVibration = value;
    }

    public static bool jumpReleaseQueueingEnabled
    {
        get => ReflectionHelper.GetField<HeroController, bool>(HeroController.instance,
            "jumpReleaseQueueingEnabled");
        set => ReflectionHelper.SetField(HeroController.instance, "jumpReleaseQueueingEnabled", value);
    }

    public static float preventCastByDialogueEndTimer
    {
        get => ReflectionHelper.GetField<HeroController, float>(HeroController.instance,
            "preventCastByDialogueEndTimer");
        set => ReflectionHelper.SetField(HeroController.instance, "preventCastByDialogueEndTimer", value);
    }

    public static Vector2 oldPos
    {
        get => ReflectionHelper.GetField<HeroController, Vector2>(HeroController.instance, "oldPos");
        set => ReflectionHelper.SetField(HeroController.instance, "oldPos", value);
    }

    #region Methods

    public static void Awake()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Awake");
    }

    public static void Start()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Start");
    }

    public static void SceneInit()
    {
        HeroController.instance.SceneInit();
    }

    public static void Update()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Update");
    }

    public static void FixedUpdate()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FixedUpdate");
    }

    public static void Update10()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Update10");
    }

    public static void OnLevelUnload()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OnLevelUnload");
    }

    public static void OnDisable()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OnDisable");
    }

    public static void Move(float move_direction)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Move", move_direction);
    }

    public static void Jump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Jump");
    }

    public static void DoubleJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "DoubleJump");
    }

    public static void Attack(AttackDirection attackDir)
    {
        HeroController.instance.Attack(attackDir);
    }

    public static void Dash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "Dash");
    }

    public static void BackDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "BackDash");
    }

    public static void ShadowDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ShadowDash");
    }

    public static void SuperDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SuperDash");
    }

    public static void FaceRight()
    {
        HeroController.instance.FaceRight();
    }

    public static void FaceLeft()
    {
        HeroController.instance.FaceLeft();
    }

    public static void StartMPDrain(float time)
    {
        HeroController.instance.StartMPDrain(time);
    }

    public static void StopMPDrain()
    {
        HeroController.instance.StopMPDrain();
    }

    public static void SetBackOnGround()
    {
        HeroController.instance.SetBackOnGround();
    }

    public static void SetStartWithWallslide()
    {
        HeroController.instance.SetStartWithWallslide();
    }

    public static void SetStartWithJump()
    {
        HeroController.instance.SetStartWithJump();
    }

    public static void SetStartWithFullJump()
    {
        HeroController.instance.SetStartWithFullJump();
    }

    public static void SetStartWithDash()
    {
        HeroController.instance.SetStartWithDash();
    }

    public static void SetStartWithAttack()
    {
        HeroController.instance.SetStartWithAttack();
    }

    public static void SetSuperDashExit()
    {
        HeroController.instance.SetSuperDashExit();
    }

    public static void SetQuakeExit()
    {
        HeroController.instance.SetQuakeExit();
    }

    public static void SetTakeNoDamage()
    {
        HeroController.instance.SetTakeNoDamage();
    }

    public static void EndTakeNoDamage()
    {
        HeroController.instance.EndTakeNoDamage();
    }

    public static void SetHeroParent(Transform newParent)
    {
        HeroController.instance.SetHeroParent(newParent);
    }

    public static void IsSwimming()
    {
        HeroController.instance.IsSwimming();
    }

    public static void NotSwimming()
    {
        HeroController.instance.NotSwimming();
    }

    public static void EnableRenderer()
    {
        HeroController.instance.EnableRenderer();
    }

    public static void ResetAirMoves()
    {
        HeroController.instance.ResetAirMoves();
    }

    public static void SetConveyorSpeed(float speed)
    {
        HeroController.instance.SetConveyorSpeed(speed);
    }

    public static void SetConveyorSpeedV(float speed)
    {
        HeroController.instance.SetConveyorSpeedV(speed);
    }

    public static void EnterWithoutInput(bool flag)
    {
        HeroController.instance.EnterWithoutInput(flag);
    }

    public static void SetDarkness(int darkness)
    {
        HeroController.instance.SetDarkness(darkness);
    }

    public static void CancelHeroJump()
    {
        HeroController.instance.CancelHeroJump();
    }

    public static void CharmUpdate()
    {
        HeroController.instance.CharmUpdate();
    }

    public static void checkEnvironment()
    {
        HeroController.instance.checkEnvironment();
    }

    public static void SetBenchRespawn(string spawnMarker, string sceneName, int spawnType, bool facingRight)
    {
        HeroController.instance.SetBenchRespawn(spawnMarker, sceneName, spawnType, facingRight);
    }

    public static void SetHazardRespawn(Vector3 position, bool facingRight)
    {
        HeroController.instance.SetHazardRespawn(position, facingRight);
    }

    public static void AddGeo(int amount)
    {
        HeroController.instance.AddGeo(amount);
    }

    public static void ToZero()
    {
        HeroController.instance.ToZero();
    }

    public static void AddGeoQuietly(int amount)
    {
        HeroController.instance.AddGeoQuietly(amount);
    }

    public static void AddGeoToCounter(int amount)
    {
        HeroController.instance.AddGeoToCounter(amount);
    }

    public static void TakeGeo(int amount)
    {
        HeroController.instance.TakeGeo(amount);
    }

    public static void UpdateGeo()
    {
        HeroController.instance.UpdateGeo();
    }

    public static bool CanInput()
    {
        return HeroController.instance.CanInput();
    }

    public static bool CanTalk()
    {
        return HeroController.instance.CanTalk();
    }

    public static void FlipSprite()
    {
        HeroController.instance.FlipSprite();
    }

    public static void NailParry()
    {
        HeroController.instance.NailParry();
    }

    public static void NailParryRecover()
    {
        HeroController.instance.NailParryRecover();
    }

    public static void QuakeInvuln()
    {
        HeroController.instance.QuakeInvuln();
    }

    public static void CancelParryInvuln()
    {
        HeroController.instance.CancelParryInvuln();
    }

    public static void CycloneInvuln()
    {
        HeroController.instance.CycloneInvuln();
    }

    public static void SetWieldingLantern(bool set)
    {
        HeroController.instance.SetWieldingLantern(set);
    }

    public static void TakeDamage(GameObject go, CollisionSide damageSide, int damageAmount,
        int hazardType)
    {
        HeroController.instance.TakeDamage(go, damageSide, damageAmount, hazardType);
    }

    public static string GetEntryGateName()
    {
        return HeroController.instance.GetEntryGateName();
    }

    public static void AddMPCharge(int amount)
    {
        HeroController.instance.AddMPCharge(amount);
    }

    public static void SoulGain()
    {
        HeroController.instance.SoulGain();
    }

    public static void AddMPChargeSpa(int amount)
    {
        HeroController.instance.AddMPChargeSpa(amount);
    }

    public static bool TryAddMPChargeSpa(int amount)
    {
        return HeroController.instance.TryAddMPChargeSpa(amount);
    }

    public static void SetMPCharge(int amount)
    {
        HeroController.instance.SetMPCharge(amount);
    }

    public static void TakeMP(int amount)
    {
        HeroController.instance.TakeMP(amount);
    }

    public static void TakeMPQuick(int amount)
    {
        HeroController.instance.TakeMPQuick(amount);
    }

    public static void TakeReserveMP(int amount)
    {
        HeroController.instance.TakeReserveMP(amount);
    }

    public static void AddHealth(int amount)
    {
        HeroController.instance.AddHealth(amount);
    }

    public static void TakeHealth(int amount)
    {
        HeroController.instance.TakeHealth(amount);
    }

    public static void MaxHealth()
    {
        HeroController.instance.MaxHealth();
    }

    public static void MaxHealthKeepBlue()
    {
        HeroController.instance.MaxHealthKeepBlue();
    }

    public static void AddToMaxHealth(int amount)
    {
        HeroController.instance.AddToMaxHealth(amount);
    }

    public static void ClearMP()
    {
        HeroController.instance.ClearMP();
    }

    public static void ClearMPSendEvents()
    {
        HeroController.instance.ClearMPSendEvents();
    }

    public static void AddToMaxMPReserve(int amount)
    {
        HeroController.instance.AddToMaxMPReserve(amount);
    }

    public static void Bounce()
    {
        HeroController.instance.Bounce();
    }

    public static void BounceHigh()
    {
        HeroController.instance.BounceHigh();
    }

    public static void ShroomBounce()
    {
        HeroController.instance.ShroomBounce();
    }

    public static void RecoilLeft()
    {
        HeroController.instance.RecoilLeft();
    }

    public static void RecoilRight()
    {
        HeroController.instance.RecoilRight();
    }

    public static void RecoilRightLong()
    {
        HeroController.instance.RecoilRightLong();
    }

    public static void RecoilLeftLong()
    {
        HeroController.instance.RecoilLeftLong();
    }

    public static void RecoilDown()
    {
        HeroController.instance.RecoilDown();
    }

    public static void ForceHardLanding()
    {
        HeroController.instance.ForceHardLanding();
    }

    public static void EnterSceneDreamGate()
    {
        HeroController.instance.EnterSceneDreamGate();
    }

    public static IEnumerator EnterScene(TransitionPoint enterGate, float delayBeforeEnter)
    {
        return HeroController.instance.EnterScene(enterGate, delayBeforeEnter);
    }

    //manual edit
    public static void LeaveScene(GatePosition? gate = null)
    {
        HeroController.instance.LeaveScene(gate);
    }

    public static IEnumerator BetaLeave(EndBeta betaEndTrigger)
    {
        return HeroController.instance.BetaLeave(betaEndTrigger);
    }

    public static IEnumerator BetaReturn()
    {
        return HeroController.instance.BetaReturn();
    }

    public static IEnumerator Respawn()
    {
        return HeroController.instance.Respawn();
    }

    public static IEnumerator HazardRespawn()
    {
        return HeroController.instance.HazardRespawn();
    }

    public static void StartCyclone()
    {
        HeroController.instance.StartCyclone();
    }

    public static void EndCyclone()
    {
        HeroController.instance.EndCyclone();
    }

    public static bool GetState(string stateName)
    {
        return HeroController.instance.GetState(stateName);
    }

    public static bool GetCState(string stateName)
    {
        return HeroController.instance.GetCState(stateName);
    }

    public static void SetCState(string stateName, bool value)
    {
        HeroController.instance.SetCState(stateName, value);
    }

    public static void ResetHardLandingTimer()
    {
        HeroController.instance.ResetHardLandingTimer();
    }

    public static void CancelSuperDash()
    {
        HeroController.instance.CancelSuperDash();
    }

    public static void RelinquishControlNotVelocity()
    {
        HeroController.instance.RelinquishControlNotVelocity();
    }

    public static void RelinquishControl()
    {
        HeroController.instance.RelinquishControl();
    }

    public static void RegainControl()
    {
        HeroController.instance.RegainControl();
    }

    public static void PreventCastByDialogueEnd()
    {
        HeroController.instance.PreventCastByDialogueEnd();
    }

    public static bool CanCast()
    {
        return HeroController.instance.CanCast();
    }

    public static bool CanFocus()
    {
        return HeroController.instance.CanFocus();
    }

    public static bool CanNailArt()
    {
        return HeroController.instance.CanNailArt();
    }

    public static bool CanQuickMap()
    {
        return HeroController.instance.CanQuickMap();
    }

    public static bool CanInspect()
    {
        return HeroController.instance.CanInspect();
    }

    public static bool CanBackDash()
    {
        return HeroController.instance.CanBackDash();
    }

    public static bool CanSuperDash()
    {
        return HeroController.instance.CanSuperDash();
    }

    public static bool CanDreamNail()
    {
        return HeroController.instance.CanDreamNail();
    }

    public static bool CanDreamGate()
    {
        return HeroController.instance.CanDreamGate();
    }

    public static bool CanInteract()
    {
        return HeroController.instance.CanInteract();
    }

    public static bool CanOpenInventory()
    {
        return HeroController.instance.CanOpenInventory();
    }

    public static void SetDamageMode(int invincibilityType)
    {
        HeroController.instance.SetDamageMode(invincibilityType);
    }

    public static void SetDamageModeFSM(int invincibilityType)
    {
        HeroController.instance.SetDamageModeFSM(invincibilityType);
    }

    public static void ResetQuakeDamage()
    {
        HeroController.instance.ResetQuakeDamage();
    }

    public static void SetDamageMode(DamageMode newDamageMode)
    {
        HeroController.instance.SetDamageMode(newDamageMode);
    }

    public static void StopAnimationControl()
    {
        HeroController.instance.StopAnimationControl();
    }

    public static void StartAnimationControl()
    {
        HeroController.instance.StartAnimationControl();
    }

    public static void IgnoreInput()
    {
        HeroController.instance.IgnoreInput();
    }

    public static void IgnoreInputWithoutReset()
    {
        HeroController.instance.IgnoreInputWithoutReset();
    }

    public static void AcceptInput()
    {
        HeroController.instance.AcceptInput();
    }

    public static void Pause()
    {
        HeroController.instance.Pause();
    }

    public static void UnPause()
    {
        HeroController.instance.UnPause();
    }

    public static void NearBench(bool isNearBench)
    {
        HeroController.instance.NearBench(isNearBench);
    }

    public static void SetWalkZone(bool inWalkZone)
    {
        HeroController.instance.SetWalkZone(inWalkZone);
    }

    public static void ResetState()
    {
        HeroController.instance.ResetState();
    }

    public static void StopPlayingAudio()
    {
        HeroController.instance.StopPlayingAudio();
    }

    public static void PauseAudio()
    {
        HeroController.instance.PauseAudio();
    }

    public static void UnPauseAudio()
    {
        HeroController.instance.UnPauseAudio();
    }

    public static void PauseInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "PauseInput");
    }

    public static void UnPauseInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "UnPauseInput");
    }

    public static void SpawnSoftLandingPrefab()
    {
        HeroController.instance.SpawnSoftLandingPrefab();
    }

    public static void AffectedByGravity(bool gravityApplies)
    {
        HeroController.instance.AffectedByGravity(gravityApplies);
    }

    public static void LookForInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "LookForInput");
    }

    public static void LookForQueueInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "LookForQueueInput");
    }

    public static void HeroJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "HeroJump");
    }

    public static void HeroJumpNoEffect()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "HeroJumpNoEffect");
    }

    public static void DoWallJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "DoWallJump");
    }

    public static void DoDoubleJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "DoDoubleJump");
    }

    public static void DoHardLanding()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "DoHardLanding");
    }

    public static void DoAttack()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "DoAttack");
    }

    public static void HeroDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "HeroDash");
    }

    public static void StartFallRumble()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "StartFallRumble");
    }

    public static void SetState(ActorStates newState)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SetState", newState);
    }

    public static void FinishedEnteringScene(bool setHazardMarker = true, bool preventRunBob = false)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FinishedEnteringScene",
            setHazardMarker,
            preventRunBob);
    }

    public static IEnumerator Die()
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance, "Die");
    }

    public static IEnumerator DieFromHazard(HazardType hazardType, float angle)
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance,
            "DieFromHazard", hazardType, angle);
    }

    public static IEnumerator StartRecoil(CollisionSide impactSide,
        bool spawnDamageEffect, int damageAmount)
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance,
            "StartRecoil", impactSide, spawnDamageEffect, damageAmount);
    }

    public static IEnumerator Invulnerable(float duration)
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance,
            "Invulnerable", duration);
    }

    public static IEnumerator FirstFadeIn()
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance,
            "FirstFadeIn");
    }

    public static void FallCheck()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FallCheck");
    }

    public static void OutOfBoundsCheck()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OutOfBoundsCheck");
    }

    public static void ConfirmOutOfBounds()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ConfirmOutOfBounds");
    }

    public static void FailSafeChecks()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FailSafeChecks");
    }

    public static Transform LocateSpawnPoint()
    {
        return HeroController.instance.LocateSpawnPoint();
    }

    public static void CancelJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelJump");
    }

    public static void CancelDoubleJump()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelDoubleJump");
    }

    public static void CancelDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelDash");
    }

    public static void CancelWallsliding()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelWallsliding");
    }

    public static void CancelBackDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelBackDash");
    }

    public static void CancelDownAttack()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelDownAttack");
    }

    public static void CancelAttack()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelAttack");
    }

    public static void CancelBounce()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelBounce");
    }

    public static void CancelRecoilHorizontal()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelRecoilHorizontal");
    }

    public static void CancelDamageRecoil()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelDamageRecoil");
    }

    public static void CancelFallEffects()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "CancelFallEffects");
    }

    public static void ResetAttacks()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetAttacks");
    }

    public static void ResetAttacksDash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetAttacksDash");
    }

    public static void ResetMotion()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetMotion");
    }

    public static void ResetMotionNotVelocity()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetMotionNotVelocity");
    }

    public static void ResetLook()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetLook");
    }

    public static void ResetInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ResetInput");
    }

    public static void BackOnGround()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "BackOnGround");
    }

    public static void JumpReleased()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "JumpReleased");
    }

    public static void FinishedDashing()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FinishedDashing");
    }

    public static void SetStartingMotionState()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SetStartingMotionState");
    }

    public static void SetStartingMotionState(bool preventRunDip)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SetStartingMotionState",
            preventRunDip);
    }

    public static void EnterAcid()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "EnterAcid");
    }

    public static void ExitAcid()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "ExitAcid");
    }

    public static void TileMapTest()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "TileMapTest");
    }

    public static IEnumerator TilemapTestPause()
    {
        return ReflectionHelper.CallMethod<HeroController, IEnumerator>(HeroController.instance,
            "TilemapTestPause");
    }

    public static void StopTilemapTest()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "StopTilemapTest");
    }

    public static IEnumerator CheckForTerrainThunk(AttackDirection attackDir)
    {
        return HeroController.instance.CheckForTerrainThunk(attackDir);
    }

    public static bool CheckStillTouchingWall(CollisionSide side, bool checkTop = false)
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CheckStillTouchingWall",
            side,
            checkTop);
    }

    public static bool CheckForBump(CollisionSide side)
    {
        return HeroController.instance.CheckForBump(side);
    }

    public static bool CheckNearRoof()
    {
        return HeroController.instance.CheckNearRoof();
    }

    public static bool CheckTouchingGround()
    {
        return HeroController.instance.CheckTouchingGround();
    }

    //manual edit
    public static List<CollisionSide> CheckTouching(PhysLayers layer)
    {
        return ReflectionHelper.CallMethod<HeroController, List<CollisionSide>>(HeroController.instance,
            "CheckTouching", layer);
    }

    //manual edit
    public static List<CollisionSide> CheckTouchingAdvanced(PhysLayers layer)
    {
        return ReflectionHelper.CallMethod<HeroController, List<CollisionSide>>(HeroController.instance,
            "CheckTouchingAdvanced", layer);
    }

    //manual edit
    public static CollisionSide FindCollisionDirection(Collision2D collision)
    {
        return ReflectionHelper.CallMethod<HeroController, CollisionSide>(HeroController.instance,
            "FindCollisionDirection", collision);
    }

    public static bool CanJump()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanJump");
    }

    public static bool CanDoubleJump()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanDoubleJump");
    }

    public static bool CanInfiniteAirJump()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanInfiniteAirJump");
    }

    public static bool CanSwim()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanSwim");
    }

    public static bool CanDash()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanDash");
    }

    public static bool CanAttack()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanAttack");
    }

    public static bool CanNailCharge()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanNailCharge");
    }

    public static bool CanWallSlide()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanWallSlide");
    }

    public static bool CanTakeDamage()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanTakeDamage");
    }

    public static bool CanWallJump()
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanWallJump");
    }

    public static bool ShouldHardLand(Collision2D collision)
    {
        return ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "ShouldHardLand", collision);
    }

    public static void OnCollisionEnter2D(Collision2D collision)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OnCollisionEnter2D", collision);
    }

    public static void OnCollisionStay2D(Collision2D collision)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OnCollisionStay2D", collision);
    }

    public static void OnCollisionExit2D(Collision2D collision)
    {
        ReflectionHelper.CallMethod(HeroController.instance, "OnCollisionExit2D", collision);
    }

    public static void SetupGameRefs()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SetupGameRefs");
    }

    public static void SetupPools()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "SetupPools");
    }

    public static void FilterInput()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "FilterInput");
    }

    public static Vector3 FindGroundPoint(Vector2 startPoint, bool useExtended = false)
    {
        return HeroController.instance.FindGroundPoint(startPoint, useExtended);
    }

    public static float FindGroundPointY(float x, float y, bool useExtended = false)
    {
        return ReflectionHelper.CallMethod<HeroController, float>(HeroController.instance, "FindGroundPointY", x, y,
            useExtended);
    }

    public static void orig_StartMPDrain(float time)
    {
        HeroController.instance.orig_StartMPDrain(time);
    }

    public static void orig_Update()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "orig_Update");
    }

    public static Vector2 OrigDashVector()
    {
        return ReflectionHelper.CallMethod<HeroController, Vector2>(HeroController.instance, "OrigDashVector");
    }

    public static void orig_Dash()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "orig_Dash");
    }

    public static void orig_CharmUpdate()
    {
        HeroController.instance.orig_CharmUpdate();
    }

    public static void orig_DoAttack()
    {
        ReflectionHelper.CallMethod(HeroController.instance, "orig_DoAttack");
    }

    #endregion
}