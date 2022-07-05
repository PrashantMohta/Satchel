using UnityEngine.Events;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PerBuildTypeOnEnableResponse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PerBuildTypeOnEnableResponseR : InstanceClassWrapper<PerBuildTypeOnEnableResponse>
{
    public PerBuildTypeOnEnableResponseR(PerBuildTypeOnEnableResponse _orig) : base(_orig)
    {
    }

    public BuildTypes[] buildTypes
    {
        get => GetField<BuildTypes[]>();
        set => SetField(value);
    }

    public UnityEvent OnIsBuildType
    {
        get => orig.OnIsBuildType;
        set => orig.OnIsBuildType = value;
    }


    public UnityEvent OnNotBuildType
    {
        get => orig.OnNotBuildType;
        set => orig.OnNotBuildType = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void DoEvent(bool value)
    {
        CallMethod(new object[] { value });
    }
}