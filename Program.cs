﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class ArrayPrc
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[6];
            bool[] freq = new bool[ary.Length];
            //initialization of array elements
            Console.WriteLine("Enter array ekement:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ary.Length; i++)
            {
                if (freq[i] == true)
                    continue;

                int cnt = 1;
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[i] == ary[j])
                    {
                        freq[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine("Grequency of {0} is {1} times", ary[i], cnt);
            }


            /*int searchEle;
            Console.WriteLine("Enter element to search:");
            searchEle=Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i=0;i<ary.Length;i++)
            {
                if (ary[i]==searchEle)
                {
                    flag = i;
                }
            }*/
        }
    }
}
