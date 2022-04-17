using Modding;

namespace Satchel.Reflected
{
    public static partial class GameManagerR
    {
        public static void Awake() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "Awake");

        public static void Start() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "Start");

        public static void Update() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "Update");

        public static void UpdateEngagement() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "UpdateEngagement");

        public static void LevelActivated(UnityEngine.SceneManagement.Scene sceneFrom,
            UnityEngine.SceneManagement.Scene sceneTo) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "LevelActivated", sceneFrom, sceneTo);

        public static void OnDisable() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "OnDisable");

        public static void OnApplicationQuit() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "OnApplicationQuit");

        public static void BeginSceneTransition(GameManager.SceneLoadInfo info) =>
            GameManager.instance.BeginSceneTransition(info);

        public static System.Collections.IEnumerator BeginSceneTransitionRoutine(GameManager.SceneLoadInfo info) =>
            ReflectionHelper.CallMethod<GameManager, System.Collections.IEnumerator>(GameManager.instance,
                "BeginSceneTransitionRoutine", info);

        public static System.Collections.IEnumerator TransitionScene(TransitionPoint gate) =>
            GameManager.instance.TransitionScene(gate);

        public static void ChangeToScene(string targetScene, string entryGateName, float pauseBeforeEnter) =>
            GameManager.instance.ChangeToScene(targetScene, entryGateName, pauseBeforeEnter);

        public static void WarpToDreamGate() =>
            GameManager.instance.WarpToDreamGate();

        public static void LeftScene(bool doAdditiveLoad = false) =>
            GameManager.instance.LeftScene(doAdditiveLoad);

        public static System.Collections.IEnumerator PlayerDead(float waitTime) =>
            GameManager.instance.PlayerDead(waitTime);

        public static System.Collections.IEnumerator PlayerDeadFromHazard(float waitTime) =>
            GameManager.instance.PlayerDeadFromHazard(waitTime);

        public static void ReadyForRespawn(bool isFirstLevelForPlayer) =>
            GameManager.instance.ReadyForRespawn(isFirstLevelForPlayer);

        public static void HazardRespawn() =>
            GameManager.instance.HazardRespawn();

        public static void TimePasses() =>
            GameManager.instance.TimePasses();

        public static void FadeSceneIn() =>
            GameManager.instance.FadeSceneIn();

        public static System.Collections.IEnumerator FadeSceneInWithDelay(float delay) =>
            GameManager.instance.FadeSceneInWithDelay(delay);

        public static bool IsGamePaused() =>
            GameManager.instance.IsGamePaused();

        public static void SetGameMap(UnityEngine.GameObject go_gameMap) =>
            GameManager.instance.SetGameMap(go_gameMap);

        public static void CalculateNotchesUsed() =>
            GameManager.instance.CalculateNotchesUsed();

        public static string GetLanguageAsString() =>
            GameManager.instance.GetLanguageAsString();

        public static string GetEntryGateName() =>
            GameManager.instance.GetEntryGateName();

        public static void SetPlayerDataBool(string boolName, bool value) =>
            GameManager.instance.SetPlayerDataBool(boolName, value);

        public static void SetPlayerDataInt(string intName, int value) =>
            GameManager.instance.SetPlayerDataInt(intName, value);

        public static void SetPlayerDataFloat(string floatName, float value) =>
            GameManager.instance.SetPlayerDataFloat(floatName, value);

        public static void SetPlayerDataString(string stringName, string value) =>
            GameManager.instance.SetPlayerDataString(stringName, value);

        public static void IncrementPlayerDataInt(string intName) =>
            GameManager.instance.IncrementPlayerDataInt(intName);

        public static void DecrementPlayerDataInt(string intName) =>
            GameManager.instance.DecrementPlayerDataInt(intName);

        public static void IntAdd(string intName, int amount) =>
            GameManager.instance.IntAdd(intName, amount);

        public static bool GetPlayerDataBool(string boolName) =>
            GameManager.instance.GetPlayerDataBool(boolName);

        public static int GetPlayerDataInt(string intName) =>
            GameManager.instance.GetPlayerDataInt(intName);

        public static float GetPlayerDataFloat(string floatName) =>
            GameManager.instance.GetPlayerDataFloat(floatName);

        public static string GetPlayerDataString(string stringName) =>
            GameManager.instance.GetPlayerDataString(stringName);

        public static void SetPlayerDataVector3(string vectorName, UnityEngine.Vector3 value) =>
            GameManager.instance.SetPlayerDataVector3(vectorName, value);

        public static UnityEngine.Vector3 GetPlayerDataVector3(string vectorName) =>
            GameManager.instance.GetPlayerDataVector3(vectorName);

        public static T GetPlayerDataVariable<T>(string fieldName) =>
            GameManager.instance.GetPlayerDataVariable<T>(fieldName);

        public static void SetPlayerDataVariable<T>(string fieldName, T value) =>
            GameManager.instance.SetPlayerDataVariable<T>(fieldName, value);

        public static void EquipCharm(int charmNum) =>
            GameManager.instance.EquipCharm(charmNum);

        public static void UnequipCharm(int charmNum) =>
            GameManager.instance.UnequipCharm(charmNum);

        public static void RefreshOvercharm() =>
            GameManager.instance.RefreshOvercharm();

        public static void UpdateBlueHealth() =>
            GameManager.instance.UpdateBlueHealth();

        public static void SetCurrentMapZoneAsRespawn() =>
            GameManager.instance.SetCurrentMapZoneAsRespawn();

        public static void SetMapZoneToSpecific(string mapZone) =>
            GameManager.instance.SetMapZoneToSpecific(mapZone);

        public static void StartSoulLimiter() =>
            GameManager.instance.StartSoulLimiter();

        public static void EndSoulLimiter() =>
            GameManager.instance.EndSoulLimiter();

        public static bool UpdateGameMap() =>
            GameManager.instance.UpdateGameMap();

        public static void CheckAllMaps() =>
            GameManager.instance.CheckAllMaps();

        public static void AddToScenesVisited(string scene) =>
            GameManager.instance.AddToScenesVisited(scene);

        public static bool GetIsSceneVisited(string scene) =>
            GameManager.instance.GetIsSceneVisited(scene);

        public static void AddToBenchList() =>
            GameManager.instance.AddToBenchList();

        public static void AddToGrubList() =>
            GameManager.instance.AddToGrubList();

        public static void AddToFlameList() =>
            GameManager.instance.AddToFlameList();

        public static void AddToCocoonList() =>
            GameManager.instance.AddToCocoonList();

        public static void AddToDreamPlantList() =>
            GameManager.instance.AddToDreamPlantList();

        public static void AddToDreamPlantCList() =>
            GameManager.instance.AddToDreamPlantCList();

        public static void CountGameCompletion() =>
            GameManager.instance.CountGameCompletion();

        public static void CountCharms() =>
            GameManager.instance.CountCharms();

        public static void CountJournalEntries() =>
            GameManager.instance.CountJournalEntries();

        public static void ActivateTestingCheats() =>
            GameManager.instance.ActivateTestingCheats();

        public static void GetAllPowerups() =>
            GameManager.instance.GetAllPowerups();

        public static void StoryRecord_death() =>
            GameManager.instance.StoryRecord_death();

        public static void StoryRecord_rescueGrub() =>
            GameManager.instance.StoryRecord_rescueGrub();

        public static void StoryRecord_defeatedShade() =>
            GameManager.instance.StoryRecord_defeatedShade();

        public static void StoryRecord_discoveredArea(string areaName) =>
            GameManager.instance.StoryRecord_discoveredArea(areaName);

        public static void StoryRecord_travelledToArea(string areaName) =>
            GameManager.instance.StoryRecord_travelledToArea(areaName);

        public static void StoryRecord_bankDeposit(int amount) =>
            GameManager.instance.StoryRecord_bankDeposit(amount);

        public static void StoryRecord_bankWithdraw(int amount) =>
            GameManager.instance.StoryRecord_bankWithdraw(amount);

        public static void StoryRecord_boughtCorniferMap(string map) =>
            GameManager.instance.StoryRecord_boughtCorniferMap(map);

        public static void StoryRecord_visited(string visited) =>
            GameManager.instance.StoryRecord_visited(visited);

        public static void StoryRecord_defeated(string defeated) =>
            GameManager.instance.StoryRecord_defeated(defeated);

        public static void StoryRecord_jiji() =>
            GameManager.instance.StoryRecord_jiji();

        public static void StoryRecord_rodeStag(string dest) =>
            GameManager.instance.StoryRecord_rodeStag(dest);

        public static void StoryRecord_acquired(string item) =>
            GameManager.instance.StoryRecord_acquired(item);

        public static void StoryRecord_bought(string item) =>
            GameManager.instance.StoryRecord_bought(item);

        public static void StoryRecord_quit() =>
            GameManager.instance.StoryRecord_quit();

        public static void StoryRecord_rest() =>
            GameManager.instance.StoryRecord_rest();

        public static void StoryRecord_upgradeNail() =>
            GameManager.instance.StoryRecord_upgradeNail();

        public static void StoryRecord_heartPiece() =>
            GameManager.instance.StoryRecord_heartPiece();

        public static void StoryRecord_maxHealthUp() =>
            GameManager.instance.StoryRecord_maxHealthUp();

        public static void StoryRecord_soulPiece() =>
            GameManager.instance.StoryRecord_soulPiece();

        public static void StoryRecord_maxSoulUp() =>
            GameManager.instance.StoryRecord_maxSoulUp();

        public static void StoryRecord_charmsChanged() =>
            GameManager.instance.StoryRecord_charmsChanged();

        public static void StoryRecord_charmEquipped(string charmName) =>
            GameManager.instance.StoryRecord_charmEquipped(charmName);

        public static void StoryRecord_start() =>
            GameManager.instance.StoryRecord_start();

        public static void AwardAchievement(string key) =>
            GameManager.instance.AwardAchievement(key);

        public static void QueueAchievement(string key) =>
            GameManager.instance.QueueAchievement(key);

        public static void AwardQueuedAchievements() =>
            GameManager.instance.AwardQueuedAchievements();

        public static bool IsAchievementAwarded(string key) =>
            GameManager.instance.IsAchievementAwarded(key);

        public static void ClearAllAchievements() =>
            GameManager.instance.ClearAllAchievements();

        public static void CheckCharmAchievements() =>
            GameManager.instance.CheckCharmAchievements();

        public static void CheckGrubAchievements() =>
            GameManager.instance.CheckGrubAchievements();

        public static void CheckStagStationAchievements() =>
            GameManager.instance.CheckStagStationAchievements();

        public static void CheckMapAchievement() =>
            GameManager.instance.CheckMapAchievement();

        public static void CheckJournalAchievements() =>
            GameManager.instance.CheckJournalAchievements();

        public static void CheckAllAchievements() =>
            GameManager.instance.CheckAllAchievements();

        public static void CheckBanishmentAchievement() =>
            GameManager.instance.CheckBanishmentAchievement();

        public static void SetStatusRecordInt(string key, int value) =>
            GameManager.instance.SetStatusRecordInt(key, value);

        public static int GetStatusRecordInt(string key) =>
            GameManager.instance.GetStatusRecordInt(key);

        public static void ResetStatusRecords() =>
            GameManager.instance.ResetStatusRecords();

        public static void SaveStatusRecords() =>
            GameManager.instance.SaveStatusRecords();

        public static void SetState(GlobalEnums.GameState newState) =>
            GameManager.instance.SetState(newState);

        public static void LoadScene(string destScene) =>
            GameManager.instance.LoadScene(destScene);

        public static System.Collections.IEnumerator LoadSceneAdditive(string destScene) =>
            GameManager.instance.LoadSceneAdditive(destScene);

        public static void OnNextLevelReady() =>
            GameManager.instance.OnNextLevelReady();

        public static void OnWillActivateFirstLevel() =>
            GameManager.instance.OnWillActivateFirstLevel();

        public static System.Collections.IEnumerator LoadFirstScene() =>
            GameManager.instance.LoadFirstScene();

        public static void LoadPermadeathUnlockScene() =>
            GameManager.instance.LoadPermadeathUnlockScene();

        public static void LoadMrMushromScene() =>
            GameManager.instance.LoadMrMushromScene();

        public static void LoadOpeningCinematic() =>
            GameManager.instance.LoadOpeningCinematic();

        public static void PositionHeroAtSceneEntrance() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "PositionHeroAtSceneEntrance");

        public static UnityEngine.Vector2? FindEntryPoint(string entryPointName,
            UnityEngine.SceneManagement.Scene filterScene) =>
            ReflectionHelper.CallMethod<GameManager, UnityEngine.Vector2?>(GameManager.instance, "FindEntryPoint",
                entryPointName, filterScene);

        public static TransitionPoint FindTransitionPoint(string entryPointName,
            UnityEngine.SceneManagement.Scene filterScene, bool fallbackToAnyAvailable) =>
            ReflectionHelper.CallMethod<GameManager, TransitionPoint>(GameManager.instance, "FindTransitionPoint",
                entryPointName, filterScene, fallbackToAnyAvailable);

        public static void EnterHero(bool additiveGateSearch = false) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "EnterHero", additiveGateSearch);

        public static void FinishedEnteringScene() =>
            GameManager.instance.FinishedEnteringScene();

        public static void SetupGameRefs() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "SetupGameRefs");

        public static void SetupSceneRefs(bool refreshTilemapInfo) =>
            GameManager.instance.SetupSceneRefs(refreshTilemapInfo);

        public static void SetupHeroRefs() =>
            GameManager.instance.SetupHeroRefs();

        public static void BeginScene() =>
            GameManager.instance.BeginScene();

        public static void UpdateUIStateFromGameState() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "UpdateUIStateFromGameState");

        public static void SkipCutscene() =>
            GameManager.instance.SkipCutscene();

        public static System.Collections.IEnumerator SkipCutsceneNoMash() =>
            ReflectionHelper.CallMethod<GameManager, System.Collections.IEnumerator>(GameManager.instance,
                "SkipCutsceneNoMash");

        public static void NoLongerFirstGame() =>
            GameManager.instance.NoLongerFirstGame();

        public static void SetupStatusModifiers() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "SetupStatusModifiers");

        public static void MatchBackerCreditsSetting() =>
            GameManager.instance.MatchBackerCreditsSetting();

        public static void RefreshLocalization() =>
            GameManager.instance.RefreshLocalization();

        public static void RefreshParticleSystems() =>
            GameManager.instance.RefreshParticleSystems();

        public static void ApplyNativeInput() =>
            GameManager.instance.ApplyNativeInput();

        public static void EnablePermadeathMode() =>
            GameManager.instance.EnablePermadeathMode();

        public static string GetCurrentMapZone() =>
            GameManager.instance.GetCurrentMapZone();

        public static float GetSceneWidth() =>
            GameManager.instance.GetSceneWidth();

        public static float GetSceneHeight() =>
            GameManager.instance.GetSceneHeight();

        public static UnityEngine.GameObject GetSceneManager() =>
            GameManager.instance.GetSceneManager();

        public static string GetFormattedMapZoneString(GlobalEnums.MapZone mapZone) =>
            GameManager.instance.GetFormattedMapZoneString(mapZone);

        public static void UpdateSceneName() =>
            GameManager.instance.UpdateSceneName();

        public static string GetSceneNameString() =>
            GameManager.instance.GetSceneNameString();

        public static void RefreshTilemapInfo(string targetScene) =>
            GameManager.instance.RefreshTilemapInfo(targetScene);

        public static void SaveLevelState() =>
            GameManager.instance.SaveLevelState();

        public static void ResetSemiPersistentItems() =>
            GameManager.instance.ResetSemiPersistentItems();

        public static bool IsMenuScene() =>
            GameManager.instance.IsMenuScene();

        public static bool IsTitleScreenScene() =>
            GameManager.instance.IsTitleScreenScene();

        public static bool IsGameplayScene() =>
            GameManager.instance.IsGameplayScene();

        public static bool IsNonGameplayScene() =>
            GameManager.instance.IsNonGameplayScene();

        public static bool IsCinematicScene() =>
            GameManager.instance.IsCinematicScene();

        public static bool IsStagTravelScene() =>
            GameManager.instance.IsStagTravelScene();

        public static bool IsBetaEndScene() =>
            GameManager.instance.IsBetaEndScene();

        public static bool IsTutorialScene() =>
            GameManager.instance.IsTutorialScene();

        public static bool IsTestScene() =>
            GameManager.instance.IsTestScene();

        public static bool IsBossDoorScene() =>
            GameManager.instance.IsBossDoorScene();

        public static bool ShouldKeepHUDCameraActive() =>
            GameManager.instance.ShouldKeepHUDCameraActive();

        public static bool IsUnloadAssetsRequired(string sourceSceneName, string destinationSceneName) =>
            GameManager.instance.IsUnloadAssetsRequired(sourceSceneName, destinationSceneName);

        public static void HasSaveFile(int saveSlot, System.Action<bool> callback) =>
            GameManager.instance.HasSaveFile(saveSlot, callback);

        public static void SaveGame() =>
            GameManager.instance.SaveGame();

        public static void ShowSaveIcon() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "ShowSaveIcon");

        public static void HideSaveIcon() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "HideSaveIcon");

        public static void SaveGame(System.Action<bool> callback) =>
            GameManager.instance.SaveGame(callback);

        public static void ResetGameTimer() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "ResetGameTimer");

        public static void IncreaseGameTimer(ref float timer) =>
            GameManager.instance.IncreaseGameTimer(ref timer);

        public static void SaveGame(int saveSlot, System.Action<bool> callback) =>
            GameManager.instance.SaveGame(saveSlot, callback);

        public static void LoadGameFromUI(int saveSlot) =>
            GameManager.instance.LoadGameFromUI(saveSlot);

        public static System.Collections.IEnumerator LoadGameFromUIRoutine(int saveSlot) =>
            ReflectionHelper.CallMethod<GameManager, System.Collections.IEnumerator>(GameManager.instance,
                "LoadGameFromUIRoutine", saveSlot);

        public static void LoadGame(int saveSlot, System.Action<bool> callback) =>
            GameManager.instance.LoadGame(saveSlot, callback);

        public static void ClearSaveFile(int saveSlot, System.Action<bool> callback) =>
            GameManager.instance.ClearSaveFile(saveSlot, callback);

        public static void GetSaveStatsForSlot(int saveSlot, System.Action<SaveStats> callback) =>
            GameManager.instance.GetSaveStatsForSlot(saveSlot, callback);

        public static System.Collections.IEnumerator PauseGameToggleByMenu() =>
            GameManager.instance.PauseGameToggleByMenu();

        public static System.Collections.IEnumerator PauseGameToggle() =>
            GameManager.instance.PauseGameToggle();

        public static System.Collections.IEnumerator SetTimeScale(float newTimeScale, float duration) =>
            ReflectionHelper.CallMethod<GameManager, System.Collections.IEnumerator>(GameManager.instance,
                "SetTimeScale", newTimeScale, duration);

        public static void SetTimeScale(float newTimeScale) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "SetTimeScale", newTimeScale);

        public static void FreezeMoment(int type) =>
            GameManager.instance.FreezeMoment(type);

        public static System.Collections.IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime,
            float targetSpeed) =>
            GameManager.instance.FreezeMoment(rampDownTime, waitTime, rampUpTime, targetSpeed);

        public static System.Collections.IEnumerator FreezeMomentGC(float rampDownTime, float waitTime,
            float rampUpTime, float targetSpeed) =>
            GameManager.instance.FreezeMomentGC(rampDownTime, waitTime, rampUpTime, targetSpeed);

        public static System.Collections.IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime,
            bool runGc = false) =>
            GameManager.instance.FreezeMoment(rampDownTime, waitTime, rampUpTime, runGc);

        public static void EnsureSaveSlotSpace(System.Action<bool> callback) =>
            GameManager.instance.EnsureSaveSlotSpace(callback);

        public static void StartNewGame(bool permadeathMode = false, bool bossRushMode = false) =>
            GameManager.instance.StartNewGame(permadeathMode, bossRushMode);

        public static System.Collections.IEnumerator RunStartNewGame() =>
            GameManager.instance.RunStartNewGame();

        public static void ContinueGame() =>
            GameManager.instance.ContinueGame();

        public static System.Collections.IEnumerator RunContinueGame() =>
            GameManager.instance.RunContinueGame();

        public static System.Collections.IEnumerator ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes saveMode, System.Action<bool> callback = null) =>
        GameManager.instance.ReturnToMainMenu(saveMode, callback);

        public static void WillTerminateInBackground() =>
            GameManager.instance.WillTerminateInBackground();

        //idk how else to make it compile
        public static void Platform_IDisengageHandler_OnDisengage(System.Action next) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "Platform.IDisengageHandler.OnDisengage",
                next);

        public static GameManager.ControllerConnectionStates GetControllerConnectionState() =>
            GameManager.instance.GetControllerConnectionState();

        public static void EmergencyReturnToMenu(System.Action callback) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "EmergencyReturnToMenu", callback);

        public static System.Collections.IEnumerator QuitGame() =>
            GameManager.instance.QuitGame();

        public static void LoadedBoss() =>
            GameManager.instance.LoadedBoss();

        public static void DoDestroyPersonalPools() =>
            GameManager.instance.DoDestroyPersonalPools();

        public static float GetImplicitCinematicVolume() =>
            GameManager.instance.GetImplicitCinematicVolume();

        public static UIManager orig_get_ui() =>
            GameManager.instance.orig_get_ui();

        public static void orig_set_ui(UIManager value) =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "orig_set_ui", value);

        public static void orig_OnApplicationQuit() =>
            ReflectionHelper.CallMethod<GameManager>(GameManager.instance, "orig_OnApplicationQuit");

        public static void orig_LoadScene(string destScene) =>
            GameManager.instance.orig_LoadScene(destScene);

        public static void orig_BeginSceneTransition(GameManager.SceneLoadInfo info) =>
            GameManager.instance.orig_BeginSceneTransition(info);

        public static void orig_ClearSaveFile(int saveSlot, System.Action<bool> callback) =>
            GameManager.instance.orig_ClearSaveFile(saveSlot, callback);

        public static System.Collections.IEnumerator orig_PlayerDead(float waitTime) =>
            GameManager.instance.orig_PlayerDead(waitTime);

        public static void orig_SetupSceneRefs(bool refreshTilemapInfo) =>
            GameManager.instance.orig_SetupSceneRefs(refreshTilemapInfo);

        public static void orig_OnWillActivateFirstLevel() =>
            GameManager.instance.orig_OnWillActivateFirstLevel();

        public static System.Collections.IEnumerator PauseToggleDynamicMenu(MenuScreen screen,
            bool allowUnpause = false) =>
            GameManager.instance.PauseToggleDynamicMenu(screen, allowUnpause);
        
        //static methods
        public static string GetBaseSceneName (string fullSceneName) =>
            GameManager.GetBaseSceneName(fullSceneName);

        public static tk2dTileMap GetTileMap (UnityEngine.GameObject gameObject) =>
            ReflectionHelper.CallMethod<GameManager,tk2dTileMap>("GetTileMap", gameObject);

        public static string GetSceneZoneName (string str) =>
            ReflectionHelper.CallMethod<GameManager,string>("GetSceneZoneName", str);

        public static int CountBits (int val) =>
            ReflectionHelper.CallMethod<GameManager,int>("CountBits", val);

        public static string ModdedSavePath (int slot) =>
            ReflectionHelper.CallMethod<GameManager,string>("ModdedSavePath", slot);
    }
}