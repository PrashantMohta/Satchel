using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetVersionNumber allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetVersionNumberR : InstanceClassWrapper<SetVersionNumber>
{
    public SetVersionNumberR(SetVersionNumber _orig) : base(_orig)
    {
    }

    public Text textUi
    {
        get => GetField<Text>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }
}