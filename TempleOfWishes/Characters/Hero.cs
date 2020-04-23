using TempleOfWishes.Items;
using TempleOfWishes.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleOfWishes.Loggers;

namespace TempleOfWishes.Characters
{
    public class Hero : Character
    {
        public Tile CurrTile { get; private set; }
        private LinkedList<Item> pouch = new LinkedList<Item>();
        public ILogger Logger { get; private set; }
        public GameManager GameManager { get; private set; }
        
        public Hero(string name, int strength, Tile tile, GameManager gameManager) : base(name, strength)
        {
            Logger = new StringLogger();
            CurrTile = tile;
            GameManager = gameManager;
        }

        public bool Move(Directions dir)
        {
            if(CurrTile.hasPath(dir))
            {
                switch (dir)
                {
                    case Directions.North:
                        return Move(CurrTile.Y - 1, CurrTile.X);
                    case Directions.Northeast:
                        return Move(CurrTile.Y - 1, CurrTile.X - 1);
                    case Directions.East:
                        return Move(CurrTile.Y, CurrTile.X - 1);
                    case Directions.Southeast:
                        return Move(CurrTile.Y + 1, CurrTile.X - 1);
                    case Directions.South:
                        return Move(CurrTile.Y + 1, CurrTile.X);
                    case Directions.Southwest:
                        return Move(CurrTile.Y + 1, CurrTile.X + 1);
                    case Directions.West:
                        return Move(CurrTile.Y, CurrTile.X + 1);
                    case Directions.Northwest:
                        return Move(CurrTile.Y - 1, CurrTile.X + 1);
                }

                return true;
            }

            return false;
        }

        private bool Move(int Y, int X)
        {
            if (Y < 0 || X < 0 || Y > GameManager.Tiles.GetLength(0) - 1 || X > GameManager.Tiles.GetLength(1) - 1)
                return false;
            else
            { 
                CurrTile = GameManager.Tiles[Y, X];
                return true;
            }
        }

        public string OpenInv()
        {
            StringBuilder s = new StringBuilder();
            if (pouch.Count == 0)
            {
                s.Append("Your pouch is empty!");
                return s.ToString();
            }
            s.Append("Here are the items in your pouch:\n");

            float tValue = 0;
            for (int i = 0; i < pouch.Count; i++)
            {
                Item item = pouch.ElementAt(i);
                s.Append(i + 1);
                s.Append(": ");
                s.Append(item.Name);
                s.Append(" (value ");
                s.Append(item.Value);
                s.Append(")\n");

                tValue += item.Value;
            }

            s.Append("Total value of all items is ");
            s.Append(tValue);

            return s.ToString();
        }

        // TODO: public bool pickupItem() { }

        public bool Rest()
        {
            if(Health == MaxHealth)
                return false;

            Health = Health <= MaxHealth - 20 ? Health + 20 : MaxHealth;

            return true;
        }

        public void SetLogger(ILogger logger)
        {
            Logger = logger;
            Logger.WriteLine(CurrTile);
        }

        public override string ToString()
        {
            return Logger.ToString();
        }
    }
}
