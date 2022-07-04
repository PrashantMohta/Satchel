namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dCameraResolutionOverride allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dCameraResolutionOverrideR:InstanceClassWrapper<tk2dCameraResolutionOverride>
{
public tk2dCameraResolutionOverrideR(tk2dCameraResolutionOverride _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public int width
{
get => orig.width;
set => orig.width = value;
}

public int height
{
get => orig.height;
set => orig.height = value;
}

public float aspectRatioNumerator
{
get => orig.aspectRatioNumerator;
set => orig.aspectRatioNumerator = value;
}

public float aspectRatioDenominator
{
get => orig.aspectRatioDenominator;
set => orig.aspectRatioDenominator = value;
}

public float scale
{
get => orig.scale;
set => orig.scale = value;
}

public UnityEngine.Vector2 offsetPixels
{
get => orig.offsetPixels;
set => orig.offsetPixels = value;
}

public tk2dCameraResolutionOverride DefaultOverride
{
get => tk2dCameraResolutionOverride.DefaultOverride;
}

public bool Match (int pixelWidth, int pixelHeight) =>
orig.Match(pixelWidth, pixelHeight);

public void Upgrade (int version) =>
orig.Upgrade(version);

}
}
