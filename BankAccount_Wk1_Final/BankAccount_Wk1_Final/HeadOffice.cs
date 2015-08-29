using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Wk1_Final
{
    public class HeadOffice
    {
        public string bankName;
        public string address;
        public Branch branch;
        public List<Branch> branchList;

        public HeadOffice(string bankName, string address, List<Branch> branchList)
        {
            if (branchList.Count < 1)
            {
                throw new Exception();
            }
            
            this.bankName = bankName;
            this.address = address;
            this.branchList = branchList;
        }
    }
}
