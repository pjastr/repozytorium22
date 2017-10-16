using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Osoba
    {
        internal string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

        public string Przedrostek()
        {
            if (plec == "M")
                return "Pan";
            else
                return "Pani";
        }
        public double Bmi()
        {
            return waga / (wzrost * wzrost);

            //if (Bmi() > 18.5) Console.WriteLine("Bmi prawidlowe");
          
        }
        public void info2()
        {
            if (Bmi() > 18.5 && Bmi() < 24.99) Console.WriteLine("Bmi prawidlowe");
            else Console.WriteLine("Bmi nieprawidlowe");
        }
    }
}
