﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleOfWishes.Tiles
{
    public class Water : Tile
    {
        public Water(int xPos, int yPos, string name = "Water") : base(xPos, yPos, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, name)
        {

        }
    }
}
