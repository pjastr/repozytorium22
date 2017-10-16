using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1976;
            dyrektor.plec = "M";
            Console.WriteLine(dyrektor.Przedrostek() + " " + dyrektor.imie + " " + dyrektor.nazwisko + " " + dyrektor.ObliczWiek());
            Osoba pacjent = new Osoba();
            pacjent.imie = "Krzysztof";
            pacjent.nazwisko = "Nowak";
            pacjent.wzrost = 175;
            pacjent.waga = 70;
            pacjent.info2();
            Console.ReadKey();
        }
    }
}
