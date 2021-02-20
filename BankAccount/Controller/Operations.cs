using BankAccount.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Controller
{
  public  class Operations
    {
        User user = new User();
         string userName;
         string AccountNumber;
         int Inventory;
         int Age;
        public  void GetUserInformation()
        {
            Console.WriteLine("Plese Enter User Name");
            userName = Console.ReadLine();


            Console.WriteLine("Plese Enter Age");
            Age = Int32.Parse(Console.ReadLine());

           

        }

        public void GetUserInventory()
        {

            Console.WriteLine("Plese Enter Inventory");
            Inventory = Int32.Parse(Console.ReadLine());
        }

        public void CreateNewUser()
        {
            Guid id = new Guid();
            user.Age = Age;
            user.Inventory = Inventory;
            user.UserName = userName;
            user.Id = id.ToString();
        }
        public void ShowUserPermissionError()
        {
            Console.WriteLine("  your age has under 18");
        }
        public void ShowUser()
        {
            Console.WriteLine("name : "+ user.UserName + "AccountId : " + user.Id + "Inventory :" + user.Inventory);
        }

        public int GetUserAge()
        {
            return Age;
        }

        public  bool CheckUserAge(int age)
        {
            bool result = true;
            if (age<18)
            {
                result = false;
            }
            return result;
        }
    }
}
