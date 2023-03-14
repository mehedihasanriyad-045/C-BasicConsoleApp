using Console_App;
using Console_App.Model;
using System;

namespace ConsoleApp
{

    class consoleApp
    {
        public static void Main(string[] args)
        {

            string input;

            Console.WriteLine("Hello Welcome!!");

            Console.WriteLine("What Type of Account you want to create?\n\n\t1. Student \t 2.Saving Account\n");

            Console.WriteLine("Type 1 or 2.");

            input  = Console.ReadLine();


            int accountType;

            

            if (int.TryParse(input, out accountType))
            {

                int accountNumber = RandomNumberGenerator.Generate();

                

                if (accountType == 1)
                {
                    Console.WriteLine("Create Your Student Account\n");


                    Console.Write("Put Your Name Here : ");
                    string accountHolderName = Console.ReadLine();

                    Console.Write("Put Your Institution Name Here : ");
                    string institutionName = Console.ReadLine();

                    StudentAccount account = new StudentAccount(accountNumber, accountHolderName, 0, 5, institutionName, 4);


                    Console.WriteLine("Account Creation Done.\n");

                    Console.WriteLine(account.ToString());

                    Console.Write("Deposit Some Money For The First Time : ");
                    input = Console.ReadLine();

                    int deposit;

                    if (int.TryParse(input, out deposit))
                    {

                        account.depositMoney(deposit);

                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }





                }
                else if(accountType ==  2)
                {
                    Console.WriteLine("Create Your Saving Account");

                    Console.Write("Put Your Name Here : ");
                    string accountHolderName = Console.ReadLine();
                    

                    int targetMonth, target, perMonthSaving;
                    string targetMonth_str, target_str, perMonthSaving_str;


                    Console.Write("Put You Target Here : ");
                    target_str = Console.ReadLine();

                    Console.Write("Put You Target Month Here : ");
                    targetMonth_str = Console.ReadLine();

                    Console.Write("Put You Target Per Month Savings Here : ");
                    perMonthSaving_str = Console.ReadLine();

                    if(int.TryParse(targetMonth_str, out targetMonth) && int.TryParse(target_str, out target) && int.TryParse(perMonthSaving_str, out perMonthSaving))
                    {
                        SavingAccount account = new SavingAccount(accountNumber, accountHolderName, 0,5,targetMonth, target, perMonthSaving);

                        Console.WriteLine("Account Creation Done.\n");

                        Console.WriteLine(account.ToString());

                        Console.Write("Deposit Some Money For The First Time : ");

                        input = Console.ReadLine();

                        int deposit;

                        if (int.TryParse(input, out deposit))
                        {

                            account.depositMoney(deposit);

                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                        }

                    }


                }

                



            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Application Closing....");
                return;
            }


        }
    }

}