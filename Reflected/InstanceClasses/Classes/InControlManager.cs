namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InControlManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InControlManagerR:InstanceClassWrapper<InControl.InControlManager>
{
public InControlManagerR(InControl.InControlManager _orig) : base(_orig) {}
public bool logDebugInfo
{
get => orig.logDebugInfo;
set => orig.logDebugInfo = value;
}

public bool invertYAxis
{
get => orig.invertYAxis;
set => orig.invertYAxis = value;
}

public bool useFixedUpdate
{
get => GetField<bool>();
set => SetField(value);
}

public bool dontDestroyOnLoad
{
get => orig.dontDestroyOnLoad;
set => orig.dontDestroyOnLoad = value;
}

public bool suspendInBackground
{
get => orig.suspendInBackground;
set => orig.suspendInBackground = value;
}

public InControl.InControlUpdateMode updateMode
{
get => orig.updateMode;
set => orig.updateMode = value;
}

public bool enableICade
{
get => orig.enableICade;
set => orig.enableICade = value;
}

public bool enableXInput
{
get => orig.enableXInput;
set => orig.enableXInput = value;
}

public bool xInputOverrideUpdateRate
{
get => orig.xInputOverrideUpdateRate;
set => orig.xInputOverrideUpdateRate = value;
}

public int xInputUpdateRate
{
get => orig.xInputUpdateRate;
set => orig.xInputUpdateRate = value;
}

public bool xInputOverrideBufferSize
{
get => orig.xInputOverrideBufferSize;
set => orig.xInputOverrideBufferSize = value;
}

public int xInputBufferSize
{
get => orig.xInputBufferSize;
set => orig.xInputBufferSize = value;
}

public bool enableNativeInput
{
get => orig.enableNativeInput;
set => orig.enableNativeInput = value;
}

public bool nativeInputEnableXInput
{
get => orig.nativeInputEnableXInput;
set => orig.nativeInputEnableXInput = value;
}

public bool nativeInputEnableMFi
{
get => orig.nativeInputEnableMFi;
set => orig.nativeInputEnableMFi = value;
}

public bool nativeInputPreventSleep
{
get => orig.nativeInputPreventSleep;
set => orig.nativeInputPreventSleep = value;
}

public bool nativeInputOverrideUpdateRate
{
get => orig.nativeInputOverrideUpdateRate;
set => orig.nativeInputOverrideUpdateRate = value;
}

public int nativeInputUpdateRate
{
get => orig.nativeInputUpdateRate;
set => orig.nativeInputUpdateRate = value;
}

public bool applicationHasQuit
{
get => GetField<bool>();
set => SetField(value);
}

public bool EnforceSingleton
{
get => GetProperty<bool>();
}

public bool IsTheSingleton
{
get => GetProperty<bool>();
}

public bool IsNotTheSingleton
{
get => GetProperty<bool>();
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Update () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void OnApplicationFocus (bool focusState) =>
CallMethod(new object[] {focusState});

public void OnApplicationPause (bool pauseState) =>
CallMethod(new object[] {pauseState});

public void OnApplicationQuit () =>
CallMethod();

public void OnSceneWasLoaded (UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode) =>
CallMethod(new object[] {scene, loadSceneMode});

public void LogMessage (InControl.LogMessage logMessage) =>
CallMethodStatic(new object[] {logMessage});

}
}
