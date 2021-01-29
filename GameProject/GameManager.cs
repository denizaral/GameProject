using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Game Added.");
            
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Game Deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Game Updated.");
        }
    }
}
