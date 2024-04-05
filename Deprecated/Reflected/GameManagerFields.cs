namespace Satchel.Reflected
{
    /// <summary>
    /// A class that contains all (public and private) fields and methods of GameManager allowing you to
    /// easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    [Obsolete("Please use HKMirror", true)]
    public static partial class GameManagerR
    {
        public static bool verboseMode
        {
            get => ReflectionHelper.GetField<GameManager, bool>(GameManager.instance, "verboseMode");
            set => ReflectionHelper.SetField(GameManager.instance, "verboseMode", value);
        }

        public static GlobalEnums.GameState gameState
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

        public static UnityEngine.Vector3 entrySpawnPoint
        {
            get => ReflectionHelper.GetField<GameManager, UnityEngine.Vector3>(GameManager.instance, "entrySpawnPoint");
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

        public static InControl.InControlManager inControlManagerPrefab
        {
            get => ReflectionHelper.GetField<GameManager, InControl.InControlManager>(GameManager.instance,
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

        public static UnityEngine.GameObject gameMap
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

        public static UnityEngine.SpriteRenderer heroLight
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

        public static UnityEngine.Audio.AudioMixerSnapshot actorSnapshotUnpaused
        {
            get => GameManager.instance.actorSnapshotUnpaused;
            set => GameManager.instance.actorSnapshotUnpaused = value;
        }

        public static UnityEngine.Audio.AudioMixerSnapshot actorSnapshotPaused
        {
            get => GameManager.instance.actorSnapshotPaused;
            set => GameManager.instance.actorSnapshotPaused = value;
        }

        public static UnityEngine.Audio.AudioMixerSnapshot silentSnapshot
        {
            get => GameManager.instance.silentSnapshot;
            set => GameManager.instance.silentSnapshot = value;
        }

        public static UnityEngine.Audio.AudioMixerSnapshot noMusicSnapshot
        {
            get => GameManager.instance.noMusicSnapshot;
            set => GameManager.instance.noMusicSnapshot = value;
        }

        public static MusicCue noMusicCue
        {
            get => GameManager.instance.noMusicCue;
            set => GameManager.instance.noMusicCue = value;
        }

        public static UnityEngine.Audio.AudioMixerSnapshot noAtmosSnapshot
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

        public static InControl.InControlManager _spawnedInControlManager
        {
            get => ReflectionHelper.GetField<GameManager, InControl.InControlManager>("_spawnedInControlManager");
            set => ReflectionHelper.SetField<GameManager, InControl.InControlManager>("_spawnedInControlManager", value);
        }

        public static int NoSaveSlotID
        {
            get => GameManager.NoSaveSlotID;
            //its a const no setter
        }

        public static System.String[] SubSceneNameSuffixes
        {
            get => ReflectionHelper.GetField<GameManager, System.String[]>("SubSceneNameSuffixes");
            set => ReflectionHelper.SetField<GameManager, System.String[]>("SubSceneNameSuffixes", value);
        }
    }
}
