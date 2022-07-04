namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UIBlendMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIBlendModeR:InstanceClassWrapper<GUIBlendModes.UIBlendMode>
{
public UIBlendModeR(GUIBlendModes.UIBlendMode _orig) : base(_orig) {}
public GUIBlendModes.BlendMode editorBlendMode
{
get => GetField<GUIBlendModes.BlendMode>();
set => SetField(value);
}

public GUIBlendModes.BlendMode blendMode
{
get => GetField<GUIBlendModes.BlendMode>();
set => SetField(value);
}

public bool editorShaderOptimization
{
get => GetField<bool>();
set => SetField(value);
}

public bool shaderOptimization
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.UI.MaskableGraphic source
{
get => GetField<UnityEngine.UI.MaskableGraphic>();
set => SetField(value);
}

public bool isDisabled
{
get => GetField<bool>();
set => SetField(value);
}

public GUIBlendModes.BlendMode BlendMode
{
get => orig.BlendMode;
set => orig.BlendMode = value;
}

public bool ShaderOptimization
{
get => orig.ShaderOptimization;
set => orig.ShaderOptimization = value;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void SetBlendMode (GUIBlendModes.BlendMode blendMode, bool shaderOptimization = false) =>
orig.SetBlendMode(blendMode, shaderOptimization);

public void SyncEditor () =>
orig.SyncEditor();

}
}
