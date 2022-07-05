namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlanarRealtimeReflection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlanarRealtimeReflectionR : InstanceClassWrapper<PlanarRealtimeReflection>
{
    public PlanarRealtimeReflectionR(PlanarRealtimeReflection _orig) : base(_orig)
    {
    }

    public bool m_DisablePixelLights
    {
        get => orig.m_DisablePixelLights;
        set => orig.m_DisablePixelLights = value;
    }

    public int m_TextureResolution
    {
        get => orig.m_TextureResolution;
        set => orig.m_TextureResolution = value;
    }

    public float m_clipPlaneOffset
    {
        get => orig.m_clipPlaneOffset;
        set => orig.m_clipPlaneOffset = value;
    }

    public float m_finalClipPlaneOffset
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool m_NormalsFromMesh
    {
        get => orig.m_NormalsFromMesh;
        set => orig.m_NormalsFromMesh = value;
    }

    public bool m_BaseClipOffsetFromMesh
    {
        get => orig.m_BaseClipOffsetFromMesh;
        set => orig.m_BaseClipOffsetFromMesh = value;
    }

    public bool m_BaseClipOffsetFromMeshInverted
    {
        get => orig.m_BaseClipOffsetFromMeshInverted;
        set => orig.m_BaseClipOffsetFromMeshInverted = value;
    }

    public Vector3 m_calculatedNormal
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public LayerMask m_ReflectLayers
    {
        get => orig.m_ReflectLayers;
        set => orig.m_ReflectLayers = value;
    }

    public Hashtable m_ReflectionCameras
    {
        get => GetField<Hashtable>();
        set => SetField(value);
    }

    public RenderTexture m_ReflectionTexture
    {
        get => GetField<RenderTexture>();
        set => SetField(value);
    }

    public int m_OldReflectionTextureSize
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool s_InsideRendering
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }


    public void OnWillRenderObject()
    {
        orig.OnWillRenderObject();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void UpdateCameraModes(Camera src, Camera dest)
    {
        CallMethod(new object[] { src, dest });
    }

    public void CreateSurfaceObjects(Camera currentCamera, Camera reflectionCamera)
    {
        CallMethod(new object[] { currentCamera, reflectionCamera });
    }

    public float sgn(float a)
    {
        return CallMethodStatic<float>(new object[] { a });
    }

    public Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
    {
        return CallMethod<Vector4>(new object[] { cam, pos, normal, sideSign });
    }

    public void CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
    {
        CallMethodStatic(new object[] { projection, clipPlane });
    }

    public void CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
    {
        CallMethodStatic(new object[] { reflectionMat, plane });
    }
}