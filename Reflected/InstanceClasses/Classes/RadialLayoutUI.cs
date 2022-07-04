namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RadialLayoutUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RadialLayoutUIR : InstanceClassWrapper<RadialLayoutUI>
{
    public RadialLayoutUIR(RadialLayoutUI _orig) : base(_orig)
    {
    }

    public float scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public float oldScale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float radius
    {
        get => orig.radius;
        set => orig.radius = value;
    }

    public float oldRadius
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool elementOffset
    {
        get => orig.elementOffset;
        set => orig.elementOffset = value;
    }

    public bool oldElementOffset
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float splitX
    {
        get => orig.splitX;
        set => orig.splitX = value;
    }

    public float oldSplitX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float splitY
    {
        get => orig.splitY;
        set => orig.splitY = value;
    }

    public float oldSplitY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool counterClockwise
    {
        get => orig.counterClockwise;
        set => orig.counterClockwise = value;
    }

    public bool oldCounterClockwise
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasValueChanged
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Update()
    {
        CallMethod();
    }

    public void OnTransformChildrenChanged()
    {
        CallMethod();
    }

    public bool HasValueChanged()
    {
        return orig.HasValueChanged();
    }

    public void UpdateUI()
    {
        orig.UpdateUI();
    }
}