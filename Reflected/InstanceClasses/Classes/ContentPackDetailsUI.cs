namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ContentPackDetailsUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ContentPackDetailsUIR:InstanceClassWrapper<ContentPackDetailsUI>
{
public ContentPackDetailsUIR(ContentPackDetailsUI _orig) : base(_orig) {}
public ContentPackDetailsUI Instance
{
get => ContentPackDetailsUI.Instance;
set => ContentPackDetailsUI.Instance = value;
}

public ContentPackDetailsUI.ContentPackDetails[] details
{
get => orig.details;
set => orig.details = value;
}

public UnityEngine.UI.Image posterImage
{
get => orig.posterImage;
set => orig.posterImage = value;
}

public UnityEngine.UI.Text titleText
{
get => orig.titleText;
set => orig.titleText = value;
}

public UnityEngine.UI.Text descriptionText
{
get => orig.descriptionText;
set => orig.descriptionText = value;
}

public UnityEngine.UI.Extensions.SoftMaskScript softMask
{
get => orig.softMask;
set => orig.softMask = value;
}

public UnityEngine.UI.ScrollRect scrollRect
{
get => orig.scrollRect;
set => orig.scrollRect = value;
}

public string languageSheet
{
get => orig.languageSheet;
set => orig.languageSheet = value;
}

public int beforeSpaces
{
get => orig.beforeSpaces;
set => orig.beforeSpaces = value;
}

public int afterSpaces
{
get => orig.afterSpaces;
set => orig.afterSpaces = value;
}

public int oldMenuStyleIndex
{
get => GetField<int>();
set => SetField(value);
}

public int packDetailsIndex
{
get => GetField<int>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void ShowPackDetails (int index) =>
orig.ShowPackDetails(index);

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator UpdateDelayed () =>
CallMethod<System.Collections.IEnumerator>();

public void UndoMenuStyle () =>
orig.UndoMenuStyle();

}
}
