namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StringEncrypt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StringEncryptR : InstanceClassWrapper<StringEncrypt>
{
    public StringEncryptR(StringEncrypt _orig) : base(_orig)
    {
    }

    public byte[] keyArray
    {
        get => GetFieldStatic<byte[]>();
        set => SetField(value);
    }

    public string EncryptData(string toEncrypt)
    {
        return StringEncrypt.EncryptData(toEncrypt);
    }

    public string DecryptData(string toDecrypt)
    {
        return StringEncrypt.DecryptData(toDecrypt);
    }
}