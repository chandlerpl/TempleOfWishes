using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleOfWishes.Items
{
    public abstract class Item
    {
        public virtual string Name { get; protected set; }
        public virtual float Value { get; protected set; }

        public Item(string name, float value)
        {
            Name = name;
            Value = value;
        }

        public virtual ItemType getItemType() { return ItemType.Item; }

        public override string ToString()
        {
            return Name + " - Value " + Value;
        }
    }
}
