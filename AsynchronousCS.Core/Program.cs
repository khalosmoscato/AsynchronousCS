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
                await Task.Delay(3000);
                return "Hello..";
                
            });

            var printWorld = Task.Run(async () => 
            {
                await Task.Delay(3000);
                return ".. World!";
            });

             string[] combinedTask = await Task.WhenAll(printHello, printWorld);

            stopwatch.Stop();
            Console.WriteLine($"{combinedTask[0]}{combinedTask[1]}");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}
