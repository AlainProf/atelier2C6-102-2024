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

        MainJoueur[] _mainsJoueurs = new MainJoueur[4]; 

        Util u =new Util();

        Paquet lePaquet = new Paquet();

        public PartiePoker()
        {
            for (int i = 0; i < 4; i++)
            {
                _mainsJoueurs[i] = new MainJoueur(i);
            }
        }

        public void Jouer()
        {
            u.Titre("Poker 2C6 102!");
            InitTable();
            lePaquet.Melanger();

            for(int i=0; i<5; i++)
            {
                for (int j=0; j<4; j++)
                {
                    _mainsJoueurs[j].InitCarte(i, lePaquet.Distribuer());
                }
            }




            for (int i=0; i<4; i++)
            {
                _mainsJoueurs[i].Afficher();    
            }





            //           lePaquet.Afficher();


            /*            while (true)
                        {
                            lePaquet.Melanger();
                            lePaquet.Afficher();
                            Console.ReadKey();
                        }
            */




        }

        void InitTable()
        {
            Console.BackgroundColor = (ConsoleColor)COULEUR_TAPIS;
            Console.ForegroundColor = (ConsoleColor)COULEUR_TEXTE;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }

    }
}
