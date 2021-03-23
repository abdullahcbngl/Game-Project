using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName+"listeye başarıyla eklendi.");
        }
        
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "listeden başarıyla kaldırıldı.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + "listede güncellendi.");
        }
    }
}
