using System;

namespace net_nvb
{
    public class Employee
    {
        int empid;
        string ename;
        double salary;
        public void getData(int empid, string ename, double salary)
        {
            this.empid = empid;
            this.ename = ename;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("Emp ID: " + empid);
            Console.WriteLine("Emp Name: " + ename);
            Console.WriteLine("Emp Salary: " + salary);
        }

        public double getSalary()
        {
            return salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getData(111, "AAAA", 2500.00);

            Employee e2 = new Employee();
            e2.getData(112, "BBBB", 20000.00);

            Console.WriteLine("Employee with higher salary:");
            if (e1.getSalary() > e2.getSalary())
                e1.showData();
            else
                e2.showData();
        }
    }
}
