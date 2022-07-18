using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;



        public Person(string firstName, string middleName, string lastName)
           : this(lastName, firstName)
        {

            this.middleName = middleName;


        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        

      

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}
