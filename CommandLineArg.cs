using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class CommandLineArg
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Command Line Arguments:");
           Console.WriteLine("First Argument: " + args[0]);
           Console.WriteLine("Second Argument: " + args[1]);
           {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Argument {i + 1}: {args[i]}");
                }
            }
        }
    }
}
