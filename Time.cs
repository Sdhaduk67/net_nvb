using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net
{
    internal class time
    {
        public int hour;
        public int minute;
        public int second;

        public void getTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void showTime()
        {
            Console.WriteLine("Time is: " + hour + ":" + minute + ":" + second);
        }

        public void addTime(time t1, time t2) // Corrected method name to addTime
        {
            this.hour = t1.hour + t2.hour;
            this.minute = t1.minute + t2.minute;
            this.second = t1.second + t2.second;

            if (this.second >= 60)
            {
                this.second -= 60;
                this.minute++; // Corrected: increment minute
            }

            if (this.minute >= 60)
            {
                this.minute -= 60;
                this.hour++; // Corrected: increment hour
            }
        }
    }

    // This is the new class containing the Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the time class
            time t1 = new time();
            t1.getTime(10, 30, 45);
            t1.showTime();

            time t2 = new time();
            t2.getTime(1, 40, 20);
            t2.showTime();

            time sumTime = new time();
            sumTime.addTime(t1, t2);
            sumTime.showTime();

            Console.ReadKey(); // Keeps the console open until a key is pressed
        }
    }
}