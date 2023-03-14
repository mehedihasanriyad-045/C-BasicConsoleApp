using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Model
{
    internal class SavingAccount : Account, AccountService
    {

        private int targetMonth;
        private int target;
        private int perMonthSaving;

        public SavingAccount(int accountNumber, string accountHolderName, decimal accountBalance, 
            decimal interestRate, int targetMonth, int target, int perMonthSaving) : base(accountNumber, accountHolderName, accountBalance, interestRate)
        {
            this.targetMonth = targetMonth;
            this.target = target;
            this.perMonthSaving = perMonthSaving;

        }

        public int TargetMonth
        {
            get { return targetMonth; }
            set { targetMonth = value; }
        }
        public int PerMonthSaving
        {
            get { return perMonthSaving; }
            set { perMonthSaving = value; }
        }

        public int Target
        {
            get { return target; }
            set { target = value; }
        }

        public override string ToString()
        {
            string details = string.Empty;


            details = "Account No: \t" + AccountNumber + "\n Name : \t" + this.AccountHolderName + "\nAccount Type : \tSaving Account" +
                    "\nTarget : \t" + Target + "\nBalance : \t" + AccountBalance + "\nTarget Month : \t" + TargetMonth + "\n";


            return details;
        }

        public void depositMoney(int money)
        {
            if(money > 0 && money >= PerMonthSaving) {

                AccountBalance += money;

                Console.WriteLine("Balance Updated Successfully");
                Console.WriteLine($"Balance is  : \t {AccountBalance}");

            }
            else
            {
                Console.WriteLine("Please Deposit Valid Amount");
            }
            
            
        }


    }
}
