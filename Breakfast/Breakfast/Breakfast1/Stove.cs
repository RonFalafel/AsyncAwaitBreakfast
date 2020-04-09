using System.Threading.Tasks;

namespace Breakfast
{
    public static class Stove
    {
        public static int Temperature = 0;
        private static bool _isBusy = false;

        public static async Task HeatUp()
        {
            await Task.Delay(20000); // Heating up...
            Temperature = 180;
        }

        public static async Task CoolDown()
        {
            await Task.Delay(500); // Turning off...
            Temperature = 0;
        }

        public static async Task<Egg[]> FryEggs(int numOfEggs)
        {
            if (Temperature < 180)
            {
                throw new StoveTooColdException(Temperature);
            }

            if (_isBusy)
            {
                throw new StoveBusyException();
            }

            _isBusy = true;
            await Task.Delay(30000); // Frying Eggs...
            _isBusy = false;
            Egg[] eggs = new Egg[numOfEggs];
            for (int i = 0; i < numOfEggs; i++)
            {
                eggs[i] = new Egg();
            }

            return eggs;
        }

        public static async Task<Sausage[]> FrySausage(int numOfSausage)
        {
            if (Temperature < 180)
            {
                throw new StoveTooColdException(Temperature);
            }

            if (_isBusy)
            {
                throw new StoveBusyException();
            }

            _isBusy = true;
            await Task.Delay(15000); // Frying Sausage...
            _isBusy = false;
            Sausage[] sausage = new Sausage[numOfSausage];
            for (int i = 0; i < numOfSausage; i++)
            {
                sausage[i] = new Sausage();
            }

            return sausage;
        }
    }
}