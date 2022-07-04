using TMPro;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_UpdateRegistry allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_UpdateRegistryR : InstanceClassWrapper<TMP_UpdateRegistry>
{
    public TMP_UpdateRegistryR(TMP_UpdateRegistry _orig) : base(_orig)
    {
    }

    public TMP_UpdateRegistry s_Instance
    {
        get => GetFieldStatic<TMP_UpdateRegistry>();
        set => SetField(value);
    }

    public List<ICanvasElement> m_LayoutRebuildQueue
    {
        get => GetField<List<ICanvasElement>>();
        set => SetField(value);
    }

    public Dictionary<int, int> m_LayoutQueueLookup
    {
        get => GetField<Dictionary<int, int>>();
        set => SetField(value);
    }

    public List<ICanvasElement> m_GraphicRebuildQueue
    {
        get => GetField<List<ICanvasElement>>();
        set => SetField(value);
    }

    public Dictionary<int, int> m_GraphicQueueLookup
    {
        get => GetField<Dictionary<int, int>>();
        set => SetField(value);
    }

    public TMP_UpdateRegistry instance => TMP_UpdateRegistry.instance;

    public void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
    {
        TMP_UpdateRegistry.RegisterCanvasElementForLayoutRebuild(element);
    }

    public bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
    {
        return CallMethod<bool>(new object[] { element });
    }

    public void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
    {
        TMP_UpdateRegistry.RegisterCanvasElementForGraphicRebuild(element);
    }

    public bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
    {
        return CallMethod<bool>(new object[] { element });
    }

    public void PerformUpdateForCanvasRendererObjects()
    {
        CallMethod();
    }

    public void PerformUpdateForMeshRendererObjects()
    {
        CallMethod();
    }

    public void UnRegisterCanvasElementForRebuild(ICanvasElement element)
    {
        TMP_UpdateRegistry.UnRegisterCanvasElementForRebuild(element);
    }

    public void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
    {
        CallMethod(new object[] { element });
    }

    public void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
    {
        CallMethod(new object[] { element });
    }
}