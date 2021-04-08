using System;
using GameHouse.Abstract;
using GameHouse.Abstract.CampaignOperations;
using GameHouse.Abstract.GameOperations;
using GameHouse.Abstract.UserOperations.ValidationOperations;
using GameHouse.Entities;
using GameHouse.Entities.GameEntities;

namespace GameHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisCheckManager());
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Aytuğ";
            customer1.LastName = "YEŞİLYURT";
            customer1.BirthYear = new DateTime(1996,5,8);
            customer1.NationalNumber = 37700130416;
            customer1.CardNumber = "1111-1111-1111-1111-1111";
            customer1.UserName = customer1.FirstName + " " + customer1.LastName;
            
            userManager.Save(customer1);

            Console.Write("\nOYUN SATIN ALMAK İÇİN BİR TUŞA BASINIZ...");
            Console.ReadLine();
            

            GamerManager gamerManager = new GamerManager();
            GameCompany gameCompany1 = new GameCompany();
            gameCompany1.Id = 1;
            gameCompany1.GameName = "Red Dead Redemption 2";
            gameCompany1.GameCategory = "Aksiyon, Savaş, Cinsellik";
            gameCompany1.ReleaseDate = new DateTime(2018, 10, 26);
            gameCompany1.CompanyName = "ROCKSTAR GAMES";
            GameCompany gameCompany2 = new GameCompany();
            gameCompany2.GameName = "GTA V";
            GameCompany gameCompany3 = new GameCompany();
            gameCompany3.GameName = "L.A. Noire";

            CampaignManager campaignManager = new CampaignManager();
            
            gamerManager.Buy(gameCompany1,customer1);
            Console.Write("\nOYUN İNDİRİMİ ALMAK İÇİN BİR TUŞA BASINIZ...");
            Console.ReadLine();
            campaignManager.SummerSale(gameCompany1, gameCompany2, gameCompany3);


            Console.ReadLine();

        }
    }
}
