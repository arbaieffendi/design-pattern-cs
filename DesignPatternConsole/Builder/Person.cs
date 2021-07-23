using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string age;

        public Person(string firstname, string lastname, string age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Age { get => age; set => age = value; }
    }
}
