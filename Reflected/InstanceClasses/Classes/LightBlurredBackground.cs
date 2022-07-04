namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LightBlurredBackground allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LightBlurredBackgroundR : InstanceClassWrapper<LightBlurredBackground>
{
    public LightBlurredBackgroundR(LightBlurredBackground _orig) : base(_orig)
    {
    }

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

    public Material blitMaterial
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public float clipEpsilon
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public LayerMask blurPlaneLayer
    {
        get => GetField<LayerMask>();
        set => SetField(value);
    }

    public GameCameras gameCameras
    {
        get => GetField<GameCameras>();
        set => SetField(value);
    }

    public Camera sceneCamera
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public Camera backgroundCamera
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public RenderTexture renderTexture
    {
        get => GetField<RenderTexture>();
        set => SetField(value);
    }

    public Material blurMaterialInstance
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public Material blitMaterialInstance
    {
        get => GetField<Material>();
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


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnCameraAspectChanged(float aspect)
    {
        CallMethod(new object[] { aspect });
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnBlurPlanesChanged()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void UpdateCameraClipPlanes()
    {
        CallMethod();
    }
}