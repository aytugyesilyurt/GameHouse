using System;
using GameHouse.Abstract;
using GameHouse.Abstract.UserOperations.ValidationOperations;
using GameHouse.Entities;

namespace GameHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisCheckManager());
            User customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Aytuğ";
            customer1.LastName = "YEŞİLYURT";
            customer1.BirthYear = new DateTime(1111,1,1);
            customer1.NationalNumber = 11111111111;

            userManager.Save(customer1);

            Console.ReadLine();

        }
    }
}
