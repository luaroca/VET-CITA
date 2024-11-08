using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace GUI
{
    public class Bot
    {
        public static ITelegramBotClient _botClient;
        
        public Bot() 
        {
            _botClient = new TelegramBotClient("7763752688:AAEi2Z1B6Sc0g-uJ30ILEIdNBI65SLW32fE");
        }

        public string NombreId()
        { 
            var me = _botClient.GetMe().Result;


           return ($"Hi, I am {me.Id} and my name is: {me.FirstName} ");      
        }


            
    }
}
