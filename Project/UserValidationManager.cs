using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.ID==1 && gamer.BirthYear == 1985 && gamer.FirstName == "Ahmet" && gamer.LastName == "Kaya" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            }
           
       
    }
}
