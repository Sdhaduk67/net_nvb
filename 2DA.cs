using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class _2DA
    {
        public static void Main(string[] args)
        {
            /*int[,] ary = new int[2, 2];
            ary[0,0] = 1;
            ary[0, 1] = 2;
            ary[1, 0] = 3;
            ary[1, 1] = 4;*/

            //2x3 array
            int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine("First Element:",ary[0,0]);
        }   
    }
}
