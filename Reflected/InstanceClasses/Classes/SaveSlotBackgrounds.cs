namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SaveSlotBackgrounds allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveSlotBackgroundsR : InstanceClassWrapper<SaveSlotBackgrounds>
{
    public SaveSlotBackgroundsR(SaveSlotBackgrounds _orig) : base(_orig)
    {
    }

    public AreaBackground[] areaBackgrounds
    {
        get => orig.areaBackgrounds;
        set => orig.areaBackgrounds = value;
    }


    public AreaBackground GetBackground(string areaName)
    {
        return orig.GetBackground(areaName);
    }

    public AreaBackground GetBackground(MapZone mapZone)
    {
        return orig.GetBackground(mapZone);
    }
}