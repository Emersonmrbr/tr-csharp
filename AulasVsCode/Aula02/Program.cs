using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length != 0){
                Console.WriteLine(args.GetValue(0));
            }
        }
        }
}
