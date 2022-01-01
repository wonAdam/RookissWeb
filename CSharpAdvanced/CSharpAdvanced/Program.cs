using System;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class Program
    {
        static Task Test()
        {
            Console.WriteLine("Start Task");
            Task t = Task.Delay(3000);
            return t;
        }

        static async Task<int> TestAsync()
        {
            Console.WriteLine("Start Task");
            Task t = Task.Delay(3000);

            await t;
            Console.WriteLine("End TaskAsync");

            return 1;
        }

        static async Task Main(string[] args)
        {
            Task<int> t = TestAsync();
            int result = await t;

            Console.WriteLine("While Start");
            while (true)
                ;
        }
    }
}
