namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShouldSerializeContractResolver allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShouldSerializeContractResolverR:InstanceClassWrapper<Modding.Patches.ShouldSerializeContractResolver>
{
public ShouldSerializeContractResolverR(Modding.Patches.ShouldSerializeContractResolver _orig) : base(_orig) {}
public Modding.Patches.ShouldSerializeContractResolver Instance
{
get => Modding.Patches.ShouldSerializeContractResolver.Instance;
set => SetField(value);
}

public bool DynamicCodeGeneration
{
get => orig.DynamicCodeGeneration;
}

public System.Reflection.BindingFlags DefaultMembersSearchFlags
{
get => orig.DefaultMembersSearchFlags;
set => orig.DefaultMembersSearchFlags = value;
}

public bool SerializeCompilerGeneratedMembers
{
get => orig.SerializeCompilerGeneratedMembers;
set => orig.SerializeCompilerGeneratedMembers = value;
}

public bool IgnoreSerializableInterface
{
get => orig.IgnoreSerializableInterface;
set => orig.IgnoreSerializableInterface = value;
}

public bool IgnoreSerializableAttribute
{
get => orig.IgnoreSerializableAttribute;
set => orig.IgnoreSerializableAttribute = value;
}

public bool IgnoreIsSpecifiedMembers
{
get => orig.IgnoreIsSpecifiedMembers;
set => orig.IgnoreIsSpecifiedMembers = value;
}

public bool IgnoreShouldSerializeMembers
{
get => orig.IgnoreShouldSerializeMembers;
set => orig.IgnoreShouldSerializeMembers = value;
}

public Newtonsoft.Json.Serialization.NamingStrategy NamingStrategy
{
get => orig.NamingStrategy;
set => orig.NamingStrategy = value;
}

public Newtonsoft.Json.Serialization.JsonProperty CreateProperty (System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization) =>
CallMethod<Newtonsoft.Json.Serialization.JsonProperty>(new object[] {member, memberSerialization});

}
}
