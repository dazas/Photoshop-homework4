using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humans
{
    public class Student : Human
    {
        private double grade;


        public double Grade
        {
            get
            {
                return grade;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Grade must be a positive number.");
                }
                grade = value;
            }
        }


        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }


        public override string ToString()
        {
            return String.Format("{0}, grade: {1:F2}", base.ToString(), this.Grade);
        }

    }
}
