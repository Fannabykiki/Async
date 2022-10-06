using System;
namespace Rookies.Async
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task.WhenAll(
                GetPrimeNumbers(0, 100),
                GetPrimeNumbers(100, 200)
            );
        }
        static async Task GetPrimeNumbers(int min, int max)
        {
            await Task.Run(() =>
            {
                for (int i = min; i < max; i++)
                {
                    if (CheckPrimeNumber(i))
                    {
                        System.Console.WriteLine(" " + i);
                    }
                }
            });
        }
        static bool CheckPrimeNumber(int num)
        {
            int i;
            for (i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {

                    return false;
                }
            }

            return false;
        }
        public static void Run()
        {
            if (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
            }
        }
    }
}