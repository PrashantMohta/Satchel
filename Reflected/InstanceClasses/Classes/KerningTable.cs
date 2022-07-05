using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KerningTable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KerningTableR : InstanceClassWrapper<KerningTable>
{
    public KerningTableR(KerningTable _orig) : base(_orig)
    {
    }

    public List<KerningPair> kerningPairs
    {
        get => orig.kerningPairs;
        set => orig.kerningPairs = value;
    }

    public void AddKerningPair()
    {
        orig.AddKerningPair();
    }

    public int AddKerningPair(int left, int right, float offset)
    {
        return orig.AddKerningPair(left, right, offset);
    }

    public void RemoveKerningPair(int left, int right)
    {
        orig.RemoveKerningPair(left, right);
    }

    public void RemoveKerningPair(int index)
    {
        orig.RemoveKerningPair(index);
    }

    public void SortKerningPairs()
    {
        orig.SortKerningPairs();
    }
}