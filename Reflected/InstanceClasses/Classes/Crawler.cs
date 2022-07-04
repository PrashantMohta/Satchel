namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Crawler allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CrawlerR:InstanceClassWrapper<Crawler>
{
public CrawlerR(Crawler _orig) : base(_orig) {}
public float speed
{
get => orig.speed;
set => orig.speed = value;
}

public UnityEngine.Transform wallCheck
{
get => orig.wallCheck;
set => orig.wallCheck = value;
}

public UnityEngine.Transform groundCheck
{
get => orig.groundCheck;
set => orig.groundCheck = value;
}

public UnityEngine.Vector2 velocity
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public Recoil recoil
{
get => GetField<Recoil>();
set => SetField(value);
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator Walk () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Turn () =>
CallMethod<System.Collections.IEnumerator>();

public bool CheckRayLocal (UnityEngine.Vector2 originLocal, UnityEngine.Vector2 directionLocal, float length) =>
orig.CheckRayLocal(originLocal, directionLocal, length);

}
}
