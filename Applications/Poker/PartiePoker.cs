using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications.Poker
{
    internal class PartiePoker
    {
        const int COULEUR_TAPIS = (int)ConsoleColor.DarkGreen;
        const int COULEUR_TEXTE = 15;
        Util u =new Util();

        Paquet lePaquet = new Paquet();

        public void Jouer()
        {
            InitTable();

            u.Titre("Poker 2C6 102!");

            Carte c1 = new Carte();
            c1.Afficher(true);

            Carte[] uneMain = new Carte[5];

            uneMain[0] = new Carte();
            uneMain[1] = new Carte(3, 12);
            uneMain[2] = new Carte(2, 10);
            uneMain[3] = new Carte(1, 8);
            uneMain[4] = new Carte(0, 11);

            /*for (int i = 0; i < uneMain.Length; i++)
            {
                
                uneMain[i].Afficher(true, i);  
            }*/
            lePaquet.Afficher();



        }

        void InitTable()
        {
            Console.BackgroundColor = (ConsoleColor)COULEUR_TAPIS;
            Console.ForegroundColor = (ConsoleColor)COULEUR_TEXTE;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

    }
}
