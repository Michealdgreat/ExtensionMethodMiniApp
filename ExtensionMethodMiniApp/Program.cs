using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodMiniApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
          
            person.FirstName = "What is your First Name".RequestString();

            person.LastName = "What is your Last Name".RequestString();

            person.Age = "What is your age".RequestInt(0, 120);
           // person.Age = ConsoleHelper.RequestInt("What is your name", 0, 120);

            Console.ReadLine();
        }
    }
}
