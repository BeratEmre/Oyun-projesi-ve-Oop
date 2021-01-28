using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class RegisteredManager: IRegisterService
    {
       
        public bool RegisterPlayer(Gamer gamer)
        {
            if (gamer.Name=="Berat"&& gamer.LastName=="Bayraktar"&&gamer.IdentityNumber==123456 && gamer.Birthday=="08/03/1996")
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
