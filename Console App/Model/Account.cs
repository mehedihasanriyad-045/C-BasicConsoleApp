using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Model
{
    internal class Account
    {

        private int accountNumber;
        private string accountHolderName;
        private decimal accountBalance;
        private decimal interestRate;


        public int AccountNumber
        {
            get { return accountNumber; } 
            set {  accountNumber = value; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        // Constructor with all properties as parameters
        public Account(int accountNumber, string accountHolderName, decimal accountBalance, decimal interestRate)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountBalance = accountBalance;
            this.interestRate = interestRate;
        }

       
    }
}
