//---------------------------------
//   Fichier : Program.cs
//   Auteur  : Alain Martel
//   Date    : 2024-01-31
//---------------------------------

namespace Atelier2C6_102_2024
{
    internal class Program
    {
        //----------------------
        //
        //---------------------
        static void Main(string[] args)
        {
            Util.Titre("Atelier du cours 2C6 gr 102");

            AfficherMenu();
            ExecuterChoix();
        }

        //----------------------
        //
        //---------------------
       static void AfficherMenu()
        {
            Console.WriteLine("F- Le Financier");
            Console.WriteLine("H- Humanité");
            Console.WriteLine("T- Tableau (array)");
            Console.WriteLine("L- Liste (array)");
            Console.WriteLine("S- Differnce entre static et non-static");
            Console.WriteLine("C- Chargement de fichiers en mémoire");

            Console.WriteLine();
            Console.WriteLine("Q- Quitter");
            Console.Write("Votre choix:");
        }
        //----------------------
        //
        //---------------------
        static void ExecuterChoix()
        {
           char choix = Util.SaisirChar();
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
                    ExploTableau.Exec();
                    break;

                case "L":
                    ExploListe.Exec();
                    break;

                case "S":
                    ExploStatic();
                    break;

                case "C":
                    ExploFichier.Exec();
                    break;


                case "Q":
                default:
                    Environment.Exit(0);    
                    break;
            }

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
            Util.Titre("L'humanité");

            Humain h1 = new Humain("Albert", new DateTime(1881, 1, 1));
            h1.Afficher();
            Humain h4 = new Humain("Tristan", new DateTime(2005, 11, 15));
            h4.Afficher();

            Humain h2 = new Humain("Béatrice");
            h2.Afficher();


            Humain h3 = new Humain();
            h3.Afficher();

            Console.WriteLine("Nom de h1:" + h1._Nom);
            h1._Nom = "Alberto";
            h1.Afficher();




            Util.Pause();
            string[] param = new string[1];
            Main(param);
        }



    }
}
