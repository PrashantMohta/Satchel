namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Bullet allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BulletR : InstanceClassWrapper<Bullet>
{
    public BulletR(Bullet _orig) : base(_orig)
    {
    }

    public Explosion explosionPrefab
    {
        get => orig.explosionPrefab;
        set => orig.explosionPrefab = value;
    }

    public float shootDistance
    {
        get => orig.shootDistance;
        set => orig.shootDistance = value;
    }

    public float shootSpeed
    {
        get => orig.shootSpeed;
        set => orig.shootSpeed = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator Shoot()
    {
        return CallMethod<IEnumerator>();
    }
}