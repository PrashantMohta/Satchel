namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_UpdateRegistry allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_UpdateRegistryR:InstanceClassWrapper<TMPro.TMP_UpdateRegistry>
{
public TMP_UpdateRegistryR(TMPro.TMP_UpdateRegistry _orig) : base(_orig) {}
public TMPro.TMP_UpdateRegistry s_Instance
{
get => GetFieldStatic<TMPro.TMP_UpdateRegistry>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue
{
get => GetField<System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_LayoutQueueLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue
{
get => GetField<System.Collections.Generic.List<UnityEngine.UI.ICanvasElement>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_GraphicQueueLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>();
set => SetField(value);
}

public TMPro.TMP_UpdateRegistry instance
{
get => TMPro.TMP_UpdateRegistry.instance;
}

public void RegisterCanvasElementForLayoutRebuild (UnityEngine.UI.ICanvasElement element) =>
TMPro.TMP_UpdateRegistry.RegisterCanvasElementForLayoutRebuild(element);

public bool InternalRegisterCanvasElementForLayoutRebuild (UnityEngine.UI.ICanvasElement element) =>
CallMethod<bool>(new object[] {element});

public void RegisterCanvasElementForGraphicRebuild (UnityEngine.UI.ICanvasElement element) =>
TMPro.TMP_UpdateRegistry.RegisterCanvasElementForGraphicRebuild(element);

public bool InternalRegisterCanvasElementForGraphicRebuild (UnityEngine.UI.ICanvasElement element) =>
CallMethod<bool>(new object[] {element});

public void PerformUpdateForCanvasRendererObjects () =>
CallMethod();

public void PerformUpdateForMeshRendererObjects () =>
CallMethod();

public void UnRegisterCanvasElementForRebuild (UnityEngine.UI.ICanvasElement element) =>
TMPro.TMP_UpdateRegistry.UnRegisterCanvasElementForRebuild(element);

public void InternalUnRegisterCanvasElementForLayoutRebuild (UnityEngine.UI.ICanvasElement element) =>
CallMethod(new object[] {element});

public void InternalUnRegisterCanvasElementForGraphicRebuild (UnityEngine.UI.ICanvasElement element) =>
CallMethod(new object[] {element});

}
}
