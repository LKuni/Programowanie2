using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._2
{
    class Mag : Bohater
    {
        private int mana;

        public Mag(Rasa rasa)
        {
            this.hp = 100;
            this.atak = 200;
            this.rasa = rasa;
            this.mana = 300;
        }

        public void RzucCzar()
        {
            Console.WriteLine("Zadanych obrażeń poprzez czar: 250.");
        }
    }

    
}
