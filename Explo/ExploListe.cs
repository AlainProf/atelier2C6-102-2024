//---------------------------------
//   Fichier : ExploListe.cs
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
    internal class ExploListe
    {
         List<int> listeEntiers = new List<int>();
         List<Humain> listeHumains = new List<Humain>();

        Util u;

        public ExploListe()
        {
            u = new Util();
        }

        const int NB_ELEMENT = 10;

        //----------------------------------
        //
        //----------------------------------
        public void Exec()
        {
            u.Titre("Exploration des listes en C#");



            //ExploListeEntier();
            ExploListeHumain();
        }

        //----------------------------------
        //
        //----------------------------------
        void ExploListeHumain()
        {
            for (int i = 0; i < NB_ELEMENT; i++)
            {
                listeHumains.Add(new Humain(u.tabNoms[u.rdm.Next(0, 10)], new DateTime(u.rdm.Next(1964, 2024), u.rdm.Next(1, 13), u.rdm.Next(1, 29))));
            }

            listeHumains[0]._Residence = new Adresse("1234", "Cartier", "Laval", "Québec", "H1H1H1");
            u.Sep("liste humain initiale");
            AfficherListeHumain();

            u.Sep("Liste humains triée par nom");
            listeHumains.Sort(new Humain().comparerNom);
            AfficherListeHumain();

            u.Sep("Liste humains triée par age");
            listeHumains.Sort();
            AfficherListeHumain();

            u.Pause();

            u.Sep("Liste humains triée par une lambda");
            listeHumains.Sort((humA, humB) => { return humA._Naissance.CompareTo(humB._Naissance); });
            AfficherListeHumain();

            u.Sep("Liste humains inversée");
            listeHumains.Reverse();
            AfficherListeHumain();

            u.Sep("Liste Clearée");
            listeHumains.Clear();
            AfficherListeHumain();
        }

        //----------------------------------
        //
        //----------------------------------
        int comparerAgeHumain(Humain humA, Humain humB)
        {
            if (humA._Naissance.Ticks < humB._Naissance.Ticks)
                return -1;
            if (humA._Naissance.Ticks > humB._Naissance.Ticks)
                return 1;
            return 0;

            //            return humB.GetNaissance().CompareTo(humA.GetNaissance());
        }
        //----------------------------------
        //
        //----------------------------------
        int comparerHumain(Humain humA, Humain humB)
        {
            return 0;
            // return humA._Nom.CompareTo(humB._Nom);
        }


        //----------------------------------
        //
        //----------------------------------
        void ExploListeEntier()
        {
            for (int i = 0; i < NB_ELEMENT; i++)
            {
                listeEntiers.Add(u.rdm.Next(1, 1000));
            }
            u.Sep("liste initiale");
            AfficherListe();

            listeEntiers.Sort();
            u.Sep("liste triée");
            AfficherListe();

            listeEntiers.Reverse();
            u.Sep("liste inversée");
            AfficherListe();

            listeEntiers.Clear();
            u.Sep("liste clearée");
            AfficherListe();

            listeEntiers.Add(666);
            u.Sep("liste bête");
            AfficherListe();
        }


        //----------------------------------
        //
        //----------------------------------
        void AfficherListe()
        {
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                if (i % 1 == 0)
                {
                    Console.WriteLine(listeEntiers[i]);
                }
            }
        }
        //----------------------------------
        //
        //----------------------------------
        void AfficherListeHumain()
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
