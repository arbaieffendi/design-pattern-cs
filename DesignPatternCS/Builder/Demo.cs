using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCS.Builder
{
    class Demo : DemoBase
    {
        public override void Run()
        {
            Person person1 = new Person("Arba`i", "Effendi", "27");

            //Person person2 = new PersonBuilder();

            //Console.WriteLine(JsonConvert.SerializeObject(person1));
        }
    }
}
