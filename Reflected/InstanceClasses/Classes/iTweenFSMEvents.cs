namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of iTweenFSMEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenFSMEventsR : InstanceClassWrapper<iTweenFSMEvents>
{
    public iTweenFSMEventsR(iTweenFSMEvents _orig) : base(_orig)
    {
    }

    public int itweenIDCount
    {
        get => iTweenFSMEvents.itweenIDCount;
        set => iTweenFSMEvents.itweenIDCount = value;
    }

    public int itweenID
    {
        get => orig.itweenID;
        set => orig.itweenID = value;
    }

    public iTweenFsmAction itweenFSMAction
    {
        get => orig.itweenFSMAction;
        set => orig.itweenFSMAction = value;
    }

    public bool donotfinish
    {
        get => orig.donotfinish;
        set => orig.donotfinish = value;
    }

    public bool islooping
    {
        get => orig.islooping;
        set => orig.islooping = value;
    }


    public void iTweenOnStart(int aniTweenID)
    {
        CallMethod(new object[] { aniTweenID });
    }

    public void iTweenOnComplete(int aniTweenID)
    {
        CallMethod(new object[] { aniTweenID });
    }
}