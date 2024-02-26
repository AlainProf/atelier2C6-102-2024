//---------------------------------
//   Fichier : Tableau2D.cs
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
    internal class Tableau2D
    {
        char[,] _grille;
        const int NB_RANGEES = 6;
        const int NB_COLONNES = 7;
        Util u;


        //----------------------------------
        //
        //----------------------------------
        public Tableau2D(int nbRang, int nbCol)
        {
            u= new Util();  
            _grille = new char[NB_COLONNES, NB_RANGEES];
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    _grille[i, j] = '_';
                }
            }
        }

        //----------------------------------
        //
        //----------------------------------
        public void RemplirHorizontal()
        {
            char dec;
            u.Titre("En rangées");
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    dec = 'x';
                    if (j % 2 == 0)
                        dec = 'o';
                    _grille[i, j] = dec;
                }
            }
        }
        //----------------------------------
        //
        //----------------------------------
        public void RemplirVertical()
        {
            char dec;
            u.Titre("En colonnes");
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    dec = 'x';
                    if (i % 2 == 0)
                        dec = 'o';
                    _grille[i, j] = dec;
                }
            }
        }
        //----------------------------------
        //
        //----------------------------------
        public void RemplirHasard()
        {
            u.Titre("Au hasard");
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    int dec = u.rdm.Next(0, 3);
                    switch (dec)
                    {
                        case 0:
                            _grille[i, j] = 'o';
                            break;
                        case 1:
                            _grille[i, j] = 'x';
                            break;
                        case 2:
                            _grille[i, j] = '_';
                            break;
                    }
                }
            }
        }

        //----------------------------------
        //
        //----------------------------------
        public void Afficher()
        {
            for (int i = 0; i < NB_COLONNES; i++)
            {
                for (int j = 0; j < NB_RANGEES; j++)
                {
                    EcrireCase(i, j);
                }
            }
        }

        //----------------------------------
        //
        //----------------------------------
        private void EcrireCase(int x, int y)
        {
            Console.SetCursorPosition(x * 4, y + 6);
            Console.Write($"_{_grille[x, y]}_|");
        }
    }
}
