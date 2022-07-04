namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WalkArea allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WalkAreaR:InstanceClassWrapper<WalkArea>
{
public WalkAreaR(WalkArea _orig) : base(_orig) {}
public UnityEngine.Collider2D myCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public HeroController heroCtrl
{
get => GetField<HeroController>();
set => SetField(value);
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}

public bool verboseMode
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerStay2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerExit2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void Deactivate () =>
CallMethod();

public void OnDisable () =>
CallMethod();

}
}
