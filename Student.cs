using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_nvb
{
    internal class Student
    {
        int rlno;
        string name;

        public Student() // Default constructor
        {
            rlno = 1;
            name = "AAAA";
        }

        public void showData()
        {
            Console.WriteLine("Roll No: " + rlno);
            Console.WriteLine("Name: " + name);
        }
    }
    
    internal class DemoClass1
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.showData(); // This will show default values since no data is set

        }
    }
}
