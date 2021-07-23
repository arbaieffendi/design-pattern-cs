using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    class Demo
    {
        public static void run()
        {
            Person person1 = new Person("Arba`i", "Effendi", "27");

            //Person person2 = new PersonBuilder();

            Console.WriteLine(JsonConvert.SerializeObject(person1));
        }
    }
}
