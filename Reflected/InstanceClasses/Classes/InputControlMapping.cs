using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputControlMapping allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InputControlMappingR : InstanceClassWrapper<InputControlMapping>
{
    public InputControlMappingR(InputControlMapping _orig) : base(_orig)
    {
    }

    public string name
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool invert
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float scale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool raw
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool passive
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool ignoreInitialZeroValue
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float sensitivity
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float lowerDeadZone
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float upperDeadZone
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public InputControlSource source
    {
        get => GetField<InputControlSource>();
        set => SetField(value);
    }

    public InputControlType target
    {
        get => GetField<InputControlType>();
        set => SetField(value);
    }

    public InputRangeType sourceRange
    {
        get => GetField<InputRangeType>();
        set => SetField(value);
    }

    public InputRangeType targetRange
    {
        get => GetField<InputRangeType>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public bool Invert
    {
        get => orig.Invert;
        set => orig.Invert = value;
    }

    public float Scale
    {
        get => orig.Scale;
        set => orig.Scale = value;
    }

    public bool Raw
    {
        get => orig.Raw;
        set => orig.Raw = value;
    }

    public bool Passive
    {
        get => orig.Passive;
        set => orig.Passive = value;
    }

    public bool IgnoreInitialZeroValue
    {
        get => orig.IgnoreInitialZeroValue;
        set => orig.IgnoreInitialZeroValue = value;
    }

    public float Sensitivity
    {
        get => orig.Sensitivity;
        set => orig.Sensitivity = value;
    }

    public float LowerDeadZone
    {
        get => orig.LowerDeadZone;
        set => orig.LowerDeadZone = value;
    }

    public float UpperDeadZone
    {
        get => orig.UpperDeadZone;
        set => orig.UpperDeadZone = value;
    }

    public InputControlSource Source
    {
        get => orig.Source;
        set => orig.Source = value;
    }

    public InputControlType Target
    {
        get => orig.Target;
        set => orig.Target = value;
    }

    public InputRangeType SourceRange
    {
        get => orig.SourceRange;
        set => orig.SourceRange = value;
    }

    public InputRangeType TargetRange
    {
        get => orig.TargetRange;
        set => orig.TargetRange = value;
    }

    public float ApplyToValue(float value)
    {
        return orig.ApplyToValue(value);
    }
}