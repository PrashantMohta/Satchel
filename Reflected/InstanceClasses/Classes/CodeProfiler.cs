namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CodeProfiler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CodeProfilerR : InstanceClassWrapper<CodeProfiler>
{
    public CodeProfilerR(CodeProfiler _orig) : base(_orig)
    {
    }

    public float startTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float nextOutputTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int numFrames
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public string displayText
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Rect displayRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void Begin(string id)
    {
        CodeProfiler.Begin(id);
    }

    public void End(string id)
    {
        CodeProfiler.End(id);
    }

    public void Update()
    {
        CallMethod();
    }
}