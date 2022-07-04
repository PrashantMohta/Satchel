using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TestInputManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TestInputManagerR : InstanceClassWrapper<TestInputManager>
{
    public TestInputManagerR(TestInputManager _orig) : base(_orig)
    {
    }

    public Font font
    {
        get => orig.font;
        set => orig.font = value;
    }

    public GUIStyle style
    {
        get => GetField<GUIStyle>();
        set => SetField(value);
    }

    public List<LogMessage> logMessages
    {
        get => GetField<List<LogMessage>>();
        set => SetField(value);
    }

    public bool isPaused
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void HandleInputUpdate(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void CheckForPauseButton()
    {
        CallMethod();
    }

    public void SetColor(Color color)
    {
        CallMethod(new object[] { color });
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void DrawUnityInputDebugger()
    {
        CallMethod();
    }

    public void OnDrawGizmos()
    {
        CallMethod();
    }
}