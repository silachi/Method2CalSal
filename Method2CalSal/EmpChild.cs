using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2CalSal
{
    public abstract class Employee
    {
        // attributes
        protected double baseSal = 15000;
        protected double fuelAllowance;
        protected double medAllowance;

        // actions
        
        public double GetBaseSal()
        {
            return baseSal;
        }
        public double GetFuelAllowance()
        {
            return fuelAllowance;
        }

        public double GetMedAllowance()
        {
            return medAllowance;
        }

        public abstract double CalSal();

    }

    public class Engineer : Employee
    {
        public Engineer(double fuelAllowance, double medAllowance)
        {
            this.fuelAllowance = fuelAllowance;
            this.medAllowance = medAllowance;

        }
        public override double CalSal()
        {
         
            double annualPaid = 7000;
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance() + annualPaid / 12;
            return salary;
        }

    }
    public class Manager : Employee
    {
        double tax = 0.17;
        public Manager(double fuelAllowance, double medAllowance)
        {
            this.fuelAllowance = fuelAllowance;
            this.medAllowance = medAllowance;

        }
        public override double CalSal()
        {
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance();
            salary = salary - salary * tax;
            return salary;
        }

    }
    public class HR : Employee
    {
        public HR(double fuelAllowance, double medAllowance)
        {
            this.fuelAllowance = fuelAllowance;
            this.medAllowance = medAllowance;

        }
        public override double CalSal()
        {
            double intrwAllowance = (GetMedAllowance() + GetFuelAllowance()) * 0.10;
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance() + intrwAllowance;
            return salary;
        }

    }

}
