namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Probability allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ProbabilityR : InstanceClassWrapper<Probability>
{
    public ProbabilityR(Probability _orig) : base(_orig)
    {
    }

    public GameObject GetRandomGameObjectByProbability(Probability.ProbabilityGameObject[] array)
    {
        return Probability.GetRandomGameObjectByProbability(array);
    }
}