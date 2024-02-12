﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Connect4
{
    internal class Grille
    {
        const int NB_COLONNES = 7;
        public const int NB_RANGEES = 6;

        Colonne[] _colonnes = new Colonne[NB_COLONNES];

        public Grille() 
        {
            for(int i= 0; i < NB_COLONNES; i++ )
            {
                _colonnes[i] = new Colonne(i);   
            }
        }


        public void Afficher()
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine(" A   B   C   D   E   F   G");
            foreach (Colonne col in _colonnes)
            {
                col.Afficher();
            }
        }

        public void InsererJeton(char decision, string joueur)
        {
            switch(decision) 
            {
                case 'A':
                    _colonnes[0].InsererJeton(joueur);
                    break;
                case 'B':
                    _colonnes[1].InsererJeton(joueur);
                    break;
                case 'C':
                    _colonnes[2].InsererJeton(joueur);
                    break;
                case 'D':
                    _colonnes[3].InsererJeton(joueur);
                    break;
                case 'E':
                    _colonnes[4].InsererJeton(joueur);
                    break;
                case 'F':
                    _colonnes[5].InsererJeton(joueur);
                    break;
                case 'G':
                    _colonnes[6].InsererJeton(joueur);
                    break;

            }
        }
    }
}
