using System.Threading.Tasks;

namespace Breakfast
{
    public static class Knife
    {
        private static bool _isBusy = false;

        public static async Task ButterToasts(Toast[] toasts)
        {
            _isBusy = true;
            foreach (Toast toast in toasts)
            {
                await Task.Delay(2000); // Applying butter...
                toast.IsButtered = true;
            }

            _isBusy = false;
        }

        public static async Task JamToasts(Toast[] toasts)
        {
            _isBusy = true;
            foreach (Toast toast in toasts)
            {
                await Task.Delay(2000); // Applying jam...
                toast.IsJammed = true;
            }

            _isBusy = false;
        }
    }
}