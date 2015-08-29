using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class SavingsAccount : BankAccount
    {
        SavingsAccount(int accountNo, decimal balance, Branch branch, Customer customer, Transaction transaction)
            : base(accountNo, balance, branch, customer, transaction)
        {
        }
        public decimal calculateCharges()
        {
            throw new NotImplementedException();
        }

        public decimal calculateInterest()
        {
            throw new NotImplementedException();
        }
    }
}
