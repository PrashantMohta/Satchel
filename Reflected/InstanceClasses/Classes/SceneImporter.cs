namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneImporter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneImporterR : InstanceClassWrapper<SceneImporter>
{
    public SceneImporterR(SceneImporter _orig) : base(_orig)
    {
    }

    public string xml_folder
    {
        get => orig.xml_folder;
        set => orig.xml_folder = value;
    }

    public string prefabs_folder
    {
        get => orig.prefabs_folder;
        set => orig.prefabs_folder = value;
    }

    public string xml_doc_filename
    {
        get => orig.xml_doc_filename;
        set => orig.xml_doc_filename = value;
    }

    public string level_name
    {
        get => orig.level_name;
        set => orig.level_name = value;
    }

    public int tile_size
    {
        get => orig.tile_size;
        set => orig.tile_size = value;
    }

    public int scene_width
    {
        get => orig.scene_width;
        set => orig.scene_width = value;
    }

    public int scene_height
    {
        get => orig.scene_height;
        set => orig.scene_height = value;
    }

    public int layer_count
    {
        get => orig.layer_count;
        set => orig.layer_count = value;
    }

    public GameObject placeholder_prefab
    {
        get => orig.placeholder_prefab;
        set => orig.placeholder_prefab = value;
    }

    public int importMode
    {
        get => orig.importMode;
        set => orig.importMode = value;
    }

    public bool lookForPrefabsFirst
    {
        get => orig.lookForPrefabsFirst;
        set => orig.lookForPrefabsFirst = value;
    }

    public bool debug_output
    {
        get => orig.debug_output;
        set => orig.debug_output = value;
    }
}