using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoPracownikach
{
    public enum Skutecznosc
    {
        ZADEN = 0,
        SLABY = 1,
        SREDNI = 2,
        DOBRY = 3,
        WYBITNY = 4
    }

    public class Inzynier
    {
        private string imie = "NULL";
        private string nazwisko = "NULL";
        private Skutecznosc skutecznosc = Skutecznosc.ZADEN;
        private int LiczbaProjektow = 0;
        public void Przyjmij(string imie, string nazwisko, Skutecznosc skutecznosc) // Zadanie 1
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.skutecznosc = skutecznosc;
            this.LiczbaProjektow = 0; // Zadanie 3
            Console.WriteLine($"Inzynier {imie} {nazwisko} zostal przyjety do pracy z skutecznoscia {skutecznosc} i liczba projektow 0.");
        }

        public int Buduj() // Zadanie 1
        {
            Console.WriteLine($"Inzynier {imie} {nazwisko} buduje projekt...");
            int projektyDoDodania = (int)skutecznosc + 1;
            LiczbaProjektow += projektyDoDodania;
            return LiczbaProjektow;
        }
        public void Pokaz() // Zadanie 1
        {
            Console.WriteLine($"Inzynier {imie} {nazwisko} zrealizowal {LiczbaProjektow} projektow.");
        }

        public void Porownaj(
               (string imie, string nazwisko, int liczbaprojektow, Skutecznosc skutecznosc) pracownik1,
               (string imie, string nazwisko, int liczbaprojektow, Skutecznosc skutecznosc) pracownik2)
        {

            if (pracownik1.skutecznosc > pracownik2.skutecznosc)
            {
                Console.WriteLine($"{pracownik1.imie} {pracownik1.nazwisko} jest bardziej skuteczniejszy od {pracownik2.imie} {pracownik2.nazwisko}.");
            }
            else if (pracownik1.skutecznosc < pracownik2.skutecznosc)
            {
                Console.WriteLine($"{pracownik2.imie} {pracownik2.nazwisko} jest bardziej skuteczniejszy od {pracownik1.imie} {pracownik1.nazwisko}.");
            }
            else
            {
                if (pracownik1.liczbaprojektow > pracownik2.liczbaprojektow)
                {
                    Console.WriteLine($"{pracownik1.imie} {pracownik1.nazwisko} jest lepszy od {pracownik2.imie} {pracownik2.nazwisko} o {(pracownik1.liczbaprojektow) - (pracownik2.liczbaprojektow)} projektow.");
                }
                else if (pracownik1.liczbaprojektow < pracownik2.liczbaprojektow)
                {
                    Console.WriteLine($"{pracownik2.imie} {pracownik2.nazwisko} jest lepszy od {pracownik1.imie} {pracownik1.nazwisko} o {(pracownik2.liczbaprojektow) - (pracownik1.liczbaprojektow)} projektow.");
                }
                else
                {
                    Console.WriteLine("Pracownicy sa rowni.");
                }
            }
        }

        public Skutecznosc Awansuj() // Zadanie 3
        {
            if (skutecznosc < Skutecznosc.WYBITNY && LiczbaProjektow >= (int)skutecznosc*5)
            {
                skutecznosc++;
                Console.WriteLine($"Inzynier {imie} {nazwisko} awansowal na skutecznosc {skutecznosc}.");
            }
            else
            {
            }
            return skutecznosc;
        }
    }
}