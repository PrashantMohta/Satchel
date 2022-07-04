namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUILayoutItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUILayoutItemR:InstanceClassWrapper<tk2dUILayoutItem>
{
public tk2dUILayoutItemR(tk2dUILayoutItem _orig) : base(_orig) {}
public tk2dBaseSprite sprite
{
get => orig.sprite;
set => orig.sprite = value;
}

public tk2dUIMask UIMask
{
get => orig.UIMask;
set => orig.UIMask = value;
}

public tk2dUILayout layout
{
get => orig.layout;
set => orig.layout = value;
}

public UnityEngine.GameObject gameObj
{
get => orig.gameObj;
set => orig.gameObj = value;
}

public bool snapLeft
{
get => orig.snapLeft;
set => orig.snapLeft = value;
}

public bool snapRight
{
get => orig.snapRight;
set => orig.snapRight = value;
}

public bool snapTop
{
get => orig.snapTop;
set => orig.snapTop = value;
}

public bool snapBottom
{
get => orig.snapBottom;
set => orig.snapBottom = value;
}

public bool fixedSize
{
get => orig.fixedSize;
set => orig.fixedSize = value;
}

public float fillPercentage
{
get => orig.fillPercentage;
set => orig.fillPercentage = value;
}

public float sizeProportion
{
get => orig.sizeProportion;
set => orig.sizeProportion = value;
}

public bool inLayoutList
{
get => orig.inLayoutList;
set => orig.inLayoutList = value;
}

public int childDepth
{
get => orig.childDepth;
set => orig.childDepth = value;
}

public UnityEngine.Vector3 oldPos
{
get => orig.oldPos;
set => orig.oldPos = value;
}

public tk2dUILayoutItem FixedSizeLayoutItem () =>
tk2dUILayoutItem.FixedSizeLayoutItem();

}
}
