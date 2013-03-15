using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humans
{
    public class Worker : Human
    {
        private decimal weekSalary;

        private decimal workHours;

        private decimal moneyPerHour;


        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
            this.moneyPerHour = GetMoneyPerHour();

        }


        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("WeekSalary must be a positive number.");
                }
                weekSalary = value;
            }
        }

        public decimal WorkHours
        {
            get
            {
                return workHours;
            }
            private set
            {
                if (value > 0 && value < 15)
                {
                    workHours = value;
                }
                if (value <= 0)
                {
                    throw new ArgumentException("WorkHours must be a positive number.");
                }

            }
        }

        public decimal MoneyPerHour
        {
            get
            {
                return moneyPerHour;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Money per hour must be a positive number.");
                }
                moneyPerHour = value;
            }
        }


        private decimal GetMoneyPerHour()
        {
            if (this.workHours > 0)
            {
                return this.weekSalary / (this.workHours * 7);
            }
            else
            {
                throw new DivideByZeroException();
            }
        }


        public override string ToString()
        {
            return string.Format("Worker's name: {0}, week salary: {1:F2}, money per hour: {1:F2}", base.ToString(), this.weekSalary, this.MoneyPerHour);

        }

    }
}