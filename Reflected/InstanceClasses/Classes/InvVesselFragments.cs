namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InvVesselFragments allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvVesselFragmentsR:InstanceClassWrapper<InvVesselFragments>
{
public InvVesselFragmentsR(InvVesselFragments _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer self
{
get => orig.self;
set => orig.self = value;
}

public UnityEngine.SpriteRenderer piece1
{
get => orig.piece1;
set => orig.piece1 = value;
}

public UnityEngine.SpriteRenderer piece2
{
get => orig.piece2;
set => orig.piece2 = value;
}

public UnityEngine.SpriteRenderer full
{
get => orig.full;
set => orig.full = value;
}

public UnityEngine.Sprite backboardSprite
{
get => orig.backboardSprite;
set => orig.backboardSprite = value;
}

public UnityEngine.Sprite singlePieceSprite
{
get => orig.singlePieceSprite;
set => orig.singlePieceSprite = value;
}

public UnityEngine.Sprite doublePieceSprite
{
get => orig.doublePieceSprite;
set => orig.doublePieceSprite = value;
}

public UnityEngine.Sprite fullSprite
{
get => orig.fullSprite;
set => orig.fullSprite = value;
}

public UnityEngine.Sprite emptySprite
{
get => orig.emptySprite;
set => orig.emptySprite = value;
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

}
}
