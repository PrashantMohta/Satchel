namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ConveyorMovementHero allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ConveyorMovementHeroR:InstanceClassWrapper<ConveyorMovementHero>
{
public ConveyorMovementHeroR(ConveyorMovementHero _orig) : base(_orig) {}
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
get => GetField<bool>();
set => SetField(value);
}

public bool gravityOff
{
get => orig.gravityOff;
set => orig.gravityOff = value;
}

public HeroController heroCon
{
get => GetField<HeroController>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void StartConveyorMove (float c_xSpeed, float c_ySpeed) =>
orig.StartConveyorMove(c_xSpeed, c_ySpeed);

public void StopConveyorMove () =>
orig.StopConveyorMove();

public void LateUpdate () =>
CallMethod();

}
}
