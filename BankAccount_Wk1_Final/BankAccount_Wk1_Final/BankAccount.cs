using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class BankAccount
    {
        private int accountNo;
        private decimal balance;
        private Branch branch;
        private Customer customer;
        private Transaction transaction;

        public BankAccount(int accountNo, decimal balance, Branch branch, Customer customer, Transaction transaction)
        {
            this.accountNo = accountNo;
            this.balance = balance;
            this.customer = customer;
            this.branch = branch;
            this.customer = customer;
            this.transaction = transaction;
        }

        public decimal returnBalance()
        {
            return this.balance;
        }

        public void updateBalance(decimal balance)
        {
            this.balance = balance;
        }
    }
}
