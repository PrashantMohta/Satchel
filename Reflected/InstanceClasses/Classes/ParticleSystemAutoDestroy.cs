namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ParticleSystemAutoDestroy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ParticleSystemAutoDestroyR:InstanceClassWrapper<ParticleSystemAutoDestroy>
{
public ParticleSystemAutoDestroyR(ParticleSystemAutoDestroy _orig) : base(_orig) {}
public UnityEngine.ParticleSystem ps
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}



public void Start () =>
orig.Start();

public void Update () =>
orig.Update();

}
}
