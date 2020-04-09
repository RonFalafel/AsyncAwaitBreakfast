using System.Threading.Tasks;

namespace Breakfast
{
    public static class JuiceBottle
    {
        public static async Task<Juice> PourJuice()
        {
            await Task.Delay(1000); // Pouring Juice
            return new Juice();
        }
    }
}