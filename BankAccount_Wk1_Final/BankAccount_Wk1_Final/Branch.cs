using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class Branch
    {
        public string address;
        public string manager;
        public HeadOffice headOffice;
        private BankAccount bankAccount;
        
        public Branch(string address, string manager, HeadOffice headOffice, BankAccount bankAccount)
        {
            this.address = address;
            this.manager = manager;
            this.headOffice = headOffice;
            this.bankAccount = bankAccount;
        }

    }
}
