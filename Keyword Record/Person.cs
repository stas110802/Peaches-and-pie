using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPega.Keyword_Record
{
    /// <summary>
    /// Immutable class
    /// </summary>
    internal record class Person
    {
        public Person(string name, int age)
        {
            (Name, Age) = (name, age);
        }
        public string Name { get; init; }
        public int Age { get; init; }
        /// <summary>
        /// Get object data as variables
        /// </summary>       
        public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
    }
}
