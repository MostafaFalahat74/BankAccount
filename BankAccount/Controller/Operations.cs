using BankAccount.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Controller
{
    public class Operations
    {
        List<User> users = new List<User>();



        public void DeleteAccount(int index)
        {
            users[index] = null;

        }
        public int ShowInventory(int id)
        {
            return users[id].Inventory;
        }

        public void DepositMoneyToAccount(int index, int money)
        {
            users[index].Inventory += money;
        }
        public int CheckAccountExist(int deposit)
        {
            int index = -1;

            for (int i = 0; i < users.Count; i++)
            {
                if (deposit == users[i].NationalCard)
                {
                    index = i;
                }
            }


            return index;

        }

        public User CreateNewUser(string userName, int nationalCard, int age, int inventory)
        {
            User user = new User()
            {
                Inventory = inventory,
                Age = age,
                NationalCard = nationalCard,
                UserName = userName,
                AccountNumber= nationalCard
            };
            users.Add(user);
            return user;

        }
        public User GetUser(int index)
        {
            return users[index];
        }

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
