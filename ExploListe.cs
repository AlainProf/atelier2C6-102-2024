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
        static List<Humain> listeHumains = new List<Humain>();

        

        static int NB_ELEMENT = 10;
        static Random r = new Random();

        public static void Exec()
        {
            Util.Titre("Exploration des listes en C#");

           

            //ExploListeEntier();
            ExploListeHumain();
        }

        static void ExploListeHumain()
        {
            for (int i = 0; i < NB_ELEMENT; i++)
            {
                listeHumains.Add(new Humain(Util.tabNoms[r.Next(0,10)], new DateTime(r.Next(1964, 2024), r.Next(1, 13), r.Next(1, 29))));
            }

            listeHumains[0]._Residence = new Adresse("1234", "Cartier", "Laval", "Québec", "H1H1H1");
            Sep("liste humain initiale");
            AfficherListeHumain();

            Sep("Liste humains triée par nom");
            listeHumains.Sort(comparerHumain);
            AfficherListeHumain();

            Sep("Liste humains triée par age");
            listeHumains.Sort(comparerAgeHumain);
            AfficherListeHumain();

            Sep("Liste humains triée par une lambda");
            listeHumains.Sort((humA, humB) => { return humA._Naissance.CompareTo(humB._Naissance); });
            AfficherListeHumain();

            Sep("Liste humains inversée");
            listeHumains.Reverse();
            AfficherListeHumain();

            Sep("Liste Clearée");
            listeHumains.Clear();
            AfficherListeHumain();
        }

        static int comparerAgeHumain(Humain humA, Humain humB)
        {
            if (humA._Naissance.Ticks < humB._Naissance.Ticks)
                return -1;
            if (humA._Naissance.Ticks > humB._Naissance.Ticks)
                return 1;
            return 0;   

//            return humB.GetNaissance().CompareTo(humA.GetNaissance());
        }
        static int comparerHumain(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom);
        }


        static void ExploListeEntier()
        {
            for (int i = 0; i < NB_ELEMENT; i++)
            {
                listeEntiers.Add(r.Next(1,1000));
            }
            Sep("liste initiale");
            AfficherListe();

            listeEntiers.Sort();
            Sep("liste triée");
            AfficherListe();

            listeEntiers.Reverse(); 
            Sep("liste inversée");
            AfficherListe();

            listeEntiers.Clear();
            Sep("liste clearée");
            AfficherListe();

            listeEntiers.Add(666);
            Sep("liste bête");
            AfficherListe();
        }

        static void Sep(string msg)
        {
            Console.WriteLine("------------" + msg + "------------");
        }

        static void AfficherListe()
        {
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                if (i % 1 == 0)
                {
                    Console.WriteLine(listeEntiers[i]);
                }
            }
        }
        static void AfficherListeHumain()
        {
            for (int i = 0; i < listeHumains.Count; i++)
            {
                if (i % 1 == 0)
                {
                    listeHumains[i].Afficher();
                }
            }
        }



    }
}
