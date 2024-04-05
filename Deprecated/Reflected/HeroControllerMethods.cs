namespace Satchel.Reflected
{
    public static partial class HeroControllerR
    {
        public static void Awake() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Awake");

        public static void Start() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Start");

        public static void SceneInit() =>
            HeroController.instance.SceneInit();

        public static void Update() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Update");

        public static void FixedUpdate() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FixedUpdate");

        public static void Update10() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Update10");

        public static void OnLevelUnload() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OnLevelUnload");

        public static void OnDisable() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OnDisable");

        public static void Move(float move_direction) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Move", move_direction);

        public static void Jump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Jump");

        public static void DoubleJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "DoubleJump");

        public static void Attack(GlobalEnums.AttackDirection attackDir) =>
            HeroController.instance.Attack(attackDir);

        public static void Dash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "Dash");

        public static void BackDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "BackDash");

        public static void ShadowDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ShadowDash");

        public static void SuperDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SuperDash");

        public static void FaceRight() =>
            HeroController.instance.FaceRight();

        public static void FaceLeft() =>
            HeroController.instance.FaceLeft();

        public static void StartMPDrain(float time) =>
            HeroController.instance.StartMPDrain(time);

        public static void StopMPDrain() =>
            HeroController.instance.StopMPDrain();

        public static void SetBackOnGround() =>
            HeroController.instance.SetBackOnGround();

        public static void SetStartWithWallslide() =>
            HeroController.instance.SetStartWithWallslide();

        public static void SetStartWithJump() =>
            HeroController.instance.SetStartWithJump();

        public static void SetStartWithFullJump() =>
            HeroController.instance.SetStartWithFullJump();

        public static void SetStartWithDash() =>
            HeroController.instance.SetStartWithDash();

        public static void SetStartWithAttack() =>
            HeroController.instance.SetStartWithAttack();

        public static void SetSuperDashExit() =>
            HeroController.instance.SetSuperDashExit();

        public static void SetQuakeExit() =>
            HeroController.instance.SetQuakeExit();

        public static void SetTakeNoDamage() =>
            HeroController.instance.SetTakeNoDamage();

        public static void EndTakeNoDamage() =>
            HeroController.instance.EndTakeNoDamage();

        public static void SetHeroParent(UnityEngine.Transform newParent) =>
            HeroController.instance.SetHeroParent(newParent);

        public static void IsSwimming() =>
            HeroController.instance.IsSwimming();

        public static void NotSwimming() =>
            HeroController.instance.NotSwimming();

        public static void EnableRenderer() =>
            HeroController.instance.EnableRenderer();

        public static void ResetAirMoves() =>
            HeroController.instance.ResetAirMoves();

        public static void SetConveyorSpeed(float speed) =>
            HeroController.instance.SetConveyorSpeed(speed);

        public static void SetConveyorSpeedV(float speed) =>
            HeroController.instance.SetConveyorSpeedV(speed);

        public static void EnterWithoutInput(bool flag) =>
            HeroController.instance.EnterWithoutInput(flag);

        public static void SetDarkness(int darkness) =>
            HeroController.instance.SetDarkness(darkness);

        public static void CancelHeroJump() =>
            HeroController.instance.CancelHeroJump();

        public static void CharmUpdate() =>
            HeroController.instance.CharmUpdate();

        public static void checkEnvironment() =>
            HeroController.instance.checkEnvironment();

        public static void SetBenchRespawn(string spawnMarker, string sceneName, int spawnType, bool facingRight) =>
            HeroController.instance.SetBenchRespawn(spawnMarker, sceneName, spawnType, facingRight);

        public static void SetHazardRespawn(UnityEngine.Vector3 position, bool facingRight) =>
            HeroController.instance.SetHazardRespawn(position, facingRight);

        public static void AddGeo(int amount) =>
            HeroController.instance.AddGeo(amount);

        public static void ToZero() =>
            HeroController.instance.ToZero();

        public static void AddGeoQuietly(int amount) =>
            HeroController.instance.AddGeoQuietly(amount);

        public static void AddGeoToCounter(int amount) =>
            HeroController.instance.AddGeoToCounter(amount);

        public static void TakeGeo(int amount) =>
            HeroController.instance.TakeGeo(amount);

        public static void UpdateGeo() =>
            HeroController.instance.UpdateGeo();

        public static bool CanInput() =>
            HeroController.instance.CanInput();

        public static bool CanTalk() =>
            HeroController.instance.CanTalk();

        public static void FlipSprite() =>
            HeroController.instance.FlipSprite();

        public static void NailParry() =>
            HeroController.instance.NailParry();

        public static void NailParryRecover() =>
            HeroController.instance.NailParryRecover();

        public static void QuakeInvuln() =>
            HeroController.instance.QuakeInvuln();

        public static void CancelParryInvuln() =>
            HeroController.instance.CancelParryInvuln();

        public static void CycloneInvuln() =>
            HeroController.instance.CycloneInvuln();

        public static void SetWieldingLantern(bool set) =>
            HeroController.instance.SetWieldingLantern(set);

        public static void TakeDamage(UnityEngine.GameObject go, GlobalEnums.CollisionSide damageSide, int damageAmount,
            int hazardType) =>
            HeroController.instance.TakeDamage(go, damageSide, damageAmount, hazardType);

        public static string GetEntryGateName() =>
            HeroController.instance.GetEntryGateName();

        public static void AddMPCharge(int amount) =>
            HeroController.instance.AddMPCharge(amount);

        public static void SoulGain() =>
            HeroController.instance.SoulGain();

        public static void AddMPChargeSpa(int amount) =>
            HeroController.instance.AddMPChargeSpa(amount);

        public static bool TryAddMPChargeSpa(int amount) =>
            HeroController.instance.TryAddMPChargeSpa(amount);

        public static void SetMPCharge(int amount) =>
            HeroController.instance.SetMPCharge(amount);

        public static void TakeMP(int amount) =>
            HeroController.instance.TakeMP(amount);

        public static void TakeMPQuick(int amount) =>
            HeroController.instance.TakeMPQuick(amount);

        public static void TakeReserveMP(int amount) =>
            HeroController.instance.TakeReserveMP(amount);

        public static void AddHealth(int amount) =>
            HeroController.instance.AddHealth(amount);

        public static void TakeHealth(int amount) =>
            HeroController.instance.TakeHealth(amount);

        public static void MaxHealth() =>
            HeroController.instance.MaxHealth();

        public static void MaxHealthKeepBlue() =>
            HeroController.instance.MaxHealthKeepBlue();

        public static void AddToMaxHealth(int amount) =>
            HeroController.instance.AddToMaxHealth(amount);

        public static void ClearMP() =>
            HeroController.instance.ClearMP();

        public static void ClearMPSendEvents() =>
            HeroController.instance.ClearMPSendEvents();

        public static void AddToMaxMPReserve(int amount) =>
            HeroController.instance.AddToMaxMPReserve(amount);

        public static void Bounce() =>
            HeroController.instance.Bounce();

        public static void BounceHigh() =>
            HeroController.instance.BounceHigh();

        public static void ShroomBounce() =>
            HeroController.instance.ShroomBounce();

        public static void RecoilLeft() =>
            HeroController.instance.RecoilLeft();

        public static void RecoilRight() =>
            HeroController.instance.RecoilRight();

        public static void RecoilRightLong() =>
            HeroController.instance.RecoilRightLong();

        public static void RecoilLeftLong() =>
            HeroController.instance.RecoilLeftLong();

        public static void RecoilDown() =>
            HeroController.instance.RecoilDown();

        public static void ForceHardLanding() =>
            HeroController.instance.ForceHardLanding();

        public static void EnterSceneDreamGate() =>
            HeroController.instance.EnterSceneDreamGate();

        public static System.Collections.IEnumerator EnterScene(TransitionPoint enterGate, float delayBeforeEnter) =>
            HeroController.instance.EnterScene(enterGate, delayBeforeEnter);

        //manual edit
        public static void LeaveScene(GlobalEnums.GatePosition? gate = null) =>
            HeroController.instance.LeaveScene(gate);

        public static System.Collections.IEnumerator BetaLeave(EndBeta betaEndTrigger) =>
            HeroController.instance.BetaLeave(betaEndTrigger);

        public static System.Collections.IEnumerator BetaReturn() =>
            HeroController.instance.BetaReturn();

        public static System.Collections.IEnumerator Respawn() =>
            HeroController.instance.Respawn();

        public static System.Collections.IEnumerator HazardRespawn() =>
            HeroController.instance.HazardRespawn();

        public static void StartCyclone() =>
            HeroController.instance.StartCyclone();

        public static void EndCyclone() =>
            HeroController.instance.EndCyclone();

        public static bool GetState(string stateName) =>
            HeroController.instance.GetState(stateName);

        public static bool GetCState(string stateName) =>
            HeroController.instance.GetCState(stateName);

        public static void SetCState(string stateName, bool value) =>
            HeroController.instance.SetCState(stateName, value);

        public static void ResetHardLandingTimer() =>
            HeroController.instance.ResetHardLandingTimer();

        public static void CancelSuperDash() =>
            HeroController.instance.CancelSuperDash();

        public static void RelinquishControlNotVelocity() =>
            HeroController.instance.RelinquishControlNotVelocity();

        public static void RelinquishControl() =>
            HeroController.instance.RelinquishControl();

        public static void RegainControl() =>
            HeroController.instance.RegainControl();

        public static void PreventCastByDialogueEnd() =>
            HeroController.instance.PreventCastByDialogueEnd();

        public static bool CanCast() =>
            HeroController.instance.CanCast();

        public static bool CanFocus() =>
            HeroController.instance.CanFocus();

        public static bool CanNailArt() =>
            HeroController.instance.CanNailArt();

        public static bool CanQuickMap() =>
            HeroController.instance.CanQuickMap();

        public static bool CanInspect() =>
            HeroController.instance.CanInspect();

        public static bool CanBackDash() =>
            HeroController.instance.CanBackDash();

        public static bool CanSuperDash() =>
            HeroController.instance.CanSuperDash();

        public static bool CanDreamNail() =>
            HeroController.instance.CanDreamNail();

        public static bool CanDreamGate() =>
            HeroController.instance.CanDreamGate();

        public static bool CanInteract() =>
            HeroController.instance.CanInteract();

        public static bool CanOpenInventory() =>
            HeroController.instance.CanOpenInventory();

        public static void SetDamageMode(int invincibilityType) =>
            HeroController.instance.SetDamageMode(invincibilityType);

        public static void SetDamageModeFSM(int invincibilityType) =>
            HeroController.instance.SetDamageModeFSM(invincibilityType);

        public static void ResetQuakeDamage() =>
            HeroController.instance.ResetQuakeDamage();

        public static void SetDamageMode(GlobalEnums.DamageMode newDamageMode) =>
            HeroController.instance.SetDamageMode(newDamageMode);

        public static void StopAnimationControl() =>
            HeroController.instance.StopAnimationControl();

        public static void StartAnimationControl() =>
            HeroController.instance.StartAnimationControl();

        public static void IgnoreInput() =>
            HeroController.instance.IgnoreInput();

        public static void IgnoreInputWithoutReset() =>
            HeroController.instance.IgnoreInputWithoutReset();

        public static void AcceptInput() =>
            HeroController.instance.AcceptInput();

        public static void Pause() =>
            HeroController.instance.Pause();

        public static void UnPause() =>
            HeroController.instance.UnPause();

        public static void NearBench(bool isNearBench) =>
            HeroController.instance.NearBench(isNearBench);

        public static void SetWalkZone(bool inWalkZone) =>
            HeroController.instance.SetWalkZone(inWalkZone);

        public static void ResetState() =>
            HeroController.instance.ResetState();

        public static void StopPlayingAudio() =>
            HeroController.instance.StopPlayingAudio();

        public static void PauseAudio() =>
            HeroController.instance.PauseAudio();

        public static void UnPauseAudio() =>
            HeroController.instance.UnPauseAudio();

        public static void PauseInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "PauseInput");

        public static void UnPauseInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "UnPauseInput");

        public static void SpawnSoftLandingPrefab() =>
            HeroController.instance.SpawnSoftLandingPrefab();

        public static void AffectedByGravity(bool gravityApplies) =>
            HeroController.instance.AffectedByGravity(gravityApplies);

        public static void LookForInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "LookForInput");

        public static void LookForQueueInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "LookForQueueInput");

        public static void HeroJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "HeroJump");

        public static void HeroJumpNoEffect() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "HeroJumpNoEffect");

        public static void DoWallJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "DoWallJump");

        public static void DoDoubleJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "DoDoubleJump");

        public static void DoHardLanding() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "DoHardLanding");

        public static void DoAttack() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "DoAttack");

        public static void HeroDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "HeroDash");

        public static void StartFallRumble() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "StartFallRumble");

        public static void SetState(GlobalEnums.ActorStates newState) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SetState", newState);

        public static void FinishedEnteringScene(bool setHazardMarker = true, bool preventRunBob = false) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FinishedEnteringScene",
                setHazardMarker,
                preventRunBob);

        public static System.Collections.IEnumerator Die() =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance, "Die");

        public static System.Collections.IEnumerator DieFromHazard(GlobalEnums.HazardType hazardType, float angle) =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance,
                "DieFromHazard", hazardType, angle);

        public static System.Collections.IEnumerator StartRecoil(GlobalEnums.CollisionSide impactSide,
            bool spawnDamageEffect, int damageAmount) =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance,
                "StartRecoil", impactSide, spawnDamageEffect, damageAmount);

        public static System.Collections.IEnumerator Invulnerable(float duration) =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance,
                "Invulnerable", duration);

        public static System.Collections.IEnumerator FirstFadeIn() =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance,
                "FirstFadeIn");

        public static void FallCheck() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FallCheck");

        public static void OutOfBoundsCheck() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OutOfBoundsCheck");

        public static void ConfirmOutOfBounds() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ConfirmOutOfBounds");

        public static void FailSafeChecks() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FailSafeChecks");

        public static UnityEngine.Transform LocateSpawnPoint() =>
            HeroController.instance.LocateSpawnPoint();

        public static void CancelJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelJump");

        public static void CancelDoubleJump() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelDoubleJump");

        public static void CancelDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelDash");

        public static void CancelWallsliding() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelWallsliding");

        public static void CancelBackDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelBackDash");

        public static void CancelDownAttack() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelDownAttack");

        public static void CancelAttack() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelAttack");

        public static void CancelBounce() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelBounce");

        public static void CancelRecoilHorizontal() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelRecoilHorizontal");

        public static void CancelDamageRecoil() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelDamageRecoil");

        public static void CancelFallEffects() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "CancelFallEffects");

        public static void ResetAttacks() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetAttacks");

        public static void ResetAttacksDash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetAttacksDash");

        public static void ResetMotion() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetMotion");

        public static void ResetMotionNotVelocity() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetMotionNotVelocity");

        public static void ResetLook() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetLook");

        public static void ResetInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ResetInput");

        public static void BackOnGround() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "BackOnGround");

        public static void JumpReleased() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "JumpReleased");

        public static void FinishedDashing() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FinishedDashing");

        public static void SetStartingMotionState() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SetStartingMotionState");

        public static void SetStartingMotionState(bool preventRunDip) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SetStartingMotionState",
                preventRunDip);

        public static void EnterAcid() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "EnterAcid");

        public static void ExitAcid() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "ExitAcid");

        public static void TileMapTest() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "TileMapTest");

        public static System.Collections.IEnumerator TilemapTestPause() =>
            ReflectionHelper.CallMethod<HeroController, System.Collections.IEnumerator>(HeroController.instance,
                "TilemapTestPause");

        public static void StopTilemapTest() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "StopTilemapTest");

        public static System.Collections.IEnumerator CheckForTerrainThunk(GlobalEnums.AttackDirection attackDir) =>
            HeroController.instance.CheckForTerrainThunk(attackDir);

        public static bool CheckStillTouchingWall(GlobalEnums.CollisionSide side, bool checkTop = false) =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CheckStillTouchingWall", side,
                checkTop);

        public static bool CheckForBump(GlobalEnums.CollisionSide side) =>
            HeroController.instance.CheckForBump(side);

        public static bool CheckNearRoof() =>
            HeroController.instance.CheckNearRoof();

        public static bool CheckTouchingGround() =>
            HeroController.instance.CheckTouchingGround();

        //manual edit
        public static List<GlobalEnums.CollisionSide> CheckTouching(GlobalEnums.PhysLayers layer) =>
            ReflectionHelper.CallMethod<HeroController, List<GlobalEnums.CollisionSide>>(HeroController.instance,
                "CheckTouching", layer);

        //manual edit
        public static List<GlobalEnums.CollisionSide> CheckTouchingAdvanced(GlobalEnums.PhysLayers layer) =>
            ReflectionHelper.CallMethod<HeroController, List<GlobalEnums.CollisionSide>>(HeroController.instance,
                "CheckTouchingAdvanced", layer);

        //manual edit
        public static GlobalEnums.CollisionSide FindCollisionDirection(UnityEngine.Collision2D collision) =>
            ReflectionHelper.CallMethod<HeroController, GlobalEnums.CollisionSide>(HeroController.instance,
                "FindCollisionDirection", collision);

        public static bool CanJump() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanJump");

        public static bool CanDoubleJump() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanDoubleJump");

        public static bool CanInfiniteAirJump() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanInfiniteAirJump");

        public static bool CanSwim() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanSwim");

        public static bool CanDash() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanDash");

        public static bool CanAttack() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanAttack");

        public static bool CanNailCharge() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanNailCharge");

        public static bool CanWallSlide() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanWallSlide");

        public static bool CanTakeDamage() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanTakeDamage");

        public static bool CanWallJump() =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "CanWallJump");

        public static bool ShouldHardLand(UnityEngine.Collision2D collision) =>
            ReflectionHelper.CallMethod<HeroController, bool>(HeroController.instance, "ShouldHardLand", collision);

        public static void OnCollisionEnter2D(UnityEngine.Collision2D collision) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OnCollisionEnter2D", collision);

        public static void OnCollisionStay2D(UnityEngine.Collision2D collision) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OnCollisionStay2D", collision);

        public static void OnCollisionExit2D(UnityEngine.Collision2D collision) =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "OnCollisionExit2D", collision);

        public static void SetupGameRefs() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SetupGameRefs");

        public static void SetupPools() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "SetupPools");

        public static void FilterInput() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "FilterInput");

        public static UnityEngine.Vector3 FindGroundPoint(UnityEngine.Vector2 startPoint, bool useExtended = false) =>
            HeroController.instance.FindGroundPoint(startPoint, useExtended);

        public static float FindGroundPointY(float x, float y, bool useExtended = false) =>
            ReflectionHelper.CallMethod<HeroController, float>(HeroController.instance, "FindGroundPointY", x, y,
                useExtended);

        public static void orig_StartMPDrain(float time) =>
            HeroController.instance.orig_StartMPDrain(time);

        public static void orig_Update() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "orig_Update");

        public static UnityEngine.Vector2 OrigDashVector() =>
            ReflectionHelper.CallMethod<HeroController, UnityEngine.Vector2>(HeroController.instance, "OrigDashVector");

        public static void orig_Dash() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "orig_Dash");

        public static void orig_CharmUpdate() =>
            HeroController.instance.orig_CharmUpdate();

        public static void orig_DoAttack() =>
            ReflectionHelper.CallMethod<HeroController>(HeroController.instance, "orig_DoAttack");

        //removed some MonoBehaviour methods
    }

    //code that can be used to reproduce this with small edits
    /*
    Log("Starting Methods");
    var methods =
        typeof(HeroController).GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
    foreach (var method in methods)
    {
        bool noreturn = false;


        var parameters = method.GetParameters();
        StringBuilder paramsInputString = new StringBuilder();
        StringBuilder paramsOutputString = new StringBuilder();
        if (parameters.Length == 0)
        {
            paramsInputString.Append("()");
            paramsOutputString.Append("");
        }
        else
        {
            paramsInputString.Append("(");
            if (!method.IsPublic) paramsOutputString.Append(", ");
            foreach (var param in parameters)
            {
                paramsOutputString.Append($"{param.Name}");

                paramsInputString.Append($"{removeSystemType(param.ParameterType.ToString())} {param.Name}");
                if (param.HasDefaultValue)
                {
                    paramsInputString.Append(param.DefaultValue == null
                        ? " = null"
                        : $" = {Convert.ChangeType(param.DefaultValue, param.ParameterType)}");
                }

                if (parameters.ToList().IndexOf(param) != parameters.Length - 1)
                {
                    paramsInputString.Append(", ");
                    paramsOutputString.Append(", ");
                }
            }

            paramsInputString.Append(")");
        }

        if (method.ReturnType.ToString() == "System.Void") noreturn = true;

        StringBuilder methodString = new StringBuilder();
        methodString.AppendLine(
            $"public static {removeSystemType(method.ReturnType.ToString())} {method.Name} {paramsInputString} =>");

        if (method.IsPublic)
        {
            methodString.AppendLine($"HeroController.instance.{method.Name}({paramsOutputString});");
        }
        else
        {
            methodString.AppendLine(noreturn
                ? $"ReflectionHelper.CallMethod<HeroController>(HeroController.instance, \"{method.Name}\"{paramsOutputString});"
                : $"ReflectionHelper.CallMethod<HeroController,{removeSystemType(method.ReturnType.ToString())}>(HeroController.instance, \"{method.Name}\"{paramsOutputString});");
        }

        Log(methodString);
    }

    string removeSystemType(string type)
    {
        return type switch
        {
            "System.Int32" => "int",
            "System.Boolean" => "bool",
            "System.Single" => "float",
            "System.String" => "string",
            "System.Void" => "void",
            _ => type
        };
    }

    */
}