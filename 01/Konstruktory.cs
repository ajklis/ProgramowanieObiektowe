using System;
using System.Collections.Generic;
using System.Text;

namespace _01
{
    class Klasa1
    {
        public int PublicznePole;
        private int prywatnePole;
        
        // Konstruktory są wywoływane w momencie tworzenia instancji klasy
        // Zapisywane są w taki sposób
        public Klasa1()
        {
            PublicznePole = 1;
            prywatnePole = 10;
        } // Klasa1 pierwsza = new Klasa1();
        // Konstruktory mogą być przeciążone (mogą przyjmować inne parametry), i wtedy wykonuje się inna funkcja
        public Klasa1(int PublicznePole)
        {
            this.PublicznePole = PublicznePole;
            prywatnePole = 0; // ponieważ nie ma parametru prywatnePole w (..), to nie trzeba pisać this.
            // Użwyanie this. pozwala na odwołanie się do pola konkretnej instancji w przypadku 
            // kiedy występuje zmienna z tą samą nazwą
            // Dobrze jest nazyważ parametry konstruktora tak jak nazywa się pole w klasie
        } // Klasa1 druga = new Klasa1(5);

        // Jeżeli jest konstruktor, który robi dużo ciekawych rzeczy, a chcemy dodać jeden
        // parametr, to zamiast kopiowania i zmieniania kodu można zrobić coś takiego

        public Klasa1(int PublicznePole, int prywatnePole) : this(PublicznePole)
        {
            this.prywatnePole = prywatnePole;
            this.PublicznePole = -10; 
        }

        // Najpierw wykona się konstruktor podany po this, a dopiero później to co jest w {...}, więc
        // Klasa1 trzecia = new Klasa1(5, 10);
        // trzecia.PublicznePole wynosi -10 a nie 5, ponieważ jest nadpisane pole w {...}
        // trzecia.prywatnePole wynosi 10

        ~Klasa1() 
        {
            // To jest destruktor klasy, wywoływany jest automatycznie kiedy instancja klasy jest
            // już niepotrzebna
            Console.WriteLine("Usunięto instancje klasy1");
            // Klasa1 klasa1 = new Klasa1();
            // klasa1 = null; <- tutaj już ta instancja Klasy1 nie jest potrzebna,
            // więc w konsoli zostanie napisane "Usunięto instancje klasy1"
        }

    }
}
