using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Game
{
    public class GameManager:IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine(game.GameName +" adlı oyun eklendi");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi");
        }

        public void Delete(Games game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi");
        }
    }
}
