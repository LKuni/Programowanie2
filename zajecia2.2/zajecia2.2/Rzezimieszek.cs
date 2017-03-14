using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._2
{
    class Rzezimieszek : Bohater
    {
        private int energia;

        public Rzezimieszek(Rasa rasa)
        {
            this.hp = 200;
            this.atak = 300;
            this.rasa = rasa;
            this.energia = 100;
        }

    }
}
