using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UnityKeyboardProvider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnityKeyboardProviderR : InstanceClassWrapper<UnityKeyboardProvider>
{
    public UnityKeyboardProviderR(UnityKeyboardProvider _orig) : base(_orig)
    {
    }

    public UnityKeyboardProvider.KeyMapping[] KeyMappings
    {
        get => UnityKeyboardProvider.KeyMappings;
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

    public bool AnyKeyIsPressed()
    {
        return orig.AnyKeyIsPressed();
    }

    public bool GetKeyIsPressed(Key control)
    {
        return orig.GetKeyIsPressed(control);
    }

    public string GetNameForKey(Key control)
    {
        return orig.GetNameForKey(control);
    }
}