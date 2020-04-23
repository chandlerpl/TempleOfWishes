using CP.Common.Commands;
using TempleOfWishes.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace TempleOfWishes.Commands
{
    public class InventoryCommand : CPCommand
    {
        public override bool Init()
        {
            Name = "Open Inventory";
            Desc = "Lists all of the items in the inventory of the character.";
            Aliases = new List<string>() { "open", "o", "i" };
            ProperUse = "open";

            return true;
        }

        public override bool Execute(object obj, List<string> args)
        {
            if (obj == null || obj.GetType() != typeof(Hero))
                return false;

            Hero hero = (Hero)obj;
            hero.Logger.WriteLine(hero.OpenInv());
            return true;
        }
    }
}
