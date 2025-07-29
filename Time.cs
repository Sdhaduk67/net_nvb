using System;

namespace net_nvb
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
        }

        public void IncrementSecond()
        {
            second++;
            if (second >= 60)
            {
                second = 0;
                minute++;
                if (minute >= 60)
                {
                    minute = 0;
                    hour++;
                    if (hour >= 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Time t1 = new Time(11, 28, 35);
            Console.Write("Current Time: ");
            t1.Display();

            t1.IncrementSecond();
            Console.Write("After Increment: ");
            t1.Display();

            Time t2 = new Time(11, 28, 59);
            Console.Write("\nCurrent Time: ");
            t2.Display();

            t2.IncrementSecond();
            Console.Write("After Increment: ");
            t2.Display();

            Time t3 = new Time(11, 59, 59);
            Console.Write("\nCurrent Time: ");
            t3.Display();

            t3.IncrementSecond();
            Console.Write("After Increment: ");
            t3.Display();
        }
    }
}
