using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManager
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
                Console.WriteLine("Doğrulama başarısız");
           
        }

        public void Delete(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt güncellendi.");
            }
            else
                Console.WriteLine("Doğrulama başarısız");

        }

        public void Update(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt silin.");
            }
            else
                Console.WriteLine("Doğrulama başarısız");

        }
    }
}
