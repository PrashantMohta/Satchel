using GUIBlendModes;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UIBlendMode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIBlendModeR : InstanceClassWrapper<UIBlendMode>
{
    public UIBlendModeR(UIBlendMode _orig) : base(_orig)
    {
    }

    public BlendMode editorBlendMode
    {
        get => GetField<BlendMode>();
        set => SetField(value);
    }

    public BlendMode blendMode
    {
        get => GetField<BlendMode>();
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

    public MaskableGraphic source
    {
        get => GetField<MaskableGraphic>();
        set => SetField(value);
    }

    public bool isDisabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public BlendMode BlendMode
    {
        get => orig.BlendMode;
        set => orig.BlendMode = value;
    }

    public bool ShaderOptimization
    {
        get => orig.ShaderOptimization;
        set => orig.ShaderOptimization = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void SetBlendMode(BlendMode blendMode, bool shaderOptimization = false)
    {
        orig.SetBlendMode(blendMode, shaderOptimization);
    }

    public void SyncEditor()
    {
        orig.SyncEditor();
    }
}