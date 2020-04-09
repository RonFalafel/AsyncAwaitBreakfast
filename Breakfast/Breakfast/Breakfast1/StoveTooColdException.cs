using System;

namespace Breakfast
{
    public class StoveTooColdException : Exception
    {
        private readonly int _temperature;

        public StoveTooColdException(int temperature)
        {
            _temperature = temperature;
        }

        public override string ToString()
        {
            return $"The stove was too cold!!! Temperature is: {_temperature}C. " + base.ToString();
        }
    }
}
