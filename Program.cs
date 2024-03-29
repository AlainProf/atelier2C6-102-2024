﻿//---------------------------------
//   Fichier : Program.cs
//   Auteur  : Alain Martel
//   Date    : 2024-01-31
//---------------------------------

using Atelier2C6_102_2024.Applications;
using Atelier2C6_102_2024.Applications.Connect4;
using Atelier2C6_102_2024.Classes;
using Atelier2C6_102_2024.Explo;
using Atelier2C6_102_2024.Applications.Poker;
using System.ComponentModel.Design;

namespace Atelier2C6_102_2024
{
    internal class Program
    {
        static int nbRangees;
        static int nbColonnes;
        static Util u = new Util();
        //----------------------
        //
        //---------------------
        static void Main(string[] args)
        {
            bool ExecOK = true;
            
            try
            {
                TraiterParamDExec(args);
                Ecran ecran = new Ecran();
                ecran.Init(0, 15);
                u.Titre("Atelier du cours 2C6 gr 102");

                AfficherMenu();
                ExecuterChoix();
            }

            catch(FormatException e)
            {
                ExecOK = false;
                Console.WriteLine("La valeur fournie ne peut être convertie: " + e.Message);
            }

            catch (ArgumentOutOfRangeException e)
            {
                ExecOK = false;
                Console.WriteLine("L'indice d'un tableau dépassait la taille du tableau : " + e.ToString());
            }

            catch (System.IO.FileNotFoundException e)
            {
                ExecOK = false;
                Console.WriteLine("Une exception est survenue: " + e.ToString());
            }
            catch (System.Exception e)
            {
                ExecOK = false;
                Console.WriteLine($"Une exception est survenue: {e}");
            }
            finally
            {
                if (ExecOK)
                   Console.WriteLine("\nAu revoir!");
                else
                    Console.WriteLine(" Une ERREUR s'est produite... ");
            }
        }


        //----------------------------------
        //
        //----------------------------------
        static void TraiterParamDExec(string[] tabParam)
        {
            if (tabParam.Length > 0)
            {

                Console.WriteLine($"{Console.WindowWidth} colonnes de large\n{Console.WindowHeight} rangées de haut");
                u.Pause();
                for (int i = 0; i < tabParam.Length; i++)
                {
                    Console.WriteLine(tabParam[i]);
                }
                u.Pause();

                nbRangees = int.Parse(tabParam[1]);
                nbColonnes = int.Parse(tabParam[0]);

                if (nbColonnes > Console.WindowWidth / 4)
                {
                    throw (new Exception("param 1 trop élevé"));
                }
                if (nbRangees > Console.WindowHeight - 6)
                {
                    throw (new Exception("param 2 trop élevé"));
                }
            }

        }

        //----------------------
        //
        //---------------------
        static void AfficherMenu()
        {
            Console.WriteLine("F- Le Financier");
            Console.WriteLine("H- Humanité");
            Console.WriteLine("T- Tableau (array)");
            Console.WriteLine("L- Liste (list)");
            Console.WriteLine("S- Differnce entre static et non-static");
            Console.WriteLine("C- Création et/ou Chargement de fichiers");
            Console.WriteLine("R- ref et out pratique");
            Console.WriteLine("X- TicTacToe");
            Console.WriteLine("O- Connect4");
            Console.WriteLine("D- Dessiner à l'écran");
            Console.WriteLine("E- HEritage");
            Console.WriteLine("A- tAbleau2D");
            Console.WriteLine("P- Piles et Files (Stack & Queue)");
            Console.WriteLine("K- Poker");

            Console.WriteLine();
            Console.WriteLine("Q- Quitter");
            Console.Write("Votre choix:");
        }
        //----------------------
        //
        //---------------------
        static void ExecuterChoix()
        {
           char choix = u.SaisirChar();
            string option = choix.ToString().ToUpper();


            switch (option)
            {
                case "F":
                  
                    ExecFinancier();
                    break;

                case "H":
                    ExecHumanite();
                    break;

                case "T":
                    ExploTableau();
                    break;

                case "L":
                    ExploListe();
                    break;

                case "S":
                    ExploStatic();
                    break;

                case "C":
                    ExploFichier();
                    break;

                case "R":
                    ExploRefETOut();
                    break;

                case "X":
                    PartieTicTacToe pTTT = new PartieTicTacToe();
                    pTTT.Jouer();
                    break;

                case "O":
                    PartieConnect4 partieConn4 = new PartieConnect4();
                    partieConn4.Jouer();
                    break;

                case "D":
                    Ecran monEcran = new Ecran();
                    monEcran.Exec();
                    break;

                case "E":
                    ExecHeritage();
                    break;
                case "A":
                    ExecTab2D();
                    break;

                case "P":
                    ExecPileEtFile();
                    break;

                case "K":
                    ExecPoker();
                    break;


                case "Q":
                default:
                    Environment.Exit(0);    
                    break;
            }
        }

        //----------------------------------
        //
        //----------------------------------
        static void ExecPoker()
        {
            PartiePoker pp = new PartiePoker();
            pp.Jouer();
        }

        //----------------------------------
        //
        //----------------------------------
        static void ExploTableau()
        {
            ExploTableau exploTableau = new ExploTableau();
            exploTableau.Exec();

        }
        //----------------------------------
        //
        //----------------------------------
        static void ExploListe()
        {
            ExploListe exploListe = new ExploListe();
            exploListe.Exec();

        }

        //----------------------------------
        //
        //----------------------------------
        static void ExploFichier()
        {
            ExploFichier exploFichier = new ExploFichier();
            exploFichier.Exec();
        }

        //----------------------
        //
        //---------------------
        static void ExecPileEtFile()
        {
            u.Titre("Les piles et files avec C#");

            Voiture vA = new Voiture();
            Voiture vB = new Voiture();
            Voiture vC = new Voiture();

            vA._Modele = "Ferrari";
            vA._Couleur = "rouge";
            vB._Modele = "Honda Fit";
            vB._Couleur = "bleue";
            vC._Modele = "Hyundai Ionic";
            vC._Couleur = "noir";

            Queue<Voiture> laveAuto = new Queue<Voiture>();

            laveAuto.Enqueue(vA);
            laveAuto.Enqueue(vB);
            laveAuto.Enqueue(vC);


            Console.WriteLine("Ordre de sortie du lave auto:");
            Voiture vPropre = laveAuto.Dequeue();
            vPropre.Afficher();
            vPropre = laveAuto.Dequeue();
            vPropre.Afficher();
            vPropre = laveAuto.Dequeue();
            vPropre.Afficher();


            u.Pause();

            Stack<Voiture> stationnement = new Stack<Voiture>();
            stationnement.Push(vA);
            stationnement.Push(vB);
            stationnement.Push(vC);

            Console.WriteLine("Ordre de sortie du stationnement:");

            Voiture vQuittante = stationnement.Pop();
            vQuittante.Afficher();  
            vQuittante = stationnement.Pop();
            vQuittante.Afficher();
            vQuittante = stationnement.Pop();
            vQuittante.Afficher();

            u.Pause();
        }

        //----------------------
        //
        //---------------------
        static void ExecTab2D()
        {
            u.Titre("Tableau en 2 dimensions");
            Tableau2D tab2D = new Tableau2D(nbRangees, nbColonnes);
            tab2D.Afficher();
            u.Pause();

            tab2D.RemplirHorizontal();
            tab2D.Afficher();
            u.Pause();

            tab2D.RemplirVertical();
            tab2D.Afficher();
            u.Pause();

            tab2D.RemplirHasard();
            tab2D.Afficher();
            u.Pause();
        }
        //----------------------
        //
        //---------------------
        static void ExecHeritage()
        {
            u.Titre("Héritage en C#");

            Etudiant etuA = new Etudiant();
            Etudiant etuB = new Etudiant("Apolonius");
            Etudiant etuC = new Etudiant("Benoite", new DateTime(1964, 6, 1));
            Etudiant etuD = new Etudiant("Cléophas", new DateTime(1964, 6, 1), "24066944");

            etuA.Afficher();
            etuB.Afficher();
            etuC.Afficher();
            etuD.Afficher();

            Universitaire etuU = new Universitaire();
            etuU.Afficher();

        }

        //----------------------
        //
        //---------------------
        static void ExploRefETOut()
        {
            u.Titre("Essai avec ref et out");
            int p = 10;

            Console.WriteLine($"Valeur initiale de p:{p}");
            f1(p);
            Console.WriteLine($"Valeur post f1  de p:{p}");
            f2(ref p);
            Console.WriteLine($"Valeur post f2  de p:{p}");
            f3(p, out int pOut);
            Console.WriteLine($"Valeur post f3  de pOut:{pOut}");
        }

        static void f1(int p)
        {
            p++;
        }
        static void f2(ref int p)
        {
            p++;
        }
        static void f3(int p, out int p1)
        {
            p1 = p;
            p1++;
        }

        //----------------------
        //
        //---------------------
        static void ExploStatic()
        {
            Humain h1 = new Humain();
            Humain h2 = new Humain("Alice");
            Humain h3 = new Humain("Benoit", new DateTime(1963,9,23));
            Humain h4 = new Humain("Charlotte", new DateTime(2021,1,1));

            Console.WriteLine("Nb humain instancié:" + Humain.compteur);

        }

        //----------------------
        //
        //---------------------
        static void ExecFinancier()
        {
            Financier fin = new Financier();
            fin.Executer();

            string[] param = new string[1];
            Main(param);
        }

        //----------------------
        //
        //---------------------
        static void ExecHumanite()
        {
            u.Titre("L'humanité");

            Humain h1 = new Humain("Albert", new DateTime(1881, 1, 1));
            h1.Afficher();
            Humain h4 = new Humain("Tristan", new DateTime(2005, 11, 15));
            h4.Afficher();

            Humain h2 = new Humain("Béatrice");
            h2.Afficher();


            Humain h3 = new Humain();
            h3.Afficher();

            //Console.WriteLine("Nom de h1:" + h1._Nom);
            //h1._Nom = "Alberto";
            h1.Afficher();

            u.Pause();
            string[] param = new string[1];
            Main(param);
        }
    }
}
