using Modding.Menu.Config;
namespace Satchel.BetterMenus
{
    public static partial class Blueprints
    {
        /// <summary>
        /// Change the inital menu's cancel action to make the supplied "DialogMenu" appear instead of the default CancelAction (when user tries to go to previous menu)
        /// </summary>
        /// <param name="initialMenu">The current Menu</param>
        /// <param name="DialogMenu">The new dialog menu you want to be shown on going back</param>
        public static void AddConfirmDialog(this Menu initialMenu, Menu DialogMenu)
        {
            initialMenu.CancelAction = () =>
            {
                initialMenu.ShowDialog(DialogMenu);
            };
        }

        /// <summary>
        /// A function to close the current menu to make the dialogue menu appear.
        /// </summary>
        /// <param name="initialMenu">The current Menu</param>
        /// <param name="DialogMenu">The dialog menu</param>
        public static void ShowDialog(this Menu initialMenu, Menu DialogMenu)
        {
            DialogMenu.returnScreen = initialMenu.GetCachedMenuScreen(initialMenu.returnScreen);
            Utils.GoToMenuScreen(DialogMenu.GetCachedMenuScreen(DialogMenu.returnScreen));
        }
        /// <summary>
        /// Creates a Menu that functions like a confirm dialog style menu. 
        /// </summary>
        /// <param name="title">Title of the dialog</param>
        /// <param name="subTitle">Subtitle of the dialog</param>
        /// <param name="Options">Options available in the dialog</param>
        /// <param name="OnButtonPress">Action that is invoked with the user's selection</param>
        /// <param name="optionsPerRow"> Number of options to show in a single row</param>
        /// <returns>The Dialog Menu</returns>
        public static Menu CreateDialogMenu(string title, string subTitle, string[] Options, Action<string> OnButtonPress, int optionsPerRow = 2) { 
            var menu = new Menu("");
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
            for(var i = 0; i < Options.Length; i += optionsPerRow)
            {
                List<Element> optionList = new List<Element>();
                for (var j = 0; (j < optionsPerRow && i + j < Options.Length); j++)
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
                rt.anchoredPosition = new Vector2(0f, -200f);

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
        /// Adds a confirm dialogue style menu when back is pressed. It can be used to ask user to confirm across a set of options. Must be called before MenuScreen is returned to modding api
        /// </summary>
        /// <param name="initialMenu">Menu to add the confirm dialog on</param>
        /// <param name="title">Title of the confirm dialog (can be left empty)</param>
        /// <param name="subTitle">Subtitle of the confirm dialog (can be left empty) </param>
        /// <param name="Options">Options available in the confirm dialog</param>
        /// <param name="OnButtonPress">Action that is invoked with the user's selection</param>
        /// <param name="optionsPerRow"> Number of options to show in a single row</param>
        /// <returns>The Dialog Menu</returns>
        public static Menu AddConfirmDialog(
            this Menu initialMenu,
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
