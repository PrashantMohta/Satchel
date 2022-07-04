namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TestInputManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TestInputManagerR:InstanceClassWrapper<InControl.TestInputManager>
{
public TestInputManagerR(InControl.TestInputManager _orig) : base(_orig) {}
public UnityEngine.Font font
{
get => orig.font;
set => orig.font = value;
}

public UnityEngine.GUIStyle style
{
get => GetField<UnityEngine.GUIStyle>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.LogMessage> logMessages
{
get => GetField<System.Collections.Generic.List<InControl.LogMessage>>();
set => SetField(value);
}

public bool isPaused
{
get => GetField<bool>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void HandleInputUpdate (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void CheckForPauseButton () =>
CallMethod();

public void SetColor (UnityEngine.Color color) =>
CallMethod(new object[] {color});

public void OnGUI () =>
CallMethod();

public void DrawUnityInputDebugger () =>
CallMethod();

public void OnDrawGizmos () =>
CallMethod();

}
}
