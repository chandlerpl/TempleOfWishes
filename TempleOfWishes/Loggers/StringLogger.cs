using System;
using System.Collections.Generic;
using System.Text;

namespace TempleOfWishes.Loggers
{
    class StringLogger : ILogger
    {
        public StringBuilder Logs { get; private set; } = new StringBuilder();

        public override void Write(string str)
        {
            Logs.Append(str);
        }

        public override void Write(object str)
        {
            Logs.Append(str);
        }

        public override void WriteLine(string str)
        {
            Logs.Append(str);
            Logs.Append("\n");
        }

        public override void WriteLine(object str)
        {
            Logs.Append(str);
            Logs.Append("\n");
        }
    }
}
