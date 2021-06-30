using System;
using System.Collections.Generic;
using System.Text;

namespace summerPractice
{
    class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string LastName => this.lastName;
        public string FirstNaame => this.firstName;
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
