namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LineOfSightDetector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LineOfSightDetectorR : InstanceClassWrapper<LineOfSightDetector>
{
    public LineOfSightDetectorR(LineOfSightDetector _orig) : base(_orig)
    {
    }

    public AlertRange[] alertRanges
    {
        get => GetField<AlertRange[]>();
        set => SetField(value);
    }

    public bool canSeeHero
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool CanSeeHero => orig.CanSeeHero;


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}