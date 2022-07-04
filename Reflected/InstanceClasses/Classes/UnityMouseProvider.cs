using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnityMouseProvider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityMouseProviderR : InstanceClassWrapper<UnityMouseProvider>
{
    public UnityMouseProviderR(UnityMouseProvider _orig) : base(_orig)
    {
    }

    public string mouseXAxis
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public string mouseYAxis
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public bool[] lastButtonPressed
    {
        get => GetField<bool[]>();
        set => SetField(value);
    }

    public bool[] buttonPressed
    {
        get => GetField<bool[]>();
        set => SetField(value);
    }

    public Vector2 lastPosition
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 position
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 delta
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float scroll
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public void Setup()
    {
        orig.Setup();
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void Update()
    {
        orig.Update();
    }

    public bool SafeGetMouseButton(int button)
    {
        return CallMethodStatic<bool>(new object[] { button });
    }

    public void ClearState()
    {
        CallMethod();
    }

    public Vector2 GetPosition()
    {
        return orig.GetPosition();
    }

    public float GetDeltaX()
    {
        return orig.GetDeltaX();
    }

    public float GetDeltaY()
    {
        return orig.GetDeltaY();
    }

    public float GetDeltaScroll()
    {
        return orig.GetDeltaScroll();
    }

    public bool GetButtonIsPressed(Mouse control)
    {
        return orig.GetButtonIsPressed(control);
    }

    public bool GetButtonWasPressed(Mouse control)
    {
        return orig.GetButtonWasPressed(control);
    }

    public bool GetButtonWasReleased(Mouse control)
    {
        return orig.GetButtonWasReleased(control);
    }

    public bool HasMousePresent()
    {
        return orig.HasMousePresent();
    }
}