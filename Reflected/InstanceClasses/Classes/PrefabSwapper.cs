namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PrefabSwapper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PrefabSwapperR:InstanceClassWrapper<PrefabSwapper>
{
public PrefabSwapperR(PrefabSwapper _orig) : base(_orig) {}
public UnityEngine.GameObject objToSwapout
{
get => orig.objToSwapout;
set => orig.objToSwapout = value;
}

public System.String[] ignoreList
{
get => orig.ignoreList;
set => orig.ignoreList = value;
}

public bool preserveZDepth
{
get => orig.preserveZDepth;
set => orig.preserveZDepth = value;
}

public bool ignorePrefabs
{
get => orig.ignorePrefabs;
set => orig.ignorePrefabs = value;
}



public bool contains (string testGo) =>
orig.contains(testGo);

}
}
