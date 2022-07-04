using UnityEngine.UI;
using UnityEngine.UI.Extensions;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ContentPackDetailsUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ContentPackDetailsUIR : InstanceClassWrapper<ContentPackDetailsUI>
{
    public ContentPackDetailsUIR(ContentPackDetailsUI _orig) : base(_orig)
    {
    }

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

    public Image posterImage
    {
        get => orig.posterImage;
        set => orig.posterImage = value;
    }

    public Text titleText
    {
        get => orig.titleText;
        set => orig.titleText = value;
    }

    public Text descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public SoftMaskScript softMask
    {
        get => orig.softMask;
        set => orig.softMask = value;
    }

    public ScrollRect scrollRect
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


    public void Awake()
    {
        CallMethod();
    }

    public void ShowPackDetails(int index)
    {
        orig.ShowPackDetails(index);
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator UpdateDelayed()
    {
        return CallMethod<IEnumerator>();
    }

    public void UndoMenuStyle()
    {
        orig.UndoMenuStyle();
    }
}