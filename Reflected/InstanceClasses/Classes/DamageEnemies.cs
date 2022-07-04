namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DamageEnemies allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DamageEnemiesR:InstanceClassWrapper<DamageEnemies>
{
public DamageEnemiesR(DamageEnemies _orig) : base(_orig) {}
public AttackTypes attackType
{
get => orig.attackType;
set => orig.attackType = value;
}

public bool circleDirection
{
get => orig.circleDirection;
set => orig.circleDirection = value;
}

public int damageDealt
{
get => orig.damageDealt;
set => orig.damageDealt = value;
}

public float direction
{
get => orig.direction;
set => orig.direction = value;
}

public bool ignoreInvuln
{
get => orig.ignoreInvuln;
set => orig.ignoreInvuln = value;
}

public float magnitudeMult
{
get => orig.magnitudeMult;
set => orig.magnitudeMult = value;
}

public bool moveDirection
{
get => orig.moveDirection;
set => orig.moveDirection = value;
}

public SpecialTypes specialType
{
get => orig.specialType;
set => orig.specialType = value;
}

public System.Collections.Generic.List<UnityEngine.Collider2D> enteredColliders
{
get => GetField<System.Collections.Generic.List<UnityEngine.Collider2D>>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnDisable () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void DoDamage (UnityEngine.GameObject target) =>
CallMethod(new object[] {target});

}
}
