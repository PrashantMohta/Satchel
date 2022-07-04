/// <summary>
/// Here you can find the code used to generate the files for the Satchel.Reflected classes
/// </summary>
public static class SingletonClassReflectedGenerator
{
    
       private void CreateReflectedFiles()
        {
            Directory.CreateDirectory(Dir);
            
            Log(Dir);

            foreach (var type in typeof(HeroController).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract))
            {
                Log(type.Name);
                try
                {
                    output = new StreamWriter(Path.Combine(Dir, $"{type.Name}.txt"));
                    CreateForInstanceClass(type, type.Name);
                    output.Close();
                }
                catch (Exception e)
                {
                    Log($"Couldnt Create for {e}");
                }
                
            }
        }

        private StreamWriter output = null;

        public void CreateForInstanceClass(Type TargetType, string ClassName)
        {
            if (!TargetType.IsPublic) return;
            string fullName = TargetType.ToString().Replace("+", ".");
            output.WriteLine("namespace Satchel.Reflected");
            output.WriteLine("{");
            output.WriteLine("/// <summary>");
            output.WriteLine($"///     A class that contains all (public and private) fields and methods of {ClassName} allowing you to");
            output.WriteLine("///     easily get/set fields and call methods without dealing with reflection.");
            output.WriteLine("/// </summary>");
            output.WriteLine($"public class {ClassName}R:InstanceClassWrapper<{fullName}>");
            output.WriteLine("{");
            output.WriteLine($"public {ClassName}R({fullName} _orig) : base(_orig) " + @"{}");

            var fields =
                TargetType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fields)
            {
                if (ignoreField(field.Name)) continue;
                if (!field.FieldType.IsPublic) continue;
                string fieldType = removeSystemType(field.FieldType.ToString());
                StringBuilder fieldString = new StringBuilder();
                fieldString.AppendLine($"public {fieldType} {field.Name}");
                fieldString.AppendLine("{");
                if (field.IsPublic)
                {
                    if (!field.IsStatic)
                    {
                        fieldString.AppendLine($"get => orig.{field.Name};");
                        if (!field.IsInitOnly)
                        {
                            fieldString.AppendLine($"set => orig.{field.Name} = value;");
                        }
                        else
                        {
                            fieldString.AppendLine($"set => SetField(value);");
                        }
                    }
                    else
                    {
                        fieldString.AppendLine($"get => {fullName}.{field.Name};");
                        if (!field.IsInitOnly)
                        {
                            fieldString.AppendLine($"set => {fullName}.{field.Name} = value;");
                        }
                        else
                        {
                            fieldString.AppendLine($"set => SetField(value);");
                        }
                    }
                }
                else
                {
                    fieldString.AppendLine(
                        $"get => GetField" + (field.IsStatic ? "Static" : "" )+ $"<{fieldType}>();");
                    fieldString.AppendLine($"set => SetField(value);");
                }

                fieldString.AppendLine("}");
                output.WriteLine(fieldString);
            }

            var properties =
                TargetType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Static);
            foreach (var property in properties)
            {
                if(!property.GetMethod.ReturnType.IsPublic) continue;
                string propertyType = removeSystemType(property.PropertyType.ToString());
                StringBuilder propertyString = new StringBuilder();
                propertyString.AppendLine($"public {propertyType} {property.Name}");
                propertyString.AppendLine("{");
                if (property.CanRead)
                {
                    if (property.GetMethod.IsPublic)
                    {
                        if (!property.GetMethod.IsStatic)
                        {
                            propertyString.AppendLine($"get => orig.{property.Name};");
                        }
                        else
                        {
                            propertyString.AppendLine($"get => {fullName}.{property.Name};");
                        }
                    }
                    else
                    {
                        propertyString.AppendLine(
                            $"get => GetProperty" + (property.GetMethod.IsStatic ? "Static" : "" )+ $"<{propertyType}>();");
                    }
                }

                if (property.CanWrite)
                {
                    if (property.SetMethod.IsPublic)
                    {
                        if (!property.SetMethod.IsStatic)
                        {
                            propertyString.AppendLine($"set => orig.{property.Name} = value;");
                        }
                        else
                        {
                            propertyString.AppendLine($"set => {fullName}.{property.Name} = value;");
                        }
                    }
                    else
                    {
                        propertyString.AppendLine(
                            $"set => SetProperty" + (property.SetMethod.IsStatic ? "Static" : "" )+ "(value);");
                    }
                }

                propertyString.AppendLine("}");
                output.WriteLine(propertyString);
            }

            var methods =
                TargetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static |
                                      BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                if (ignoreMethod(method.Name)) continue;
                if (!method.ReturnType.IsPublic) continue;

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
                                : $" = {replaceDefaultParams(Convert.ChangeType(param.DefaultValue, param.ParameterType).ToString())}");
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
                    if (!method.IsStatic)
                    {
                        if (!method.IsGenericMethod)
                        {
                            methodString.AppendLine($"orig.{method.Name}({paramsOutputString});");
                        }
                        else
                        {
                            methodString.AppendLine($"orig.{method.Name}<T>({paramsOutputString});");
                        }
                    }
                    else
                    {
                        if (!method.IsGenericMethod)
                        {
                            methodString.AppendLine($"{fullName}.{method.Name}({paramsOutputString});");
                        }
                        else
                        {
                            methodString.AppendLine($"{fullName}.{method.Name}<T>({paramsOutputString});");
                        }
                    }
                }
                else
                {
                    methodString.AppendLine(noreturn
                        ? $"CallMethod" + (method.IsStatic ? "Static" : "" )+ $"({paramsOutputString});"
                        : $"CallMethod" + (method.IsStatic ? "Static" : "" )+ $"<{removeSystemType(method.ReturnType.ToString())}>({paramsOutputString});");
                }
                output.WriteLine(methodString);
            }
            output.WriteLine("}\n}");

            string removeSystemType(string type)
            {
                type = type.Replace("+", ".");
                type = type.Replace("&", "");
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
                else if (type.Contains("List`1["))
                {
                    type = type.Replace("List`1[", "List<").Replace("]", ">");
                }
                else if (type.Contains("HashSet`1["))
                {
                    type = type.Replace("HashSet`1[", "List<").Replace("]", ">");
                }
                else if (type.Contains("Tuple`1["))
                {
                    type = type.Replace("Tuple`1[", "List<").Replace("]", ">");
                }
                else if (type.Contains("Tuple`2["))
                {
                    type = type.Replace("Tuple`2[", "List<").Replace("]", ">");
                }
                else if (type.Contains("Dictionary<"))
                {
                    type = type.Replace("Dictionary<", "Dictionary<").Replace("]", ">");
                }
                else if (type.Contains("Action`1["))
                {
                    type = type.Replace("Action`1[", "Action<").Replace("]", ">");;
                }
                else if (type.Contains("Action`2["))
                {
                    type = type.Replace("Action`2[", "Action<").Replace("]", ">");;
                }
                else if (type.Contains("Action`3["))
                {
                    type = type.Replace("Action`3[", "Action<").Replace("]", ">");;
                }
                else if (type.Contains("Action`4["))
                {
                    type = type.Replace("Action`4[", "Action<").Replace("]", ">");;
                }
                else if (type.Contains("Action`5["))
                {
                    type = type.Replace("Action`5[", "Action<").Replace("]", ">");;
                }
                else if (type.Contains("Func`1["))
                {
                    type = type.Replace("Func`1[", "Func<").Replace("]", ">");;
                }
                else if (type.Contains("Func`2["))
                {
                    type = type.Replace("Func`2[", "Func<").Replace("]", ">");;
                }
                else if (type.Contains("Func`3["))
                {
                    type = type.Replace("Func`3[", "Func<").Replace("]", ">");;
                }
                else if (type.Contains("Func`4["))
                {
                    type = type.Replace("Func`4[", "Func<").Replace("]", ">");;
                }
                else if (type.Contains("Func`5["))
                {
                    type = type.Replace("Func`5[", "Func<").Replace("]", ">");;
                }
                else if (type.Contains("ReadOnlyCollection`1["))
                {
                    type = type.Replace("ReadOnlyCollection`1[", "ReadOnlyCollection<").Replace("]", ">");;
                }else if (type.Contains("TMP_XmlTagStack`1["))
                {
                    type = type.Replace("TMP_XmlTagStack`1[", "TMP_XmlTagStack<").Replace("]", ">");;
                }

                return type;
            }

            bool ignoreMethod(string name)
            {
                List<string> toIgnore = new List<string> { "add_", "remove_", "get_", "set_" };
                foreach (var ignore in toIgnore)
                {
                    if (name.StartsWith(ignore)) return true;
                }

                if (name.StartsWith("<")) return true;

                if (name.Contains("BeginInvoke")) return true;

                return false;
            }
            bool ignoreField(string name)
            {
                if (name.Contains("k__BackingField")) return true;
                return false;
            }

            string replaceDefaultParams(string param)
            {
                return param switch
                {
                    "True" => "true",
                    "False" => "false",
                    _ => param,
                };
            }
		}
}
