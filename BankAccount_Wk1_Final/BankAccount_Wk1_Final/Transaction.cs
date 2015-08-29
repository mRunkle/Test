using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class Transaction
    {
        private decimal amount;
        private BankAccount bankAccount;

        public Transaction(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
    }
}
