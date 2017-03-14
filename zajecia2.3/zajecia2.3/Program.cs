using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba ktoś = new Osoba("Robert". "Lewandowski", "1980");

            Ocena pięć = new Ocena("Matma", "2017.07.02", 5);
            Student student1 = new Student("Kasia", "S", "2000", 1, 2, 123456);


            PilkarzNozny RobertLewandowski = new PilkarzNozny("Robert", "Lewandowski", "1980", "napastnik", "X");
        }
    }
}
