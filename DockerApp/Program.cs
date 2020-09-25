using System;
using System.Threading.Tasks;

namespace DockerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Hello World! {i}");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
