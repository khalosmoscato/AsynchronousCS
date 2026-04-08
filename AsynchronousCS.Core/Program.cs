using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace AsynchronousCS.Core
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var printHello = Task.Run(async () =>
            {
                Console.WriteLine("Hello..");
                await Task.Delay(3000);
            });

            var printWorld = Task.Run(async () => 
            {
                Console.WriteLine(".. World!");
                await Task.Delay(3000);
            });

            await Task.WhenAll([printHello, printWorld]);
            stopwatch.Stop();
        }
    }
}
