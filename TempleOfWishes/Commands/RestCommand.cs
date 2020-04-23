using CP.Common.Commands;
using TempleOfWishes.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleOfWishes.Commands
{
    public class RestCommand : CPCommand
    {
        public override bool Init()
        {
            Name = "Rest";
            Desc = "This command lets the hero rest for a small health gain.";
            Aliases = new List<string>() { "rest", "r" };
            ProperUse = "rest";

            return true;
        }

        public override bool Execute(object obj, List<string> args)
        {
            if (obj == null || obj.GetType() != typeof(Hero))
                return false;

            Hero hero = (Hero)obj;
            if (hero.Rest())
                hero.Logger.WriteLine("You have rested, your health is now " + hero.Health);
            else
                hero.Logger.WriteLine("You are already at max health.");
            return true;
        }
    }
}
