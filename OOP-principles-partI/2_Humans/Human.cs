﻿using System;


namespace Humans
{
    public abstract class Human
    {
        public string FirstName { get; private set; }


        public string LastName { get; private set; }


        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}