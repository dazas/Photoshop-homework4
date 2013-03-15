using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartI
{
    public class Student : PersonInSchool
    {
        private int Grade;
    
        public int Id { get; private set; }


        public string Tag { get; set; }


        public Student(string firstName, string lastName, int id)
            : base(firstName, lastName)
        {
            this.Id = id;
        }


        public override string ToString()
        {
            return String.Format("{0}ID: {1}", base.ToString(), this.Id);
        }
    }

}
