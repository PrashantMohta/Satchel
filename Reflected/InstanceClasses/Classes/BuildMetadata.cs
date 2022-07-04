namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BuildMetadata allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BuildMetadataR : InstanceClassWrapper<BuildMetadata>
{
    public BuildMetadataR(BuildMetadata _orig) : base(_orig)
    {
    }

    public string branchName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string revision
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public long commitTime
    {
        get => GetField<long>();
        set => SetField(value);
    }

    public string machineName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public long buildTime
    {
        get => GetField<long>();
        set => SetField(value);
    }

    public bool didLoad
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public BuildMetadata embedded
    {
        get => GetFieldStatic<BuildMetadata>();
        set => SetField(value);
    }

    public string EmbeddedFileName
    {
        get => BuildMetadata.EmbeddedFileName;
        set => SetField(value);
    }

    public string BranchName => orig.BranchName;

    public string Revision => orig.Revision;

    public DateTime CommitTime => orig.CommitTime;

    public string MachineName => orig.MachineName;

    public DateTime BuildTime => orig.BuildTime;

    public BuildMetadata Embedded => BuildMetadata.Embedded;

    public BuildMetadata Create(string branchName, string revision, DateTime commitTime, string machineName,
        DateTime buildTime)
    {
        return BuildMetadata.Create(branchName, revision, commitTime, machineName, buildTime);
    }
}