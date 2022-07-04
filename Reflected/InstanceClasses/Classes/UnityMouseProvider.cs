namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnityMouseProvider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityMouseProviderR:InstanceClassWrapper<InControl.UnityMouseProvider>
{
public UnityMouseProviderR(InControl.UnityMouseProvider _orig) : base(_orig) {}
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

public System.Boolean[] lastButtonPressed
{
get => GetField<System.Boolean[]>();
set => SetField(value);
}

public System.Boolean[] buttonPressed
{
get => GetField<System.Boolean[]>();
set => SetField(value);
}

public UnityEngine.Vector2 lastPosition
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 position
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 delta
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float scroll
{
get => GetField<float>();
set => SetField(value);
}

public void Setup () =>
orig.Setup();

public void Reset () =>
orig.Reset();

public void Update () =>
orig.Update();

public bool SafeGetMouseButton (int button) =>
CallMethodStatic<bool>(new object[] {button});

public void ClearState () =>
CallMethod();

public UnityEngine.Vector2 GetPosition () =>
orig.GetPosition();

public float GetDeltaX () =>
orig.GetDeltaX();

public float GetDeltaY () =>
orig.GetDeltaY();

public float GetDeltaScroll () =>
orig.GetDeltaScroll();

public bool GetButtonIsPressed (InControl.Mouse control) =>
orig.GetButtonIsPressed(control);

public bool GetButtonWasPressed (InControl.Mouse control) =>
orig.GetButtonWasPressed(control);

public bool GetButtonWasReleased (InControl.Mouse control) =>
orig.GetButtonWasReleased(control);

public bool HasMousePresent () =>
orig.HasMousePresent();

}
}
