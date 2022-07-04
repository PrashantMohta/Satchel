namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LookAnimNPC allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LookAnimNPCR:InstanceClassWrapper<LookAnimNPC>
{
public LookAnimNPCR(LookAnimNPC _orig) : base(_orig) {}
public string leftAnim
{
get => orig.leftAnim;
set => orig.leftAnim = value;
}

public string rightAnim
{
get => orig.rightAnim;
set => orig.rightAnim = value;
}

public bool defaultLeft
{
get => orig.defaultLeft;
set => orig.defaultLeft = value;
}

public float centreOffset
{
get => orig.centreOffset;
set => orig.centreOffset = value;
}

public float limitZ
{
get => orig.limitZ;
set => orig.limitZ = value;
}

public TriggerEnterEvent enterDetector
{
get => orig.enterDetector;
set => orig.enterDetector = value;
}

public TriggerEnterEvent exitDetector
{
get => orig.exitDetector;
set => orig.exitDetector = value;
}

public UnityEngine.Transform target
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public float turnFinishTime
{
get => GetField<float>();
set => SetField(value);
}

public bool isTurning
{
get => GetField<bool>();
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

public void OnDrawGizmosSelected () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
