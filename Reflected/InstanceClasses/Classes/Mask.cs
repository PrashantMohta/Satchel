namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Mask allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MaskR:InstanceClassWrapper<ToJ.Mask>
{
public MaskR(ToJ.Mask _orig) : base(_orig) {}
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

public UnityEngine.Shader _maskedSpriteWorldCoordsShader
{
get => GetField<UnityEngine.Shader>();
set => SetField(value);
}

public UnityEngine.Shader _maskedUnlitWorldCoordsShader
{
get => GetField<UnityEngine.Shader>();
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



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public UnityEngine.Vector3 RotateVector (UnityEngine.Vector3 point, UnityEngine.Vector3 angles) =>
CallMethod<UnityEngine.Vector3>(new object[] {point, angles});

public void SetMaskMappingAxisInMaterials (ToJ.Mask.MappingAxis mappingAxis) =>
CallMethod(new object[] {mappingAxis});

public void SetMaskMappingAxisInMaterial (ToJ.Mask.MappingAxis mappingAxis, UnityEngine.Material material) =>
orig.SetMaskMappingAxisInMaterial(mappingAxis, material);

public void SetMaskFloatValueInMaterials (string variable, float value) =>
CallMethod(new object[] {variable, value});

public void SetMaskBoolValueInMaterials (string variable, bool value) =>
CallMethod(new object[] {variable, value});

public void SetMaskBoolValueInMaterial (string variable, bool value, UnityEngine.Material material) =>
orig.SetMaskBoolValueInMaterial(variable, value, material);

public void CreateAndAssignQuad (UnityEngine.Mesh mesh, float minX = -0.5f, float maxX = 0.5f, float minY = -0.5f, float maxY = 0.5f) =>
CallMethod(new object[] {mesh, minX, maxX, minY, maxY});

public void SetMaskRendererActive (bool value) =>
orig.SetMaskRendererActive(value);

public void ChangeMappingAxis (ToJ.Mask.MappingAxis currMaskMappingWorldAxis, ToJ.Mask.MappingAxis prevMaskMappingWorldAxis, bool currInvertAxis) =>
CallMethod(new object[] {currMaskMappingWorldAxis, prevMaskMappingWorldAxis, currInvertAxis});

}
}
