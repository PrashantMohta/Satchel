using InControl;
using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameManagerRR : InstanceClassWrapper<GameManager>
{
    public GameManagerRR(GameManager _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameState gameState
    {
        get => orig.gameState;
        set => orig.gameState = value;
    }

    public bool isPaused
    {
        get => orig.isPaused;
        set => orig.isPaused = value;
    }

    public int timeSlowedCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public string sceneName
    {
        get => orig.sceneName;
        set => orig.sceneName = value;
    }

    public string nextSceneName
    {
        get => orig.nextSceneName;
        set => orig.nextSceneName = value;
    }

    public string entryGateName
    {
        get => orig.entryGateName;
        set => orig.entryGateName = value;
    }

    public TransitionPoint callingGate
    {
        get => GetField<TransitionPoint>();
        set => SetField(value);
    }

    public Vector3 entrySpawnPoint
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float entryDelay
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float sceneWidth
    {
        get => orig.sceneWidth;
        set => orig.sceneWidth = value;
    }

    public float sceneHeight
    {
        get => orig.sceneHeight;
        set => orig.sceneHeight = value;
    }

    public GameConfig gameConfig
    {
        get => orig.gameConfig;
        set => orig.gameConfig = value;
    }

    public GameCameras gameCams
    {
        get => GetField<GameCameras>();
        set => SetField(value);
    }

    public AudioManager audioManager
    {
        get => GetField<AudioManager>();
        set => SetField(value);
    }

    public InControlManager inControlManagerPrefab
    {
        get => GetField<InControlManager>();
        set => SetField(value);
    }

    public InControlManager _spawnedInControlManager
    {
        get => GetFieldStatic<InControlManager>();
        set => SetField(value);
    }

    public GameSettings gameSettings
    {
        get => orig.gameSettings;
        set => orig.gameSettings = value;
    }

    public TimeScaleIndependentUpdate timeTool
    {
        get => orig.timeTool;
        set => orig.timeTool = value;
    }

    public GameObject gameMap
    {
        get => orig.gameMap;
        set => orig.gameMap = value;
    }

    public PlayMakerFSM inventoryFSM
    {
        get => orig.inventoryFSM;
        set => orig.inventoryFSM = value;
    }

    public PlayerData playerData
    {
        get => orig.playerData;
        set => orig.playerData = value;
    }

    public SceneData sceneData
    {
        get => orig.sceneData;
        set => orig.sceneData = value;
    }

    public int NoSaveSlotID
    {
        get => GameManager.NoSaveSlotID;
        set => SetField(value);
    }

    public int profileID
    {
        get => orig.profileID;
        set => orig.profileID = value;
    }

    public bool needsFlush
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isEmergencyReturningToMenu
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float sessionPlayTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float sessionStartTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool startedOnThisScene
    {
        get => orig.startedOnThisScene;
        set => orig.startedOnThisScene = value;
    }

    public bool hazardRespawningHero
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string targetScene
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool tilemapDirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool needFirstFadeIn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool waitForManualLevelStart
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool startedSteamEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool startedGOGEnabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool startedLanguageDisabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AudioMixerSnapshot actorSnapshotUnpaused
    {
        get => orig.actorSnapshotUnpaused;
        set => orig.actorSnapshotUnpaused = value;
    }

    public AudioMixerSnapshot actorSnapshotPaused
    {
        get => orig.actorSnapshotPaused;
        set => orig.actorSnapshotPaused = value;
    }

    public AudioMixerSnapshot silentSnapshot
    {
        get => orig.silentSnapshot;
        set => orig.silentSnapshot = value;
    }

    public AudioMixerSnapshot noMusicSnapshot
    {
        get => orig.noMusicSnapshot;
        set => orig.noMusicSnapshot = value;
    }

    public MusicCue noMusicCue
    {
        get => orig.noMusicCue;
        set => orig.noMusicCue = value;
    }

    public AudioMixerSnapshot noAtmosSnapshot
    {
        get => orig.noAtmosSnapshot;
        set => orig.noAtmosSnapshot = value;
    }

    public bool hasFinishedEnteringScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public WorldInfo worldInfo
    {
        get => GetField<WorldInfo>();
        set => SetField(value);
    }

    public bool isLoading
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float currentLoadDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int sceneLoadsWithoutGarbageCollect
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool isUsingCustomLoadAnimation
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public StandaloneLoadingSpinner standaloneLoadingSpinnerPrefab
    {
        get => GetField<StandaloneLoadingSpinner>();
        set => SetField(value);
    }

    public GameManager _instance
    {
        get => GameManager._instance;
        set => GameManager._instance = value;
    }

    public SceneLoad sceneLoad
    {
        get => GetField<SceneLoad>();
        set => SetField(value);
    }

    public string[] SubSceneNameSuffixes
    {
        get => GetFieldStatic<string[]>();
        set => SetField(value);
    }

    public int saveIconShowCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public UIManager _uiInstance
    {
        get => GetField<UIManager>();
        set => SetField(value);
    }

    public bool TimeSlowed => orig.TimeSlowed;

    public InputHandler inputHandler
    {
        get => orig.inputHandler;
        set => SetProperty(value);
    }

    public AchievementHandler achievementHandler
    {
        get => orig.achievementHandler;
        set => SetProperty(value);
    }

    public AudioManager AudioManager => orig.AudioManager;

    public CameraController cameraCtrl
    {
        get => orig.cameraCtrl;
        set => SetProperty(value);
    }

    public HeroController hero_ctrl
    {
        get => orig.hero_ctrl;
        set => SetProperty(value);
    }

    public SpriteRenderer heroLight
    {
        get => orig.heroLight;
        set => SetProperty(value);
    }

    public SceneManager sm
    {
        get => orig.sm;
        set => SetProperty(value);
    }

    public UIManager ui
    {
        get => orig.ui;
        set => SetProperty(value);
    }

    public tk2dTileMap tilemap
    {
        get => orig.tilemap;
        set => SetProperty(value);
    }

    public PlayMakerFSM soulOrb_fsm
    {
        get => orig.soulOrb_fsm;
        set => SetProperty(value);
    }

    public PlayMakerFSM soulVessel_fsm
    {
        get => orig.soulVessel_fsm;
        set => SetProperty(value);
    }

    public float PlayTime => orig.PlayTime;

    public bool RespawningHero
    {
        get => orig.RespawningHero;
        set => orig.RespawningHero = value;
    }

    public bool IsInSceneTransition
    {
        get => orig.IsInSceneTransition;
        set => SetProperty(value);
    }

    public bool HasFinishedEnteringScene => orig.HasFinishedEnteringScene;

    public WorldInfo WorldInfo => orig.WorldInfo;

    public bool IsLoadingSceneTransition => orig.IsLoadingSceneTransition;

    public float CurrentLoadDuration => orig.CurrentLoadDuration;

    public bool IsUsingCustomLoadAnimation => orig.IsUsingCustomLoadAnimation;

    public GameManager instance => GameManager.instance;

    public GameManager UnsafeInstance => GameManager.UnsafeInstance;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateEngagement()
    {
        CallMethod();
    }

    public void LevelActivated(Scene sceneFrom, Scene sceneTo)
    {
        CallMethod(new object[] { sceneFrom, sceneTo });
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnApplicationQuit()
    {
        CallMethod();
    }

    public void BeginSceneTransition(GameManager.SceneLoadInfo info)
    {
        orig.BeginSceneTransition(info);
    }

    public IEnumerator BeginSceneTransitionRoutine(GameManager.SceneLoadInfo info)
    {
        return CallMethod<IEnumerator>(new object[] { info });
    }

    public IEnumerator TransitionScene(TransitionPoint gate)
    {
        return orig.TransitionScene(gate);
    }

    public void ChangeToScene(string targetScene, string entryGateName, float pauseBeforeEnter)
    {
        orig.ChangeToScene(targetScene, entryGateName, pauseBeforeEnter);
    }

    public void WarpToDreamGate()
    {
        orig.WarpToDreamGate();
    }

    public void LeftScene(bool doAdditiveLoad = false)
    {
        orig.LeftScene(doAdditiveLoad);
    }

    public IEnumerator PlayerDead(float waitTime)
    {
        return orig.PlayerDead(waitTime);
    }

    public IEnumerator PlayerDeadFromHazard(float waitTime)
    {
        return orig.PlayerDeadFromHazard(waitTime);
    }

    public void ReadyForRespawn(bool isFirstLevelForPlayer)
    {
        orig.ReadyForRespawn(isFirstLevelForPlayer);
    }

    public void HazardRespawn()
    {
        orig.HazardRespawn();
    }

    public void TimePasses()
    {
        orig.TimePasses();
    }

    public void FadeSceneIn()
    {
        orig.FadeSceneIn();
    }

    public IEnumerator FadeSceneInWithDelay(float delay)
    {
        return orig.FadeSceneInWithDelay(delay);
    }

    public bool IsGamePaused()
    {
        return orig.IsGamePaused();
    }

    public void SetGameMap(GameObject go_gameMap)
    {
        orig.SetGameMap(go_gameMap);
    }

    public void CalculateNotchesUsed()
    {
        orig.CalculateNotchesUsed();
    }

    public string GetLanguageAsString()
    {
        return orig.GetLanguageAsString();
    }

    public string GetEntryGateName()
    {
        return orig.GetEntryGateName();
    }

    public void SetPlayerDataBool(string boolName, bool value)
    {
        orig.SetPlayerDataBool(boolName, value);
    }

    public void SetPlayerDataInt(string intName, int value)
    {
        orig.SetPlayerDataInt(intName, value);
    }

    public void SetPlayerDataFloat(string floatName, float value)
    {
        orig.SetPlayerDataFloat(floatName, value);
    }

    public void SetPlayerDataString(string stringName, string value)
    {
        orig.SetPlayerDataString(stringName, value);
    }

    public void IncrementPlayerDataInt(string intName)
    {
        orig.IncrementPlayerDataInt(intName);
    }

    public void DecrementPlayerDataInt(string intName)
    {
        orig.DecrementPlayerDataInt(intName);
    }

    public void IntAdd(string intName, int amount)
    {
        orig.IntAdd(intName, amount);
    }

    public bool GetPlayerDataBool(string boolName)
    {
        return orig.GetPlayerDataBool(boolName);
    }

    public int GetPlayerDataInt(string intName)
    {
        return orig.GetPlayerDataInt(intName);
    }

    public float GetPlayerDataFloat(string floatName)
    {
        return orig.GetPlayerDataFloat(floatName);
    }

    public string GetPlayerDataString(string stringName)
    {
        return orig.GetPlayerDataString(stringName);
    }

    public void SetPlayerDataVector3(string vectorName, Vector3 value)
    {
        orig.SetPlayerDataVector3(vectorName, value);
    }

    public Vector3 GetPlayerDataVector3(string vectorName)
    {
        return orig.GetPlayerDataVector3(vectorName);
    }

    public T GetPlayerDataVariable<T>(string fieldName)
    {
        return orig.GetPlayerDataVariable<T>(fieldName);
    }

    public void SetPlayerDataVariable<T>(string fieldName, T value)
    {
        orig.SetPlayerDataVariable(fieldName, value);
    }

    public void EquipCharm(int charmNum)
    {
        orig.EquipCharm(charmNum);
    }

    public void UnequipCharm(int charmNum)
    {
        orig.UnequipCharm(charmNum);
    }

    public void RefreshOvercharm()
    {
        orig.RefreshOvercharm();
    }

    public void UpdateBlueHealth()
    {
        orig.UpdateBlueHealth();
    }

    public void SetCurrentMapZoneAsRespawn()
    {
        orig.SetCurrentMapZoneAsRespawn();
    }

    public void SetMapZoneToSpecific(string mapZone)
    {
        orig.SetMapZoneToSpecific(mapZone);
    }

    public void StartSoulLimiter()
    {
        orig.StartSoulLimiter();
    }

    public void EndSoulLimiter()
    {
        orig.EndSoulLimiter();
    }

    public bool UpdateGameMap()
    {
        return orig.UpdateGameMap();
    }

    public void CheckAllMaps()
    {
        orig.CheckAllMaps();
    }

    public void AddToScenesVisited(string scene)
    {
        orig.AddToScenesVisited(scene);
    }

    public bool GetIsSceneVisited(string scene)
    {
        return orig.GetIsSceneVisited(scene);
    }

    public void AddToBenchList()
    {
        orig.AddToBenchList();
    }

    public void AddToGrubList()
    {
        orig.AddToGrubList();
    }

    public void AddToFlameList()
    {
        orig.AddToFlameList();
    }

    public void AddToCocoonList()
    {
        orig.AddToCocoonList();
    }

    public void AddToDreamPlantList()
    {
        orig.AddToDreamPlantList();
    }

    public void AddToDreamPlantCList()
    {
        orig.AddToDreamPlantCList();
    }

    public void CountGameCompletion()
    {
        orig.CountGameCompletion();
    }

    public void CountCharms()
    {
        orig.CountCharms();
    }

    public void CountJournalEntries()
    {
        orig.CountJournalEntries();
    }

    public void ActivateTestingCheats()
    {
        orig.ActivateTestingCheats();
    }

    public void GetAllPowerups()
    {
        orig.GetAllPowerups();
    }

    public void StoryRecord_death()
    {
        orig.StoryRecord_death();
    }

    public void StoryRecord_rescueGrub()
    {
        orig.StoryRecord_rescueGrub();
    }

    public void StoryRecord_defeatedShade()
    {
        orig.StoryRecord_defeatedShade();
    }

    public void StoryRecord_discoveredArea(string areaName)
    {
        orig.StoryRecord_discoveredArea(areaName);
    }

    public void StoryRecord_travelledToArea(string areaName)
    {
        orig.StoryRecord_travelledToArea(areaName);
    }

    public void StoryRecord_bankDeposit(int amount)
    {
        orig.StoryRecord_bankDeposit(amount);
    }

    public void StoryRecord_bankWithdraw(int amount)
    {
        orig.StoryRecord_bankWithdraw(amount);
    }

    public void StoryRecord_boughtCorniferMap(string map)
    {
        orig.StoryRecord_boughtCorniferMap(map);
    }

    public void StoryRecord_visited(string visited)
    {
        orig.StoryRecord_visited(visited);
    }

    public void StoryRecord_defeated(string defeated)
    {
        orig.StoryRecord_defeated(defeated);
    }

    public void StoryRecord_jiji()
    {
        orig.StoryRecord_jiji();
    }

    public void StoryRecord_rodeStag(string dest)
    {
        orig.StoryRecord_rodeStag(dest);
    }

    public void StoryRecord_acquired(string item)
    {
        orig.StoryRecord_acquired(item);
    }

    public void StoryRecord_bought(string item)
    {
        orig.StoryRecord_bought(item);
    }

    public void StoryRecord_quit()
    {
        orig.StoryRecord_quit();
    }

    public void StoryRecord_rest()
    {
        orig.StoryRecord_rest();
    }

    public void StoryRecord_upgradeNail()
    {
        orig.StoryRecord_upgradeNail();
    }

    public void StoryRecord_heartPiece()
    {
        orig.StoryRecord_heartPiece();
    }

    public void StoryRecord_maxHealthUp()
    {
        orig.StoryRecord_maxHealthUp();
    }

    public void StoryRecord_soulPiece()
    {
        orig.StoryRecord_soulPiece();
    }

    public void StoryRecord_maxSoulUp()
    {
        orig.StoryRecord_maxSoulUp();
    }

    public void StoryRecord_charmsChanged()
    {
        orig.StoryRecord_charmsChanged();
    }

    public void StoryRecord_charmEquipped(string charmName)
    {
        orig.StoryRecord_charmEquipped(charmName);
    }

    public void StoryRecord_start()
    {
        orig.StoryRecord_start();
    }

    public void AwardAchievement(string key)
    {
        orig.AwardAchievement(key);
    }

    public void QueueAchievement(string key)
    {
        orig.QueueAchievement(key);
    }

    public void AwardQueuedAchievements()
    {
        orig.AwardQueuedAchievements();
    }

    public bool IsAchievementAwarded(string key)
    {
        return orig.IsAchievementAwarded(key);
    }

    public void ClearAllAchievements()
    {
        orig.ClearAllAchievements();
    }

    public void CheckCharmAchievements()
    {
        orig.CheckCharmAchievements();
    }

    public void CheckGrubAchievements()
    {
        orig.CheckGrubAchievements();
    }

    public void CheckStagStationAchievements()
    {
        orig.CheckStagStationAchievements();
    }

    public void CheckMapAchievement()
    {
        orig.CheckMapAchievement();
    }

    public void CheckJournalAchievements()
    {
        orig.CheckJournalAchievements();
    }

    public void CheckAllAchievements()
    {
        orig.CheckAllAchievements();
    }

    public void CheckBanishmentAchievement()
    {
        orig.CheckBanishmentAchievement();
    }

    public void SetStatusRecordInt(string key, int value)
    {
        orig.SetStatusRecordInt(key, value);
    }

    public int GetStatusRecordInt(string key)
    {
        return orig.GetStatusRecordInt(key);
    }

    public void ResetStatusRecords()
    {
        orig.ResetStatusRecords();
    }

    public void SaveStatusRecords()
    {
        orig.SaveStatusRecords();
    }

    public void SetState(GameState newState)
    {
        orig.SetState(newState);
    }

    public void LoadScene(string destScene)
    {
        orig.LoadScene(destScene);
    }

    public IEnumerator LoadSceneAdditive(string destScene)
    {
        return orig.LoadSceneAdditive(destScene);
    }

    public void OnNextLevelReady()
    {
        orig.OnNextLevelReady();
    }

    public void OnWillActivateFirstLevel()
    {
        orig.OnWillActivateFirstLevel();
    }

    public IEnumerator LoadFirstScene()
    {
        return orig.LoadFirstScene();
    }

    public void LoadPermadeathUnlockScene()
    {
        orig.LoadPermadeathUnlockScene();
    }

    public void LoadMrMushromScene()
    {
        orig.LoadMrMushromScene();
    }

    public void LoadOpeningCinematic()
    {
        orig.LoadOpeningCinematic();
    }

    public void PositionHeroAtSceneEntrance()
    {
        CallMethod();
    }

    public Vector2? FindEntryPoint(string entryPointName, Scene filterScene)
    {
        return CallMethod<Vector2?>(new object[] { entryPointName, filterScene });
    }

    public TransitionPoint FindTransitionPoint(string entryPointName, Scene filterScene, bool fallbackToAnyAvailable)
    {
        return CallMethod<TransitionPoint>(new object[] { entryPointName, filterScene, fallbackToAnyAvailable });
    }

    public void EnterHero(bool additiveGateSearch = false)
    {
        CallMethod(new object[] { additiveGateSearch });
    }

    public void FinishedEnteringScene()
    {
        orig.FinishedEnteringScene();
    }

    public void SetupGameRefs()
    {
        CallMethod();
    }

    public void SetupSceneRefs(bool refreshTilemapInfo)
    {
        orig.SetupSceneRefs(refreshTilemapInfo);
    }

    public void SetupHeroRefs()
    {
        orig.SetupHeroRefs();
    }

    public void BeginScene()
    {
        orig.BeginScene();
    }

    public void UpdateUIStateFromGameState()
    {
        CallMethod();
    }

    public void SkipCutscene()
    {
        orig.SkipCutscene();
    }

    public IEnumerator SkipCutsceneNoMash()
    {
        return CallMethod<IEnumerator>();
    }

    public void NoLongerFirstGame()
    {
        orig.NoLongerFirstGame();
    }

    public void SetupStatusModifiers()
    {
        CallMethod();
    }

    public void MatchBackerCreditsSetting()
    {
        orig.MatchBackerCreditsSetting();
    }

    public void RefreshLocalization()
    {
        orig.RefreshLocalization();
    }

    public void RefreshParticleSystems()
    {
        orig.RefreshParticleSystems();
    }

    public void ApplyNativeInput()
    {
        orig.ApplyNativeInput();
    }

    public void EnablePermadeathMode()
    {
        orig.EnablePermadeathMode();
    }

    public string GetCurrentMapZone()
    {
        return orig.GetCurrentMapZone();
    }

    public float GetSceneWidth()
    {
        return orig.GetSceneWidth();
    }

    public float GetSceneHeight()
    {
        return orig.GetSceneHeight();
    }

    public GameObject GetSceneManager()
    {
        return orig.GetSceneManager();
    }

    public string GetFormattedMapZoneString(MapZone mapZone)
    {
        return orig.GetFormattedMapZoneString(mapZone);
    }

    public void UpdateSceneName()
    {
        orig.UpdateSceneName();
    }

    public string GetBaseSceneName(string fullSceneName)
    {
        return GameManager.GetBaseSceneName(fullSceneName);
    }

    public string GetSceneNameString()
    {
        return orig.GetSceneNameString();
    }

    public tk2dTileMap GetTileMap(GameObject gameObject)
    {
        return CallMethodStatic<tk2dTileMap>(new object[] { gameObject });
    }

    public void RefreshTilemapInfo(string targetScene)
    {
        orig.RefreshTilemapInfo(targetScene);
    }

    public void SaveLevelState()
    {
        orig.SaveLevelState();
    }

    public void ResetSemiPersistentItems()
    {
        orig.ResetSemiPersistentItems();
    }

    public bool IsMenuScene()
    {
        return orig.IsMenuScene();
    }

    public bool IsTitleScreenScene()
    {
        return orig.IsTitleScreenScene();
    }

    public bool IsGameplayScene()
    {
        return orig.IsGameplayScene();
    }

    public bool IsNonGameplayScene()
    {
        return orig.IsNonGameplayScene();
    }

    public bool IsCinematicScene()
    {
        return orig.IsCinematicScene();
    }

    public bool IsStagTravelScene()
    {
        return orig.IsStagTravelScene();
    }

    public bool IsBetaEndScene()
    {
        return orig.IsBetaEndScene();
    }

    public bool IsTutorialScene()
    {
        return orig.IsTutorialScene();
    }

    public bool IsTestScene()
    {
        return orig.IsTestScene();
    }

    public bool IsBossDoorScene()
    {
        return orig.IsBossDoorScene();
    }

    public bool ShouldKeepHUDCameraActive()
    {
        return orig.ShouldKeepHUDCameraActive();
    }

    public string GetSceneZoneName(string str)
    {
        return CallMethodStatic<string>(new object[] { str });
    }

    public int CountBits(int val)
    {
        return CallMethodStatic<int>(new object[] { val });
    }

    public bool IsUnloadAssetsRequired(string sourceSceneName, string destinationSceneName)
    {
        return orig.IsUnloadAssetsRequired(sourceSceneName, destinationSceneName);
    }

    public void HasSaveFile(int saveSlot, Action<bool> callback)
    {
        orig.HasSaveFile(saveSlot, callback);
    }

    public void SaveGame()
    {
        orig.SaveGame();
    }

    public void ShowSaveIcon()
    {
        CallMethod();
    }

    public void HideSaveIcon()
    {
        CallMethod();
    }

    public void SaveGame(Action<bool> callback)
    {
        orig.SaveGame(callback);
    }

    public void ResetGameTimer()
    {
        CallMethod();
    }

    public void IncreaseGameTimer(ref float timer)
    {
        orig.IncreaseGameTimer(ref timer);
    }

    public void SaveGame(int saveSlot, Action<bool> callback)
    {
        orig.SaveGame(saveSlot, callback);
    }

    public void LoadGameFromUI(int saveSlot)
    {
        orig.LoadGameFromUI(saveSlot);
    }

    public IEnumerator LoadGameFromUIRoutine(int saveSlot)
    {
        return CallMethod<IEnumerator>(new object[] { saveSlot });
    }

    public void LoadGame(int saveSlot, Action<bool> callback)
    {
        orig.LoadGame(saveSlot, callback);
    }

    public void ClearSaveFile(int saveSlot, Action<bool> callback)
    {
        orig.ClearSaveFile(saveSlot, callback);
    }

    public void GetSaveStatsForSlot(int saveSlot, Action<SaveStats> callback)
    {
        orig.GetSaveStatsForSlot(saveSlot, callback);
    }

    public IEnumerator PauseGameToggleByMenu()
    {
        return orig.PauseGameToggleByMenu();
    }

    public IEnumerator PauseGameToggle()
    {
        return orig.PauseGameToggle();
    }

    public IEnumerator SetTimeScale(float newTimeScale, float duration)
    {
        return CallMethod<IEnumerator>(new object[] { newTimeScale, duration });
    }

    public void SetTimeScale(float newTimeScale)
    {
        CallMethod(new object[] { newTimeScale });
    }

    public void FreezeMoment(int type)
    {
        orig.FreezeMoment(type);
    }

    public IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime, float targetSpeed)
    {
        return orig.FreezeMoment(rampDownTime, waitTime, rampUpTime, targetSpeed);
    }

    public IEnumerator FreezeMomentGC(float rampDownTime, float waitTime, float rampUpTime, float targetSpeed)
    {
        return orig.FreezeMomentGC(rampDownTime, waitTime, rampUpTime, targetSpeed);
    }

    public IEnumerator FreezeMoment(float rampDownTime, float waitTime, float rampUpTime, bool runGc = false)
    {
        return orig.FreezeMoment(rampDownTime, waitTime, rampUpTime, runGc);
    }

    public void EnsureSaveSlotSpace(Action<bool> callback)
    {
        orig.EnsureSaveSlotSpace(callback);
    }

    public void StartNewGame(bool permadeathMode = false, bool bossRushMode = false)
    {
        orig.StartNewGame(permadeathMode, bossRushMode);
    }

    public IEnumerator RunStartNewGame()
    {
        return orig.RunStartNewGame();
    }

    public void ContinueGame()
    {
        orig.ContinueGame();
    }

    public IEnumerator RunContinueGame()
    {
        return orig.RunContinueGame();
    }

    public IEnumerator ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes saveMode, Action<bool> callback = null)
    {
        return orig.ReturnToMainMenu(saveMode, callback);
    }

    public void WillTerminateInBackground()
    {
        orig.WillTerminateInBackground();
    }

    public void EmergencyReturnToMenu(Action callback)
    {
        CallMethod(new object[] { callback });
    }

    public IEnumerator QuitGame()
    {
        return orig.QuitGame();
    }

    public void LoadedBoss()
    {
        orig.LoadedBoss();
    }

    public void DoDestroyPersonalPools()
    {
        orig.DoDestroyPersonalPools();
    }

    public float GetImplicitCinematicVolume()
    {
        return orig.GetImplicitCinematicVolume();
    }

    public UIManager orig_get_ui()
    {
        return orig.orig_get_ui();
    }

    public void orig_set_ui(UIManager value)
    {
        CallMethod(new object[] { value });
    }

    public void orig_OnApplicationQuit()
    {
        CallMethod();
    }

    public void orig_LoadScene(string destScene)
    {
        orig.orig_LoadScene(destScene);
    }

    public void orig_BeginSceneTransition(GameManager.SceneLoadInfo info)
    {
        orig.orig_BeginSceneTransition(info);
    }

    public void orig_ClearSaveFile(int saveSlot, Action<bool> callback)
    {
        orig.orig_ClearSaveFile(saveSlot, callback);
    }

    public IEnumerator orig_PlayerDead(float waitTime)
    {
        return orig.orig_PlayerDead(waitTime);
    }

    public string ModdedSavePath(int slot)
    {
        return CallMethodStatic<string>(new object[] { slot });
    }

    public void orig_SetupSceneRefs(bool refreshTilemapInfo)
    {
        orig.orig_SetupSceneRefs(refreshTilemapInfo);
    }

    public void orig_OnWillActivateFirstLevel()
    {
        orig.orig_OnWillActivateFirstLevel();
    }

    public IEnumerator PauseToggleDynamicMenu(MenuScreen screen, bool allowUnpause = false)
    {
        return orig.PauseToggleDynamicMenu(screen, allowUnpause);
    }
}