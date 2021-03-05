using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Lab2
{

    class  Employee
    {
        private string sName;
        private double fWage;

        public Employee vCreateEmp()
        {
            return new Employee();
        }

        public void vRelease()
        {
            Console.WriteLine($"Имя: {this.sName}");
            Console.WriteLine($"Зп: {this.fWage}");
        }

        public string sEmpName
        {
            get
            {
                return this.sName;
            }
            set
            {
                this.sName = value is string ? value : null;
            }
        }

        public double fEmpWage
        {
            get
            {
                return this.fWage;
            }
            set
            {
                this.fWage = value;
            }
        }

    }

    class Program
    {

        static List<Employee> lEmp;
        static Employee pEmp;

        static void Main()
        {
            lEmp = new List<Employee>();
            pEmp = new Employee();
            for(int i = 0; i < 3; i++)
            {
                lEmp.Add(pEmp.vCreateEmp());
            }
            foreach(Employee i in lEmp)
            {
                i.sEmpName = Console.ReadLine();
                i.fEmpWage = Convert.ToDouble(Console.ReadLine());
            }
            foreach (Employee i in lEmp)
            {
                i.vRelease();
            }
            Console.ReadKey();
        }

    }
}
