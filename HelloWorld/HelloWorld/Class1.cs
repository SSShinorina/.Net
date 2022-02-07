using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Employee
    {
        public void Show(int empno, out string name, out float basic)
        {
            if(empno == 1)
            {
                name = "Shinorina";
                basic = 100;
            }
            else if(empno == 2)
            {
                name = "Shahrin";
                basic = 200;
            }
            else
            {
                name = "Shaon";
                basic = 300;
            }
        }
        static void Main1(string[] args)
        {
            Employee emp = new Employee();
            int empno;
            string name;
            float basic;
            Console.WriteLine("Enter Employee No: ");
            empno = Convert.ToInt32(Console.ReadLine());
            emp.Show(empno, out name, out basic);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Basic: " + basic);


        }
    }
}
