namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_UpdateManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_UpdateManagerR:InstanceClassWrapper<TMPro.TMP_UpdateManager>
{
public TMP_UpdateManagerR(TMPro.TMP_UpdateManager _orig) : base(_orig) {}
public TMPro.TMP_UpdateManager s_Instance
{
get => GetFieldStatic<TMPro.TMP_UpdateManager>();
set => SetField(value);
}

public System.Collections.Generic.List<TMPro.TMP_Text> m_LayoutRebuildQueue
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_Text>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_LayoutQueueLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>();
set => SetField(value);
}

public System.Collections.Generic.List<TMPro.TMP_Text> m_GraphicRebuildQueue
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_Text>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_GraphicQueueLookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>();
set => SetField(value);
}

public TMPro.TMP_UpdateManager instance
{
get => TMPro.TMP_UpdateManager.instance;
}

public void RegisterTextElementForLayoutRebuild (TMPro.TMP_Text element) =>
TMPro.TMP_UpdateManager.RegisterTextElementForLayoutRebuild(element);

public bool InternalRegisterTextElementForLayoutRebuild (TMPro.TMP_Text element) =>
CallMethod<bool>(new object[] {element});

public void RegisterTextElementForGraphicRebuild (TMPro.TMP_Text element) =>
TMPro.TMP_UpdateManager.RegisterTextElementForGraphicRebuild(element);

public bool InternalRegisterTextElementForGraphicRebuild (TMPro.TMP_Text element) =>
CallMethod<bool>(new object[] {element});

public void OnCameraPreRender (UnityEngine.Camera cam) =>
CallMethod(new object[] {cam});

public void UnRegisterTextElementForRebuild (TMPro.TMP_Text element) =>
TMPro.TMP_UpdateManager.UnRegisterTextElementForRebuild(element);

public void InternalUnRegisterTextElementForGraphicRebuild (TMPro.TMP_Text element) =>
CallMethod(new object[] {element});

public void InternalUnRegisterTextElementForLayoutRebuild (TMPro.TMP_Text element) =>
CallMethod(new object[] {element});

}
}
