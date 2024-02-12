using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Connect4
{
    internal class PartieConnect4
    {
        Grille _grille;
        string _joueurActif = "x";
        public void Jouer()
        {
            Util.Titre("Connection 4 \n Par \t Alain Martel");
             _grille = new Grille();
            bool partieEnCours = true;
        

            while(partieEnCours) 
            {
                _grille.Afficher();
                SaisirDecision();
                partieEnCours = false;
                if (_joueurActif == "x")
                    _joueurActif = "o";
                else
                    _joueurActif = "x";

            }

        }

        private void SaisirDecision()
        {
            char decision = ' ';
             if (DecisionValide(out decision))
            {
                InsererJeton(decision);
            }
        }

        private bool DecisionValide(out char decision)
        {
            decision = 'A';
            return true;
        }

        void InsererJeton(char decision)
        {
            _grille.InsererJeton(decision, _joueurActif);
        }
    }
}
