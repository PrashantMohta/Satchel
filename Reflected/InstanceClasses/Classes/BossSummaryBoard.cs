namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSummaryBoard allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSummaryBoardR : InstanceClassWrapper<BossSummaryBoard>
{
    public BossSummaryBoardR(BossSummaryBoard _orig) : base(_orig)
    {
    }

    public List<BossStatue> bossStatues
    {
        get => orig.bossStatues;
        set => orig.bossStatues = value;
    }

    public GameObject bossSummaryUI
    {
        get => orig.bossSummaryUI;
        set => orig.bossSummaryUI = value;
    }

    public BossSummaryUI ui
    {
        get => GetField<BossSummaryUI>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Show()
    {
        orig.Show();
    }

    public void Hide()
    {
        orig.Hide();
    }
}