using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications.Poker
{
    internal class MainJoueur
    {
        Carte[] lesCartes = new Carte[5];
        int _idJoueur = 0;

        public MainJoueur(int idJ) 
        {
            for (int i = 0; i < 5; i++) 
            {
                lesCartes[i] = new Carte();
            }
            _idJoueur = idJ;
        }

        public void Afficher()
        {
            for(int i = 0; i < 5; i++)
            {
                lesCartes[i].Afficher(true, i, _idJoueur );
            }
        }

        public void InitCarte(int pos, Carte laCarte)
        {
            lesCartes[pos] = laCarte;
        }
    }
}
