namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ConveyorMovement allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConveyorMovementR : InstanceClassWrapper<ConveyorMovement>
{
    public ConveyorMovementR(ConveyorMovement _orig) : base(_orig)
    {
    }

    public float xSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float ySpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool onConveyor
    {
        get => orig.onConveyor;
        set => orig.onConveyor = value;
    }


    public void OnEnable()
    {
        orig.OnEnable();
    }

    public void StartConveyorMove(float c_xSpeed, float c_ySpeed)
    {
        orig.StartConveyorMove(c_xSpeed, c_ySpeed);
    }

    public void StopConveyorMove()
    {
        orig.StopConveyorMove();
    }

    public void LateUpdate()
    {
        CallMethod();
    }
}