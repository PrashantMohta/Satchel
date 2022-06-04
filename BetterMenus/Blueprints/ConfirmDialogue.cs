using Modding.Menu;
using Modding.Menu.Config;
using On.InControl.NativeDeviceProfiles;
using UnityEngine.UI;
using SMenu =  Satchel.BetterMenus.Menu;
namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Show a Dialog instead of the default CancelAction
        /// </summary>
        /// <param name="initialMenu">The current Menu</param>
        /// <param name="DialogMenu">The dialog Menu</param>
        public static void AddConfirmDialog(this SMenu initialMenu, SMenu DialogMenu)
        {
            initialMenu.CancelAction = () =>
            {
                initialMenu.ShowDialog(DialogMenu);
            };
        }

        /// <summary>
        /// Shows a dialog menu while hiding the existing menu
        /// </summary>
        /// <param name="initialMenu">The current Menu</param>
        /// <param name="DialogMenu">The dialog Menu</param>
        public static void ShowDialog(this SMenu initialMenu, SMenu DialogMenu)
        {
            DialogMenu.returnScreen = initialMenu.GetCachedMenuScreen(initialMenu.returnScreen);
            Utils.GoToMenuScreen(DialogMenu.GetCachedMenuScreen(DialogMenu.returnScreen));
        }
        /// <summary>
        /// Create a Dialog style menu
        /// </summary>
        /// <param name="title">Title of the dialog</param>
        /// <param name="subTitle">Subtitle of the dialog</param>
        /// <param name="Options">Options available in the dialog</param>
        /// <param name="OnButtonPress">Action that is invoked with the user's selection</param>
        /// <param name="optionsPerRow"> Number of options to show in a single row</param>
        /// <returns>The Dialog Menu</returns>
        public static SMenu CreateDialogMenu(string title,string subTitle,string[] Options,Action<string> OnButtonPress, int optionsPerRow = 2) { 
            var menu = new Menu("", new Element[]
            {
                //new StaticPanel("space", _ => { }),
                //new StaticPanel("fleur", _ => {}),
            });
            if (title != string.Empty)
            {
                menu.AddElement(new TextPanel(title, fontSize: 55)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                });
            }
            if (subTitle != string.Empty)
            {
                menu.AddElement(new TextPanel(subTitle, fontSize: 39)
                {
                    Font = TextPanelConfig.TextFont.TrajanBold
                });
            }
            for(var i=0;i< Options.Length; i+=optionsPerRow)
            {
                List<Element> optionList = new List<Element>();
                for (var j=0;(j < optionsPerRow && i+j < Options.Length); j++)
                {
                    var option = Options[i + j];
                    optionList.Add(
                        new MenuButton(option, "", _ =>
                        {
                            OnButtonPress(option);
                        })
                    );
                }
                menu.AddElement(new MenuRow(optionList, $"Options{i}")
                {
                    XDelta = optionList.Count > 2 ? 250 : 500,
                });
            }
            
            menu.OnBuilt += (_, _) =>
            {
                var mobj = menu.menuScreen.gameObject;
                var rt = mobj.GetComponent<RectTransform>();
                rt.sizeDelta = new Vector2(0f, 250f);
                //rt.pivot = new Vector2(0.5f, 0.5f);
                //rt.anchorMin = new Vector2(0f, 0f);
                //rt.anchorMax = new Vector2(1f, 1f);
                rt.anchoredPosition = new Vector2(0f, -200f);

                /*var panel = menu.Find("fleur").gameObject;
                var fleur = menu.menuScreen.topFleur;
                //fleur.transform.SetParent(panel.transform, false);
                UnityEngine.Object.DontDestroyOnLoad(fleur);
                AnchoredPosition.FromSiblingAnchor(
                        new Vector2(0.5f, 0.5f),
                        panel.GetComponent<RectTransform>(),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.0f, 50))
                    .Reposition(fleur.GetComponent<RectTransform>());*/
                // destroy the back button 
                // todo make this be optional in the menu itself
                var backButton = menu.menuScreen.gameObject.Find("BackButton");
                if (backButton != null)
                {
                    GameObject.Destroy(backButton);
                }

            };
            return menu;
        }

        /// <summary>
        /// When back is pressed, ask user to confirm across a set of options
        /// </summary>
        /// <param name="initialMenu">Menu to add the confirm dialog on</param>
        /// <param name="title">Title of the confirm dialog</param>
        /// <param name="subTitle">Subtitle of the confirm dialog</param>
        /// <param name="Options">Options available in the confirm dialog</param>
        /// <param name="OnButtonPress">Action that is invoked with the user's selection</param>
        /// <param name="optionsPerRow"> Number of options to show in a single row</param>
        /// <returns>The Dialog Menu</returns>
        public static SMenu AddConfirmDialog(
            this SMenu initialMenu,
            string title, 
            string subTitle, 
            string[] Options, 
            Action<string> OnButtonPress
            , int optionsPerRow = 2)
        {
            var confirmMenu = CreateDialogMenu(title, subTitle, Options, OnButtonPress, optionsPerRow);
            initialMenu.AddConfirmDialog(confirmMenu);
            confirmMenu.GetMenuScreen(initialMenu.menuScreen);
            return confirmMenu;
        }
    }
}