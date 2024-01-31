//---------------------------------
//   Fichier : util.cs
//   Auteur  : Alain Martel
//   Date    : 2024-01-31
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Util
    {
        //----------------------
        //
        //---------------------
        public static void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //----------------------
        //
        //---------------------
        public static void Titre(string leTitre)
        {
            ViderEcran();
            Console.WriteLine(leTitre);
            for(int i = 0; i< leTitre.Length; i++)
            {
                Console.Write('_');
            }
            Console.Write('\n');
        }

        //----------------------
        //
        //---------------------
        public static char SaisirChar()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            return (char)key.KeyChar;
        }

        //----------------------
        //
        //---------------------
        public static void Pause()
        {
            Console.WriteLine(" appuyer une touche...");
            Console.ReadKey();
        }

        //----------------------
        //
        //---------------------
        public static double SaisirUnDouble(string nomDuDouble)
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
