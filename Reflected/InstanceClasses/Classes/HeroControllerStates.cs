namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HeroControllerStates allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroControllerStatesR:InstanceClassWrapper<HeroControllerStates>
{
public HeroControllerStatesR(HeroControllerStates _orig) : base(_orig) {}
public bool facingRight
{
get => orig.facingRight;
set => orig.facingRight = value;
}

public bool onGround
{
get => orig.onGround;
set => orig.onGround = value;
}

public bool jumping
{
get => orig.jumping;
set => orig.jumping = value;
}

public bool wallJumping
{
get => orig.wallJumping;
set => orig.wallJumping = value;
}

public bool doubleJumping
{
get => orig.doubleJumping;
set => orig.doubleJumping = value;
}

public bool nailCharging
{
get => orig.nailCharging;
set => orig.nailCharging = value;
}

public bool shadowDashing
{
get => orig.shadowDashing;
set => orig.shadowDashing = value;
}

public bool swimming
{
get => orig.swimming;
set => orig.swimming = value;
}

public bool falling
{
get => orig.falling;
set => orig.falling = value;
}

public bool dashing
{
get => orig.dashing;
set => orig.dashing = value;
}

public bool superDashing
{
get => orig.superDashing;
set => orig.superDashing = value;
}

public bool superDashOnWall
{
get => orig.superDashOnWall;
set => orig.superDashOnWall = value;
}

public bool backDashing
{
get => orig.backDashing;
set => orig.backDashing = value;
}

public bool touchingWall
{
get => orig.touchingWall;
set => orig.touchingWall = value;
}

public bool wallSliding
{
get => orig.wallSliding;
set => orig.wallSliding = value;
}

public bool transitioning
{
get => orig.transitioning;
set => orig.transitioning = value;
}

public bool attacking
{
get => orig.attacking;
set => orig.attacking = value;
}

public bool lookingUp
{
get => orig.lookingUp;
set => orig.lookingUp = value;
}

public bool lookingDown
{
get => orig.lookingDown;
set => orig.lookingDown = value;
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

public bool altAttack
{
get => orig.altAttack;
set => orig.altAttack = value;
}

public bool upAttacking
{
get => orig.upAttacking;
set => orig.upAttacking = value;
}

public bool downAttacking
{
get => orig.downAttacking;
set => orig.downAttacking = value;
}

public bool bouncing
{
get => orig.bouncing;
set => orig.bouncing = value;
}

public bool shroomBouncing
{
get => orig.shroomBouncing;
set => orig.shroomBouncing = value;
}

public bool recoilingRight
{
get => orig.recoilingRight;
set => orig.recoilingRight = value;
}

public bool recoilingLeft
{
get => orig.recoilingLeft;
set => orig.recoilingLeft = value;
}

public bool dead
{
get => orig.dead;
set => orig.dead = value;
}

public bool hazardDeath
{
get => orig.hazardDeath;
set => orig.hazardDeath = value;
}

public bool hazardRespawning
{
get => orig.hazardRespawning;
set => orig.hazardRespawning = value;
}

public bool willHardLand
{
get => orig.willHardLand;
set => orig.willHardLand = value;
}

public bool recoilFrozen
{
get => orig.recoilFrozen;
set => orig.recoilFrozen = value;
}

public bool recoiling
{
get => orig.recoiling;
set => orig.recoiling = value;
}

public bool invulnerable
{
get => orig.invulnerable;
set => orig.invulnerable = value;
}

public bool casting
{
get => orig.casting;
set => orig.casting = value;
}

public bool castRecoiling
{
get => orig.castRecoiling;
set => orig.castRecoiling = value;
}

public bool preventDash
{
get => orig.preventDash;
set => orig.preventDash = value;
}

public bool preventBackDash
{
get => orig.preventBackDash;
set => orig.preventBackDash = value;
}

public bool dashCooldown
{
get => orig.dashCooldown;
set => orig.dashCooldown = value;
}

public bool backDashCooldown
{
get => orig.backDashCooldown;
set => orig.backDashCooldown = value;
}

public bool nearBench
{
get => orig.nearBench;
set => orig.nearBench = value;
}

public bool inWalkZone
{
get => orig.inWalkZone;
set => orig.inWalkZone = value;
}

public bool isPaused
{
get => orig.isPaused;
set => orig.isPaused = value;
}

public bool onConveyor
{
get => orig.onConveyor;
set => orig.onConveyor = value;
}

public bool onConveyorV
{
get => orig.onConveyorV;
set => orig.onConveyorV = value;
}

public bool inConveyorZone
{
get => orig.inConveyorZone;
set => orig.inConveyorZone = value;
}

public bool spellQuake
{
get => orig.spellQuake;
set => orig.spellQuake = value;
}

public bool freezeCharge
{
get => orig.freezeCharge;
set => orig.freezeCharge = value;
}

public bool focusing
{
get => orig.focusing;
set => orig.focusing = value;
}

public bool inAcid
{
get => orig.inAcid;
set => orig.inAcid = value;
}

public bool slidingLeft
{
get => orig.slidingLeft;
set => orig.slidingLeft = value;
}

public bool slidingRight
{
get => orig.slidingRight;
set => orig.slidingRight = value;
}

public bool touchingNonSlider
{
get => orig.touchingNonSlider;
set => orig.touchingNonSlider = value;
}

public bool wasOnGround
{
get => orig.wasOnGround;
set => orig.wasOnGround = value;
}

public bool GetState (string stateName) =>
orig.GetState(stateName);

public void SetState (string stateName, bool value) =>
orig.SetState(stateName, value);

public void Reset () =>
orig.Reset();

}
}
