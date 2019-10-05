using System;

namespace L2P3_Pythagorean_Triples_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, Hyperthenuse;
            Fragerunde(out a, out b, out c, out Hyperthenuse);

            if (Hyperthenuse != a && Hyperthenuse != b)
            {
                if (Math.Pow(Hyperthenuse,2) == (Math.Pow(a,2) + Math.Pow(b,2)))
                {
                    Console.WriteLine("Dein Dreieck, mit der Hyperthenuse {0} und den beiden Seitenlängen von {1} und {2} ist ein ein Dreieck nach Pythagoras!\n", Hyperthenuse, a, b);
                }
                else
                {
                    Console.WriteLine("Das Dreieck ist kein pythagoreanisches\n");
                    Fragerunde(out a, out b, out c, out Hyperthenuse);

                }

            }
            if (Hyperthenuse != a && Hyperthenuse != c)
            {
                if (Math.Pow(Hyperthenuse, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("Dein Dreieck, mit der Hyperthenuse {0} und den beiden Seitenlängen von {1} und {2} ist ein ein Dreieck nach Pythagoras!\n", Hyperthenuse, a, c);
                }
                else
                {
                    Console.WriteLine("Das Dreieck ist kein pythagoreanisches\n");
                    Fragerunde(out a, out b, out c, out Hyperthenuse);

                }


            }
            else
            {
                if (Math.Pow(Hyperthenuse, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("Dein Dreieck, mit der Hyperthenuse {0} und den beiden Seitenlängen von {1} und {2} ist ein ein Dreieck nach Pythagoras!\n", Hyperthenuse, b, c);
                }
                else
                {
                    Console.WriteLine("Das Dreieck ist kein pythagoreanisches\n");
                    Fragerunde(out a, out b, out c, out Hyperthenuse);

                }

            }



        }

        private static void Fragerunde(out double a, out double b, out double c, out double Hyperthenuse)
        {
            Console.WriteLine("Willkommen bei dem Pythagorean Triple Checker. \n Gib mir jetzt die erste Seitenlänge des Dreiecks:\n");
            a = Convert.ToDouble(Console.ReadLine());
            Convert.ToDouble(a);
            Console.WriteLine("Gib mir jetzt die zweite Seitenlänge des Dreiecks:\n");
            b = Convert.ToDouble(Console.ReadLine());
            Convert.ToDouble(a);
            Console.WriteLine("Gib mir jetzt die dritte Seitenlänge des Dreiecks:\n");
            c = Convert.ToDouble(Console.ReadLine());
            double biggestab = Math.Max(a, b);
            Hyperthenuse = Math.Max(c, biggestab);
            Console.WriteLine("ab" + biggestab + "hyperthenuse:" + Hyperthenuse);
        }
    }

}
