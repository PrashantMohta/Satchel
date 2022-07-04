namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_TextInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_TextInfoR:InstanceClassWrapper<TMPro.TMP_TextInfo>
{
public TMP_TextInfoR(TMPro.TMP_TextInfo _orig) : base(_orig) {}
public UnityEngine.Vector2 k_InfinityVectorPositive
{
get => GetFieldStatic<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 k_InfinityVectorNegative
{
get => GetFieldStatic<UnityEngine.Vector2>();
set => SetField(value);
}

public TMPro.TMP_Text textComponent
{
get => orig.textComponent;
set => orig.textComponent = value;
}

public int characterCount
{
get => orig.characterCount;
set => orig.characterCount = value;
}

public int spriteCount
{
get => orig.spriteCount;
set => orig.spriteCount = value;
}

public int spaceCount
{
get => orig.spaceCount;
set => orig.spaceCount = value;
}

public int wordCount
{
get => orig.wordCount;
set => orig.wordCount = value;
}

public int linkCount
{
get => orig.linkCount;
set => orig.linkCount = value;
}

public int lineCount
{
get => orig.lineCount;
set => orig.lineCount = value;
}

public int pageCount
{
get => orig.pageCount;
set => orig.pageCount = value;
}

public int materialCount
{
get => orig.materialCount;
set => orig.materialCount = value;
}

public TMPro.TMP_CharacterInfo[] characterInfo
{
get => orig.characterInfo;
set => orig.characterInfo = value;
}

public TMPro.TMP_WordInfo[] wordInfo
{
get => orig.wordInfo;
set => orig.wordInfo = value;
}

public TMPro.TMP_LinkInfo[] linkInfo
{
get => orig.linkInfo;
set => orig.linkInfo = value;
}

public TMPro.TMP_LineInfo[] lineInfo
{
get => orig.lineInfo;
set => orig.lineInfo = value;
}

public TMPro.TMP_PageInfo[] pageInfo
{
get => orig.pageInfo;
set => orig.pageInfo = value;
}

public TMPro.TMP_MeshInfo[] meshInfo
{
get => orig.meshInfo;
set => orig.meshInfo = value;
}

public TMPro.TMP_MeshInfo[] m_CachedMeshInfo
{
get => GetField<TMPro.TMP_MeshInfo[]>();
set => SetField(value);
}

public void Clear () =>
orig.Clear();

public void ClearMeshInfo (bool updateMesh) =>
orig.ClearMeshInfo(updateMesh);

public void ClearAllMeshInfo () =>
orig.ClearAllMeshInfo();

public void ResetVertexLayout (bool isVolumetric) =>
orig.ResetVertexLayout(isVolumetric);

public void ClearUnusedVertices (TMPro.MaterialReference[] materials) =>
orig.ClearUnusedVertices(materials);

public void ClearLineInfo () =>
orig.ClearLineInfo();

public TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData () =>
orig.CopyMeshInfoVertexData();

public void Resize<T>(ref T[] array, int size) =>
TMPro.TMP_TextInfo.Resize<T>(ref array, size);

public void Resize<T> (ref T[] array, int size, bool isBlockAllocated) =>
TMPro.TMP_TextInfo.Resize<T>(ref array, size, isBlockAllocated);

}
}
