using Modding.Menu;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RegularGridLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RegularGridLayoutR : InstanceClassWrapper<RegularGridLayout>
{
    public RegularGridLayoutR(RegularGridLayout _orig) : base(_orig)
    {
    }

    public RelVector2 ItemAdvance
    {
        get => orig.ItemAdvance;
        set => orig.ItemAdvance = value;
    }

    public AnchoredPosition Start
    {
        get => orig.Start;
        set => orig.Start = value;
    }

    public int Columns
    {
        get => orig.Columns;
        set => orig.Columns = value;
    }

    public int Index
    {
        get => orig.Index;
        set => orig.Index = value;
    }

    public Vector2Int IndexPos => orig.IndexPos;

    public RegularGridLayout CreateVerticalLayout(float itemHeight, Vector2 start = default)
    {
        return RegularGridLayout.CreateVerticalLayout(itemHeight, start);
    }

    public void ModifyNext(RectTransform rt)
    {
        orig.ModifyNext(rt);
    }

    public void ChangeColumns(int columns, float originalAnchor = 0.5f, RelVector2? newSize = null,
        float newAnchor = 0.5f)
    {
        orig.ChangeColumns(columns, originalAnchor, newSize, newAnchor);
    }
}