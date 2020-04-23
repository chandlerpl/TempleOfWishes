using CP.Common.Commands;
using TempleOfWishes.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleOfWishes.Commands
{
    public class WalkCommand : CPCommand
    {
        public override bool Init()
        {
            Name = "Walk";
            Desc = "This command moves the Hero in the specified Direction";
            Aliases = new List<string>() { "walk", "w", "move", "m" };
            ProperUse = "walk (north | northeast | east | southeast | south | southwest | west | northwest)";

            return true;
        }

        public override bool Execute(object obj, List<string> args)
        {
            if (obj == null || obj.GetType() != typeof(Hero))
                return false;

            Hero hero = (Hero)obj;
            if(args != null && args.Count == 2 && args[1].Length > 0)
            {
                Directions dir;
                string name = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();
                name = name.Replace("-", "");

                if (Enum.TryParse(name, out dir) || DirectionsHelper.TryConvertAbbr(name, out dir))
                {
                    if (hero.Move(dir))
                    {
                        hero.Logger.WriteLine(hero.CurrTile);
                    }
                    else
                    {
                        hero.Logger.WriteLine("You can't go that way.");
                    }
                } else
                {
                    hero.Logger.Write("The direction ");
                    hero.Logger.Write(name);
                    hero.Logger.WriteLine(" is not valid!");
                }

                return true;
            }

            return false;
        }
    }
}
