using System;

namespace DesignPatternCS.Facade
{
    internal class Bank
    {
        internal bool HasSufficientSavings(Customer customer, double amount)
        {
            Console.WriteLine($"Check bank account for {customer.Name}");
            return true;
        }
    }
}