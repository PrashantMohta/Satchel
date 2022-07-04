namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnityKeyboardProvider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityKeyboardProviderR:InstanceClassWrapper<InControl.UnityKeyboardProvider>
{
public UnityKeyboardProviderR(InControl.UnityKeyboardProvider _orig) : base(_orig) {}
public InControl.UnityKeyboardProvider.KeyMapping[] KeyMappings
{
get => InControl.UnityKeyboardProvider.KeyMappings;
set => SetField(value);
}

public void Setup () =>
orig.Setup();

public void Reset () =>
orig.Reset();

public void Update () =>
orig.Update();

public bool AnyKeyIsPressed () =>
orig.AnyKeyIsPressed();

public bool GetKeyIsPressed (InControl.Key control) =>
orig.GetKeyIsPressed(control);

public string GetNameForKey (InControl.Key control) =>
orig.GetNameForKey(control);

}
}
