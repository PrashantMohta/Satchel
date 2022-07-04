namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RealtimeReflections allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RealtimeReflectionsR : InstanceClassWrapper<RealtimeReflections>
{
    public RealtimeReflectionsR(RealtimeReflections _orig) : base(_orig)
    {
    }

    public int cubemapSize
    {
        get => orig.cubemapSize;
        set => orig.cubemapSize = value;
    }

    public float nearClip
    {
        get => orig.nearClip;
        set => orig.nearClip = value;
    }

    public float farClip
    {
        get => orig.farClip;
        set => orig.farClip = value;
    }

    public bool oneFacePerFrame
    {
        get => orig.oneFacePerFrame;
        set => orig.oneFacePerFrame = value;
    }

    public Material[] materials
    {
        get => orig.materials;
        set => orig.materials = value;
    }

    public ReflectionProbe[] reflectionProbes
    {
        get => orig.reflectionProbes;
        set => orig.reflectionProbes = value;
    }

    public LayerMask layerMask
    {
        get => orig.layerMask;
        set => orig.layerMask = value;
    }

    public Camera cam
    {
        get => GetField<Camera>();
        set => SetField(value);
    }

    public RenderTexture renderTexture
    {
        get => GetField<RenderTexture>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void UpdateCubemap(int faceMask)
    {
        CallMethod(new object[] { faceMask });
    }

    public void OnDisable()
    {
        CallMethod();
    }
}