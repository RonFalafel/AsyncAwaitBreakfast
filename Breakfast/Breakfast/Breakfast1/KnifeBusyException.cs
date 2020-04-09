using System;

namespace Breakfast
{
    public class KnifeBusyException : Exception
    {
        public override string ToString()
        {
            return "The knife was used while already busy! " + base.ToString();
        }
    }
}
