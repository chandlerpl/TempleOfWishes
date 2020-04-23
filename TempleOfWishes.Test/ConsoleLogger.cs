using System;
using System.Collections.Generic;
using System.Text;
using TempleOfWishes.Loggers;

namespace TempleOfWishes.Test
{
    class ConsoleLogger : ILogger
    {
        public override void Write(string str)
        {
            Console.Write(str);
        }

        public override void Write(object str)
        {
            Console.Write(str);
        }

        public override void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public override void WriteLine(object str)
        {
            Console.WriteLine(str);
        }
    }
}
