//---------------------------------
//   Fichier : Ecran.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Explo
{
    internal class Ecran
    {
        Util u = new Util();
        //----------------------------------
        //
        //----------------------------------
        public void Exec()
        {
            u.Titre("Dessinons à l'écran avec C#");
            Console.WriteLine("Largeur: " + Console.WindowWidth + " carac");
            Console.WriteLine("Hauteur: " + Console.WindowHeight + " carac");

            Init();

            Parcours();
            //Epilepsis();
        }


        //----------------------------------
        //
        //----------------------------------
        void Epilepsis()
        {
            int compteur = 0;
            int x = 0;
            int y = 0;
            while (compteur < 1)
            {
                for (; y < Console.WindowHeight; y++)
                {
                    Console.BackgroundColor = (ConsoleColor)(y % 16);
                    for (; x < Console.WindowWidth; x++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                    //Thread.Sleep(1);
                }
                for (x = 0; x < Console.WindowWidth; x++)
                {
                    Console.BackgroundColor = (ConsoleColor)(x % 16);
                    for (y = 0; y < Console.WindowHeight; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");

                    }
                    //Thread.Sleep(1);
                }
                compteur++;
            }
            u.Pause();
            Init(0, 15);

            int ITERATIONS = 10 * Console.WindowWidth * Console.WindowHeight;
            x = u.rdm.Next(0, Console.WindowWidth);
            y = u.rdm.Next(0, Console.WindowHeight);
            Console.BackgroundColor = (ConsoleColor)15; // u.rdm.Next(1, 16);
            compteur = 0;

            while (compteur < ITERATIONS)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                x = u.rdm.Next(0, Console.WindowWidth);
                y = u.rdm.Next(0, Console.WindowHeight);
                Console.BackgroundColor = (ConsoleColor)15; // u.rdm.Next(1, 16);

                compteur++;
                //Thread.Sleep(1);
            }
        }


        //----------------------------------
        //
        //----------------------------------
        void Parcours()
        {
            int x = 0;
            int y = 0;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            for (; x < Console.WindowWidth - 1; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }

            for (; y < Console.WindowHeight - 1; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }

            for (; x > 0; x--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }
            for (; y > 0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                Thread.Sleep(1);
            }
        }


        //----------------------------------
        //
        //----------------------------------
        public void Init(int back = (int)ConsoleColor.DarkBlue, int fore = (int)ConsoleColor.Yellow)
        {
            Console.BackgroundColor = (ConsoleColor)back;
            Console.ForegroundColor = (ConsoleColor)fore;
            Util u = new Util();
            u.ViderEcran();
            //u.Pause();
        }
    }
}
