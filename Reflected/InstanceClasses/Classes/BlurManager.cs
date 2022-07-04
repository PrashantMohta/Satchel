namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BlurManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BlurManagerR : InstanceClassWrapper<BlurManager>
{
    public BlurManagerR(BlurManager _orig) : base(_orig)
    {
    }

    public ShaderQualities appliedShaderQuality
    {
        get => GetField<ShaderQualities>();
        set => SetField(value);
    }

    public LightBlurredBackground lightBlurredBackground
    {
        get => GetField<LightBlurredBackground>();
        set => SetField(value);
    }

    public int baseHeight
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int largeConsoleHeight
    {
        get => GetField<int>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}