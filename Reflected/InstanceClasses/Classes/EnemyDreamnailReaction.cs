namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyDreamnailReaction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyDreamnailReactionR:InstanceClassWrapper<EnemyDreamnailReaction>
{
public EnemyDreamnailReactionR(EnemyDreamnailReaction _orig) : base(_orig) {}
public int RegularMPGain
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int BoostedMPGain
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public float AttackMagnitude
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float CooldownDuration
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public int convoAmount
{
get => GetField<int>();
set => SetField(value);
}

public string convoTitle
{
get => GetField<string>();
set => SetField(value);
}

public bool startSuppressed
{
get => GetField<bool>();
set => SetField(value);
}

public bool noSoul
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.GameObject dreamImpactPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool allowUseChildColliders
{
get => orig.allowUseChildColliders;
set => orig.allowUseChildColliders = value;
}

public float cooldownTimeRemaining
{
get => GetField<float>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Start () =>
CallMethod();

public void RecieveDreamImpact () =>
orig.RecieveDreamImpact();

public void MakeReady () =>
orig.MakeReady();

public void SetConvoTitle (string title) =>
orig.SetConvoTitle(title);

public void ShowConvo () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
