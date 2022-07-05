using ToJ;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Mask allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MaskR : InstanceClassWrapper<Mask>
{
    public MaskR(Mask _orig) : base(_orig)
    {
    }

    public bool shaderErrorLogged
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool _invertAxis
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool _clampAlphaHorizontally
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool _clampAlphaVertically
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float _clampingBorder
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool _useMaskAlphaChannel
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Shader _maskedSpriteWorldCoordsShader
    {
        get => GetField<Shader>();
        set => SetField(value);
    }

    public Shader _maskedUnlitWorldCoordsShader
    {
        get => GetField<Shader>();
        set => SetField(value);
    }

    public bool invertAxis
    {
        get => orig.invertAxis;
        set => orig.invertAxis = value;
    }

    public bool clampAlphaHorizontally
    {
        get => orig.clampAlphaHorizontally;
        set => orig.clampAlphaHorizontally = value;
    }

    public bool clampAlphaVertically
    {
        get => orig.clampAlphaVertically;
        set => orig.clampAlphaVertically = value;
    }

    public float clampingBorder
    {
        get => orig.clampingBorder;
        set => orig.clampingBorder = value;
    }

    public bool useMaskAlphaChannel
    {
        get => orig.useMaskAlphaChannel;
        set => orig.useMaskAlphaChannel = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public Vector3 RotateVector(Vector3 point, Vector3 angles)
    {
        return CallMethod<Vector3>(new object[] { point, angles });
    }

    public void SetMaskMappingAxisInMaterials(Mask.MappingAxis mappingAxis)
    {
        CallMethod(new object[] { mappingAxis });
    }

    public void SetMaskMappingAxisInMaterial(Mask.MappingAxis mappingAxis, Material material)
    {
        orig.SetMaskMappingAxisInMaterial(mappingAxis, material);
    }

    public void SetMaskFloatValueInMaterials(string variable, float value)
    {
        CallMethod(new object[] { variable, value });
    }

    public void SetMaskBoolValueInMaterials(string variable, bool value)
    {
        CallMethod(new object[] { variable, value });
    }

    public void SetMaskBoolValueInMaterial(string variable, bool value, Material material)
    {
        orig.SetMaskBoolValueInMaterial(variable, value, material);
    }

    public void CreateAndAssignQuad(Mesh mesh, float minX = -0.5f, float maxX = 0.5f, float minY = -0.5f,
        float maxY = 0.5f)
    {
        CallMethod(new object[] { mesh, minX, maxX, minY, maxY });
    }

    public void SetMaskRendererActive(bool value)
    {
        orig.SetMaskRendererActive(value);
    }

    public void ChangeMappingAxis(Mask.MappingAxis currMaskMappingWorldAxis, Mask.MappingAxis prevMaskMappingWorldAxis,
        bool currInvertAxis)
    {
        CallMethod(new object[] { currMaskMappingWorldAxis, prevMaskMappingWorldAxis, currInvertAxis });
    }
}