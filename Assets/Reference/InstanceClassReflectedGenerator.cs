/// <summary>
/// Here you can find the code used to generate the files for the Satchel.Reflected classes
/// </summary>
public static class SingletonClassReflectedGenerator
{
    
        public void CreateForInstanceClass()
        {
            Type TargetType = typeof(HealthManager);
            string ClassName = nameof(HealthManager);
            Log($"public class {ClassName}R:InstanceClassWrapper<{ClassName}>");
            Log("{");
            Log($"public {ClassName}R({ClassName} _orig) : base(_orig) " + @"{}");

            var fields =
                TargetType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                string fieldType = removeSystemType(field.FieldType.ToString());
                StringBuilder fieldString = new StringBuilder();
                fieldString.AppendLine($"public {fieldType} {field.Name}");
                fieldString.AppendLine("{");
                if (field.IsPublic)
                {
                    fieldString.AppendLine($"get => orig.{field.Name};");
                    fieldString.AppendLine($"set => orig.{field.Name} = value;");
                }
                else
                {
                    fieldString.AppendLine(
                        $"get => GetField<{fieldType}>();");
                    fieldString.AppendLine($"set => SetField(value);");
                }

                fieldString.AppendLine("}");
                Log(fieldString);
            }

            var properties =
                TargetType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var property in properties)
            {
                string propertyType = removeSystemType(property.PropertyType.ToString());
                StringBuilder propertyString = new StringBuilder();
                propertyString.AppendLine($"public {propertyType} {property.Name}");
                propertyString.AppendLine("{");
                if (property.CanRead)
                {
                    if (property.GetMethod.IsPublic)
                    {
                        propertyString.AppendLine($"get => orig.{property.Name};");
                    }
                    else
                    {
                        propertyString.AppendLine(
                            $"get => GetProperty<{propertyType}>();");
                    }
                }

                if (property.CanWrite)
                {
                    if (property.SetMethod.IsPublic)
                    {
                        propertyString.AppendLine($"set => orig.{property.Name} = value;");
                    }
                    else
                    {
                        propertyString.AppendLine(
                            $"set => SetField(value);");
                    }
                }

                propertyString.AppendLine("}");
                Log(propertyString);
            }

            Log("Starting Methods");
            var methods =
                TargetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                      BindingFlags.DeclaredOnly);
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
                    if (!method.IsPublic) paramsOutputString.Append("new object[] {");
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
                    if (!method.IsPublic) paramsOutputString.Append("}");
                }

                if (method.ReturnType.ToString() == "System.Void") noreturn = true;

                StringBuilder methodString = new StringBuilder();
                methodString.AppendLine(
                    $"public {removeSystemType(method.ReturnType.ToString())} {method.Name} {paramsInputString} =>");

                if (method.IsPublic)
                {
                    methodString.AppendLine($"orig.{method.Name}({paramsOutputString});");
                }
                else
                {
                    methodString.AppendLine(noreturn
                        ? $"CallMethod({paramsOutputString});"
                        : $"CallMethod<{removeSystemType(method.ReturnType.ToString())}>({paramsOutputString});");
                }

                Log(methodString);
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
