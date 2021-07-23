using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Facade
{
    class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        internal bool IsEligible(Customer customer, int amount)
        {
            bool eligible = true;
            
            //check customer saving, bad loan history, good credit
            if (!bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            
            if (loan.HasBlackListFlag(customer))
            {
                eligible = false;
            }
            
            if (credit.HasCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
