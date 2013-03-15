﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPPrinciplesPartI
{
    public class School
    {
        private SchoolClass[] classes;


        public School(SchoolClass[] classes)
        {
            this.Classes = classes;
        }


        public SchoolClass[] Classes
        {
            get { return this.classes; }
            set
            {
                if (value.Length > 0)
                {
                    this.classes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

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
    }
}
