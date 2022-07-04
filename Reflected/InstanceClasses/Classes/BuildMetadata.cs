namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BuildMetadata allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BuildMetadataR:InstanceClassWrapper<BuildMetadata>
{
public BuildMetadataR(BuildMetadata _orig) : base(_orig) {}
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

public System.Int64 commitTime
{
get => GetField<System.Int64>();
set => SetField(value);
}

public string machineName
{
get => GetField<string>();
set => SetField(value);
}

public System.Int64 buildTime
{
get => GetField<System.Int64>();
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

public string BranchName
{
get => orig.BranchName;
}

public string Revision
{
get => orig.Revision;
}

public System.DateTime CommitTime
{
get => orig.CommitTime;
}

public string MachineName
{
get => orig.MachineName;
}

public System.DateTime BuildTime
{
get => orig.BuildTime;
}

public BuildMetadata Embedded
{
get => BuildMetadata.Embedded;
}

public BuildMetadata Create (string branchName, string revision, System.DateTime commitTime, string machineName, System.DateTime buildTime) =>
BuildMetadata.Create(branchName, revision, commitTime, machineName, buildTime);

}
}
