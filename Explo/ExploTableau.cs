//---------------------------------
//   Fichier : ExploTableau.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atelier2C6_102_2024.Classes;

namespace Atelier2C6_102_2024.Explo
{
    internal class ExploTableau
    {

        const int NB_ELEMENT = 10;
        int[] tabEntiers = new int[NB_ELEMENT];
         Humain[] tabHumains = new Humain[NB_ELEMENT];

         string[] tabNoms = new string[NB_ELEMENT];

         Util u = new Util();



        //----------------------------------
        //
        //----------------------------------
        public void Exec()
        {
            u.Titre("Exploration des tableaux (array) en C#");
            // ExploTabEntier();
            ExploTabHumain();
        }

        //----------------------------------
        //
        //----------------------------------
        void ExploTabHumain()
        {
            for (int i = 0; i < tabHumains.Length; i++)
            {
                tabHumains[i] = new Humain(tabNoms[u.rdm.Next(0, 10)], new DateTime(u.rdm.Next(1964, 2024), u.rdm.Next(1, 13), u.rdm.Next(1, 29)));
            }
            u.Sep("Tab initial");
            AfficherTabHum();

            u.Sep("Tri");
            Array.Sort(tabHumains, new Humain().comparerNom);
            AfficherTabHum();

            u.Sep("Clear");
            Array.Clear(tabHumains);
            AfficherTabHum();
        }

        //----------------------------------
        //
        //----------------------------------
        void ExploTabEntier()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = u.rdm.Next(0, 1000);
            }
            u.Sep("Tab initial");
            AfficherTab();

            Array.Sort(tabEntiers);
            u.Sep("Tab trié");
            AfficherTab();


            u.Sep("Tab inversé");
            Array.Reverse(tabEntiers);
            AfficherTab();

            u.Sep("Moyenne");
            double moy = tabEntiers.Average();
            Console.WriteLine("Val moyenne: " + moy);

            u.Sep("Clear");
            Array.Clear(tabEntiers);
            AfficherTab();


        }

        //----------------------------------
        //
        //----------------------------------
        void AfficherTab()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine(tabEntiers[i]);
            }
        }
        //----------------------------------
        //
        //----------------------------------
        void AfficherTabHum()
        {
            for (int i = 0; i < tabHumains.Length; i++)
            {
                if (tabHumains[i] is not null)
                    tabHumains[i].Afficher();
                else
                {
                    Console.WriteLine("humain est nul");
                }
            }
        }
    }
}
