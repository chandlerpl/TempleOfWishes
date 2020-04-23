﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleOfWishes.Tiles
{
    public class Field : Tile
    {
        public Field(int xPos, int yPos, byte[] paths = null, string name = "Field") : base(xPos, yPos, paths, name)
        {

        }
    }
}
