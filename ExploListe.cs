using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class ExploListe
    {
        static List<int> listeEntiers = new List<int>();
        static int NB_ELEMENT = 10;
        static Random r = new Random();

        public static void Exec()
        {
            Util.Titre("Exploration des listes en C#");

            ExploListeEntier();
        }

        static void ExploListeEntier()
        {
            for (int i = 0; i < NB_ELEMENT; i++)
            {
                listeEntiers.Add(r.Next(1,8));
            }
            Sep("liste initiale");



        }

        static void Sep(string msg)
        {
            Console.WriteLine("------------" + msg + "------------");
        }

    }
}
