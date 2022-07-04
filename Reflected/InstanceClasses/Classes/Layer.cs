namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Layer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LayerR:InstanceClassWrapper<tk2dRuntime.TileMap.Layer>
{
public LayerR(tk2dRuntime.TileMap.Layer _orig) : base(_orig) {}
public int hash
{
get => orig.hash;
set => orig.hash = value;
}

public tk2dRuntime.TileMap.SpriteChannel spriteChannel
{
get => orig.spriteChannel;
set => orig.spriteChannel = value;
}

public int tileMask
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int flagMask
{
get => GetFieldStatic<int>();
set => SetField(value);
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

public int numColumns
{
get => orig.numColumns;
set => orig.numColumns = value;
}

public int numRows
{
get => orig.numRows;
set => orig.numRows = value;
}

public int divX
{
get => orig.divX;
set => orig.divX = value;
}

public int divY
{
get => orig.divY;
set => orig.divY = value;
}

public UnityEngine.GameObject gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public bool IsEmpty
{
get => orig.IsEmpty;
}

public int NumActiveChunks
{
get => orig.NumActiveChunks;
}

public void Init (int hash, int width, int height, int divX, int divY) =>
orig.Init(hash, width, height, divX, divY);

public void Create () =>
orig.Create();

public System.Int32[] GetChunkData (int x, int y) =>
orig.GetChunkData(x, y);

public tk2dRuntime.TileMap.SpriteChunk GetChunk (int x, int y) =>
orig.GetChunk(x, y);

public tk2dRuntime.TileMap.SpriteChunk FindChunkAndCoordinate (int x, int y, int offset) =>
CallMethod<tk2dRuntime.TileMap.SpriteChunk>(new object[] {x, y, offset});

public bool GetRawTileValue (int x, int y, int value) =>
CallMethod<bool>(new object[] {x, y, value});

public void SetRawTileValue (int x, int y, int value) =>
CallMethod(new object[] {x, y, value});

public void DestroyGameData (tk2dTileMap tilemap) =>
orig.DestroyGameData(tilemap);

public int GetTile (int x, int y) =>
orig.GetTile(x, y);

public tk2dTileFlags GetTileFlags (int x, int y) =>
orig.GetTileFlags(x, y);

public int GetRawTile (int x, int y) =>
orig.GetRawTile(x, y);

public void SetTile (int x, int y, int tile) =>
orig.SetTile(x, y, tile);

public void SetTileFlags (int x, int y, tk2dTileFlags flags) =>
orig.SetTileFlags(x, y, flags);

public void ClearTile (int x, int y) =>
orig.ClearTile(x, y);

public void SetRawTile (int x, int y, int rawTile) =>
orig.SetRawTile(x, y, rawTile);

public void CreateChunk (tk2dRuntime.TileMap.SpriteChunk chunk) =>
CallMethod(new object[] {chunk});

public void Optimize (tk2dRuntime.TileMap.SpriteChunk chunk) =>
CallMethod(new object[] {chunk});

public void Optimize () =>
orig.Optimize();

public void OptimizeIncremental () =>
orig.OptimizeIncremental();

public void ClearDirtyFlag () =>
orig.ClearDirtyFlag();

}
}
