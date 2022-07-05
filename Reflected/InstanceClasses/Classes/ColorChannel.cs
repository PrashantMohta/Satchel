using tk2dRuntime.TileMap;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ColorChannel allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColorChannelR : InstanceClassWrapper<ColorChannel>
{
    public ColorChannelR(ColorChannel _orig) : base(_orig)
    {
    }

    public Color clearColor
    {
        get => orig.clearColor;
        set => orig.clearColor = value;
    }

    public ColorChunk[] chunks
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

    public bool IsEmpty => orig.IsEmpty;

    public int NumActiveChunks => orig.NumActiveChunks;

    public void Init(int width, int height, int divX, int divY)
    {
        orig.Init(width, height, divX, divY);
    }

    public ColorChunk FindChunkAndCoordinate(int x, int y, out int offset)
    {
        return orig.FindChunkAndCoordinate(x, y, out offset);
    }

    public Color GetColor(int x, int y)
    {
        return orig.GetColor(x, y);
    }

    public void InitChunk(ColorChunk chunk)
    {
        CallMethod(new object[] { chunk });
    }

    public void SetColor(int x, int y, Color color)
    {
        orig.SetColor(x, y, color);
    }

    public ColorChunk GetChunk(int x, int y)
    {
        return orig.GetChunk(x, y);
    }

    public ColorChunk GetChunk(int x, int y, bool init)
    {
        return orig.GetChunk(x, y, init);
    }

    public void ClearChunk(ColorChunk chunk)
    {
        orig.ClearChunk(chunk);
    }

    public void ClearDirtyFlag()
    {
        orig.ClearDirtyFlag();
    }

    public void Clear(Color color)
    {
        orig.Clear(color);
    }

    public void Delete()
    {
        orig.Delete();
    }

    public void Create()
    {
        orig.Create();
    }

    public void Optimize(ColorChunk chunk)
    {
        CallMethod(new object[] { chunk });
    }

    public void Optimize()
    {
        orig.Optimize();
    }
}