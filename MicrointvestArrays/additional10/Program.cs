using System;
using System.Linq;

namespace additional10
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            char[] sorted = input.OrderBy(x => (int)x).ToArray();

            Console.WriteLine(string.Join("",sorted));
        }
    }
}
