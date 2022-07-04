using Modding.Menu.Components;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AutoSelector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoSelectorR : InstanceClassWrapper<AutoSelector>
{
    public AutoSelectorR(AutoSelector _orig) : base(_orig)
    {
    }

    public Selectable Start
    {
        get => orig.Start;
        set => orig.Start = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public IEnumerator SelectDelayed(Selectable selectable)
    {
        return CallMethod<IEnumerator>(new object[] { selectable });
    }
}