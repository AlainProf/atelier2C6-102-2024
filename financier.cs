﻿//---------------------------------
//   Fichier : financier.cs
//   Auteur  : Alain Martel
//   Date    : 2024-01-31
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Financier
    {
        double _detteInitiale;

        //----------------------
        //
        //---------------------
        public void Executer()
        {
            bool go = true;
            while (go)
            {
                Util.Titre("Le Financier");
                AfficherMenu();
                string option  =ExecuterChoix();
                if (option == "Q")
                {
                    go = false;
                }
            }

        }

        //----------------------
        //
        //---------------------
        void AfficherMenu()
        {
            Console.WriteLine("D- Dette rempoursement ");
            Console.WriteLine("P- Placement rendement");
            Console.WriteLine("q- Quitter");
            Console.Write("Votre choix:");
        }

        //----------------------
        //
        //---------------------
        string ExecuterChoix()
        {
            char choix = Util.SaisirChar();
            string option = choix.ToString().ToUpper();

            bool retour = false;

            switch (option)
            {
                case "D":
                    CalculerDette();
                    break;
                case "P":
                    CalculerPlacement();
                    break;
                case "Q":
                default:
                    break;
            }
            Util.Pause();
            return option;
        }

        //----------------------
        //
        //---------------------
        void CalculerPlacement()
        {
            Console.WriteLine("Placement... à venir");
            Util.Pause();
        }

        //----------------------
        //
        //---------------------
        void SaisirParametres()
        {
            _detteInitiale = Util.SaisirUnDouble("Montant de la dette");
            //Console.WriteLine("Votre dette saisie:" + dette + "$");
        }


        //----------------------
        //
        //---------------------
        public void CalculerDette()
        {
            SaisirParametres();

            double tauxInteretAnnuel = 0.21;
            double tauxInteretMensuel = tauxInteretAnnuel / 12;

            Console.WriteLine("Dette initiale:" + _detteInitiale + "$\nTaux intérêt annuel:" + tauxInteretAnnuel);

            int mois = 1;

            double interetCum = 0;
            double paiementCum = 0;
            double solde = _detteInitiale;
            while (solde > 1)
            {
                double paiementMin = 0.04 * solde;
                double interetCourant = solde * tauxInteretMensuel;
                paiementCum += paiementMin;
                interetCum += interetCourant;

                if (mois % 10 == 0)
                {
                    Console.WriteLine(mois.ToString("N0").PadLeft(6) + " "
                               + solde.ToString("N2").PadLeft(9) + " "
                               + paiementMin.ToString("N2").PadLeft(7) + " "
                               + paiementCum.ToString("N2").PadLeft(9) + " "
                               + interetCourant.ToString("N2").PadLeft(7) + " "
                               + interetCum.ToString("N2").PadLeft(9));
                }
                solde -= paiementMin - interetCourant;
                mois++;
            }
        }

    }
}
