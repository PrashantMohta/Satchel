namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossChallengeUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossChallengeUIR:InstanceClassWrapper<BossChallengeUI>
{
public BossChallengeUIR(BossChallengeUI _orig) : base(_orig) {}
public BossStatue bossStatue
{
get => GetField<BossStatue>();
set => SetField(value);
}

public UnityEngine.UI.Text bossNameText
{
get => orig.bossNameText;
set => orig.bossNameText = value;
}

public UnityEngine.UI.Text descriptionText
{
get => orig.descriptionText;
set => orig.descriptionText = value;
}

public UnityEngine.UI.MenuSelectable firstSelected
{
get => orig.firstSelected;
set => orig.firstSelected = value;
}

public string closeStateName
{
get => orig.closeStateName;
set => orig.closeStateName = value;
}

public UnityEngine.GameObject tier3UnlockEffect
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

public UnityEngine.Canvas canvas
{
get => GetField<UnityEngine.Canvas>();
set => SetField(value);
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.CanvasGroup group
{
get => GetField<UnityEngine.CanvasGroup>();
set => SetField(value);
}

public bool started
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Setup (BossStatue bossStatue, string bossNameSheet, string bossNameKey, string descriptionSheet, string descriptionKey) =>
orig.Setup(bossStatue, bossNameSheet, bossNameKey, descriptionSheet, descriptionKey);

public System.Collections.IEnumerator ShowUnlockEffect () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator SetFirstSelected () =>
CallMethod<System.Collections.IEnumerator>();

public void Hide () =>
orig.Hide();

public void Hide (bool doAnim) =>
orig.Hide(doAnim);

public System.Collections.IEnumerator HideAnim () =>
CallMethod<System.Collections.IEnumerator>();

public void LoadBoss (int level) =>
orig.LoadBoss(level);

public void LoadBoss (int level, bool doHideAnim) =>
orig.LoadBoss(level, doHideAnim);

public void RecordLastSelected (int index) =>
orig.RecordLastSelected(index);

}
}
