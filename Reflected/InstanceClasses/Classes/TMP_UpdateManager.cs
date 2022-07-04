using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_UpdateManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_UpdateManagerR : InstanceClassWrapper<TMP_UpdateManager>
{
    public TMP_UpdateManagerR(TMP_UpdateManager _orig) : base(_orig)
    {
    }

    public TMP_UpdateManager s_Instance
    {
        get => GetFieldStatic<TMP_UpdateManager>();
        set => SetField(value);
    }

    public List<TMP_Text> m_LayoutRebuildQueue
    {
        get => GetField<List<TMP_Text>>();
        set => SetField(value);
    }

    public Dictionary<int, int> m_LayoutQueueLookup
    {
        get => GetField<Dictionary<int, int>>();
        set => SetField(value);
    }

    public List<TMP_Text> m_GraphicRebuildQueue
    {
        get => GetField<List<TMP_Text>>();
        set => SetField(value);
    }

    public Dictionary<int, int> m_GraphicQueueLookup
    {
        get => GetField<Dictionary<int, int>>();
        set => SetField(value);
    }

    public TMP_UpdateManager instance => TMP_UpdateManager.instance;

    public void RegisterTextElementForLayoutRebuild(TMP_Text element)
    {
        TMP_UpdateManager.RegisterTextElementForLayoutRebuild(element);
    }

    public bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
    {
        return CallMethod<bool>(new object[] { element });
    }

    public void RegisterTextElementForGraphicRebuild(TMP_Text element)
    {
        TMP_UpdateManager.RegisterTextElementForGraphicRebuild(element);
    }

    public bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
    {
        return CallMethod<bool>(new object[] { element });
    }

    public void OnCameraPreRender(Camera cam)
    {
        CallMethod(new object[] { cam });
    }

    public void UnRegisterTextElementForRebuild(TMP_Text element)
    {
        TMP_UpdateManager.UnRegisterTextElementForRebuild(element);
    }

    public void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
    {
        CallMethod(new object[] { element });
    }

    public void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
    {
        CallMethod(new object[] { element });
    }
}