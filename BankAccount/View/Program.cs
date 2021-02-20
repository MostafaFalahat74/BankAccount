using BankAccount.Controller;
using System;

namespace BankAccount
{
    class Program
    {

      

        static void Main(string[] args)
        {
            string userName;
            string AccountNumber;
            int Inventory;
            int Age;
            bool permissionToBuildAccount;
            Operations operations = new Operations();
            int userChoice;

            Console.WriteLine("1 : For Create Account  ");
            Console.WriteLine("2 : For Deposit To Account  ");
            Console.WriteLine("3 : For View Inventory  ");
            Console.WriteLine("4 : For Delete Account  ");
            userChoice=Int32.Parse( Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    operations.GetUserInformation();
                    Age = operations.GetUserAge();
                    permissionToBuildAccount = operations.CheckUserAge(Age);
                    if (permissionToBuildAccount)
                    {
                        operations.GetUserInventory();
                        operations.CreateNewUser();
                        operations.ShowUser();
                    }
                    else
                    {
                        operations.ShowUserPermissionError();
                    }

                break;

                case 2:
              
                break;

                case 3:
           
                break;

                case 4:
                
                break;
            }
                





        }
     
    }
}

