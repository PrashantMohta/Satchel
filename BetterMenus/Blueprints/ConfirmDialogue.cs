using Modding.Menu;
using Modding.Menu.Config;
using On.InControl.NativeDeviceProfiles;
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
        /// <param name="mainPrompt">The main prompt that the user will be shown on the menu</param>
        /// <param name="subPromt">The text below the main prompt (in smaller font)</param>
        /// <param name="YesPrompt">Text to show on the yes button</param>
        /// <param name="NoPrompt">Text to show on the no button</param>
        /// <param name="OnYesPressed">code to be ran when yes is pressed and user is taken to return screen</param>
        /// <param name="OnNoPressed">code to be ran when no is pressed and user is taken back to modmenu</param>
        /// <returns>The MenuRef to use to add new elements/edit existing elements</returns>
        public static Menu AddConfirmDialogueToMenu(this Menu MenuRef, MenuScreen returnScreen, 
            string mainPrompt, string subPromt = "", 
            string YesPrompt = "Yes", string NoPrompt = "No", 
            Action OnYesPressed = null, Action OnNoPressed = null)
        {
            var confirmMenu = new Menu("", new Element[]
            {
                new StaticPanel("space", _ => { }),
                new StaticPanel("fleur", _ => {}),
            });
            if (mainPrompt != string.Empty)
            {
                confirmMenu.AddElement(new TextPanel(mainPrompt, fontSize: 55)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                });
            }

            if (subPromt != string.Empty)
            {
                confirmMenu.AddElement(new TextPanel(subPromt, fontSize: 39)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                });
            }
            confirmMenu.AddElement(new MenuRow(new List<Element>()
            {
                new MenuButton(YesPrompt, "", _ =>
                {
                    OnYesPressed?.Invoke();
                    Utils.GoToMenuScreen(returnScreen);
                }),
                new MenuButton(NoPrompt, "", _ =>
                {
                    OnNoPressed?.Invoke();
                    Utils.GoToMenuScreen(MenuRef.menuScreen);
                }),
            }, "Buttons")
            {
                XDelta = 500,
            });
            
            confirmMenu.OnBuilt += (_, _) =>
            {
                var panel = confirmMenu.Find("fleur").gameObject;
                var fleur = confirmMenu.menuScreen.topFleur;
                fleur.transform.SetParent(panel.transform, false);
                UnityEngine.Object.DontDestroyOnLoad(fleur);
                AnchoredPosition.FromSiblingAnchor(
                        new Vector2(0.5f, 0.5f),
                        panel.GetComponent<RectTransform>(),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.0f, 50))
                    .Reposition(fleur.GetComponent<RectTransform>());
            };

            confirmMenu.OnBuilt += (_, _) =>
            {
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