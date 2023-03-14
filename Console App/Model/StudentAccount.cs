using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Model
{
    internal class StudentAccount : Account , AccountService
    {

        private string institutionName;
        private int validity;

        public string InstitutionName
        {
            get { return institutionName; }
            set { institutionName = value; }
        }

        public int Validity
        {
            get { return validity; }
            set { validity = value; }
        }

        public StudentAccount(int accountNumber, string accountHolderName, 
            decimal accountBalance, decimal interestRate, string institutionName, 
            int validity) : base(accountNumber, accountHolderName, accountBalance, interestRate)
        {
            this.institutionName = institutionName; 
            this.validity = validity;
        }

        public override string ToString()
        {
            string details = string.Empty;


            details = "Account No: \t"+ AccountNumber +"\n Name : \t" + this.AccountHolderName + "\nAccount Type : \tStudent Account" +
                    "\nInstitution Name : \t"+InstitutionName+"\nBalance : \t"+AccountBalance+"\nValidity : \t"+Validity+"\n";


            return details;
        }

        public void depositMoney(int money)
        {
            if(money > 0)
            {
                AccountBalance += money;

                Console.WriteLine("Balance Updated Successfully");
                Console.WriteLine($"Balance is  : \t {AccountBalance}");
            }
            else
            {
                Console.WriteLine("Please, Deposit Valid Amount");
            }
        }
    }
}

/*
 
 * */
