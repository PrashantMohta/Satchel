namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RegularGridLayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RegularGridLayoutR:InstanceClassWrapper<Modding.Menu.RegularGridLayout>
{
public RegularGridLayoutR(Modding.Menu.RegularGridLayout _orig) : base(_orig) {}
public Modding.Menu.RelVector2 ItemAdvance
{
get => orig.ItemAdvance;
set => orig.ItemAdvance = value;
}

public Modding.Menu.AnchoredPosition Start
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

public UnityEngine.Vector2Int IndexPos
{
get => orig.IndexPos;
}

public Modding.Menu.RegularGridLayout CreateVerticalLayout (float itemHeight, UnityEngine.Vector2 start = default) =>
Modding.Menu.RegularGridLayout.CreateVerticalLayout(itemHeight, start);

public void ModifyNext (UnityEngine.RectTransform rt) =>
orig.ModifyNext(rt);

public void ChangeColumns (int columns, float originalAnchor = 0.5f, Modding.Menu.RelVector2? newSize = null, float newAnchor = 0.5f) =>
orig.ChangeColumns(columns, originalAnchor, newSize, newAnchor);

}
}
