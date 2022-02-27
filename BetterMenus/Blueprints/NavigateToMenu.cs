namespace Satchel.BetterMenus
{
    public static partial class Blueprints{
         public static MenuButton NavigateToMenu(string name,string description,Func<MenuScreen> getScreen){
           return new MenuButton(
                name,
                description,
                (mb)=>{
                        UIManager.instance.UIGoToDynamicMenu(getScreen());
                    },
                proceed:true
            );
        }
    }
}