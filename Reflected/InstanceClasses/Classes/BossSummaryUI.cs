namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossSummaryUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSummaryUIR:InstanceClassWrapper<BossSummaryUI>
{
public BossSummaryUIR(BossSummaryUI _orig) : base(_orig) {}
public UnityEngine.GameObject listItemTemplate
{
get => orig.listItemTemplate;
set => orig.listItemTemplate = value;
}

public UnityEngine.Sprite[] stateSprites
{
get => orig.stateSprites;
set => orig.stateSprites = value;
}

public UnityEngine.Sprite[] noTierStateSprites
{
get => orig.noTierStateSprites;
set => orig.noTierStateSprites = value;
}

public string defaultName
{
get => orig.defaultName;
set => orig.defaultName = value;
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void SetupUI (System.Collections.Generic.List<BossStatue> bossStatues) =>
orig.SetupUI(bossStatues);

public void CreateListItem (BossStatue bossStatue, bool isAlt = false) =>
CallMethod(new object[] {bossStatue, isAlt});

public void Show () =>
orig.Show();

public void Hide () =>
orig.Hide();

public System.Collections.IEnumerator Close () =>
CallMethod<System.Collections.IEnumerator>();

}
}
