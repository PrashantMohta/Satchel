using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossChallengeUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossChallengeUIR : InstanceClassWrapper<BossChallengeUI>
{
    public BossChallengeUIR(BossChallengeUI _orig) : base(_orig)
    {
    }

    public BossStatue bossStatue
    {
        get => GetField<BossStatue>();
        set => SetField(value);
    }

    public Text bossNameText
    {
        get => orig.bossNameText;
        set => orig.bossNameText = value;
    }

    public Text descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public MenuSelectable firstSelected
    {
        get => orig.firstSelected;
        set => orig.firstSelected = value;
    }

    public string closeStateName
    {
        get => orig.closeStateName;
        set => orig.closeStateName = value;
    }

    public GameObject tier3UnlockEffect
    {
        get => orig.tier3UnlockEffect;
        set => orig.tier3UnlockEffect = value;
    }

    public float tier3UnlockEffectDelay
    {
        get => orig.tier3UnlockEffectDelay;
        set => orig.tier3UnlockEffectDelay = value;
    }

    public int lastSelectedButton
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public Canvas canvas
    {
        get => GetField<Canvas>();
        set => SetField(value);
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public CanvasGroup group
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public bool started
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Setup(BossStatue bossStatue, string bossNameSheet, string bossNameKey, string descriptionSheet,
        string descriptionKey)
    {
        orig.Setup(bossStatue, bossNameSheet, bossNameKey, descriptionSheet, descriptionKey);
    }

    public IEnumerator ShowUnlockEffect()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator SetFirstSelected()
    {
        return CallMethod<IEnumerator>();
    }

    public void Hide()
    {
        orig.Hide();
    }

    public void Hide(bool doAnim)
    {
        orig.Hide(doAnim);
    }

    public IEnumerator HideAnim()
    {
        return CallMethod<IEnumerator>();
    }

    public void LoadBoss(int level)
    {
        orig.LoadBoss(level);
    }

    public void LoadBoss(int level, bool doHideAnim)
    {
        orig.LoadBoss(level, doHideAnim);
    }

    public void RecordLastSelected(int index)
    {
        orig.RecordLastSelected(index);
    }
}