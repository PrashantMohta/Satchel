using System.Reflection;
using Modding.Patches;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShouldSerializeContractResolver allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShouldSerializeContractResolverR : InstanceClassWrapper<ShouldSerializeContractResolver>
{
    public ShouldSerializeContractResolverR(ShouldSerializeContractResolver _orig) : base(_orig)
    {
    }

    public ShouldSerializeContractResolver Instance
    {
        get => ShouldSerializeContractResolver.Instance;
        set => SetField(value);
    }

    public bool DynamicCodeGeneration => orig.DynamicCodeGeneration;

    public BindingFlags DefaultMembersSearchFlags
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

    public NamingStrategy NamingStrategy
    {
        get => orig.NamingStrategy;
        set => orig.NamingStrategy = value;
    }

    public JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        return CallMethod<JsonProperty>(new object[] { member, memberSerialization });
    }
}