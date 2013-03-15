using System;


namespace OOPPrinciplesPartI
{
    public abstract class PersonInSchool
    {
        public string FirstName { get; private set; }


        public string LastName { get; private set; }


        protected PersonInSchool(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.");
            }

            if (String.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be empty.");
            }


            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}\n\rLast name: {1}\n\r", this.FirstName, this.LastName);
        }
    }
}