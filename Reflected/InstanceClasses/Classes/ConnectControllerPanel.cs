namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConnectControllerPanel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConnectControllerPanelR : InstanceClassWrapper<ConnectControllerPanel>
{
    public ConnectControllerPanelR(ConnectControllerPanel _orig) : base(_orig)
    {
    }

    public CanvasGroup canvasGroup
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public float fadeRate
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateContent()
    {
        CallMethod();
    }
}