using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Id = 101;
            game1.GameName = "101 Plus";
            game1.GameCategori = "Table Game";
            game1.GamePrice = 50;
            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignPercentDiscount = 50;
            campaign1.StartDate = new DateTime(2020, 11, 26);
            campaign1.EndDate = new DateTime(2021, 11, 27);


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            

            User gamer1 = new User();
            gamer1.Id = 6;
            gamer1.FirstName = "Deniz";
            gamer1.LastName = "Aral";
            gamer1.BirthYear = 1997;
            gamer1.IdentitiyNumber = 12345678901;

            GamerUserManager gamerUserManager = new GamerUserManager();
            gamerUserManager.Add(gamer1);
            

            Console.Read();
        }
    }
}
