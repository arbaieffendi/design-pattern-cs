using System;

namespace DesignPatternConsole.Facade
{
    internal class Loan
    {
        internal bool HasBlackListFlag(Customer customer)
        {
            Console.WriteLine($"Check if {customer.Name} are in blacklist");
            return false;
        }
    }
}