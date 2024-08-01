using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.BirthYear == 1999 && gamer.FirstName=="Tuğçe" && gamer.LastName=="Özelmaci" && gamer.IdentityNumber==1278)
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
