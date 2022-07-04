namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ParallaxSorter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ParallaxSorterR:InstanceClassWrapper<ParallaxSorter>
{
public ParallaxSorterR(ParallaxSorter _orig) : base(_orig) {}
public System.String[] sortingLayers
{
get => orig.sortingLayers;
set => orig.sortingLayers = value;
}

public System.Int32[] sortingLayerIDs
{
get => orig.sortingLayerIDs;
set => orig.sortingLayerIDs = value;
}

public System.Single[] layerDepths
{
get => orig.layerDepths;
set => orig.layerDepths = value;
}

public bool stripSortingLayers
{
get => orig.stripSortingLayers;
set => orig.stripSortingLayers = value;
}



public void Awake () =>
CallMethod();

}
}
