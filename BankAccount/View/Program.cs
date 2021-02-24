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
            bool permissionToBuildAccount;
            Operations operations = new Operations();
            string userChoice;
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
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":

                        Console.WriteLine("Plese Enter User Name");
                        userName = Console.ReadLine();

                        Console.WriteLine("Plese Enter National Card");                    
                        nationalCard = Int32.Parse(Console.ReadLine());
                      
                        Console.WriteLine("Plese Enter Age");
                        age = Int32.Parse(Console.ReadLine());

                        permissionToBuildAccount = operations.CheckUserAge(age);
                        if (permissionToBuildAccount)
                        {
                            Console.WriteLine("Plese Enter Inventory");
                            inventory = Int32.Parse(Console.ReadLine());
                            User user = operations.CreateNewUser(userName, nationalCard, age, inventory);
                            Console.Clear();
                            Console.WriteLine("  Name : " + user.UserName + "  Account Number : " + user.NationalCard + "  Inventory :  " + user.Inventory);
                        }
                        else
                        {
                            Console.WriteLine("  your age has under 18 ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(" please enter father name ");
                            string fatherName = Console.ReadLine();


                            Console.WriteLine(" please enter father age ");
                            int fatherAge = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Plese Enter Inventory");
                            inventory = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            if (fatherAge>18)
                            {
                                User user = operations.CreateNewUser(userName, nationalCard, age, inventory);
                                Console.WriteLine("  Name : " + user.UserName + "  Account Number : " + user.NationalCard + "  Inventory :  " + user.Inventory);
                            }
                            else
                            {
                                Console.WriteLine(" sorry father age under 18");
                            }
                        }
                     

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account to Deposit money");
                        int accountNumber = Int32.Parse(Console.ReadLine());
                        int accountIndex = operations.CheckAccountExist(accountNumber);
                        if (accountIndex != -1)
                        {
                            Console.WriteLine("Plese Enter User amount of money to deposit");
                            amountMoneyDeposit = Int32.Parse(Console.ReadLine());
                            operations.DepositMoneyToAccount(accountIndex, amountMoneyDeposit);
                            Console.Clear();
                            var user = operations.GetUser(accountIndex);

                            Console.WriteLine("  Name : " + user.UserName + "  AccountId : " + user.NationalCard + "  Inventory :  " + user.Inventory);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The Account Does Not Exist ");
                        }
                        Console.Clear();

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account Number");
                        accountDeposit = Int32.Parse(Console.ReadLine());
                        int accountExist = operations.CheckAccountExist(accountDeposit);

                        if (accountExist != -1)
                        {
                            Console.Clear();
                            Console.WriteLine(operations.ShowInventory(accountExist));
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("the account is dont exist");
                        }
                     

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account to Deposit money");
                        int account = Int32.Parse(Console.ReadLine());                       
                        int accountForDeleteExist = operations.CheckAccountExist(account);
                        if (accountForDeleteExist != -1)
                        {
                            operations.DeleteAccount(accountForDeleteExist);
                        
                            Console.Clear();
                            Console.WriteLine("Account deleted");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Account Does Not Exist ");                         
                        }
                       
                        break;
                }

            }

        }

    }
}

