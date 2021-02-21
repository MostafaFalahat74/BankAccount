using BankAccount.Controller;
using BankAccount.Models;
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
            int AccountDeposit;
            int AccountInventory;
            bool permissionToBuildAccount;
            Operations operations = new Operations();
            int userChoice;


          //  string userName;
            string aAccountNumber;
            int accountDeposit;
            int nationalCard;
            int inventory;
            int amountMoneyDeposit;
            int age;
            while (true)
            {

                Console.WriteLine("1 : For Create Account  ");
                Console.WriteLine("2 : For Deposit To Account  ");
                Console.WriteLine("3 : For View Inventory  ");
                Console.WriteLine("4 : For Delete Account  ");
                userChoice = Int32.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        //operations.GetUserInformation();

                        Console.WriteLine("Plese Enter User Name");
                        userName = Console.ReadLine();

                        Console.WriteLine("Plese Enter National Card");
                        nationalCard = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Plese Enter Age");
                        age = Int32.Parse(Console.ReadLine());


                       // Age = operations.GetUserAge();
                        permissionToBuildAccount = operations.CheckUserAge(age);
                        if (permissionToBuildAccount)
                        {
                            // operations.GetUserInventory();
                            Console.WriteLine("Plese Enter Inventory");
                            inventory = Int32.Parse(Console.ReadLine());
                            User user= operations.CreateNewUser(userName , nationalCard , age , inventory);
                            //  operations.ShowUser();
                            Console.WriteLine("  name : " + user.UserName + "  AccountId : " + user.NationalCard + "  Inventory :  " + user.Inventory);
                        }
                        else
                        {
                            //  operations.ShowUserPermissionError();
                            Console.WriteLine("  your age has under 18");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 2:
                        Console.Clear();
                        AccountDeposit = operations.GetAccount();
                        int AccountIndex = operations.CheckAccountExist(AccountDeposit);
                        if (AccountIndex!= -1)
                        {
                            operations.DepositMoneyToAccount();
                            Console.Clear();
                            operations.ShowUser();
                            Console.ReadKey();
                        }
                        else
                        {
                            operations.AccountIsNotExist();
                        }

                        break;

                    case 3:
                         Console.Clear();
                      //  AccountInventory = operations.GetAccount();
                         Console.WriteLine("Plese Enter Account to Deposit money");
                         accountDeposit = Int32.Parse(Console.ReadLine());
                         int AccountExist = operations.CheckAccountExist(accountDeposit);
                       
                        if (AccountExist>0)
                        {
                            operations.ShowInventory(AccountExist);
                        }
                        else
                        {
                            Console.WriteLine("the account is dont exist");
                        }
                        
                        break;

                    case 4:
                        Console.Clear();
                        // var AccountForDelete = operations.GetAccount();
                        Console.WriteLine("Plese Enter Account to Deposit money");
                        accountDeposit = Int32.Parse(Console.ReadLine());
                        int AccountForDeleteExist = operations.CheckAccountExist(accountDeposit);
                        if (AccountForDeleteExist>0)
                        {
                            operations.DeleteAccount(AccountForDeleteExist);
                            Console.Clear();
                            Console.ReadKey();
                        }
                        else
                        {
                            operations.AccountIsNotExist();
                          
                        }
                        break;
                }

            }

        }

    }
}

