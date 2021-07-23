using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    class PersonBuilder
    {
        private string firstname;
        private string lastname;
        private string age;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Age { get => age; set => age = value; }

        public Person Build()
        {
            return new Person(Firstname, Lastname, Age);
        }
    }
}
