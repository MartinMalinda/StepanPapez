using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETApp.Models
{
    public class Greeting
    {
        private string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};
        public long Id { get; set; }
        public string Content { get; set; }
        private static long callCount;
        public long CallCount
        {
            get
            {
                return callCount;
            }
        }

        public Greeting()
        {
            callCount++;
            Id = callCount;
            Content = "Hello World!";
        }

        public Greeting(string name)
        {
            callCount++;
            Id = CallCount;
            Content = name;
        }

        //public Greeting(long id, string content)
        //{
        //    //Id = id;
        //    //Content = content;
        //    callCount++;
        //    Id = callCount;
        //    Content = content;
        // }
    }
}
