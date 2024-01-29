﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2C6_102_2024
{
    internal class util
    {
        public static void viderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        public static void titre(string leTitre)
        {
            viderEcran();
            Console.WriteLine(leTitre);
        }

        public static char SaisirChar()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            return (char)key.KeyChar;
        }

        public static void pause()
        {
            Console.WriteLine(" appuyer une touche...");
            Console.ReadKey();
        }

        public static double saisirUnDouble(string nomDuDouble)
        {
            Console.WriteLine(nomDuDouble + ":");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double resultat))
            {
                return resultat;
            }
            else
                return 0.0;
        }


    }
}
