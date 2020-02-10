using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace ConsoleApplication11
{
    enum Kierunek : int
    {
        left,
        right,
        up,
        down,
        none
    }
    class Program
    {
        public static Kierunek kier = Kierunek.none;
        static int x = 0, y = 0;
        static bool endgame = false;
        static void Move()
        {
            if (Console.KeyAvailable)
                switch (Console.ReadKey(true).Key.ToString())
                {
                    case "A":
                        kier = Kierunek.left;
                        break;
                    case "S":
                        kier = Kierunek.down;
                        break;
                    case "D":
                        kier = Kierunek.right;
                        break;
                    case "W":
                        kier = Kierunek.up;
                        break;
                    case "Q":
                        kier = Kierunek.none;
                        break;
                }
            switch (kier)
            {
                case Kierunek.down:
                    y--;
                    break;
                case Kierunek.up:
                    y++;
                    break;
                case Kierunek.left:
                    x--;
                    break;
                case Kierunek.right:
                    x++;
                    break;

            }
            Console.WriteLine($"X = {x}, Y = {y} ");
        }
        static void Main()
        {
            while(!endgame)
            {
                Move();
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
