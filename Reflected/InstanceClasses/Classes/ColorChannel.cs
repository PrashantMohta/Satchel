namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ColorChannel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColorChannelR:InstanceClassWrapper<tk2dRuntime.TileMap.ColorChannel>
{
public ColorChannelR(tk2dRuntime.TileMap.ColorChannel _orig) : base(_orig) {}
public UnityEngine.Color clearColor
{
get => orig.clearColor;
set => orig.clearColor = value;
}

public tk2dRuntime.TileMap.ColorChunk[] chunks
{
get => orig.chunks;
set => orig.chunks = value;
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

public bool IsEmpty
{
get => orig.IsEmpty;
}

public int NumActiveChunks
{
get => orig.NumActiveChunks;
}

public void Init (int width, int height, int divX, int divY) =>
orig.Init(width, height, divX, divY);

public tk2dRuntime.TileMap.ColorChunk FindChunkAndCoordinate (int x, int y, out int offset) =>
orig.FindChunkAndCoordinate(x, y, out offset);

public UnityEngine.Color GetColor (int x, int y) =>
orig.GetColor(x, y);

public void InitChunk (tk2dRuntime.TileMap.ColorChunk chunk) =>
CallMethod(new object[] {chunk});

public void SetColor (int x, int y, UnityEngine.Color color) =>
orig.SetColor(x, y, color);

public tk2dRuntime.TileMap.ColorChunk GetChunk (int x, int y) =>
orig.GetChunk(x, y);

public tk2dRuntime.TileMap.ColorChunk GetChunk (int x, int y, bool init) =>
orig.GetChunk(x, y, init);

public void ClearChunk (tk2dRuntime.TileMap.ColorChunk chunk) =>
orig.ClearChunk(chunk);

public void ClearDirtyFlag () =>
orig.ClearDirtyFlag();

public void Clear (UnityEngine.Color color) =>
orig.Clear(color);

public void Delete () =>
orig.Delete();

public void Create () =>
orig.Create();

public void Optimize (tk2dRuntime.TileMap.ColorChunk chunk) =>
CallMethod(new object[] {chunk});

public void Optimize () =>
orig.Optimize();

}
}
