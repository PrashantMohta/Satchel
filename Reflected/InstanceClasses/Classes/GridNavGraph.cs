namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GridNavGraph allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GridNavGraphR:InstanceClassWrapper<Modding.Menu.GridNavGraph>
{
public GridNavGraphR(Modding.Menu.GridNavGraph _orig) : base(_orig) {}
public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UI.Selectable>> grid
{
get => GetField<System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UI.Selectable>>>();
set => SetField(value);
}

public int Columns
{
get => orig.Columns;
set => SetProperty(value);
}

public void ChangeColumns (int columns) =>
orig.ChangeColumns(columns);

public void AddNavigationNode (UnityEngine.UI.Selectable selectable) =>
orig.AddNavigationNode(selectable);

public UnityEngine.UI.Selectable BuildNavigation () =>
orig.BuildNavigation();

public T GetWrapped<T>(System.Collections.Generic.List<T> list, int index) =>
CallMethodStatic<T>(new object[] {list, index});

}
}
