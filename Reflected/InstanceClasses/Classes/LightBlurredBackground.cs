namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LightBlurredBackground allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LightBlurredBackgroundR:InstanceClassWrapper<LightBlurredBackground>
{
public LightBlurredBackgroundR(LightBlurredBackground _orig) : base(_orig) {}
public float distantFarClipPlane
{
get => GetField<float>();
set => SetField(value);
}

public int renderTextureHeight
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Material blitMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public float clipEpsilon
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.LayerMask blurPlaneLayer
{
get => GetField<UnityEngine.LayerMask>();
set => SetField(value);
}

public GameCameras gameCameras
{
get => GetField<GameCameras>();
set => SetField(value);
}

public UnityEngine.Camera sceneCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public UnityEngine.Camera backgroundCamera
{
get => GetField<UnityEngine.Camera>();
set => SetField(value);
}

public UnityEngine.RenderTexture renderTexture
{
get => GetField<UnityEngine.RenderTexture>();
set => SetField(value);
}

public UnityEngine.Material blurMaterialInstance
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.Material blitMaterialInstance
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public LightBlur lightBlur
{
get => GetField<LightBlur>();
set => SetField(value);
}

public int passGroupCount
{
get => GetField<int>();
set => SetField(value);
}

public int _vibrancyProp
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int _blurPlaneVibranceProp
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int RenderTextureHeight
{
get => orig.RenderTextureHeight;
set => orig.RenderTextureHeight = value;
}

public int PassGroupCount
{
get => orig.PassGroupCount;
set => orig.PassGroupCount = value;
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnCameraAspectChanged (float aspect) =>
CallMethod(new object[] {aspect});

public void OnDisable () =>
CallMethod();

public void OnBlurPlanesChanged () =>
CallMethod();

public void LateUpdate () =>
CallMethod();

public void UpdateCameraClipPlanes () =>
CallMethod();

}
}
