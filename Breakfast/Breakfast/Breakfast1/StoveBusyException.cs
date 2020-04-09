using System;

namespace Breakfast
{
    public class StoveBusyException : Exception
    {
        public override string ToString()
        {
            return "The stove was used while already busy! " + base.ToString();
        }
    }
}
