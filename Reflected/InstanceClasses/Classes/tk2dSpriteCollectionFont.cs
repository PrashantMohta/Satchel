namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionFont allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionFontR:InstanceClassWrapper<tk2dSpriteCollectionFont>
{
public tk2dSpriteCollectionFontR(tk2dSpriteCollectionFont _orig) : base(_orig) {}
public bool active
{
get => orig.active;
set => orig.active = value;
}

public UnityEngine.TextAsset bmFont
{
get => orig.bmFont;
set => orig.bmFont = value;
}

public UnityEngine.Texture2D texture
{
get => orig.texture;
set => orig.texture = value;
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

public tk2dFont editorData
{
get => orig.editorData;
set => orig.editorData = value;
}

public int materialId
{
get => orig.materialId;
set => orig.materialId = value;
}

public bool useGradient
{
get => orig.useGradient;
set => orig.useGradient = value;
}

public UnityEngine.Texture2D gradientTexture
{
get => orig.gradientTexture;
set => orig.gradientTexture = value;
}

public int gradientCount
{
get => orig.gradientCount;
set => orig.gradientCount = value;
}

public string Name
{
get => orig.Name;
}

public bool InUse
{
get => orig.InUse;
}

public void CopyFrom (tk2dSpriteCollectionFont src) =>
orig.CopyFrom(src);

}
}
