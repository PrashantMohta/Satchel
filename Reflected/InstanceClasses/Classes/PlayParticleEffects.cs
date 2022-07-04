namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayParticleEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayParticleEffectsR:InstanceClassWrapper<PlayParticleEffects>
{
public PlayParticleEffectsR(PlayParticleEffects _orig) : base(_orig) {}
public UnityEngine.ParticleSystem[] particleEffects
{
get => orig.particleEffects;
set => orig.particleEffects = value;
}



public void PlayParticleSystems () =>
orig.PlayParticleSystems();

}
}
