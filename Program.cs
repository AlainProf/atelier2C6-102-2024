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
                case "Q":
                default:
                    Environment.Exit(0);    
                    break;
            }

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

            Console.WriteLine("Nom de h1:" + h1.GetNom());
            h1.SetNom("Alberto");
            h1.Afficher();




            Util.Pause();
            string[] param = new string[1];
            Main(param);
        }

        //----------------------
        //
        //---------------------
        static void AfficherMenu()
        {
            Console.WriteLine("f- Le Financier");
            Console.WriteLine("h- Humanité");
            Console.WriteLine("q- Quitter");
            Console.Write("Votre choix:");
        }


    }
}
