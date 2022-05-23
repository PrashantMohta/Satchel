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
        public static Menu AddConfirmDialogueToMenu(this Menu MenuRef, MenuScreen returnScreen, string mainPrompt, string subPromt)
        {
            var confirmMenu = new Menu("", new Element[]
            {
                new StaticPanel("space", _ => { }),
                new StaticPanel("fleur", _ => {}),
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
            confirmMenu.OnBuilt += (_, _) =>
            {
                var panel = (confirmMenu.Find("fleur") as StaticPanel).gameObject;
                var fleur = confirmMenu.menuScreen.topFleur;
                fleur.transform.SetParent(panel.transform, false);
                AnchoredPosition.FromSiblingAnchor(
                        new Vector2(0.5f, 0.5f),
                        panel.GetComponent<RectTransform>(),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.0f, 50))
                    .Reposition(fleur.GetComponent<RectTransform>());
                
                //for when subsribing mod is built before
                MenuRef.returnScreen = confirmMenu.menuScreen;
            };

            //for when subsribing mod is built later
            MenuRef.OnBuilt += (_, _) =>
            {
                MenuRef.returnScreen = confirmMenu.menuScreen;
            };
            
            //for when its called after all menus built
            MenuRef.returnScreen = confirmMenu.menuScreen;

            confirmMenu.GetMenuScreen(returnScreen);
            UnityEngine.Object.Destroy(confirmMenu.menuScreen.controls.transform.Find("BackButton").gameObject);

            return confirmMenu;
        }
    }
}