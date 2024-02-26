//---------------------------------
//   Fichier : PartieTicTacToe.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications
{
    internal class PartieTicTacToe
    {
        char joueurCourant = 'X';
        char[] _cases = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        Util u = new Util();


        //----------------------------------
        //
        //----------------------------------
        public void Jouer()
        {

            bool partieEnCours = true;

            while (partieEnCours)
            {
                DessinerGrille();
                ProchainCoup();
                if (CoupGagnant())
                {
                    DessinerGrille();
                    Console.WriteLine($"\n\t!!!  Bravo {joueurCourant}!!");
                    partieEnCours = false;
                }

                if (joueurCourant == 'X')
                    joueurCourant = 'O';
                else
                    joueurCourant = 'X';
            }
        }



        //----------------------------------
        //
        //----------------------------------
        void ProchainCoup()
        {
            Console.WriteLine($"Au {joueurCourant} de jouer\nQuelle case (0 à 8)");

            char coup = 'Q';
            while (!coupLegal(coup))
            {
                coup = u.SaisirChar();
            }

            int idx = int.Parse(coup.ToString());

            _cases[idx] = joueurCourant;

        }

        //----------------------------------
        //
        //----------------------------------
        bool coupLegal(char coup)
        {
            if (coup != '0' && coup != '1' && coup != '2' &&
                coup != '3' && coup != '4' && coup != '5' &&
                coup != '6' && coup != '7' && coup != '8')
                return false;

            int idx = int.Parse(coup.ToString());
            if (_cases[idx] != ' ')
                return false;

            return true;
        }

        //----------------------------------
        //
        //----------------------------------
        bool CoupGagnant()
        {
            if (_cases[0] != ' ')
            {
                if (_cases[0] == _cases[1] && _cases[0] == _cases[2])
                    return true;
            }
            if (_cases[3] != ' ')
            {
                if (_cases[3] == _cases[4] && _cases[3] == _cases[5])
                    return true;
            }
            if (_cases[6] != ' ')
            {
                if (_cases[6] == _cases[7] && _cases[6] == _cases[8])
                    return true;
            }


            return false;
        }

        //----------------------------------
        //
        //----------------------------------
        void DessinerGrille()
        {
            u.Titre("Partie de TicTacToe entre Xavier et Olivier");
            Console.WriteLine("\n");

            // Case 0
            if (_cases[0] == ' ') { Console.Write("___|"); } else { Console.Write("_" + _cases[0] + "_|"); }

            // Case 1
            if (_cases[1] == ' ')
            {
                Console.Write("___|");
            }
            else
            {
                Console.Write("_" + _cases[1] + "_|");
            }

            // case 2
            if (_cases[2] == ' ')
            {
                Console.WriteLine("___");
            }
            else
            {
                Console.WriteLine("_" + _cases[2] + "_");
            }

            // Case 3
            if (_cases[3] == ' ')
            {
                Console.Write("___|");
            }
            else
            {
                Console.Write("_" + _cases[3] + "_|");
            }

            // Case 4
            if (_cases[4] == ' ')
            {
                Console.Write("___|");
            }
            else
            {
                Console.Write("_" + _cases[4] + "_|");
            }

            // Case 5
            if (_cases[5] == ' ')
            {
                Console.WriteLine("___");
            }
            else
            {
                Console.WriteLine("_" + _cases[5] + "_");
            }
            // Case 6
            if (_cases[6] == ' ')
            {
                Console.Write("   |");
            }
            else
            {
                Console.Write(" " + _cases[6] + " |");
            }



            // Case 7
            if (_cases[7] == ' ')
            {
                Console.Write("   |");
            }
            else
            {
                Console.Write(" " + _cases[7] + " |");
            }
            // Case 8

            if (_cases[8] == ' ')
            {
                Console.WriteLine("    ");
            }
            else
            {
                Console.WriteLine(" " + _cases[8] + "  ");
            }

        }
    }
}
