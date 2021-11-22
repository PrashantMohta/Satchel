using Modding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Satchel.BetterMenus;

namespace Satchel.BetterMenus
{
    [Obsolete("This is an example, and is not to be used in any way.", true)]
    internal sealed class BuildExample
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            return Menu.Create("", modListMenu, new MenuOptionBuilder()
                .AddKeyBind("Test", null, out _) //Will add a KeyBind.
                .AddKeyBind("Test2", null, out var Bind) //Will add a KeyBind and store it.
                .AddTextPanel("Test3", out _, 1000f) //Will add a TextPanel.
                .AddHorizontalOption(new HorizontalOption("Name", new string[] { "Op1", "Op2" }, "lol", null, null)) //Will attempt to add a Horizontal option.
                                                                                                                     //This will likely go weird, but that's a problem
                                                                                                                     //for the one that made HorizontalOption.
                .AddHorizontalOption("Name", new string[] { "Op1" }, "Desc", null, null, out _) //Will log an error saying that the option couldn't be added. (Because null values were given.)
                .AddTextPanel("", out _) //Will log an error saying the TextPanel couldn't be added. (Because the name value is an empty string.)
                .Build()); //Builds the MenuOptionBuilder.
        }
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }
}
