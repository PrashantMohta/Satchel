namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CharmItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmItemR : InstanceClassWrapper<CharmItem>
{
    public CharmItemR(CharmItem _orig) : base(_orig)
    {
    }

    public int listNumber
    {
        get => orig.listNumber;
        set => orig.listNumber = value;
    }


    public int GetListNumber()
    {
        return orig.GetListNumber();
    }

    public void SetListNumber(int newNumber)
    {
        orig.SetListNumber(newNumber);
    }
}