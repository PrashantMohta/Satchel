namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dFont allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dFontR:InstanceClassWrapper<tk2dFont>
{
public tk2dFontR(tk2dFont _orig) : base(_orig) {}
public UnityEngine.TextAsset bmFont
{
get => orig.bmFont;
set => orig.bmFont = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Texture texture
{
get => orig.texture;
set => orig.texture = value;
}

public UnityEngine.Texture2D gradientTexture
{
get => orig.gradientTexture;
set => orig.gradientTexture = value;
}

public bool dupeCaps
{
get => orig.dupeCaps;
set => orig.dupeCaps = value;
}

public bool flipTextureY
{
get => orig.flipTextureY;
set => orig.flipTextureY = value;
}

public bool proxyFont
{
get => orig.proxyFont;
set => orig.proxyFont = value;
}

public bool useTk2dCamera
{
get => GetField<bool>();
set => SetField(value);
}

public int targetHeight
{
get => GetField<int>();
set => SetField(value);
}

public float targetOrthoSize
{
get => GetField<float>();
set => SetField(value);
}

public tk2dSpriteCollectionSize sizeDef
{
get => orig.sizeDef;
set => orig.sizeDef = value;
}

public int gradientCount
{
get => orig.gradientCount;
set => orig.gradientCount = value;
}

public bool manageMaterial
{
get => orig.manageMaterial;
set => orig.manageMaterial = value;
}

public bool loadable
{
get => orig.loadable;
set => orig.loadable = value;
}

public int charPadX
{
get => orig.charPadX;
set => orig.charPadX = value;
}

public tk2dFontData data
{
get => orig.data;
set => orig.data = value;
}

public int CURRENT_VERSION
{
get => tk2dFont.CURRENT_VERSION;
set => tk2dFont.CURRENT_VERSION = value;
}

public int version
{
get => orig.version;
set => orig.version = value;
}



public void Upgrade () =>
orig.Upgrade();

}
}
