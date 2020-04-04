using System;

namespace sibenice01
{
    class Program
    {
        //funkce
        static void _1()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n XXXXXX\nXXXXXXXX");
        }
        static void _2()
        {
            Console.WriteLine("");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _3()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _4()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X");
            Console.WriteLine("   XX X");
            Console.WriteLine("   XXX");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _5()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X    .");
            Console.WriteLine("   XX X     .");
            Console.WriteLine("   XXX      .");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _6()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X    .");
            Console.WriteLine("   XX X     .");
            Console.WriteLine("   XXX      .");
            Console.WriteLine("   XX       O");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _7()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X    .");
            Console.WriteLine("   XX X     .");
            Console.WriteLine("   XXX      .");
            Console.WriteLine("   XX       O");
            Console.WriteLine("   XX       i");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _8()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X    .");
            Console.WriteLine("   XX X     .");
            Console.WriteLine("   XXX      .");
            Console.WriteLine("   XX       O");
            Console.WriteLine("   XX      /i\\");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("   XX");
            }
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void _9()
        {
            Console.WriteLine("\n   XXXXXXXXXXX");
            Console.WriteLine("   XX  X    .");
            Console.WriteLine("   XX X     .");
            Console.WriteLine("   XXX      .");
            Console.WriteLine("   XX       O");
            Console.WriteLine("   XX      /i\\");
            Console.WriteLine("   XX      / \\");
            Console.WriteLine("   XX");
            Console.WriteLine(" XXXXXX\nXXXXXXXX");
        }
        static void Main(string[] args)
        {
            Console.Write("Vitej u hry Sibenice :)\nZadej slovo: ");
            string zadaneSlovo = Console.ReadLine();
            Console.Clear();
            int delkaSlova = zadaneSlovo.Length;
            int pocetZivotu = 9;
            int pocetPokusu = 0;
            int n = 0; //pomocna promenna
            int pocetUhadnutychPismen = 0;
            char[] hadaneSlovo = new char[delkaSlova];
            for (int i = 0; i < delkaSlova; i++)
            {
                hadaneSlovo[i] = '*';
                Console.Write(" " + hadaneSlovo[i]);
            }

        doby:

            Console.Write("\nzadej pismenko: ");
            string pismenko = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("zadane pismenko je: " + pismenko);
            for (int i = 0; i < delkaSlova; i++)
            {
                if (i < 1)
                {
                    pocetPokusu = pocetPokusu + 1;
                }
                if (pismenko[0] == hadaneSlovo[i])
                {
                    n = n + 1;
                    if (n == 1)
                    {
                        Console.WriteLine("Tohle pismeno uz jsi jednou hadal!");
                    }
                }
                else if (zadaneSlovo[i] == pismenko[0])  // == znamená porovnat
                {
                    hadaneSlovo[i] = pismenko[0];   // = znamená nová hodnota
                    pocetUhadnutychPismen = pocetUhadnutychPismen + 1;
                    n = n + 1;
                    if (n == 1)
                    {
                        pocetZivotu = pocetZivotu + 1;
                    }
                }
            }
            n = 0;
            pocetZivotu = pocetZivotu - 1;
            Console.WriteLine("Tvuj pocet zivotu: " + pocetZivotu);
            for (int i = 0; i < delkaSlova; i++)
            {
                Console.Write(" " + hadaneSlovo[i]);
            }
            Console.WriteLine("");
            if (pocetUhadnutychPismen == delkaSlova)
            {
                Console.Write("\nVYHRAL JSI, GRATULUJI!!!\nPocet pokusu je " + pocetPokusu);
                goto konec;
            }



            if (pocetZivotu == 8)
            {
                _1();
            }
            else if (pocetZivotu == 7)
            {
                _2();
            }
            else if (pocetZivotu == 6)
            {
                _3();
            }
            else if (pocetZivotu == 5)
            {
                _4();
            }
            else if (pocetZivotu == 4)
            {
                _5();
            }
            else if (pocetZivotu == 3)
            {
                _6();
            }
            else if (pocetZivotu == 2)
            {
                _7();
            }
            else if (pocetZivotu == 1)
            {
                _8();
            }
            else if (pocetZivotu == 0)
            {
                _9();
                Console.WriteLine("\nPROHRAL JSI, SRY :/\nZadane slovo bylo: " + zadaneSlovo);
                goto konec;
            }



            goto doby;

        konec:

            Console.ReadKey();
        }
    }
}