namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerHashTableProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerHashTableProxyR:InstanceClassWrapper<PlayMakerHashTableProxy>
{
public PlayMakerHashTableProxyR(PlayMakerHashTableProxy _orig) : base(_orig) {}
public System.Collections.Hashtable _hashTable
{
get => orig._hashTable;
set => orig._hashTable = value;
}

public System.Collections.Hashtable _snapShot
{
get => GetField<System.Collections.Hashtable>();
set => SetField(value);
}

public bool showEvents
{
get => orig.showEvents;
set => orig.showEvents = value;
}

public bool showContent
{
get => orig.showContent;
set => orig.showContent = value;
}

public bool TextureElementSmall
{
get => orig.TextureElementSmall;
set => orig.TextureElementSmall = value;
}

public bool condensedView
{
get => orig.condensedView;
set => orig.condensedView = value;
}

public bool liveUpdate
{
get => orig.liveUpdate;
set => orig.liveUpdate = value;
}

public string referenceName
{
get => orig.referenceName;
set => orig.referenceName = value;
}

public bool enablePlayMakerEvents
{
get => orig.enablePlayMakerEvents;
set => orig.enablePlayMakerEvents = value;
}

public string addEvent
{
get => orig.addEvent;
set => orig.addEvent = value;
}

public string setEvent
{
get => orig.setEvent;
set => orig.setEvent = value;
}

public string removeEvent
{
get => orig.removeEvent;
set => orig.removeEvent = value;
}

public int contentPreviewStartIndex
{
get => orig.contentPreviewStartIndex;
set => orig.contentPreviewStartIndex = value;
}

public int contentPreviewMaxRows
{
get => orig.contentPreviewMaxRows;
set => orig.contentPreviewMaxRows = value;
}

public int preFillObjectTypeIndex
{
get => orig.preFillObjectTypeIndex;
set => orig.preFillObjectTypeIndex = value;
}

public int preFillCount
{
get => orig.preFillCount;
set => orig.preFillCount = value;
}

public System.Collections.Generic.List<System.String> preFillKeyList
{
get => orig.preFillKeyList;
set => orig.preFillKeyList = value;
}

public System.Collections.Generic.List<System.Boolean> preFillBoolList
{
get => orig.preFillBoolList;
set => orig.preFillBoolList = value;
}

public System.Collections.Generic.List<UnityEngine.Color> preFillColorList
{
get => orig.preFillColorList;
set => orig.preFillColorList = value;
}

public System.Collections.Generic.List<System.Single> preFillFloatList
{
get => orig.preFillFloatList;
set => orig.preFillFloatList = value;
}

public System.Collections.Generic.List<UnityEngine.GameObject> preFillGameObjectList
{
get => orig.preFillGameObjectList;
set => orig.preFillGameObjectList = value;
}

public System.Collections.Generic.List<System.Int32> preFillIntList
{
get => orig.preFillIntList;
set => orig.preFillIntList = value;
}

public System.Collections.Generic.List<UnityEngine.Material> preFillMaterialList
{
get => orig.preFillMaterialList;
set => orig.preFillMaterialList = value;
}

public System.Collections.Generic.List<UnityEngine.Object> preFillObjectList
{
get => orig.preFillObjectList;
set => orig.preFillObjectList = value;
}

public System.Collections.Generic.List<UnityEngine.Quaternion> preFillQuaternionList
{
get => orig.preFillQuaternionList;
set => orig.preFillQuaternionList = value;
}

public System.Collections.Generic.List<UnityEngine.Rect> preFillRectList
{
get => orig.preFillRectList;
set => orig.preFillRectList = value;
}

public System.Collections.Generic.List<System.String> preFillStringList
{
get => orig.preFillStringList;
set => orig.preFillStringList = value;
}

public System.Collections.Generic.List<UnityEngine.Texture2D> preFillTextureList
{
get => orig.preFillTextureList;
set => orig.preFillTextureList = value;
}

public System.Collections.Generic.List<UnityEngine.Vector2> preFillVector2List
{
get => orig.preFillVector2List;
set => orig.preFillVector2List = value;
}

public System.Collections.Generic.List<UnityEngine.Vector3> preFillVector3List
{
get => orig.preFillVector3List;
set => orig.preFillVector3List = value;
}

public System.Collections.Generic.List<UnityEngine.AudioClip> preFillAudioClipList
{
get => orig.preFillAudioClipList;
set => orig.preFillAudioClipList = value;
}

public System.Collections.Hashtable hashTable
{
get => orig.hashTable;
}



public void Awake () =>
orig.Awake();

public bool isCollectionDefined () =>
orig.isCollectionDefined();

public void TakeSnapShot () =>
orig.TakeSnapShot();

public void RevertToSnapShot () =>
orig.RevertToSnapShot();

public void InspectorEdit (int index) =>
orig.InspectorEdit(index);

public void PreFillHashTable () =>
CallMethod();

}
}
