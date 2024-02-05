using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class ExploTableau
    {

        static int NB_ELEMENT = 10;
        static Random r = new Random();
        static int[] tabEntiers = new int[NB_ELEMENT];
        static Humain[] tabHumains = new Humain[NB_ELEMENT];

        static string[] tabNoms = new string[NB_ELEMENT];

        static Util u = new Util();



        public static void Exec()
        {
            Util.Titre("Exploration des tableaux (array) en C#");

            tabNoms[0] = "Layah";
            tabNoms[1] = "Claude";
            tabNoms[2] = "Pierre";
            tabNoms[3] = "Tristan";
            tabNoms[4] = "Olivier";
            tabNoms[5] = "Miguel";
            tabNoms[6] = "Simon";
            tabNoms[7] = "Xavier";
            tabNoms[8] = "Jolan";
            tabNoms[9] = "Samael";


            // ExploTabEntier();
            ExploTabHumain();
        }

        static void ExploTabHumain()
        {
            for (int i = 0; i < tabHumains.Length; i++)
            {
                tabHumains[i] = new Humain(tabNoms[r.Next(0,10)], new DateTime(r.Next(1964,2024), r.Next(1,13), r.Next(1,29) ));
            }
            u.Sep("Tab initial");
            AfficherTabHum();

            u.Sep("Tri");
            Array.Sort(tabHumains, comparerHumain);
            AfficherTabHum();

            u.Sep("Clear");
            Array.Clear(tabHumains);
            AfficherTabHum();

        }

        static int comparerHumain(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom); 

            /*
              if (humA.GetNaissance().Ticks > humB.GetNaissance().Ticks)
                return -1;
            if (humA.GetNaissance().Ticks < humB.GetNaissance().Ticks)
                return 1;
            return 0;
            */


        }

        static void ExploTabEntier()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = r.Next(0, 1000);
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

        static void AfficherTab()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine(tabEntiers[i]);
            }
        }
        static void AfficherTabHum()
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

            Util.SepST(" static ");
            Util utili = new Util();
            utili.Sep(" non statique");
            
        }

   
    }
}
