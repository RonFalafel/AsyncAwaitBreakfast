using System.Threading.Tasks;

namespace Breakfast
{
    public static class Nespresso
    {
        public static async Task<Coffee> MakeCoffee()
        {
            await Task.Delay(4000); // Making coffee...
            return new Coffee();
        }
    }
}