using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPega.Keyword_Record
{
    public class CutomRecord
    {
        public CutomRecord()
        {
            
        }

        public void Start()
        {
            Console.WriteLine("First example: ");
            var person = new Person("Stanislav", 19);// create immutable object

            var (name, age) = person;// Deconstruct object data
            Console.WriteLine("{0} and {1}\n", name, age);
            //person.Name = "Vladimir";// ERROR!
            // т.к. вместо 'set' стоит 'init'

            Console.WriteLine("Second example: ");
            var tom = new Person("Tom", 37);
            var sam = tom with { Name = "Sam" };// Sam will have the same parameters except for the name ( because he is Sam :D )           
            PrintPesonInfo(tom, sam);


            var person1 = new Person("Vova", 44);
            var person2 = new Person("Vova", 44);
            Console.WriteLine(person1.Equals(person2)); // true
            Console.WriteLine(person1 == person2);//the same

            // without record keyword return false
            // because in the 'Class' we are comparing addresses
        }

        private static void PrintPesonInfo(params Person[] persons)
        {
            foreach (var user in persons)
            {
                Console.WriteLine($"name: {user.Name}\nage: {user.Age}");
                Console.WriteLine();
            }
        }
    }

    /*
        record - неизменяемый (immutable) тип 
    */
}
