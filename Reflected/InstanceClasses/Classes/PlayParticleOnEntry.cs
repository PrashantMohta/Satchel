namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayParticleOnEntry allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayParticleOnEntryR:InstanceClassWrapper<PlayParticleOnEntry>
{
public PlayParticleOnEntryR(PlayParticleOnEntry _orig) : base(_orig) {}
public UnityEngine.ParticleSystem particle
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
