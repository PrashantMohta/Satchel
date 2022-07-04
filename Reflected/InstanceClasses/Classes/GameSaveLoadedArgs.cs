namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GameSaveLoadedArgs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameSaveLoadedArgsR:InstanceClassWrapper<Microsoft.Xbox.GameSaveLoadedArgs>
{
public GameSaveLoadedArgsR(Microsoft.Xbox.GameSaveLoadedArgs _orig) : base(_orig) {}
public System.Byte[] Data
{
get => orig.Data;
set => SetProperty(value);
}

}
}
