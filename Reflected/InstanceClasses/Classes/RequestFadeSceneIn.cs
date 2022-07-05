namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RequestFadeSceneIn allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RequestFadeSceneInR : InstanceClassWrapper<RequestFadeSceneIn>
{
    public RequestFadeSceneInR(RequestFadeSceneIn _orig) : base(_orig)
    {
    }

    public float waitBeforeFade
    {
        get => orig.waitBeforeFade;
        set => orig.waitBeforeFade = value;
    }

    public CameraFadeInType fadeInSpeed
    {
        get => orig.fadeInSpeed;
        set => orig.fadeInSpeed = value;
    }


    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }
}