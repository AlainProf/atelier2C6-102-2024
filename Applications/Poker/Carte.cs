using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications.Poker
{
    internal class Carte
    {
        // ♥♣♦♠
        public int _Sorte {  get; set; }
        public int _Valeur { get; set; }

        string _valeurTexte = "2";
        string _sorteTexte = "pique";

        const int COULEUR_PIQUE = 0;
        const int COULEUR_TREFLE = (int)ConsoleColor.DarkBlue;
        const int COULEUR_CARREAU = (int)ConsoleColor.Red;
        const int COULEUR_COEUR =(int) ConsoleColor.DarkRed;
        const int LARGEUR_CARTE = 5;

        public Carte(int sorte=0, int val=0)
        { 
            _Sorte = sorte; 
            _Valeur = val;  
        }

        public void Afficher(bool modeGraphique =false, int position =0)
        {
            ConvertVal();
            ConvertSorte();

            if (modeGraphique)
            {
                switch(_Sorte)
                {
                    case 0:
                        Console.BackgroundColor = (ConsoleColor)COULEUR_PIQUE;
                        break;
                    case 1:
                        Console.BackgroundColor = (ConsoleColor)COULEUR_TREFLE;
                        break;
                    case 2:
                        Console.BackgroundColor = (ConsoleColor)COULEUR_CARREAU;
                        break;
                    case 3:
                        Console.BackgroundColor = (ConsoleColor)COULEUR_COEUR;
                        break;
                }
                //Console.BackgroundColor = 0;

                Console.SetCursorPosition(1 + (position * (LARGEUR_CARTE+1)), 4);
                Console.Write($"{_valeurTexte}    ");
                Console.SetCursorPosition(1 + (position * (LARGEUR_CARTE + 1)), 5);
                Console.WriteLine("  ♥  ");
                Console.SetCursorPosition(1 + (position * (LARGEUR_CARTE + 1)), 6);
                Console.WriteLine($"    {_valeurTexte}");
            }
            else
            {
                Console.WriteLine($"\n{_valeurTexte} de {_sorteTexte}");
            }
        }

        void ConvertSorte()
        {
            switch (_Sorte)
            {
                case 0:
                    _sorteTexte = "pique";
                    break;
                case 1:
                    _sorteTexte = "trèfle";
                    break;
                case 2:
                    _sorteTexte = "carreau";
                    break;
                case 3:
                    _sorteTexte = "coeur";
                    break;
                default:
                    throw new Exception($"sorte {_Sorte} invalide");

            }
        }
        void ConvertVal()
        {
            switch (_Valeur)
            {
                case 0:
                    _valeurTexte = "2";
                    break;
                case 1:
                    _valeurTexte = "3";
                    break;
                case 2:
                    _valeurTexte = "4";
                    break;
                case 3:
                    _valeurTexte = "5";
                    break;
                case 4:
                    _valeurTexte = "6";
                    break;
                case 5:
                    _valeurTexte = "7";
                    break;
                case 6:
                    _valeurTexte = "8";
                    break;
                case 7:
                    _valeurTexte = "9";
                    break;
                case 8:
                    _valeurTexte = "X";
                    break;
                case 9:
                    _valeurTexte = "J";
                    break;
                case 10:
                    _valeurTexte = "Q";
                    break;
                case 11:
                    _valeurTexte = "K";
                    break;
                case 12:
                    _valeurTexte = "A";
                    break;
                default:
                    throw new Exception($"valeur {_Valeur} invalide");

            }
        }
    }
}
