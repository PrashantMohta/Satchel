using System.Collections.ObjectModel;
using Modding.Delegates;
using LogLevel = Modding.LogLevel;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ModHooks allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModHooksR : InstanceClassWrapper<ModHooks>
{
    public ModHooksR(ModHooks _orig) : base(_orig)
    {
    }

    public int _modVersion
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public string SettingsPath
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public ModHooks _instance
    {
        get => GetFieldStatic<ModHooks>();
        set => SetField(value);
    }

    public Dictionary<string, string> LoadedModsWithVersions
    {
        get => ModHooks.LoadedModsWithVersions;
        set => SetField(value);
    }

    public string ModVersion
    {
        get => ModHooks.ModVersion;
        set => ModHooks.ModVersion = value;
    }

    public GameVersionData version
    {
        get => ModHooks.version;
        set => ModHooks.version = value;
    }

    public LanguageGetProxy LanguageGetHook
    {
        get => GetFieldStatic<LanguageGetProxy>();
        set => SetField(value);
    }

    public Action CursorHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Action<GameObject> ColliderCreateHook
    {
        get => GetFieldStatic<Action<GameObject>>();
        set => SetField(value);
    }

    public Func<GameObject, GameObject> ObjectPoolSpawnHook
    {
        get => GetFieldStatic<Func<GameObject, GameObject>>();
        set => SetField(value);
    }

    public Action ApplicationQuitHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public HitInstanceHandler HitInstanceHook
    {
        get => GetFieldStatic<HitInstanceHandler>();
        set => SetField(value);
    }

    public Action<List<GameObject>> DrawBlackBordersHook
    {
        get => GetFieldStatic<Action<List<GameObject>>>();
        set => SetField(value);
    }

    public OnEnableEnemyHandler OnEnableEnemyHook
    {
        get => GetFieldStatic<OnEnableEnemyHandler>();
        set => SetField(value);
    }

    public OnReceiveDeathEventHandler OnReceiveDeathEventHook
    {
        get => GetFieldStatic<OnReceiveDeathEventHandler>();
        set => SetField(value);
    }

    public RecordKillForJournalHandler RecordKillForJournalHook
    {
        get => GetFieldStatic<RecordKillForJournalHandler>();
        set => SetField(value);
    }

    public SetBoolProxy SetPlayerBoolHook
    {
        get => GetFieldStatic<SetBoolProxy>();
        set => SetField(value);
    }

    public GetBoolProxy GetPlayerBoolHook
    {
        get => GetFieldStatic<GetBoolProxy>();
        set => SetField(value);
    }

    public SetIntProxy SetPlayerIntHook
    {
        get => GetFieldStatic<SetIntProxy>();
        set => SetField(value);
    }

    public GetIntProxy GetPlayerIntHook
    {
        get => GetFieldStatic<GetIntProxy>();
        set => SetField(value);
    }

    public SetFloatProxy SetPlayerFloatHook
    {
        get => GetFieldStatic<SetFloatProxy>();
        set => SetField(value);
    }

    public GetFloatProxy GetPlayerFloatHook
    {
        get => GetFieldStatic<GetFloatProxy>();
        set => SetField(value);
    }

    public SetStringProxy SetPlayerStringHook
    {
        get => GetFieldStatic<SetStringProxy>();
        set => SetField(value);
    }

    public GetStringProxy GetPlayerStringHook
    {
        get => GetFieldStatic<GetStringProxy>();
        set => SetField(value);
    }

    public SetVector3Proxy SetPlayerVector3Hook
    {
        get => GetFieldStatic<SetVector3Proxy>();
        set => SetField(value);
    }

    public GetVector3Proxy GetPlayerVector3Hook
    {
        get => GetFieldStatic<GetVector3Proxy>();
        set => SetField(value);
    }

    public SetVariableProxy SetPlayerVariableHook
    {
        get => GetFieldStatic<SetVariableProxy>();
        set => SetField(value);
    }

    public GetVariableProxy GetPlayerVariableHook
    {
        get => GetFieldStatic<GetVariableProxy>();
        set => SetField(value);
    }

    public Func<int> BlueHealthHook
    {
        get => GetFieldStatic<Func<int>>();
        set => SetField(value);
    }

    public TakeHealthProxy TakeHealthHook
    {
        get => GetFieldStatic<TakeHealthProxy>();
        set => SetField(value);
    }

    public TakeDamageProxy TakeDamageHook
    {
        get => GetFieldStatic<TakeDamageProxy>();
        set => SetField(value);
    }

    public AfterTakeDamageHandler AfterTakeDamageHook
    {
        get => GetFieldStatic<AfterTakeDamageHandler>();
        set => SetField(value);
    }

    public Action BeforePlayerDeadHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Action AfterPlayerDeadHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Action<AttackDirection> AttackHook
    {
        get => GetFieldStatic<Action<AttackDirection>>();
        set => SetField(value);
    }

    public Action DoAttackHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Action<AttackDirection> AfterAttackHook
    {
        get => GetFieldStatic<Action<AttackDirection>>();
        set => SetField(value);
    }

    public SlashHitHandler SlashHitHook
    {
        get => GetFieldStatic<SlashHitHandler>();
        set => SetField(value);
    }

    public CharmUpdateHandler CharmUpdateHook
    {
        get => GetFieldStatic<CharmUpdateHandler>();
        set => SetField(value);
    }

    public Action HeroUpdateHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Func<int, int> BeforeAddHealthHook
    {
        get => GetFieldStatic<Func<int, int>>();
        set => SetField(value);
    }

    public Func<float> FocusCostHook
    {
        get => GetFieldStatic<Func<float>>();
        set => SetField(value);
    }

    public Func<int, int> SoulGainHook
    {
        get => GetFieldStatic<Func<int, int>>();
        set => SetField(value);
    }

    public Func<Vector2, Vector2> DashVectorHook
    {
        get => GetFieldStatic<Func<Vector2, Vector2>>();
        set => SetField(value);
    }

    public Func<bool> DashPressedHook
    {
        get => GetFieldStatic<Func<bool>>();
        set => SetField(value);
    }

    public Action<int> SavegameLoadHook
    {
        get => GetFieldStatic<Action<int>>();
        set => SetField(value);
    }

    public Action<int> SavegameSaveHook
    {
        get => GetFieldStatic<Action<int>>();
        set => SetField(value);
    }

    public Action NewGameHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public Action<int> SavegameClearHook
    {
        get => GetFieldStatic<Action<int>>();
        set => SetField(value);
    }

    public Action<SaveGameData> AfterSavegameLoadHook
    {
        get => GetFieldStatic<Action<SaveGameData>>();
        set => SetField(value);
    }

    public Action<SaveGameData> BeforeSavegameSaveHook
    {
        get => GetFieldStatic<Action<SaveGameData>>();
        set => SetField(value);
    }

    public Func<int, string> GetSaveFileNameHook
    {
        get => GetFieldStatic<Func<int, string>>();
        set => SetField(value);
    }

    public Action<int> AfterSaveGameClearHook
    {
        get => GetFieldStatic<Action<int>>();
        set => SetField(value);
    }

    public Action<string> SceneChanged
    {
        get => GetFieldStatic<Action<string>>();
        set => SetField(value);
    }

    public Func<string, string> BeforeSceneLoadHook
    {
        get => GetFieldStatic<Func<string, string>>();
        set => SetField(value);
    }

    public Action _finishedLoadingModsHook
    {
        get => GetFieldStatic<Action>();
        set => SetField(value);
    }

    public ReadOnlyDictionary<IMod, MenuScreen> BuiltModMenuScreens => ModHooks.BuiltModMenuScreens;

    public ModHooksGlobalSettings GlobalSettings
    {
        get => ModHooks.GlobalSettings;
        set => SetPropertyStatic(value);
    }

    public ModHooks Instance => ModHooks.Instance;

    public void LoadGlobalSettings()
    {
        CallMethodStatic();
    }

    public void SaveGlobalSettings()
    {
        CallMethodStatic();
    }

    public void LogConsole(string message, LogLevel level)
    {
        CallMethodStatic(new object[] { message, level });
    }

    public string LanguageGet(string key, string sheet)
    {
        return CallMethodStatic<string>(new object[] { key, sheet });
    }

    public void OnCursor(GameManager gm)
    {
        CallMethodStatic(new object[] { gm });
    }

    public void OnColliderCreate(GameObject go)
    {
        CallMethodStatic(new object[] { go });
    }

    public GameObject OnObjectPoolSpawn(GameObject go)
    {
        return CallMethodStatic<GameObject>(new object[] { go });
    }

    public void OnApplicationQuit()
    {
        CallMethodStatic();
    }

    public HitInstance OnHitInstanceBeforeHit(Fsm owner, HitInstance hit)
    {
        return CallMethodStatic<HitInstance>(new object[] { owner, hit });
    }

    public void OnDrawBlackBorders(List<GameObject> borders)
    {
        CallMethodStatic(new object[] { borders });
    }

    public bool OnEnableEnemy(GameObject enemy, bool isAlreadyDead)
    {
        return CallMethodStatic<bool>(new object[] { enemy, isAlreadyDead });
    }

    public void OnRecieveDeathEvent(EnemyDeathEffects enemyDeathEffects, bool eventAlreadyRecieved,
        float? attackDirection, bool resetDeathEvent, bool spellBurn, bool isWatery)
    {
        CallMethodStatic(new object[]
            { enemyDeathEffects, eventAlreadyRecieved, attackDirection, resetDeathEvent, spellBurn, isWatery });
    }

    public void OnRecordKillForJournal(EnemyDeathEffects enemyDeathEffects, string playerDataName,
        string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey,
        string newDataBoolPlayerDataLookupKey)
    {
        CallMethodStatic(new object[]
        {
            enemyDeathEffects, playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey,
            newDataBoolPlayerDataLookupKey
        });
    }

    public void SetPlayerBool(string target, bool orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public bool GetPlayerBool(string target, PlayerData pd)
    {
        return CallMethodStatic<bool>(new object[] { target, pd });
    }

    public void SetPlayerInt(string target, int orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public int GetPlayerInt(string target, PlayerData pd)
    {
        return CallMethodStatic<int>(new object[] { target, pd });
    }

    public void SetPlayerFloat(string target, float orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public float GetPlayerFloat(string target, PlayerData pd)
    {
        return CallMethodStatic<float>(new object[] { target, pd });
    }

    public void SetPlayerString(string target, string orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public string GetPlayerString(string target, PlayerData pd)
    {
        return CallMethodStatic<string>(new object[] { target, pd });
    }

    public void SetPlayerVector3(string target, Vector3 orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public Vector3 GetPlayerVector3(string target, PlayerData pd)
    {
        return CallMethodStatic<Vector3>(new object[] { target, pd });
    }

    public void SetPlayerVariable<T>(string target, T orig, PlayerData pd)
    {
        CallMethodStatic(new object[] { target, orig, pd });
    }

    public T GetPlayerVariable<T>(string target, PlayerData pd)
    {
        return CallMethodStatic<T>(new object[] { target, pd });
    }

    public int OnBlueHealth()
    {
        return CallMethodStatic<int>();
    }

    public int OnTakeHealth(int damage)
    {
        return CallMethodStatic<int>(new object[] { damage });
    }

    public int OnTakeDamage(int hazardType, int damage)
    {
        return CallMethodStatic<int>(new object[] { hazardType, damage });
    }

    public int AfterTakeDamage(int hazardType, int damageAmount)
    {
        return CallMethodStatic<int>(new object[] { hazardType, damageAmount });
    }

    public void OnBeforePlayerDead()
    {
        CallMethodStatic();
    }

    public void OnAfterPlayerDead()
    {
        CallMethodStatic();
    }

    public void OnAttack(AttackDirection dir)
    {
        CallMethodStatic(new object[] { dir });
    }

    public void OnDoAttack()
    {
        CallMethodStatic();
    }

    public void AfterAttack(AttackDirection dir)
    {
        CallMethodStatic(new object[] { dir });
    }

    public void OnSlashHit(Collider2D otherCollider, GameObject gameObject)
    {
        CallMethodStatic(new object[] { otherCollider, gameObject });
    }

    public void OnCharmUpdate(PlayerData pd, HeroController hc)
    {
        CallMethodStatic(new object[] { pd, hc });
    }

    public void OnHeroUpdate()
    {
        CallMethodStatic();
    }

    public int BeforeAddHealth(int amount)
    {
        return CallMethodStatic<int>(new object[] { amount });
    }

    public float OnFocusCost()
    {
        return CallMethodStatic<float>();
    }

    public int OnSoulGain(int num)
    {
        return CallMethodStatic<int>(new object[] { num });
    }

    public Vector2 DashVelocityChange(Vector2 change)
    {
        return CallMethodStatic<Vector2>(new object[] { change });
    }

    public bool OnDashPressed()
    {
        return CallMethodStatic<bool>();
    }

    public void OnSavegameLoad(int id)
    {
        CallMethodStatic(new object[] { id });
    }

    public void OnSavegameSave(int id)
    {
        CallMethodStatic(new object[] { id });
    }

    public void OnNewGame()
    {
        CallMethodStatic();
    }

    public void OnSavegameClear(int id)
    {
        CallMethodStatic(new object[] { id });
    }

    public void OnAfterSaveGameLoad(SaveGameData data)
    {
        CallMethodStatic(new object[] { data });
    }

    public void OnBeforeSaveGameSave(SaveGameData data)
    {
        CallMethodStatic(new object[] { data });
    }

    public string GetSaveFileName(int saveSlot)
    {
        return CallMethodStatic<string>(new object[] { saveSlot });
    }

    public void OnAfterSaveGameClear(int saveSlot)
    {
        CallMethodStatic(new object[] { saveSlot });
    }

    public void OnSceneChanged(string targetScene)
    {
        CallMethodStatic(new object[] { targetScene });
    }

    public string BeforeSceneLoad(string sceneName)
    {
        return CallMethodStatic<string>(new object[] { sceneName });
    }

    public IMod GetMod(string name, bool onlyEnabled = false, bool allowLoadError = false)
    {
        return ModHooks.GetMod(name, onlyEnabled, allowLoadError);
    }

    public IMod GetMod(Type type, bool onlyEnabled = false, bool allowLoadError = false)
    {
        return ModHooks.GetMod(type, onlyEnabled, allowLoadError);
    }

    public bool ModEnabled(ITogglableMod mod)
    {
        return ModHooks.ModEnabled(mod);
    }

    public bool ModEnabled(string name)
    {
        return ModHooks.ModEnabled(name);
    }

    public bool ModEnabled(Type type)
    {
        return ModHooks.ModEnabled(type);
    }

    public IEnumerable<IMod> GetAllMods(bool onlyEnabled = false, bool allowLoadError = false)
    {
        return ModHooks.GetAllMods(onlyEnabled, allowLoadError);
    }

    public void OnFinishedLoadingMods()
    {
        CallMethodStatic();
    }
}