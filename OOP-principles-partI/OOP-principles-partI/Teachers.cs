using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartI
{
    public class Teacher : PersonInSchool //, IAnnotation
    {
        public List<Discipline> Disciplines { get; private set; }


        public string Tag { get; set; }


        public Teacher(string firstName, string lastName, Discipline[] disciplines)
            : base(firstName, lastName)
        {
            this.Disciplines = new List<Discipline>(disciplines);
        }


        public override string ToString()
        {
            StringBuilder teacherData = new StringBuilder();


            teacherData.AppendFormat("Teacher: {0}", base.ToString());


            teacherData.Append("\r\nCourses:");


            foreach (Discipline discipline in this.Disciplines)
            {
                teacherData.AppendFormat("\r\n{0}", discipline);
            }


            return teacherData.ToString();
        }
    }

}
