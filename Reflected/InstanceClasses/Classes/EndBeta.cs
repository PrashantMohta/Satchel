namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EndBeta allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EndBetaR:InstanceClassWrapper<EndBeta>
{
public EndBetaR(EndBeta _orig) : base(_orig) {}
public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public bool isActive
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void Reactivate () =>
orig.Reactivate();

}
}
