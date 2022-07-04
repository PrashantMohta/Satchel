namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayForEnumAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayForEnumAttributeR:InstanceClassWrapper<ArrayForEnumAttribute>
{
public ArrayForEnumAttributeR(ArrayForEnumAttribute _orig) : base(_orig) {}
public System.Type EnumType
{
get => orig.EnumType;
set => SetField(value);
}

public int EnumLength
{
get => orig.EnumLength;
set => SetField(value);
}

public bool IsValid
{
get => orig.IsValid;
}

public int order
{
get => orig.order;
set => orig.order = value;
}

public System.Object TypeId
{
get => orig.TypeId;
}

public void EnsureArraySize<T>(ref T[] array, System.Type enumType) =>
ArrayForEnumAttribute.EnsureArraySize<T>(ref array, enumType);

}
}
