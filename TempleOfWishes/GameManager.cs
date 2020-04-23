using TempleOfWishes.Characters;
using TempleOfWishes.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CP.Common.Commands;

namespace TempleOfWishes
{
    public class GameManager
    {
        public readonly int NUMBER_Y_AREAS = 10;
        public readonly int NUMBER_X_AREAS = 10;

        public Tile[,] Tiles { get; private set; }
        public Hero Hero { get; private set; }
        public Command Command { get; private set; }

        public GameManager()
        {
            Command = new Command();
            generateAreas();

            Hero = new Hero("Hero", 5, Tiles[Utils.Random.Next(Tiles.GetLength(0)), Utils.Random.Next(Tiles.GetLength(1))], this);

            Hero.Logger.WriteLine(Hero.CurrTile);
        }

        public static Task<GameManager> CreateGame()
        {
            return Task.Run(() =>
            {
                GameManager gm = new GameManager();

                return gm;
            });
        }

        public void generateAreas()
        {
            Tiles = new Tile[NUMBER_Y_AREAS, NUMBER_X_AREAS];

            for (int y = 0; y < Tiles.GetLength(0); y++)
            {
                for (int x = 0; x < Tiles.GetLength(1); x++)
                {
                    Tiles[y, x] = new Field(x, y);
                }
            }
        }

        public void Play(string command)
        {
            Command.commandInterface(Hero, command.Split(' '));
        }

        private bool WinConditions()
        {
            return true;
        }

        public override string ToString()
        {
            return Hero.ToString();
        }
    }
}
