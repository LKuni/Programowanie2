using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._2
{
    public interface IBohater
    {
        void BijWroga();
        void SprawdzHp();

    }

    abstract class Bohater : IBohater
    {
        protected int hp;
        protected int atak;
        protected Rasa rasa;
        public enum Rasa
        {
            Elf,
            Krasnolud,
            Hobbit,
            Człowiek
        }

        public void BijWroga()
        {
            Console.WriteLine("Zadanych obrażeń: " + this.atak);
        }
        public void SprawdzHp()
        {
            Console.WriteLine("Hp wynosi: " + this.hp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rzezimieszek Frodo = new Rzezimieszek(Bohater.Rasa.Hobbit);
            Wojownik Aragorn = new Wojownik(Bohater.Rasa.Człowiek);
            Wojownik Gimli = new Wojownik(Bohater.Rasa.Krasnolud);

            Frodo.BijWroga();
            Frodo.SprawdzHp();

            Aragorn.RzucToporem();
            Aragorn.SprawdzHp();

            Gimli.BijWroga();
            Gimli.RzucToporem();
            Gimli.SprawdzHp();

            Console.WriteLine("Zwycięstwo!");
            Console.ReadLine();
        }
    }

}
