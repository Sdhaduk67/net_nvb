using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class _2array
    {
        public static void Main(string[] args)
        {
            int[] ary1 = new int[1];
            int[] ary2 = new int[1];
            int[] sumAry = new int[1];
            Console.WriteLine("Enter elements for first array:");
            for (int i = 0; i < ary1.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ary1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter elements for second array:");
            for (int i = 0; i < ary2.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ary2[i] = Int32.Parse(Console.ReadLine());
            }
            // Calculate the sum of the two arrays
            for (int i = 0; i < sumAry.Length; i++)
            {
                sumAry[i] = ary1[i] + ary2[i];
            }
            // Display the result
            Console.WriteLine("Sum of the two arrays:");
            foreach (var item in sumAry)
            {
                Console.Write(item + " ");
            }
        }
    }
}
