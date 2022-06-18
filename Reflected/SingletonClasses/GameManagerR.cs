using InControl;
using UnityEngine.Audio;

namespace Satchel.Reflected
{
    /// <summary>
    ///     A class that contains all (public and private) fields and methods of GameManager allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public static class GameManagerR
    {
        public static bool verboseMode
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "verboseMode");
            set => ReflectionHelper.SetField(GameManager.instance, "verboseMode", value);
        }

        public static GameState gameState
        {
            get => GameManager.instance.gameState;
            set => GameManager.instance.gameState = value;
        }

        public static bool isPaused
        {
            get => GameManager.instance.isPaused;
            set => GameManager.instance.isPaused = value;
        }

        public static int timeSlowedCount
        {
            get => ReflectionHelper.GetField<GameManager, int>(GameManager.instance, "timeSlowedCount");
            set => ReflectionHelper.SetField(GameManager.instance, "timeSlowedCount", value);
        }

        public static string sceneName
        {
            get => GameManager.instance.sceneName;
            set => GameManager.instance.sceneName = value;
        }

        public static string nextSceneName
        {
            get => GameManager.instance.nextSceneName;
            set => GameManager.instance.nextSceneName = value;
        }

        public static string entryGateName
        {
            get => GameManager.instance.entryGateName;
            set => GameManager.instance.entryGateName = value;
        }

        public static TransitionPoint callingGate
        {
            get => ReflectionHelper.GetField<GameManager, TransitionPoint>(GameManager.instance, "callingGate");
            set => ReflectionHelper.SetField(GameManager.instance, "callingGate", value);
        }

        public static Vector3 entrySpawnPoint
        {
            get => ReflectionHelper.GetField<GameManager, Vector3>(GameManager.instance, "entrySpawnPoint");
            set => ReflectionHelper.SetField(GameManager.instance, "entrySpawnPoint", value);
        }

        public static float entryDelay
        {
            get => ReflectionHelper.GetField<GameManager, float>(GameManager.instance, "entryDelay");
            set => ReflectionHelper.SetField(GameManager.instance, "entryDelay", value);
        }

        public static float sceneWidth
        {
            get => GameManager.instance.sceneWidth;
            set => GameManager.instance.sceneWidth = value;
        }

        public static float sceneHeight
        {
            get => GameManager.instance.sceneHeight;
            set => GameManager.instance.sceneHeight = value;
        }

        public static GameConfig gameConfig
        {
            get => GameManager.instance.gameConfig;
            set => GameManager.instance.gameConfig = value;
        }

        public static InputHandler inputHandler
        {
            get => GameManager.instance.inputHandler;
            set => ReflectionHelper.SetProperty(GameManager.instance, "inputHandler", value);
        }

        public static GameCameras gameCams
        {
            get => ReflectionHelper.GetField<GameManager, GameCameras>(GameManager.instance, "gameCams");
            set => ReflectionHelper.SetField(GameManager.instance, "gameCams", value);
        }

        public static AchievementHandler achievementHandler
        {
            get => GameManager.instance.achievementHandler;
            set => ReflectionHelper.SetProperty(GameManager.instance, "achievementHandler", value);
        }

        public static AudioManager audioManager
        {
            get => ReflectionHelper.GetField<GameManager, AudioManager>(GameManager.instance, "audioManager");
            set => ReflectionHelper.SetField(GameManager.instance, "audioManager", value);
        }

        public static InControlManager inControlManagerPrefab
        {
            get => ReflectionHelper.GetField<GameManager, InControlManager>(GameManager.instance,
                "inControlManagerPrefab");
            set => ReflectionHelper.SetField(GameManager.instance, "inControlManagerPrefab", value);
        }

        public static GameSettings gameSettings
        {
            get => GameManager.instance.gameSettings;
            set => GameManager.instance.gameSettings = value;
        }

        public static TimeScaleIndependentUpdate timeTool
        {
            get => GameManager.instance.timeTool;
            set => GameManager.instance.timeTool = value;
        }

        public static GameObject gameMap
        {
            get => GameManager.instance.gameMap;
            set => GameManager.instance.gameMap = value;
        }

        public static CameraController cameraCtrl
        {
            get => GameManager.instance.cameraCtrl;
            set => ReflectionHelper.SetProperty(GameManager.instance, "cameraCtrl", value);
        }

        public static HeroController hero_ctrl
        {
            get => GameManager.instance.hero_ctrl;
            set => ReflectionHelper.SetProperty(GameManager.instance, "hero_ctrl", value);
        }

        public static SpriteRenderer heroLight
        {
            get => GameManager.instance.heroLight;
            set => ReflectionHelper.SetProperty(GameManager.instance, "heroLight", value);
        }

        public static SceneManager sm
        {
            get => GameManager.instance.sm;
            set => ReflectionHelper.SetProperty(GameManager.instance, "sm", value);
        }

        public static UIManager ui
        {
            get => GameManager.instance.ui;
            set => ReflectionHelper.SetProperty(GameManager.instance, "ui", value);
        }

        public static tk2dTileMap tilemap
        {
            get => GameManager.instance.tilemap;
            set => ReflectionHelper.SetProperty(GameManager.instance, "tilemap", value);
        }

        public static PlayMakerFSM soulOrb_fsm
        {
            get => GameManager.instance.soulOrb_fsm;
            set => ReflectionHelper.SetProperty(GameManager.instance, "soulOrb_fsm", value);
        }

        public static PlayMakerFSM soulVessel_fsm
        {
            get => GameManager.instance.soulVessel_fsm;
            set => ReflectionHelper.SetProperty(GameManager.instance, "soulVessel_fsm", value);
        }

        public static PlayMakerFSM inventoryFSM
        {
            get => GameManager.instance.inventoryFSM;
            set => GameManager.instance.inventoryFSM = value;
        }

        public static PlayerData playerData
        {
            get => GameManager.instance.playerData;
            set => GameManager.instance.playerData = value;
        }

        public static SceneData sceneData
        {
            get => GameManager.instance.sceneData;
            set => GameManager.instance.sceneData = value;
        }

        public static int profileID
        {
            get => GameManager.instance.profileID;
            set => GameManager.instance.profileID = value;
        }

        public static bool needsFlush
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "needsFlush");
            set => ReflectionHelper.SetField(GameManager.instance, "needsFlush", value);
        }

        public static bool isEmergencyReturningToMenu
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "isEmergencyReturningToMenu");
            set => ReflectionHelper.SetField(GameManager.instance, "isEmergencyReturningToMenu", value);
        }

        public static float sessionPlayTimer
        {
            get => ReflectionHelper.GetField<GameManager, float>(GameManager.instance, "sessionPlayTimer");
            set => ReflectionHelper.SetField(GameManager.instance, "sessionPlayTimer", value);
        }

        public static float sessionStartTime
        {
            get => ReflectionHelper.GetField<GameManager, float>(GameManager.instance, "sessionStartTime");
            set => ReflectionHelper.SetField(GameManager.instance, "sessionStartTime", value);
        }

        public static bool startedOnThisScene
        {
            get => GameManager.instance.startedOnThisScene;
            set => GameManager.instance.startedOnThisScene = value;
        }

        public static bool RespawningHero
        {
            get => GameManager.instance.RespawningHero;
            set => GameManager.instance.RespawningHero = value;
        }

        public static bool hazardRespawningHero
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "hazardRespawningHero");
            set => ReflectionHelper.SetField(GameManager.instance, "hazardRespawningHero", value);
        }

        public static string targetScene
        {
            get => ReflectionHelper.GetField<GameManager, string>(GameManager.instance, "targetScene");
            set => ReflectionHelper.SetField(GameManager.instance, "targetScene", value);
        }

        public static bool tilemapDirty
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "tilemapDirty");
            set => ReflectionHelper.SetField(GameManager.instance, "tilemapDirty", value);
        }

        public static bool needFirstFadeIn
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "needFirstFadeIn");
            set => ReflectionHelper.SetField(GameManager.instance, "needFirstFadeIn", value);
        }

        public static bool waitForManualLevelStart
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "waitForManualLevelStart");
            set => ReflectionHelper.SetField(GameManager.instance, "waitForManualLevelStart", value);
        }

        public static bool startedSteamEnabled
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "startedSteamEnabled");
            set => ReflectionHelper.SetField(GameManager.instance, "startedSteamEnabled", value);
        }

        public static bool startedGOGEnabled
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "startedGOGEnabled");
            set => ReflectionHelper.SetField(GameManager.instance, "startedGOGEnabled", value);
        }

        public static bool startedLanguageDisabled
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "startedLanguageDisabled");
            set => ReflectionHelper.SetField(GameManager.instance, "startedLanguageDisabled", value);
        }

        public static AudioMixerSnapshot actorSnapshotUnpaused
        {
            get => GameManager.instance.actorSnapshotUnpaused;
            set => GameManager.instance.actorSnapshotUnpaused = value;
        }

        public static AudioMixerSnapshot actorSnapshotPaused
        {
            get => GameManager.instance.actorSnapshotPaused;
            set => GameManager.instance.actorSnapshotPaused = value;
        }

        public static AudioMixerSnapshot silentSnapshot
        {
            get => GameManager.instance.silentSnapshot;
            set => GameManager.instance.silentSnapshot = value;
        }

        public static AudioMixerSnapshot noMusicSnapshot
        {
            get => GameManager.instance.noMusicSnapshot;
            set => GameManager.instance.noMusicSnapshot = value;
        }

        public static MusicCue noMusicCue
        {
            get => GameManager.instance.noMusicCue;
            set => GameManager.instance.noMusicCue = value;
        }

        public static AudioMixerSnapshot noAtmosSnapshot
        {
            get => GameManager.instance.noAtmosSnapshot;
            set => GameManager.instance.noAtmosSnapshot = value;
        }


        public static bool IsInSceneTransition
        {
            get => GameManager.instance.IsInSceneTransition;
            set => ReflectionHelper.SetProperty(GameManager.instance, "IsInSceneTransition", value);
        }

        public static bool hasFinishedEnteringScene
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "hasFinishedEnteringScene");
            set => ReflectionHelper.SetField(GameManager.instance, "hasFinishedEnteringScene", value);
        }

        public static WorldInfo worldInfo
        {
            get => ReflectionHelper.GetField<GameManager, WorldInfo>(GameManager.instance, "worldInfo");
            set => ReflectionHelper.SetField(GameManager.instance, "worldInfo", value);
        }

        public static bool isLoading
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "isLoading");
            set => ReflectionHelper.SetField(GameManager.instance, "isLoading", value);
        }

        public static float currentLoadDuration
        {
            get => ReflectionHelper.GetField<GameManager, float>(GameManager.instance, "currentLoadDuration");
            set => ReflectionHelper.SetField(GameManager.instance, "currentLoadDuration", value);
        }

        public static int sceneLoadsWithoutGarbageCollect
        {
            get => ReflectionHelper.GetField<GameManager, int>(GameManager.instance, "sceneLoadsWithoutGarbageCollect");
            set => ReflectionHelper.SetField(GameManager.instance, "sceneLoadsWithoutGarbageCollect", value);
        }

        public static bool isUsingCustomLoadAnimation
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "isUsingCustomLoadAnimation");
            set => ReflectionHelper.SetField(GameManager.instance, "isUsingCustomLoadAnimation", value);
        }

        public static StandaloneLoadingSpinner standaloneLoadingSpinnerPrefab
        {
            get => ReflectionHelper.GetField<GameManager, StandaloneLoadingSpinner>(GameManager.instance
                , "standaloneLoadingSpinnerPrefab");

            set => ReflectionHelper.SetField(GameManager.instance, "standaloneLoadingSpinnerPrefab", value);
        }

        public static SceneLoad sceneLoad
        {
            get => ReflectionHelper.GetField<GameManager, SceneLoad>(GameManager.instance, "sceneLoad");
            set => ReflectionHelper.SetField(GameManager.instance, "sceneLoad", value);
        }

        public static int saveIconShowCounter
        {
            get => ReflectionHelper.GetField<GameManager, int>(GameManager.instance, "saveIconShowCounter");
            set => ReflectionHelper.SetField(GameManager.instance, "saveIconShowCounter", value);
        }

        public static UIManager _uiInstance
        {
            get => ReflectionHelper.GetField<GameManager, UIManager>(GameManager.instance, "_uiInstance");
            set => ReflectionHelper.SetField(GameManager.instance, "_uiInstance", value);
        }

        //static fields

        public static InControlManager _spawnedInControlManager
        {
            get => ReflectionHelper.GetField<GameManager, InControlManager>("_spawnedInControlManager");
            set => ReflectionHelper.SetField<GameManager, InControlManager>("_spawnedInControlManager", value);
        }

        public static int NoSaveSlotID => GameManager.NoSaveSlotID;

        //its a const no setter
        public static string[] SubSceneNameSuffixes
        {
            get => ReflectionHelper.GetField<GameManager, string[]>("SubSceneNameSuffixes");
            set => ReflectionHelper.SetField<GameManager, string[]>("SubSceneNameSuffixes", value);
        }

        #region Methods

        public static void Awake()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "Awake");
        }

        public static void Start()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "Start");
        }

        public static void Update()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "Update");
        }

        public static void UpdateEngagement()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "UpdateEngagement");
        }

        public static void LevelActivated(Scene sceneFrom,
            Scene sceneTo)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "LevelActivated", sceneFrom, sceneTo);
        }

        public static void OnDisable()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "OnDisable");
        }

        public static void OnApplicationQuit()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "OnApplicationQuit");
        }

        public static void BeginSceneTransition(GameManager.SceneLoadInfo info)
        {
            GameManager.instance.BeginSceneTransition(info);
        }

        public static IEnumerator BeginSceneTransitionRoutine(GameManager.SceneLoadInfo info)
        {
            return ReflectionHelper.CallMethod<GameManager, IEnumerator>(GameManager.instance,
                "BeginSceneTransitionRoutine", info);
        }

        public static IEnumerator TransitionScene(TransitionPoint gate)
        {
            return GameManager.instance.TransitionScene(gate);
        }

        public static void ChangeToScene(string targetScene, string entryGateName, float pauseBeforeEnter)
        {
            GameManager.instance.ChangeToScene(targetScene, entryGateName, pauseBeforeEnter);
        }

        public static void WarpToDreamGate()
        {
            GameManager.instance.WarpToDreamGate();
        }

        public static void LeftScene(bool doAdditiveLoad = false)
        {
            GameManager.instance.LeftScene(doAdditiveLoad);
        }

        public static IEnumerator PlayerDead(float waitTime)
        {
            return GameManager.instance.PlayerDead(waitTime);
        }

        public static IEnumerator PlayerDeadFromHazard(float waitTime)
        {
            return GameManager.instance.PlayerDeadFromHazard(waitTime);
        }

        public static void ReadyForRespawn(bool isFirstLevelForPlayer)
        {
            GameManager.instance.ReadyForRespawn(isFirstLevelForPlayer);
        }

        public static void HazardRespawn()
        {
            GameManager.instance.HazardRespawn();
        }

        public static void TimePasses()
        {
            GameManager.instance.TimePasses();
        }

        public static void FadeSceneIn()
        {
            GameManager.instance.FadeSceneIn();
        }

        public static IEnumerator FadeSceneInWithDelay(float delay)
        {
            return GameManager.instance.FadeSceneInWithDelay(delay);
        }

        public static bool IsGamePaused()
        {
            return GameManager.instance.IsGamePaused();
        }

        public static void SetGameMap(GameObject go_gameMap)
        {
            GameManager.instance.SetGameMap(go_gameMap);
        }

        public static void CalculateNotchesUsed()
        {
            GameManager.instance.CalculateNotchesUsed();
        }

        public static string GetLanguageAsString()
        {
            return GameManager.instance.GetLanguageAsString();
        }

        public static string GetEntryGateName()
        {
            return GameManager.instance.GetEntryGateName();
        }

        public static void SetPlayerDataBool(string boolName, bool value)
        {
            GameManager.instance.SetPlayerDataBool(boolName, value);
        }

        public static void SetPlayerDataInt(string intName, int value)
        {
            GameManager.instance.SetPlayerDataInt(intName, value);
        }

        public static void SetPlayerDataFloat(string floatName, float value)
        {
            GameManager.instance.SetPlayerDataFloat(floatName, value);
        }

        public static void SetPlayerDataString(string stringName, string value)
        {
            GameManager.instance.SetPlayerDataString(stringName, value);
        }

        public static void IncrementPlayerDataInt(string intName)
        {
            GameManager.instance.IncrementPlayerDataInt(intName);
        }

        public static void DecrementPlayerDataInt(string intName)
        {
            GameManager.instance.DecrementPlayerDataInt(intName);
        }

        public static void IntAdd(string intName, int amount)
        {
            GameManager.instance.IntAdd(intName, amount);
        }

        public static bool GetPlayerDataBool(string boolName)
        {
            return GameManager.instance.GetPlayerDataBool(boolName);
        }

        public static int GetPlayerDataInt(string intName)
        {
            return GameManager.instance.GetPlayerDataInt(intName);
        }

        public static float GetPlayerDataFloat(string floatName)
        {
            return GameManager.instance.GetPlayerDataFloat(floatName);
        }

        public static string GetPlayerDataString(string stringName)
        {
            return GameManager.instance.GetPlayerDataString(stringName);
        }

        public static void SetPlayerDataVector3(string vectorName, Vector3 value)
        {
            GameManager.instance.SetPlayerDataVector3(vectorName, value);
        }

        public static Vector3 GetPlayerDataVector3(string vectorName)
        {
            return GameManager.instance.GetPlayerDataVector3(vectorName);
        }

        public static T GetPlayerDataVariable<T>(string fieldName)
        {
            return GameManager.instance.GetPlayerDataVariable<T>(fieldName);
        }

        public static void SetPlayerDataVariable<T>(string fieldName, T value)
        {
            GameManager.instance.SetPlayerDataVariable(fieldName, value);
        }

        public static void EquipCharm(int charmNum)
        {
            GameManager.instance.EquipCharm(charmNum);
        }

        public static void UnequipCharm(int charmNum)
        {
            GameManager.instance.UnequipCharm(charmNum);
        }

        public static void RefreshOvercharm()
        {
            GameManager.instance.RefreshOvercharm();
        }

        public static void UpdateBlueHealth()
        {
            GameManager.instance.UpdateBlueHealth();
        }

        public static void SetCurrentMapZoneAsRespawn()
        {
            GameManager.instance.SetCurrentMapZoneAsRespawn();
        }

        public static void SetMapZoneToSpecific(string mapZone)
        {
            GameManager.instance.SetMapZoneToSpecific(mapZone);
        }

        public static void StartSoulLimiter()
        {
            GameManager.instance.StartSoulLimiter();
        }

        public static void EndSoulLimiter()
        {
            GameManager.instance.EndSoulLimiter();
        }

        public static bool UpdateGameMap()
        {
            return GameManager.instance.UpdateGameMap();
        }

        public static void CheckAllMaps()
        {
            GameManager.instance.CheckAllMaps();
        }

        public static void AddToScenesVisited(string scene)
        {
            GameManager.instance.AddToScenesVisited(scene);
        }

        public static bool GetIsSceneVisited(string scene)
        {
            return GameManager.instance.GetIsSceneVisited(scene);
        }

        public static void AddToBenchList()
        {
            GameManager.instance.AddToBenchList();
        }

        public static void AddToGrubList()
        {
            GameManager.instance.AddToGrubList();
        }

        public static void AddToFlameList()
        {
            GameManager.instance.AddToFlameList();
        }

        public static void AddToCocoonList()
        {
            GameManager.instance.AddToCocoonList();
        }

        public static void AddToDreamPlantList()
        {
            GameManager.instance.AddToDreamPlantList();
        }

        public static void AddToDreamPlantCList()
        {
            GameManager.instance.AddToDreamPlantCList();
        }

        public static void CountGameCompletion()
        {
            GameManager.instance.CountGameCompletion();
        }

        public static void CountCharms()
        {
            GameManager.instance.CountCharms();
        }

        public static void CountJournalEntries()
        {
            GameManager.instance.CountJournalEntries();
        }

        public static void ActivateTestingCheats()
        {
            GameManager.instance.ActivateTestingCheats();
        }

        public static void GetAllPowerups()
        {
            GameManager.instance.GetAllPowerups();
        }

        public static void StoryRecord_death()
        {
            GameManager.instance.StoryRecord_death();
        }

        public static void StoryRecord_rescueGrub()
        {
            GameManager.instance.StoryRecord_rescueGrub();
        }

        public static void StoryRecord_defeatedShade()
        {
            GameManager.instance.StoryRecord_defeatedShade();
        }

        public static void StoryRecord_discoveredArea(string areaName)
        {
            GameManager.instance.StoryRecord_discoveredArea(areaName);
        }

        public static void StoryRecord_travelledToArea(string areaName)
        {
            GameManager.instance.StoryRecord_travelledToArea(areaName);
        }

        public static void StoryRecord_bankDeposit(int amount)
        {
            GameManager.instance.StoryRecord_bankDeposit(amount);
        }

        public static void StoryRecord_bankWithdraw(int amount)
        {
            GameManager.instance.StoryRecord_bankWithdraw(amount);
        }

        public static void StoryRecord_boughtCorniferMap(string map)
        {
            GameManager.instance.StoryRecord_boughtCorniferMap(map);
        }

        public static void StoryRecord_visited(string visited)
        {
            GameManager.instance.StoryRecord_visited(visited);
        }

        public static void StoryRecord_defeated(string defeated)
        {
            GameManager.instance.StoryRecord_defeated(defeated);
        }

        public static void StoryRecord_jiji()
        {
            GameManager.instance.StoryRecord_jiji();
        }

        public static void StoryRecord_rodeStag(string dest)
        {
            GameManager.instance.StoryRecord_rodeStag(dest);
        }

        public static void StoryRecord_acquired(string item)
        {
            GameManager.instance.StoryRecord_acquired(item);
        }

        public static void StoryRecord_bought(string item)
        {
            GameManager.instance.StoryRecord_bought(item);
        }

        public static void StoryRecord_quit()
        {
            GameManager.instance.StoryRecord_quit();
        }

        public static void StoryRecord_rest()
        {
            GameManager.instance.StoryRecord_rest();
        }

        public static void StoryRecord_upgradeNail()
        {
            GameManager.instance.StoryRecord_upgradeNail();
        }

        public static void StoryRecord_heartPiece()
        {
            GameManager.instance.StoryRecord_heartPiece();
        }

        public static void StoryRecord_maxHealthUp()
        {
            GameManager.instance.StoryRecord_maxHealthUp();
        }

        public static void StoryRecord_soulPiece()
        {
            GameManager.instance.StoryRecord_soulPiece();
        }

        public static void StoryRecord_maxSoulUp()
        {
            GameManager.instance.StoryRecord_maxSoulUp();
        }

        public static void StoryRecord_charmsChanged()
        {
            GameManager.instance.StoryRecord_charmsChanged();
        }

        public static void StoryRecord_charmEquipped(string charmName)
        {
            GameManager.instance.StoryRecord_charmEquipped(charmName);
        }

        public static void StoryRecord_start()
        {
            GameManager.instance.StoryRecord_start();
        }

        public static void AwardAchievement(string key)
        {
            GameManager.instance.AwardAchievement(key);
        }

        public static void QueueAchievement(string key)
        {
            GameManager.instance.QueueAchievement(key);
        }

        public static void AwardQueuedAchievements()
        {
            GameManager.instance.AwardQueuedAchievements();
        }

        public static bool IsAchievementAwarded(string key)
        {
            return GameManager.instance.IsAchievementAwarded(key);
        }

        public static void ClearAllAchievements()
        {
            GameManager.instance.ClearAllAchievements();
        }

        public static void CheckCharmAchievements()
        {
            GameManager.instance.CheckCharmAchievements();
        }

        public static void CheckGrubAchievements()
        {
            GameManager.instance.CheckGrubAchievements();
        }

        public static void CheckStagStationAchievements()
        {
            GameManager.instance.CheckStagStationAchievements();
        }

        public static void CheckMapAchievement()
        {
            GameManager.instance.CheckMapAchievement();
        }

        public static void CheckJournalAchievements()
        {
            GameManager.instance.CheckJournalAchievements();
        }

        public static void CheckAllAchievements()
        {
            GameManager.instance.CheckAllAchievements();
        }

        public static void CheckBanishmentAchievement()
        {
            GameManager.instance.CheckBanishmentAchievement();
        }

        public static void SetStatusRecordInt(string key, int value)
        {
            GameManager.instance.SetStatusRecordInt(key, value);
        }

        public static int GetStatusRecordInt(string key)
        {
            return GameManager.instance.GetStatusRecordInt(key);
        }

        public static void ResetStatusRecords()
        {
            GameManager.instance.ResetStatusRecords();
        }

        public static void SaveStatusRecords()
        {
            GameManager.instance.SaveStatusRecords();
        }

        public static void SetState(GameState newState)
        {
            GameManager.instance.SetState(newState);
        }

        public static void LoadScene(string destScene)
        {
            GameManager.instance.LoadScene(destScene);
        }

        public static IEnumerator LoadSceneAdditive(string destScene)
        {
            return GameManager.instance.LoadSceneAdditive(destScene);
        }

        public static void OnNextLevelReady()
        {
            GameManager.instance.OnNextLevelReady();
        }

        public static void OnWillActivateFirstLevel()
        {
            GameManager.instance.OnWillActivateFirstLevel();
        }

        public static IEnumerator LoadFirstScene()
        {
            return GameManager.instance.LoadFirstScene();
        }

        public static void LoadPermadeathUnlockScene()
        {
            GameManager.instance.LoadPermadeathUnlockScene();
        }

        public static void LoadMrMushromScene()
        {
            GameManager.instance.LoadMrMushromScene();
        }

        public static void LoadOpeningCinematic()
        {
            GameManager.instance.LoadOpeningCinematic();
        }

        public static void PositionHeroAtSceneEntrance()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "PositionHeroAtSceneEntrance");
        }

        public static Vector2? FindEntryPoint(string entryPointName,
            Scene filterScene)
        {
            return ReflectionHelper.CallMethod<GameManager, Vector2?>(GameManager.instance, "FindEntryPoint",
                entryPointName, filterScene);
        }

        public static TransitionPoint FindTransitionPoint(string entryPointName,
            Scene filterScene, bool fallbackToAnyAvailable)
        {
            return ReflectionHelper.CallMethod<GameManager, TransitionPoint>(GameManager.instance,
                "FindTransitionPoint",
                entryPointName, filterScene, fallbackToAnyAvailable);
        }

        public static void EnterHero(bool additiveGateSearch = false)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "EnterHero", additiveGateSearch);
        }

        public static void FinishedEnteringScene()
        {
            GameManager.instance.FinishedEnteringScene();
        }

        public static void SetupGameRefs()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "SetupGameRefs");
        }

        public static void SetupSceneRefs(bool refreshTilemapInfo)
        {
            GameManager.instance.SetupSceneRefs(refreshTilemapInfo);
        }

        public static void SetupHeroRefs()
        {
            GameManager.instance.SetupHeroRefs();
        }

        public static void BeginScene()
        {
            GameManager.instance.BeginScene();
        }

        public static void UpdateUIStateFromGameState()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "UpdateUIStateFromGameState");
        }

        public static void SkipCutscene()
        {
            GameManager.instance.SkipCutscene();
        }

        public static IEnumerator SkipCutsceneNoMash()
        {
            return ReflectionHelper.CallMethod<GameManager, IEnumerator>(GameManager.instance,
                "SkipCutsceneNoMash");
        }

        public static void NoLongerFirstGame()
        {
            GameManager.instance.NoLongerFirstGame();
        }

        public static void SetupStatusModifiers()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "SetupStatusModifiers");
        }

        public static void MatchBackerCreditsSetting()
        {
            GameManager.instance.MatchBackerCreditsSetting();
        }

        public static void RefreshLocalization()
        {
            GameManager.instance.RefreshLocalization();
        }

        public static void RefreshParticleSystems()
        {
            GameManager.instance.RefreshParticleSystems();
        }

        public static void ApplyNativeInput()
        {
            GameManager.instance.ApplyNativeInput();
        }

        public static void EnablePermadeathMode()
        {
            GameManager.instance.EnablePermadeathMode();
        }

        public static string GetCurrentMapZone()
        {
            return GameManager.instance.GetCurrentMapZone();
        }

        public static float GetSceneWidth()
        {
            return GameManager.instance.GetSceneWidth();
        }

        public static float GetSceneHeight()
        {
            return GameManager.instance.GetSceneHeight();
        }

        public static GameObject GetSceneManager()
        {
            return GameManager.instance.GetSceneManager();
        }

        public static string GetFormattedMapZoneString(MapZone mapZone)
        {
            return GameManager.instance.GetFormattedMapZoneString(mapZone);
        }

        public static void UpdateSceneName()
        {
            GameManager.instance.UpdateSceneName();
        }

        public static string GetSceneNameString()
        {
            return GameManager.instance.GetSceneNameString();
        }

        public static void RefreshTilemapInfo(string targetScene)
        {
            GameManager.instance.RefreshTilemapInfo(targetScene);
        }

        public static void SaveLevelState()
        {
            GameManager.instance.SaveLevelState();
        }

        public static void ResetSemiPersistentItems()
        {
            GameManager.instance.ResetSemiPersistentItems();
        }

        public static bool IsMenuScene()
        {
            return GameManager.instance.IsMenuScene();
        }

        public static bool IsTitleScreenScene()
        {
            return GameManager.instance.IsTitleScreenScene();
        }

        public static bool IsGameplayScene()
        {
            return GameManager.instance.IsGameplayScene();
        }

        public static bool IsNonGameplayScene()
        {
            return GameManager.instance.IsNonGameplayScene();
        }

        public static bool IsCinematicScene()
        {
            return GameManager.instance.IsCinematicScene();
        }

        public static bool IsStagTravelScene()
        {
            return GameManager.instance.IsStagTravelScene();
        }

        public static bool IsBetaEndScene()
        {
            return GameManager.instance.IsBetaEndScene();
        }

        public static bool IsTutorialScene()
        {
            return GameManager.instance.IsTutorialScene();
        }

        public static bool IsTestScene()
        {
            return GameManager.instance.IsTestScene();
        }

        public static bool IsBossDoorScene()
        {
            return GameManager.instance.IsBossDoorScene();
        }

        public static bool ShouldKeepHUDCameraActive()
        {
            return GameManager.instance.ShouldKeepHUDCameraActive();
        }

        public static bool IsUnloadAssetsRequired(string sourceSceneName, string destinationSceneName)
        {
            return GameManager.instance.IsUnloadAssetsRequired(sourceSceneName, destinationSceneName);
        }

        public static void HasSaveFile(int saveSlot, Action<bool> callback)
        {
            GameManager.instance.HasSaveFile(saveSlot, callback);
        }

        public static void SaveGame()
        {
            GameManager.instance.SaveGame();
        }

        public static void ShowSaveIcon()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "ShowSaveIcon");
        }

        public static void HideSaveIcon()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "HideSaveIcon");
        }

        public static void SaveGame(Action<bool> callback)
        {
            GameManager.instance.SaveGame(callback);
        }

        public static void ResetGameTimer()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "ResetGameTimer");
        }

        public static void IncreaseGameTimer(ref float timer)
        {
            GameManager.instance.IncreaseGameTimer(ref timer);
        }

        public static void SaveGame(int saveSlot, Action<bool> callback)
        {
            GameManager.instance.SaveGame(saveSlot, callback);
        }

        public static void LoadGameFromUI(int saveSlot)
        {
            GameManager.instance.LoadGameFromUI(saveSlot);
        }

        public static IEnumerator LoadGameFromUIRoutine(int saveSlot)
        {
            return ReflectionHelper.CallMethod<GameManager, IEnumerator>(GameManager.instance,
                "LoadGameFromUIRoutine", saveSlot);
        }

        public static void LoadGame(int saveSlot, Action<bool> callback)
        {
            GameManager.instance.LoadGame(saveSlot, callback);
        }

        public static void ClearSaveFile(int saveSlot, Action<bool> callback)
        {
            GameManager.instance.ClearSaveFile(saveSlot, callback);
        }

        public static void GetSaveStatsForSlot(int saveSlot, Action<SaveStats> callback)
        {
            GameManager.instance.GetSaveStatsForSlot(saveSlot, callback);
        }

        public static IEnumerator PauseGameToggleByMenu()
        {
            return GameManager.instance.PauseGameToggleByMenu();
        }

        public static IEnumerator PauseGameToggle()
        {
            return GameManager.instance.PauseGameToggle();
        }

        public static IEnumerator SetTimeScale(float newTimeScale, float duration)
        {
            return ReflectionHelper.CallMethod<GameManager, IEnumerator>(GameManager.instance,
                "SetTimeScale", newTimeScale, duration);
        }

        public static void SetTimeScale(float newTimeScale)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "SetTimeScale", newTimeScale);
        }

        public static void FreezeMoment(int type)
        {
            GameManager.instance.FreezeMoment(type);
        }

        public static IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime,
            float targetSpeed)
        {
            return GameManager.instance.FreezeMoment(rampDownTime, waitTime, rampUpTime, targetSpeed);
        }

        public static IEnumerator FreezeMomentGC(float rampDownTime, float waitTime,
            float rampUpTime, float targetSpeed)
        {
            return GameManager.instance.FreezeMomentGC(rampDownTime, waitTime, rampUpTime, targetSpeed);
        }

        public static IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime,
            bool runGc = false)
        {
            return GameManager.instance.FreezeMoment(rampDownTime, waitTime, rampUpTime, runGc);
        }

        public static void EnsureSaveSlotSpace(Action<bool> callback)
        {
            GameManager.instance.EnsureSaveSlotSpace(callback);
        }

        public static void StartNewGame(bool permadeathMode = false, bool bossRushMode = false)
        {
            GameManager.instance.StartNewGame(permadeathMode, bossRushMode);
        }

        public static IEnumerator RunStartNewGame()
        {
            return GameManager.instance.RunStartNewGame();
        }

        public static void ContinueGame()
        {
            GameManager.instance.ContinueGame();
        }

        public static IEnumerator RunContinueGame()
        {
            return GameManager.instance.RunContinueGame();
        }

        public static IEnumerator ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes saveMode,
            Action<bool> callback = null)
        {
            return GameManager.instance.ReturnToMainMenu(saveMode, callback);
        }

        public static void WillTerminateInBackground()
        {
            GameManager.instance.WillTerminateInBackground();
        }

        //idk how else to make it compile
        public static void Platform_IDisengageHandler_OnDisengage(Action next)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "Platform.IDisengageHandler.OnDisengage",
                next);
        }

        public static GameManager.ControllerConnectionStates GetControllerConnectionState()
        {
            return GameManager.instance.GetControllerConnectionState();
        }

        public static void EmergencyReturnToMenu(Action callback)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "EmergencyReturnToMenu", callback);
        }

        public static IEnumerator QuitGame()
        {
            return GameManager.instance.QuitGame();
        }

        public static void LoadedBoss()
        {
            GameManager.instance.LoadedBoss();
        }

        public static void DoDestroyPersonalPools()
        {
            GameManager.instance.DoDestroyPersonalPools();
        }

        public static float GetImplicitCinematicVolume()
        {
            return GameManager.instance.GetImplicitCinematicVolume();
        }

        public static UIManager orig_get_ui()
        {
            return GameManager.instance.orig_get_ui();
        }

        public static void orig_set_ui(UIManager value)
        {
            ReflectionHelper.CallMethod(GameManager.instance, "orig_set_ui", value);
        }

        public static void orig_OnApplicationQuit()
        {
            ReflectionHelper.CallMethod(GameManager.instance, "orig_OnApplicationQuit");
        }

        public static void orig_LoadScene(string destScene)
        {
            GameManager.instance.orig_LoadScene(destScene);
        }

        public static void orig_BeginSceneTransition(GameManager.SceneLoadInfo info)
        {
            GameManager.instance.orig_BeginSceneTransition(info);
        }

        public static void orig_ClearSaveFile(int saveSlot, Action<bool> callback)
        {
            GameManager.instance.orig_ClearSaveFile(saveSlot, callback);
        }

        public static IEnumerator orig_PlayerDead(float waitTime)
        {
            return GameManager.instance.orig_PlayerDead(waitTime);
        }

        public static void orig_SetupSceneRefs(bool refreshTilemapInfo)
        {
            GameManager.instance.orig_SetupSceneRefs(refreshTilemapInfo);
        }

        public static void orig_OnWillActivateFirstLevel()
        {
            GameManager.instance.orig_OnWillActivateFirstLevel();
        }

        public static IEnumerator PauseToggleDynamicMenu(MenuScreen screen,
            bool allowUnpause = false)
        {
            return GameManager.instance.PauseToggleDynamicMenu(screen, allowUnpause);
        }

        public static string GetBaseSceneName(string fullSceneName)
        {
            return GameManager.GetBaseSceneName(fullSceneName);
        }

        public static tk2dTileMap GetTileMap(GameObject gameObject)
        {
            return ReflectionHelper.CallMethod<GameManager, tk2dTileMap>("GetTileMap", gameObject);
        }

        public static string GetSceneZoneName(string str)
        {
            return ReflectionHelper.CallMethod<GameManager, string>("GetSceneZoneName", str);
        }

        public static int CountBits(int val)
        {
            return ReflectionHelper.CallMethod<GameManager, int>("CountBits", val);
        }

        public static string ModdedSavePath(int slot)
        {
            return ReflectionHelper.CallMethod<GameManager, string>("ModdedSavePath", slot);
        }

        #endregion
    }
}