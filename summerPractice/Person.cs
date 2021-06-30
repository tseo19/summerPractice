using System;
using System.Collections.Generic;
using System.Text;

namespace summerPractice
{
    class Person
    {
        string firstName;
        string lastName;
        int id;

        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        public string LastName => this.lastName;
        public string FirstNaame => this.firstName;
        public int Id => this.id
        public override string ToString()
        {
            return this.id + " " + this.firstName + " " + this.lastName;
        }
    }
}
