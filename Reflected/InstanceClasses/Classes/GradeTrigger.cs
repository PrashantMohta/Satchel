namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GradeTrigger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GradeTriggerR : InstanceClassWrapper<GradeTrigger>
{
    public GradeTriggerR(GradeTrigger _orig) : base(_orig)
    {
    }

    public GradeMarker gradeMarker
    {
        get => orig.gradeMarker;
        set => orig.gradeMarker = value;
    }

    public bool instantActivate
    {
        get => orig.instantActivate;
        set => orig.instantActivate = value;
    }

    public float easeTime
    {
        get => orig.easeTime;
        set => orig.easeTime = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D triggerObject)
    {
        CallMethod(new object[] { triggerObject });
    }

    public void OnTriggerExit2D(Collider2D triggerObject)
    {
        CallMethod(new object[] { triggerObject });
    }
}