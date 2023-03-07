using System;
using System.Collections.Generic;
using System.Text;

namespace _01
{
    // Właściwości Get, Set wykorzystuje się do ograniczenia dostępu do zmiennej
    // GET NIGDY NIE MOŻE ZWRACAĆ WYJĄTKU!!!
    class GetSet
    {
        public GetSet(int zmienna1, int zmienna2, int Zmienna3)
        {
            this.zmienna1 = zmienna1;
            this.zmienna2 = zmienna2;
            this.Zmienna3 = Zmienna3;
        }
        public GetSet() : this(0, 0, 0) { }

        private int zmienna1;
        public int Zmienna1 // zmienna read-only
        {
            get { return zmienna1; }
        }

        private int zmienna2;
        public int Zmienna2
        {
            set { zmienna2 = value; } // zmienna write-only
        }
        // !!!! WAŻNE !!!!!
        // Ogólnie zmienne powinny mieć implementacje get albo get oraz set, nigdy samo set
        // tutaj jest tylko dla pokazania

        // Można wykorzystać domyślne metody get oraz set
        // public int Zmienna3 { get; set; }
        public int Zmienna3 { get; } // publiczna zmienna której wartość można odczytać 
                                     // ale nie można przypisać => getSet.Zmienna3 = 10 - ERROR!!!

        // W dwóch pierwszych przypadkach publiczne są tylko właściwości zmiennej,
        // a sama zmienna jest prywatna, za to w 3 przypadku zmienna jest publiczna ale read-only
    }
}
