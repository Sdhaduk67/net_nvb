using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class JaggedArray
    {
        public static void Main(string[] args)
        {
            // Declare a jagged array with 3 rows
            int[][] jaggedArray = new int[7][];
            // Initialize each row with different lengths
            jaggedArray[0] = new int[1]; // First row has 2 elements
            jaggedArray[1] = new int[2]; // Second row has 3 elements
            jaggedArray[2] = new int[3]; // Third row has 4 elements
            jaggedArray[3] = new int[4]; // Fourth row has 5 elements
            jaggedArray[4] = new int[3]; // Fifth row has 6 elements
            jaggedArray[5] = new int[2]; // Sixth row has 7 elements
            jaggedArray[6] = new int[1]; // Seventh row has 8 elements
            // Fill the jagged array with values
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    //Console.Write($"Enter element at row {i}, column {j}: ");
                    jaggedArray[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            // Display the jagged array
            Console.WriteLine("Jagged Array Elements is:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
