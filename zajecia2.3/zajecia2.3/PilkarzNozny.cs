﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._3
{
    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public void StrzelGola() { }
    }
}
