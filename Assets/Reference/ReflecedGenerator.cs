/// <summary>
/// Here you can find the code used to generate the files for the Satchel.Reflected classes
/// </summary>
public static class ReflectedGenerator
{
    public static void Start()
    {
        Type TargetType = typeof(HeroController);
        string ClassName = nameof(HeroController);

        Log("Starting Fields");
        var fields =
            TargetType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var field in fields)
        {
            string fieldType = removeSystemType(field.FieldType.ToString());
            StringBuilder fieldString = new StringBuilder();
            fieldString.AppendLine($"public static {fieldType} {field.Name}");
            fieldString.AppendLine("{");
            if (field.IsPublic)
            {
                fieldString.AppendLine($"get => {ClassName}.instance.{field.Name};");
                fieldString.AppendLine($"set => {ClassName}.instance.{field.Name} = value;");
            }
            else
            {
                fieldString.AppendLine(
                    $"get => ReflectionHelper.GetField<{ClassName}, {fieldType}>({ClassName}.instance, \"{field.Name}\");");
                fieldString.AppendLine(
                    $"set => ReflectionHelper.SetField({ClassName}.instance, \"{field.Name}\", value);");
            }

            fieldString.AppendLine("}");
            Log(fieldString);
        }
        Log("Starting Methods");
        var methods =
            TargetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            bool noreturn = false;

            var parameters = method.GetParameters();
            StringBuilder paramsInputString = new StringBuilder();
            StringBuilder paramsOutputString = new StringBuilder();
            if (parameters.Length == 0)
            {
                paramsInputString.Append("()");
                paramsOutputString.Append("");
            }
            else
            {
                paramsInputString.Append("(");
                if (!method.IsPublic) paramsOutputString.Append(", ");
                foreach (var param in parameters)
                {
                    paramsOutputString.Append($"{param.Name}");

                    paramsInputString.Append($"{removeSystemType(param.ParameterType.ToString())} {param.Name}");
                    if (param.HasDefaultValue)
                    {
                        paramsInputString.Append(param.DefaultValue == null
                            ? " = null"
                            : $" = {Convert.ChangeType(param.DefaultValue, param.ParameterType)}");
                    }

                    if (parameters.ToList().IndexOf(param) != parameters.Length - 1)
                    {
                        paramsInputString.Append(", ");
                        paramsOutputString.Append(", ");
                    }
                }

                paramsInputString.Append(")");
            }

            if (method.ReturnType.ToString() == "System.Void") noreturn = true;

            StringBuilder methodString = new StringBuilder();
            methodString.AppendLine(
                $"public static {removeSystemType(method.ReturnType.ToString())} {method.Name} {paramsInputString} =>");

            if (method.IsPublic)
            {
                methodString.AppendLine($"{ClassName}.instance.{method.Name}({paramsOutputString});");
            }
            else
            {
                methodString.AppendLine(noreturn
                    ? $"ReflectionHelper.CallMethod<{ClassName}>({ClassName}.instance, \"{method.Name}\"{paramsOutputString});"
                    : $"ReflectionHelper.CallMethod<{ClassName},{removeSystemType(method.ReturnType.ToString())}>({ClassName}.instance, \"{method.Name}\"{paramsOutputString});");
            }
            Log(methodString);
        }

        Log("Starting IL Hooks");
        foreach (var method in methods)
        {
            if (method.ReturnType.ToString() == "System.Collections.IEnumerator")
            {
                StringBuilder IEnumeratorILHook = new StringBuilder();
                IEnumeratorILHook.AppendLine($"public static event ILContext.Manipulator {method.Name}");
                IEnumeratorILHook.AppendLine("{");
                IEnumeratorILHook.AppendLine($"add => HookEndpointManager.Modify(typeof({ClassName}).GetMethod(\"{method.Name}\", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(), value);");
                IEnumeratorILHook.AppendLine($"remove => HookEndpointManager.Unmodify(typeof({ClassName}).GetMethod(\"{method.Name}\", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(), value);");
                IEnumeratorILHook.AppendLine("}");
                Log(IEnumeratorILHook);
            }
        }
        string removeSystemType(string type)
        {
            type = type switch
            {
                "System.Int32" => "int",
                "System.Boolean" => "bool",
                "System.Single" => "float",
                "System.String" => "string",
                "System.Void" => "void",
                _ => type
            };

            if (type.Contains("System.Nullable`1["))
            {
                type = type.Replace("System.Nullable`1[", "").Replace("]", "?");
            }
            else if (type.Contains("System.Collections.Generic.List`1["))
            {
                type = type.Replace("System.Collections.Generic.List`1[", "List<").Replace("]", ">");
            }
            return type;
        }
    }
}

}
