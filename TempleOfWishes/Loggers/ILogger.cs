using System;
using System.Collections.Generic;
using System.Text;

namespace TempleOfWishes.Loggers
{
    public abstract class ILogger
    {
        public string Name { get; protected set; }

        public abstract void Write(string str);

        public abstract void WriteLine(string str);

        public abstract void Write(object str);

        public abstract void WriteLine(object str);
    }
}
