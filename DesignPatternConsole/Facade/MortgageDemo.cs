using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Facade
{
    class MortgageDemo : DemoBase
    {
        public override void Run()
        {
            Mortgage mortgage = new Mortgage();

            // check eligibility of customer

            Customer customer = new Customer("Arba");
            bool eligible = mortgage.IsEligible(customer, 125000);

            string status = eligible ? "Approved" : "Rejected";

            Console.WriteLine($"\n {customer.Name} application has been {status}");
        }
    }
}
