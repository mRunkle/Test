using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class Customer
    {
        private string name;
        private string address;
        private BankAccount bankAccount;

        public Customer(string name, string address, BankAccount bankAccount)
        {
            this.name = name;
            this.address = address;
            this.bankAccount = bankAccount;
        }
    }
}
