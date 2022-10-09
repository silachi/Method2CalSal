using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2CalSal
{
    internal class Program
    {
        // hussain make sure you can use static here or not
        static Employee GetObj(string _profession)
        {
            if (_profession == "Manager")
            {
                return new Manager(250, 1000);
            }
            else if (_profession == "Engineer")
            {
                return new Engineer(0, 0);
            }
            else
            {
                return new HR(150, 800);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("To get check salary kindly enter you proffesion___");
            Console.WriteLine("\t 1. Engineer");
            Console.WriteLine("\t 2. Manager");
            Console.WriteLine("\t 3. HR");
            Console.Write("\n \t  =");
            string profession = Console.ReadLine();

            Employee employee = GetObj(profession);

            Console.WriteLine("\n \t \t \t your salary is " + employee.CalSal());
            

            Console.ReadLine();
        }



    }

}
