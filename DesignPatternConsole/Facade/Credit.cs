using System;

namespace DesignPatternConsole.Facade
{
    internal class Credit
    {
        internal bool HasCredit(Customer customer)
        {
            Console.WriteLine($"Check if {customer.Name} still has credit");
            return false;
        }
    }
}