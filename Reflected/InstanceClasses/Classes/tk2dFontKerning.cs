namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dFontKerning allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dFontKerningR:InstanceClassWrapper<tk2dFontKerning>
{
public tk2dFontKerningR(tk2dFontKerning _orig) : base(_orig) {}
public int c0
{
get => orig.c0;
set => orig.c0 = value;
}

public int c1
{
get => orig.c1;
set => orig.c1 = value;
}

public float amount
{
get => orig.amount;
set => orig.amount = value;
}

}
}
