using BankAccount.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Controller
{
    public class Operations
    {
        List<User> users = new List<User>();
        string userName;
        string aAccountNumber;
        int accountDeposit;
        int nationalCard;
        int inventory;
        int amountMoneyDeposit;
        int age;

        public void AccountIsNotExist()
        {
            Console.WriteLine("The Account Does Not Exist ");
        }
        public void DeleteAccount(int index)
        {
            users[index] = null;
            //user = null;
            //  Console.WriteLine("Account deleted");
        }
        public int ShowInventory(int id)
        {
            return users[id].Inventory;
           // Console.WriteLine(user.Inventory);
        }

        public void DepositMoneyToAccount()
        {
            Console.WriteLine("Plese Enter User amount of money to deposit");
            amountMoneyDeposit = Int32.Parse(Console.ReadLine());
           // user.Inventory = user.Inventory + amountMoneyDeposit;
        }
        public int CheckAccountExist(int deposit)
        {
           // bool result = false;
            int index = -1;

            for(int i=0; i<users.Count; i++)
            {
                if (deposit == users[i].NationalCard)
                {
                    index = i;
                }
            }
           

            return index;
            
        }
/*

        public void GetUserInformation()
        {
            Console.WriteLine("Plese Enter User Name");
            userName = Console.ReadLine();

            Console.WriteLine("Plese Enter National Card");
            nationalCard = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Plese Enter Age");
            age = Int32.Parse(Console.ReadLine());



        }
        */
        public int GetAccount()
        {
            Console.WriteLine("Plese Enter Account to Deposit money");
            accountDeposit = Int32.Parse(Console.ReadLine());
            return accountDeposit;
        }
        /*
        public void GetUserInventory()
        {

            Console.WriteLine("Plese Enter Inventory");
            inventory = Int32.Parse(Console.ReadLine());
        }
        */
        public User CreateNewUser(string userName ,int nationalCard ,int age ,int inventory)
        {
            //  Guid id = new Guid();
            User user = new User()
            {
            Inventory=inventory,
            Age=age,
            NationalCard=nationalCard,
            UserName=userName
            };
            users.Add(user);
            return user; 
            
        }
        public void ShowUserPermissionError()
        {
            Console.WriteLine("  your age has under 18");
            Console.ReadKey();
            Console.Clear();
        }
        public void ShowUser()
        {
            Console.WriteLine("  name : " + userName + "  AccountId : " + nationalCard + "  Inventory :  " + inventory);
        }
        /*
        public int GetUserAge()
        {
            return age;
        }
        */
        public bool CheckUserAge(int age)
        {
            bool result = true;
            if (age < 18)
            {
                result = false;
            }
            return result;
        }
    }
}
