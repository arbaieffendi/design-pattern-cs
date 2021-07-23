using System;

namespace DesignPatternConsole.Facade
{
    internal class Bank
    {
        internal bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"Check bank account for {customer}");
            return true;
        }
    }
}