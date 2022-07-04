using Modding.Menu;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GridNavGraph allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GridNavGraphR : InstanceClassWrapper<GridNavGraph>
{
    public GridNavGraphR(GridNavGraph _orig) : base(_orig)
    {
    }

    public List<List<Selectable>> grid
    {
        get => GetField<List<List<Selectable>>>();
        set => SetField(value);
    }

    public int Columns
    {
        get => orig.Columns;
        set => SetProperty(value);
    }

    public void ChangeColumns(int columns)
    {
        orig.ChangeColumns(columns);
    }

    public void AddNavigationNode(Selectable selectable)
    {
        orig.AddNavigationNode(selectable);
    }

    public Selectable BuildNavigation()
    {
        return orig.BuildNavigation();
    }

    public T GetWrapped<T>(List<T> list, int index)
    {
        return CallMethodStatic<T>(new object[] { list, index });
    }
}