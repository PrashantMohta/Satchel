namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RandomScale allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomScaleR:InstanceClassWrapper<RandomScale>
{
public RandomScaleR(RandomScale _orig) : base(_orig) {}
public float minScale
{
get => orig.minScale;
set => orig.minScale = value;
}

public float maxScale
{
get => orig.maxScale;
set => orig.maxScale = value;
}

public bool scaleOnEnable
{
get => orig.scaleOnEnable;
set => orig.scaleOnEnable = value;
}

public bool didScale
{
get => GetField<bool>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void ApplyScale () =>
CallMethod();

}
}
