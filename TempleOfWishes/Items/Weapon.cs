using System;
using System.Collections.Generic;
using System.Text;

namespace TempleOfWishes.Items
{
    public class Weapon : Item
    {
        public virtual float Damage { get; protected set; }
        public virtual float Durability { get; protected set; }

        public Weapon(string name, float value, float damage, float durability) : base(name, value)
        {
            Damage = damage;
            Durability = durability;
        }

        public override ItemType getItemType()
        {
            return ItemType.Weapon;
        }

        public override string ToString()
        {
            return base.ToString() + " / Durability " + Durability + " / Damage " + Damage;
        }
    }
}
