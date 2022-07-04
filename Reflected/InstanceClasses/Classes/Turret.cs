namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Turret allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TurretR:InstanceClassWrapper<Turret>
{
public TurretR(Turret _orig) : base(_orig) {}
public Bullet bulletPrefab
{
get => orig.bulletPrefab;
set => orig.bulletPrefab = value;
}

public UnityEngine.Transform gun
{
get => orig.gun;
set => orig.gun = value;
}

public UnityEngine.GameObject testPrefab
{
get => orig.testPrefab;
set => orig.testPrefab = value;
}



public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
