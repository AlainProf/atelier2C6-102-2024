using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Connect4
{
    internal class Colonne
    {
        Case[] _cases = new Case[Grille.NB_RANGEES];
        int _numero;

        public Colonne(int n)
        {
            _numero = n;
            for (int i = 0; i < Grille.NB_RANGEES; i++)
            {
                _cases[i] = new Case(_numero, i);
            }
        }


        public void Afficher()
        {
            foreach (Case uneCase in _cases)
            {
                uneCase.Afficher();
            }
        }

        public void InsererJeton(string joueur)
        {
            _cases[0]._Contenu = joueur;

        }
    }
}
