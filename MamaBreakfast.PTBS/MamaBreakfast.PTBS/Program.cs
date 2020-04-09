using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Breakfast;

namespace MamaBreakfast.PTBS
{
    class Program
    {
        /// <summary>
        /// Original
        /// </summary>
        //static void Main(string[] args)
        //{
        //    Coffee cup = Nespresso.MakeCoffee();
        //    Console.WriteLine("Coffee is ready!");

        //    Stove.HeatUp();
        //    Egg[] eggs = Stove.FryEggs(2);
        //    Console.WriteLine("Eggs are ready!");

        //    Sausage[] bacon = Stove.FrySausage(3);
        //    Console.WriteLine("Sausages are ready!");
        //    Stove.CoolDown();

        //    Toast[] toasts = Toaster.ToastBread(2);
        //    Knife.ButterToasts(toasts);
        //    Knife.JamToasts(toasts);
        //    Console.WriteLine("Toasts are ready!");

        //    Juice juice = JuiceBottle.PourJuice();
        //    Console.WriteLine("Juice is ready!");

        //    Console.WriteLine("Breakfast is ready!");
        //}

        /// <summary>
        /// Threads
        /// </summary>
        //static void Main(string[] args)
        //{
        //    Thread coffeeThread = new Thread(() =>
        //    {
        //        Coffee cup = Nespresso.MakeCoffee();
        //        Console.WriteLine("Coffee is ready!");
        //    });

        //    Thread stoveThread = new Thread(() =>
        //    {
        //        Stove.HeatUp();
        //        Egg[] eggs = Stove.FryEggs(2);
        //        Console.WriteLine("Eggs are ready!");

        //        Sausage[] bacon = Stove.FrySausage(3);
        //        Console.WriteLine("Sausages are ready!");
        //        Stove.CoolDown();
        //    });

        //    Thread toastsThread = new Thread(() =>
        //    {
        //        Toast[] toasts = Toaster.ToastBread(2);
        //        Knife.ButterToasts(toasts);
        //        Knife.JamToasts(toasts);
        //        Console.WriteLine("Toasts are ready!");
        //    });

        //    Thread juiceThread = new Thread(() =>
        //    {
        //        Juice juice = JuiceBottle.PourJuice();
        //        Console.WriteLine("Juice is ready!");
        //    });

        //    coffeeThread.Start();
        //    stoveThread.Start();
        //    toastsThread.Start();
        //    juiceThread.Start();
        //    Console.WriteLine("Breakfast is ready!");
        //}

        /// <summary>
        /// Original
        /// </summary>
        //static async Task Main(string[] args)
        //{
        //    Coffee cup = await Nespresso.MakeCoffee();
        //    Console.WriteLine("Coffee is ready!");

        //    await Stove.HeatUp();
        //    Egg[] eggs = await Stove.FryEggs(2);
        //    Console.WriteLine("Eggs are ready!");

        //    Sausage[] bacon = await Stove.FrySausage(3);
        //    Console.WriteLine("Sausages are ready!");
        //    await Stove.CoolDown();

        //    Toast[] toasts = await Toaster.ToastBread(2);
        //    await Knife.ButterToasts(toasts);
        //    await Knife.JamToasts(toasts);
        //    Console.WriteLine("Toasts are ready!");

        //    Juice juice = await JuiceBottle.PourJuice();
        //    Console.WriteLine("Juice is ready!");

        //    Console.WriteLine("Breakfast is ready!");
        //}

        public static async Task Main(string[] args)
        {
            Task<string> getUserTask = GetUserById(6);
            Console.WriteLine(await getUserTask);

            Console.WriteLine("Continuing program execution...");
        }

        public static async Task<string> GetUserById(int userId)
        {
            var httpClient = new HttpClient();
            Task<string> userTask = httpClient.GetStringAsync($"http://localhost:8080/api/v1/users/{userId}");
            Console.WriteLine(await userTask);
            return userTask.Result;
        }

        //public static async Task Main(string[] args)
        //{
        //    Task<string> getUser1 = GetUserById(1);
        //    Task<string> getUser2 = GetUserById(2);
        //    Task<string> getUser3 = GetUserById(3);

        //    List<Task<string>> getUsersTasks = new List<Task<string>> { getUser1, getUser2, getUser3 };
        //    while (getUsersTasks.Any())
        //    {
        //        Task<string> finished = await Task.WhenAny(getUsersTasks);
        //        Console.WriteLine(finished.Result);
        //        getUsersTasks.Remove(finished);
        //    }
        //}

        //public static async Task<string> GetUserById(int userId)
        //{
        //    var httpClient = new HttpClient();
        //    return await httpClient.GetStringAsync($"http://localhost:8080/api/v1/users/{userId}");
        //}
    }
}
