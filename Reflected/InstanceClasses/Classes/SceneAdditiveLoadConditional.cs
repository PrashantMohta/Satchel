namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneAdditiveLoadConditional allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneAdditiveLoadConditionalR : InstanceClassWrapper<SceneAdditiveLoadConditional>
{
    public SceneAdditiveLoadConditionalR(SceneAdditiveLoadConditional _orig) : base(_orig)
    {
    }

    public string sceneNameToLoad
    {
        get => orig.sceneNameToLoad;
        set => orig.sceneNameToLoad = value;
    }

    public string altSceneNameToLoad
    {
        get => orig.altSceneNameToLoad;
        set => orig.altSceneNameToLoad = value;
    }

    public bool loadAlt
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string needsPlayerDataBool
    {
        get => orig.needsPlayerDataBool;
        set => orig.needsPlayerDataBool = value;
    }

    public bool playerDataBoolValue
    {
        get => orig.playerDataBoolValue;
        set => orig.playerDataBoolValue = value;
    }

    public string needsPlayerDataInt
    {
        get => orig.needsPlayerDataInt;
        set => orig.needsPlayerDataInt = value;
    }

    public int playerDataIntValue
    {
        get => orig.playerDataIntValue;
        set => orig.playerDataIntValue = value;
    }

    public bool isIntValue
    {
        get => orig.isIntValue;
        set => orig.isIntValue = value;
    }

    public SceneAdditiveLoadConditional.BoolTest[] extraBoolTests
    {
        get => orig.extraBoolTests;
        set => orig.extraBoolTests = value;
    }

    public SceneAdditiveLoadConditional.IntTest[] extraIntTests
    {
        get => orig.extraIntTests;
        set => orig.extraIntTests = value;
    }

    public bool usePersistentBoolItem
    {
        get => orig.usePersistentBoolItem;
        set => orig.usePersistentBoolItem = value;
    }

    public PersistentBoolData persistentBoolData
    {
        get => orig.persistentBoolData;
        set => orig.persistentBoolData = value;
    }

    public string doorTrigger
    {
        get => orig.doorTrigger;
        set => orig.doorTrigger = value;
    }

    public bool sceneLoaded
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public PersistentBoolData saveStateData
    {
        get => orig.saveStateData;
        set => orig.saveStateData = value;
    }

    public bool skipExtraTests
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public List<SceneAdditiveLoadConditional> additiveSceneLoads
    {
        get => GetFieldStatic<List<SceneAdditiveLoadConditional>>();
        set => SetField(value);
    }

    public bool loadInSequence
    {
        get => SceneAdditiveLoadConditional.loadInSequence;
        set => SceneAdditiveLoadConditional.loadInSequence = value;
    }

    public string SceneNameToLoad => GetProperty<string>();

    public bool ShouldLoadBoss => SceneAdditiveLoadConditional.ShouldLoadBoss;


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator LoadAll()
    {
        return SceneAdditiveLoadConditional.LoadAll();
    }

    public IEnumerator LoadRoutine(bool callEvent = false)
    {
        return CallMethod<IEnumerator>(new object[] { callEvent });
    }
}