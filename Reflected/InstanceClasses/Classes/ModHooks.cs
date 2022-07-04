namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ModHooks allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModHooksR:InstanceClassWrapper<Modding.ModHooks>
{
public ModHooksR(Modding.ModHooks _orig) : base(_orig) {}
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

public Modding.ModHooks _instance
{
get => GetFieldStatic<Modding.ModHooks>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.String,System.String> LoadedModsWithVersions
{
get => Modding.ModHooks.LoadedModsWithVersions;
set => SetField(value);
}

public string ModVersion
{
get => Modding.ModHooks.ModVersion;
set => Modding.ModHooks.ModVersion = value;
}

public GameVersionData version
{
get => Modding.ModHooks.version;
set => Modding.ModHooks.version = value;
}

public Modding.Delegates.LanguageGetProxy LanguageGetHook
{
get => GetFieldStatic<Modding.Delegates.LanguageGetProxy>();
set => SetField(value);
}

public System.Action CursorHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Action<UnityEngine.GameObject> ColliderCreateHook
{
get => GetFieldStatic<System.Action<UnityEngine.GameObject>>();
set => SetField(value);
}

public System.Func<UnityEngine.GameObject,UnityEngine.GameObject> ObjectPoolSpawnHook
{
get => GetFieldStatic<System.Func<UnityEngine.GameObject,UnityEngine.GameObject>>();
set => SetField(value);
}

public System.Action ApplicationQuitHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public Modding.Delegates.HitInstanceHandler HitInstanceHook
{
get => GetFieldStatic<Modding.Delegates.HitInstanceHandler>();
set => SetField(value);
}

public System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> DrawBlackBordersHook
{
get => GetFieldStatic<System.Action<System.Collections.Generic.List<UnityEngine.GameObject>>>();
set => SetField(value);
}

public Modding.Delegates.OnEnableEnemyHandler OnEnableEnemyHook
{
get => GetFieldStatic<Modding.Delegates.OnEnableEnemyHandler>();
set => SetField(value);
}

public Modding.Delegates.OnReceiveDeathEventHandler OnReceiveDeathEventHook
{
get => GetFieldStatic<Modding.Delegates.OnReceiveDeathEventHandler>();
set => SetField(value);
}

public Modding.Delegates.RecordKillForJournalHandler RecordKillForJournalHook
{
get => GetFieldStatic<Modding.Delegates.RecordKillForJournalHandler>();
set => SetField(value);
}

public Modding.Delegates.SetBoolProxy SetPlayerBoolHook
{
get => GetFieldStatic<Modding.Delegates.SetBoolProxy>();
set => SetField(value);
}

public Modding.Delegates.GetBoolProxy GetPlayerBoolHook
{
get => GetFieldStatic<Modding.Delegates.GetBoolProxy>();
set => SetField(value);
}

public Modding.Delegates.SetIntProxy SetPlayerIntHook
{
get => GetFieldStatic<Modding.Delegates.SetIntProxy>();
set => SetField(value);
}

public Modding.Delegates.GetIntProxy GetPlayerIntHook
{
get => GetFieldStatic<Modding.Delegates.GetIntProxy>();
set => SetField(value);
}

public Modding.Delegates.SetFloatProxy SetPlayerFloatHook
{
get => GetFieldStatic<Modding.Delegates.SetFloatProxy>();
set => SetField(value);
}

public Modding.Delegates.GetFloatProxy GetPlayerFloatHook
{
get => GetFieldStatic<Modding.Delegates.GetFloatProxy>();
set => SetField(value);
}

public Modding.Delegates.SetStringProxy SetPlayerStringHook
{
get => GetFieldStatic<Modding.Delegates.SetStringProxy>();
set => SetField(value);
}

public Modding.Delegates.GetStringProxy GetPlayerStringHook
{
get => GetFieldStatic<Modding.Delegates.GetStringProxy>();
set => SetField(value);
}

public Modding.Delegates.SetVector3Proxy SetPlayerVector3Hook
{
get => GetFieldStatic<Modding.Delegates.SetVector3Proxy>();
set => SetField(value);
}

public Modding.Delegates.GetVector3Proxy GetPlayerVector3Hook
{
get => GetFieldStatic<Modding.Delegates.GetVector3Proxy>();
set => SetField(value);
}

public Modding.Delegates.SetVariableProxy SetPlayerVariableHook
{
get => GetFieldStatic<Modding.Delegates.SetVariableProxy>();
set => SetField(value);
}

public Modding.Delegates.GetVariableProxy GetPlayerVariableHook
{
get => GetFieldStatic<Modding.Delegates.GetVariableProxy>();
set => SetField(value);
}

public System.Func<System.Int32> BlueHealthHook
{
get => GetFieldStatic<System.Func<System.Int32>>();
set => SetField(value);
}

public Modding.Delegates.TakeHealthProxy TakeHealthHook
{
get => GetFieldStatic<Modding.Delegates.TakeHealthProxy>();
set => SetField(value);
}

public Modding.Delegates.TakeDamageProxy TakeDamageHook
{
get => GetFieldStatic<Modding.Delegates.TakeDamageProxy>();
set => SetField(value);
}

public Modding.Delegates.AfterTakeDamageHandler AfterTakeDamageHook
{
get => GetFieldStatic<Modding.Delegates.AfterTakeDamageHandler>();
set => SetField(value);
}

public System.Action BeforePlayerDeadHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Action AfterPlayerDeadHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Action<GlobalEnums.AttackDirection> AttackHook
{
get => GetFieldStatic<System.Action<GlobalEnums.AttackDirection>>();
set => SetField(value);
}

public System.Action DoAttackHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Action<GlobalEnums.AttackDirection> AfterAttackHook
{
get => GetFieldStatic<System.Action<GlobalEnums.AttackDirection>>();
set => SetField(value);
}

public Modding.Delegates.SlashHitHandler SlashHitHook
{
get => GetFieldStatic<Modding.Delegates.SlashHitHandler>();
set => SetField(value);
}

public Modding.Delegates.CharmUpdateHandler CharmUpdateHook
{
get => GetFieldStatic<Modding.Delegates.CharmUpdateHandler>();
set => SetField(value);
}

public System.Action HeroUpdateHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Func<System.Int32,System.Int32> BeforeAddHealthHook
{
get => GetFieldStatic<System.Func<System.Int32,System.Int32>>();
set => SetField(value);
}

public System.Func<System.Single> FocusCostHook
{
get => GetFieldStatic<System.Func<System.Single>>();
set => SetField(value);
}

public System.Func<System.Int32,System.Int32> SoulGainHook
{
get => GetFieldStatic<System.Func<System.Int32,System.Int32>>();
set => SetField(value);
}

public System.Func<UnityEngine.Vector2,UnityEngine.Vector2> DashVectorHook
{
get => GetFieldStatic<System.Func<UnityEngine.Vector2,UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Func<System.Boolean> DashPressedHook
{
get => GetFieldStatic<System.Func<System.Boolean>>();
set => SetField(value);
}

public System.Action<System.Int32> SavegameLoadHook
{
get => GetFieldStatic<System.Action<System.Int32>>();
set => SetField(value);
}

public System.Action<System.Int32> SavegameSaveHook
{
get => GetFieldStatic<System.Action<System.Int32>>();
set => SetField(value);
}

public System.Action NewGameHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Action<System.Int32> SavegameClearHook
{
get => GetFieldStatic<System.Action<System.Int32>>();
set => SetField(value);
}

public System.Action<SaveGameData> AfterSavegameLoadHook
{
get => GetFieldStatic<System.Action<SaveGameData>>();
set => SetField(value);
}

public System.Action<SaveGameData> BeforeSavegameSaveHook
{
get => GetFieldStatic<System.Action<SaveGameData>>();
set => SetField(value);
}

public System.Func<System.Int32,System.String> GetSaveFileNameHook
{
get => GetFieldStatic<System.Func<System.Int32,System.String>>();
set => SetField(value);
}

public System.Action<System.Int32> AfterSaveGameClearHook
{
get => GetFieldStatic<System.Action<System.Int32>>();
set => SetField(value);
}

public System.Action<System.String> SceneChanged
{
get => GetFieldStatic<System.Action<System.String>>();
set => SetField(value);
}

public System.Func<System.String,System.String> BeforeSceneLoadHook
{
get => GetFieldStatic<System.Func<System.String,System.String>>();
set => SetField(value);
}

public System.Action _finishedLoadingModsHook
{
get => GetFieldStatic<System.Action>();
set => SetField(value);
}

public System.Collections.ObjectModel.ReadOnlyDictionary<Modding.IMod,MenuScreen> BuiltModMenuScreens
{
get => Modding.ModHooks.BuiltModMenuScreens;
}

public Modding.ModHooksGlobalSettings GlobalSettings
{
get => Modding.ModHooks.GlobalSettings;
set => SetPropertyStatic(value);
}

public Modding.ModHooks Instance
{
get => Modding.ModHooks.Instance;
}

public void LoadGlobalSettings () =>
CallMethodStatic();

public void SaveGlobalSettings () =>
CallMethodStatic();

public void LogConsole (string message, Modding.LogLevel level) =>
CallMethodStatic(new object[] {message, level});

public string LanguageGet (string key, string sheet) =>
CallMethodStatic<string>(new object[] {key, sheet});

public void OnCursor (GameManager gm) =>
CallMethodStatic(new object[] {gm});

public void OnColliderCreate (UnityEngine.GameObject go) =>
CallMethodStatic(new object[] {go});

public UnityEngine.GameObject OnObjectPoolSpawn (UnityEngine.GameObject go) =>
CallMethodStatic<UnityEngine.GameObject>(new object[] {go});

public void OnApplicationQuit () =>
CallMethodStatic();

public HitInstance OnHitInstanceBeforeHit (HutongGames.PlayMaker.Fsm owner, HitInstance hit) =>
CallMethodStatic<HitInstance>(new object[] {owner, hit});

public void OnDrawBlackBorders (System.Collections.Generic.List<UnityEngine.GameObject> borders) =>
CallMethodStatic(new object[] {borders});

public bool OnEnableEnemy (UnityEngine.GameObject enemy, bool isAlreadyDead) =>
CallMethodStatic<bool>(new object[] {enemy, isAlreadyDead});

public void OnRecieveDeathEvent (EnemyDeathEffects enemyDeathEffects, bool eventAlreadyRecieved, System.Single? attackDirection, bool resetDeathEvent, bool spellBurn, bool isWatery) =>
CallMethodStatic(new object[] {enemyDeathEffects, eventAlreadyRecieved, attackDirection, resetDeathEvent, spellBurn, isWatery});

public void OnRecordKillForJournal (EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey) =>
CallMethodStatic(new object[] {enemyDeathEffects, playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey, newDataBoolPlayerDataLookupKey});

public void SetPlayerBool (string target, bool orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public bool GetPlayerBool (string target, PlayerData pd) =>
CallMethodStatic<bool>(new object[] {target, pd});

public void SetPlayerInt (string target, int orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public int GetPlayerInt (string target, PlayerData pd) =>
CallMethodStatic<int>(new object[] {target, pd});

public void SetPlayerFloat (string target, float orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public float GetPlayerFloat (string target, PlayerData pd) =>
CallMethodStatic<float>(new object[] {target, pd});

public void SetPlayerString (string target, string orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public string GetPlayerString (string target, PlayerData pd) =>
CallMethodStatic<string>(new object[] {target, pd});

public void SetPlayerVector3 (string target, UnityEngine.Vector3 orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public UnityEngine.Vector3 GetPlayerVector3 (string target, PlayerData pd) =>
CallMethodStatic<UnityEngine.Vector3>(new object[] {target, pd});

public void SetPlayerVariable<T>(string target, T orig, PlayerData pd) =>
CallMethodStatic(new object[] {target, orig, pd});

public T GetPlayerVariable<T>(string target, PlayerData pd) =>
CallMethodStatic<T>(new object[] {target, pd});

public int OnBlueHealth() => CallMethodStatic<int>();

public int OnTakeHealth (int damage) =>
CallMethodStatic<int>(new object[] {damage});

public int OnTakeDamage (int hazardType, int damage) =>
CallMethodStatic<int>(new object[] {hazardType, damage});

public int AfterTakeDamage (int hazardType, int damageAmount) =>
CallMethodStatic<int>(new object[] {hazardType, damageAmount});

public void OnBeforePlayerDead () =>
CallMethodStatic();

public void OnAfterPlayerDead () =>
CallMethodStatic();

public void OnAttack (GlobalEnums.AttackDirection dir) =>
CallMethodStatic(new object[] {dir});

public void OnDoAttack () =>
CallMethodStatic();

public void AfterAttack (GlobalEnums.AttackDirection dir) =>
CallMethodStatic(new object[] {dir});

public void OnSlashHit (UnityEngine.Collider2D otherCollider, UnityEngine.GameObject gameObject) =>
CallMethodStatic(new object[] {otherCollider, gameObject});

public void OnCharmUpdate (PlayerData pd, HeroController hc) =>
CallMethodStatic(new object[] {pd, hc});

public void OnHeroUpdate () =>
CallMethodStatic();

public int BeforeAddHealth (int amount) =>
CallMethodStatic<int>(new object[] {amount});

public float OnFocusCost () =>
CallMethodStatic<float>();

public int OnSoulGain (int num) =>
CallMethodStatic<int>(new object[] {num});

public UnityEngine.Vector2 DashVelocityChange (UnityEngine.Vector2 change) =>
CallMethodStatic<UnityEngine.Vector2>(new object[] {change});

public bool OnDashPressed () =>
CallMethodStatic<bool>();

public void OnSavegameLoad (int id) =>
CallMethodStatic(new object[] {id});

public void OnSavegameSave (int id) =>
CallMethodStatic(new object[] {id});

public void OnNewGame () =>
CallMethodStatic();

public void OnSavegameClear (int id) =>
CallMethodStatic(new object[] {id});

public void OnAfterSaveGameLoad (SaveGameData data) =>
CallMethodStatic(new object[] {data});

public void OnBeforeSaveGameSave (SaveGameData data) =>
CallMethodStatic(new object[] {data});

public string GetSaveFileName (int saveSlot) =>
CallMethodStatic<string>(new object[] {saveSlot});

public void OnAfterSaveGameClear (int saveSlot) =>
CallMethodStatic(new object[] {saveSlot});

public void OnSceneChanged (string targetScene) =>
CallMethodStatic(new object[] {targetScene});

public string BeforeSceneLoad (string sceneName) =>
CallMethodStatic<string>(new object[] {sceneName});

public Modding.IMod GetMod (string name, bool onlyEnabled = false, bool allowLoadError = false) =>
Modding.ModHooks.GetMod(name, onlyEnabled, allowLoadError);

public Modding.IMod GetMod (System.Type type, bool onlyEnabled = false, bool allowLoadError = false) =>
Modding.ModHooks.GetMod(type, onlyEnabled, allowLoadError);

public bool ModEnabled (Modding.ITogglableMod mod) =>
Modding.ModHooks.ModEnabled(mod);

public bool ModEnabled (string name) =>
Modding.ModHooks.ModEnabled(name);

public bool ModEnabled (System.Type type) =>
Modding.ModHooks.ModEnabled(type);

public System.Collections.Generic.IEnumerable<Modding.IMod> GetAllMods (bool onlyEnabled = false, bool allowLoadError = false) =>
Modding.ModHooks.GetAllMods(onlyEnabled, allowLoadError);

public void OnFinishedLoadingMods () =>
CallMethodStatic();

}
}
