using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartI
{
    public class Discipline //: IAnnotation
    {
        public string Title { get; private set; }

        public int Lectures { get; private set; }

        public int Exercises { get; private set; }

        public string Tag { get; set; }

        public Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Discipline(string title, int lectures, int exercises)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Course title cannot be empty.");
            }

            this.Title = title;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} lectures, {2} exercises", this.Title, this.Lectures, this.Exercises);
        }
    }

}
