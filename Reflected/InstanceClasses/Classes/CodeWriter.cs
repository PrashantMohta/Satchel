namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CodeWriter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CodeWriterR:InstanceClassWrapper<InControl.Internal.CodeWriter>
{
public CodeWriterR(InControl.Internal.CodeWriter _orig) : base(_orig) {}
public System.Char newLine
{
get => GetFieldStatic<System.Char>();
set => SetField(value);
}

public int indent
{
get => GetField<int>();
set => SetField(value);
}

public System.Text.StringBuilder stringBuilder
{
get => GetField<System.Text.StringBuilder>();
set => SetField(value);
}

public void IncreaseIndent () =>
orig.IncreaseIndent();

public void DecreaseIndent () =>
orig.DecreaseIndent();

public void Append (string code) =>
orig.Append(code);

public void Append (bool trim, string code) =>
orig.Append(trim, code);

public void AppendLine (string code) =>
orig.AppendLine(code);

public void AppendLine (int count) =>
orig.AppendLine(count);

public void AppendFormat (string format, System.Object[] args) =>
orig.AppendFormat(format, args);

public void AppendLineFormat (string format, System.Object[] args) =>
orig.AppendLineFormat(format, args);

public string ToString () =>
orig.ToString();

}
}
