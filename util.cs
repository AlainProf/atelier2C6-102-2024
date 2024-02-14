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
        public static Random rdm = new Random();

        public static string[] tabNoms = new string[] { "Layah", "Claude", "Pierre", "Tristan", "Olivier", "Miguel", "Simon", "Xavier", "Jolan", "Samael" };

        public const int ERR_DATE_CORROMPUE = -1;
        public const int ERR_ANNEE_HORS_LIMITE = -2;
        public const int ERR_ANNEE_CORROMPUE = -3;
        public const int ERR_MOIS_HORS_LIMITE = -4;
        public const int ERR_MOIS_CORROMPU = -5;
        public const int ERR_JOUR_HORS_LIMITE = -6;
        public const int ERR_JOUR_CORROMPU = -7;

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
            string? input = Console.ReadLine();


            if (double.TryParse(input, out double resultat))
            {
                return resultat;
            }
            else
                return 0.0;
        }

        public void Sep(string msg)
        {
            Console.WriteLine("------------" + msg + "------------");
        }
        public static void SepST(string msg)
        {
            Console.WriteLine("______________" + msg + "*************");
        }


    }
}
