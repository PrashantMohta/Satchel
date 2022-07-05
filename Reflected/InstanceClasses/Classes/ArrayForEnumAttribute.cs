namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayForEnumAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayForEnumAttributeR : InstanceClassWrapper<ArrayForEnumAttribute>
{
    public ArrayForEnumAttributeR(ArrayForEnumAttribute _orig) : base(_orig)
    {
    }

    public Type EnumType
    {
        get => orig.EnumType;
        set => SetField(value);
    }

    public int EnumLength
    {
        get => orig.EnumLength;
        set => SetField(value);
    }

    public bool IsValid => orig.IsValid;

    public int order
    {
        get => orig.order;
        set => orig.order = value;
    }

    public object TypeId => orig.TypeId;

    public void EnsureArraySize<T>(ref T[] array, Type enumType)
    {
        ArrayForEnumAttribute.EnsureArraySize(ref array, enumType);
    }
}