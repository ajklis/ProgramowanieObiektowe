using System;

namespace _01
{
    // Wielką literą nazwy klas, publiczne pola w klasie itp
    // Małą literą prywatne pola w klasie oraz zmienne lokalne (w funkcji)
    // Stałe pisane CAPSEM, a w przypadku nazwy zawierającej kilka słów używa sie _

    class Klasa
    {
        // publiczne, prywatne pola
        public int PolePierwsze;
        private int poleDrugie;
        public const int POLE_STALE = 2137;

        // metody (funckje w klasach)
        public int MetodaPierwsza()
        {
            return 0;
        }
        private int metodaDruga()
        {
            return 1;
        }

        // Metody i pola statyczne
        // Wspólne dla klasy, nie należą do instancji, tzn:
        // Klasa instancja = new Klasa();
        // instancja.StatycznePole - nie zadziala
        // Klasa.StatycznePole - zadziala

        public static int StatycznePole;

        public static int StatycznaMetoda()
        {
            return StatycznePole;
            //return PolePierwsze; - nie zadziała 
        }

        // Statyczne zmienne można wykorzystywać w metodach niestatycznych, ale
        // niestatycznych pól nie można wykorzystywać w metodach statycznych
    }

    static class StatycznaKlasa
    {
        // W klasach statycznych mogą być tylko i wyłącznie statyczne metody oraz zmienne
        // Te klasy NIE MOGĄ mieć instancji
        // StatycznaKlasa statyczna = new StatycznaKlasa() - ERROR!!!
    }

}
