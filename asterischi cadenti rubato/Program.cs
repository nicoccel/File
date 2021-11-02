using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asterischi_cadenti
{
    class Program
    {
        static void Main(string[] args)
        {
            const int footer = 10;
            const int offsetFoot = 4;
            Random colore = new Random();
            Random xy = new Random();
            Boolean tasto;
            int back;
            int fore;
            int maxwidth;
            int maxheight;
            int contaAsterischi = 0;
            
            do
            {
                back= colore.Next(0, 16);
                fore= colore.Next(0, 16);
                //Console.BackgroundColor = (ConsoleColor)back;
                Console.ForegroundColor = (ConsoleColor)fore;
                maxwidth = xy.Next(0, Console.WindowWidth);
                maxheight = xy.Next(0, Console.WindowHeight - footer);
                
                Console.SetCursorPosition(maxwidth,maxheight);
                Console.Write("*");
                Thread.Sleep(100);

                Console.ResetColor();
                //visualizzazione posizione in x y degli asterischi 
                Console.SetCursorPosition(5, Console.WindowHeight - footer);
                Console.Write("                   ");
                Console.SetCursorPosition(5, Console.WindowHeight - footer);
                Console.Write("x:"+maxwidth);
                Console.Write(" y:"+maxheight);
                //conteggio e visualizzazione degli asterischi 
                contaAsterischi = contaAsterischi + 1;
                Console.SetCursorPosition(5, (Console.WindowHeight - footer) + offsetFoot);
                Console.Write("                   ");
                Console.SetCursorPosition(5, (Console.WindowHeight - footer) + offsetFoot);
                Console.Write("n°asterischi:" + contaAsterischi);
                


                tasto = Console.KeyAvailable;
            }
            while (!tasto);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("applicazione terminata");
            Console.ReadLine();
        }
    }
}
