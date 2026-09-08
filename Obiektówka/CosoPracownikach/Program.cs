
/*
 Note: Gemini z wyszukiwarki i wbudowany Github Copilot w Visual Studio ogólnie zostało zrealizowane tylko do powpowiedzenia tematyki skryptów, poprawki kodu i szybszego przepisywania go.
 */

using CosoPracownikach;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoPracownikach
{

    class Program
    {
        Inzynier inzynier = new Inzynier();
        List<(string imie, string nazwisko, int liczbaprojektow, Skutecznosc skutecznosc)> pracownicy =
            new()
            {
                    ("Larp", "Sahurski", 0, Skutecznosc.SLABY),
                    ("Ballerino", "Cappucino", 0, Skutecznosc.SREDNI),
                    ("Joffstein", "Diddcomb", 0, Skutecznosc.DOBRY),
                    ("King", "Brokul", 0, Skutecznosc.WYBITNY)
            };


        public void ZaaktualizujStatystyki()
        {
            int Liczbainzynierow = pracownicy.Count;
            int Wszystkieprojektyfirmy = 0;

            for (int i = 0; i < pracownicy.Count; i++)
            {
                Wszystkieprojektyfirmy += pracownicy[i].liczbaprojektow;
            }

            Console.WriteLine($"Liczba wszystkich zrealizowanych Projektow: {Wszystkieprojektyfirmy}");
            Console.WriteLine($"Srednia liczba projektow na inzyniera: {(double)Wszystkieprojektyfirmy / Liczbainzynierow}");

            var posortowani = pracownicy
                .OrderByDescending(x => x.liczbaprojektow)
                .ToList();

            var najlepszy = posortowani[0];
            var drugiNajlepszy = posortowani[1];

            Console.WriteLine(
                $"Najwiecej projektow: {najlepszy.imie} {najlepszy.nazwisko} - {najlepszy.liczbaprojektow}"
            );

            Console.WriteLine(
                $"Drugi najlepszy: {drugiNajlepszy.imie} {drugiNajlepszy.nazwisko} - {drugiNajlepszy.liczbaprojektow}"
            );
            Console.WriteLine(
                $"Różnica projektów: {(najlepszy.liczbaprojektow) - (drugiNajlepszy.liczbaprojektow)}"
            );
        }

        static void Main(string[] args) // Zadanie 2
        {
            Inzynier inzynier = new Inzynier();
            Program program = new Program();
            var pracownicy = program.pracownicy;

            for (int i = 0; i < pracownicy.Count; i++) // Zadanie 3
            {
                inzynier.Przyjmij(pracownicy[i].imie, pracownicy[i].nazwisko, pracownicy[i].skutecznosc);
                for (int j = 0; j < 6; j++)
                {
                    pracownicy[i] = (pracownicy[i].imie, pracownicy[i].nazwisko, inzynier.Buduj(), inzynier.Awansuj());
                }
                inzynier.Pokaz();
            }
            inzynier.Porownaj(pracownicy[0], pracownicy[1]);
            inzynier.Porownaj(pracownicy[3], pracownicy[2]);
            program.ZaaktualizujStatystyki(); // Zadanie 4
        }
    }
}

