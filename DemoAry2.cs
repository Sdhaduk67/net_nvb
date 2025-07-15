using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class DemoAry2
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[3, 3];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < ary.GetLength(0); i++) // rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // columns
                {
                    Console.Write("Enter element at position [{0},{1}]: ", i, j);
                    ary[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < ary.GetLength(0); i++) // rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // columns
                {
                    Console.Write(ary[i, j] + "\t");

                }
                Console.WriteLine();
            }




            /*int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for(int i=0; i<ary.GetLength(0); i++) //number of rows
            {
                for(int j=0;j<ary.GetLength(1); j++)
                {
                    Console.Write(ary[i,j]);
                }
                Console.WriteLine();
            }*/
            //ary[0, 0] = 1;
            //ary[0, 1] = 2;
            //ary[1, 0] = 3;
            //ary[1, 1] = 4;

            // Console.WriteLine("First element:", ary[0, 0]);
        }
    }
}
