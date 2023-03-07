using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace _01
{
    static class Rozszerzenia // Metody rozszerzajace
    {
        public static int Silnia(this int x)
        {
            int output = 1;
            while (x > 1)
                output *= x--; // w tym miejscu najpierw output jest mnożony przez x,
                               // potem x zmniejsza sie o 1
            return output;
        }
        // int liczba = 3;
        // Console.WriteLine(liczba.Silnia()); zwróci 6

        public static double Potega(this double x, int n)
        { // bardzo sprytny kod przekopiowany prosto ze skryptu
            double p = 1;
            for (int i = 0; i < (n < 0 ? -n : n); i++)
                p *= x;
            return n < 0 ? 1 / p : p;
        }
        // double d = 3;
        // Console.WriteLine(d.Potega(3)); zwróci 27, czyli 3^3;
    }
}
/* 
 * Wytłumaczenie retrun n < 0 ? 1 / p : p;
 * 
 * Jest to to samo co:
 * if (n < 0) 
 *     return 1 / p;
 * else 
 *     return p;
 * 
 * Składnia jest taka: (zapytanie) ? (wartosc jak prawda) : (wartosc jak falsz);
 */