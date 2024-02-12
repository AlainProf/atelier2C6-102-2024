using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Ecran
    {
        public void Exec()
        {
            Util.Titre("Dessinons à l'écran avec C#");
            Console.WriteLine("Largeur: " + Console.WindowWidth + " carac");
            Console.WriteLine("Hauteur: " + Console.WindowHeight + " carac");
            Init();
            /*for (int b = 0; b<16; b++)
                Init(b, 8);
            */
            Init();

            Parcours();



        }

        void Parcours()
        {
            int x = 0; 
            int y = 0;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            for (; x < Console.WindowWidth; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }

            for (; y < Console.WindowHeight; y++)
            {
                Console.SetCursorPosition(x-1, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }

            for (; x > 0; x--)
            {
                Console.SetCursorPosition(x-1, y-1);
                Console.Write(" ");
                Thread.Sleep(1);
            }
            for (; y > 0; y--)
            {
                Console.SetCursorPosition(x+1, y+1);
                Console.Write(" ");
                Thread.Sleep(1);
            }
        }


        void Init(int back = (int)ConsoleColor.DarkBlue, int fore = (int)ConsoleColor.Yellow)
        {
            Console.BackgroundColor = (ConsoleColor)back;
            Console.ForegroundColor = (ConsoleColor)fore;
            Util.ViderEcran();
            Util.Pause();
        }
    }
}
