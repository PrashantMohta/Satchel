using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// When back is pressed, ask user to confirm whether or not they want to actually go back
        /// </summary>
        /// <param name="MenuRef">The BetterMenus.Menu instance for that menuscreen</param>
        /// <param name="returnScreen">the final return screen</param>
        public static void AddConfirmDialogueToMenu(this Menu MenuRef, MenuScreen returnScreen, string mainPrompt, string subPromt)
        {
            var confirmMenu = new Menu("", new Element[]
            {
                new StaticPanel("space", _ => { }),
                new StaticPanel("fleur", panel =>
                {
                    //todo add fleur
                }),
                new TextPanel(mainPrompt, fontSize: 55)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                },
                new TextPanel(subPromt, fontSize: 39)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                },
                new MenuButton("Yes", "", _ => Utils.GoToMenuScreen(returnScreen)),
                new MenuButton("No", "", _ => Utils.GoToMenuScreen(MenuRef.menuScreen)),

            });
            confirmMenu.GetMenuScreen(returnScreen);
            UnityEngine.Object.Destroy(confirmMenu.menuScreen.topFleur.gameObject);
            UnityEngine.Object.Destroy(confirmMenu.menuScreen.controls.transform.Find("BackButton").gameObject);

            MenuRef.returnScreen = confirmMenu.menuScreen;
        }
    }
}