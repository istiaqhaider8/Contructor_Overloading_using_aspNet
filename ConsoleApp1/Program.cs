using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("Istiaq", "Hridon");
            string fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);

            Person bPerson = new Person("Istiaq", "Haider", "Hridon");
            string fullName1 = bPerson.GetFullName();
            Console.WriteLine(fullName1);



            Console.ReadKey();


        }
    }
}
