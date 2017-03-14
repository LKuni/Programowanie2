using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._2
{
    class Wojownik : Bohater
    {
        public Wojownik(Rasa rasa)
        {
            this.hp = 500;
            this.atak = 100;
            this.rasa = rasa;
        }
        public void RzucToporem()
        {
            Console.WriteLine("Zadanych obrażeń toporem: 150.");
        }
    }
}
