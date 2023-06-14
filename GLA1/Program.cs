using System;

namespace GLA1
{
    public class Employee
    {
        
        private string name;
        private double wage;
        private double unpaidWorkHours;
        private double employeeMoneyOwed;

        public void SetName(string name)
        {
            
            this.name = name;
        }

        public string GetName()
        {
            
            return name;
        }

        public void SetWage(double rate)
        {
            
            wage = rate;
        }

        public double GetWage()
        {
            
            return wage;
        }

        public void Work(double hours)
        {

            unpaidWorkHours += hours;


            employeeMoneyOwed = wage * unpaidWorkHours;
        }

        public double Pay()
        {
            
            double payment = employeeMoneyOwed;
            unpaidWorkHours = 0;
            employeeMoneyOwed = 0;
            return payment;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.SetName("David");
            emp1.SetWage(15);
            emp2.SetName("Susan");
            emp2.SetWage(30);

            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.GetName(), emp2.Pay());

            emp1.Work(5);
            emp2.Work(8);

            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());

            emp1.Work(5);
            emp2.Work(2);

            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.GetName(), emp2.Pay());
        }
    }
}


