namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HashTableSortKeysfromValues allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HashTableSortKeysfromValuesR : InstanceClassWrapper<HashTableSortKeysfromValues>
{
    public HashTableSortKeysfromValuesR(HashTableSortKeysfromValues _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}