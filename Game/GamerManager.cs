using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IGamerService
    {
        IRegisterService _registerService ;
        Messages _messages;
        public GamerManager(IRegisterService registerService,Messages messages)
        {
            _registerService = registerService;
            _messages =messages;
        }
        public void Add(Gamer gamer)
        {
            if (_registerService.RegisterPlayer(gamer))
            {
                Console.WriteLine(_messages.Eklendi);
            }
            else
            {
                Console.WriteLine(_messages.Eklenemedi);               
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_registerService.RegisterPlayer(gamer))
            {
                Console.WriteLine(_messages.Silindi);
            }
            
            Console.WriteLine(_messages.Bulunamadı);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(_messages.Guncellendi);
        }
    }
}
