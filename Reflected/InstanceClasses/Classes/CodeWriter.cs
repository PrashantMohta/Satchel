using System.Text;
using InControl.Internal;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CodeWriter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CodeWriterR : InstanceClassWrapper<CodeWriter>
{
    public CodeWriterR(CodeWriter _orig) : base(_orig)
    {
    }

    public char newLine
    {
        get => GetFieldStatic<char>();
        set => SetField(value);
    }

    public int indent
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public StringBuilder stringBuilder
    {
        get => GetField<StringBuilder>();
        set => SetField(value);
    }

    public void IncreaseIndent()
    {
        orig.IncreaseIndent();
    }

    public void DecreaseIndent()
    {
        orig.DecreaseIndent();
    }

    public void Append(string code)
    {
        orig.Append(code);
    }

    public void Append(bool trim, string code)
    {
        orig.Append(trim, code);
    }

    public void AppendLine(string code)
    {
        orig.AppendLine(code);
    }

    public void AppendLine(int count)
    {
        orig.AppendLine(count);
    }

    public void AppendFormat(string format, object[] args)
    {
        orig.AppendFormat(format, args);
    }

    public void AppendLineFormat(string format, object[] args)
    {
        orig.AppendLineFormat(format, args);
    }

    public string ToString()
    {
        return orig.ToString();
    }
}