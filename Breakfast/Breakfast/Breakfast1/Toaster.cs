using System.Threading.Tasks;

namespace Breakfast
{
    public static class Toaster
    {
        public static async Task<Toast[]> ToastBread(int numOfToasts)
        {
            await Task.Delay(10000); // Making Toast...
            Toast[] toasts = new Toast[numOfToasts];
            for (int i = 0; i < numOfToasts; i++)
            {
                toasts[i] = new Toast();
            }

            return toasts;
        }
    }
}