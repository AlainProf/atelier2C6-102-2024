namespace atelier2C6_102_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            util.titre("Atelier du cours 2C6 gr 102\n__________________________________");

            AfficherMenu();
            ExecuterChoix();
        }

        static void ExecuterChoix()
        {
            char choix = util.SaisirChar();
            string option = choix.ToString().ToUpper();   


            switch(option)
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

        static void ExecFinancier()
        {
            financier fin = new financier();
            fin.Executer();

            string[] param = new string[1];
            Main(param);
        }

        static void ExecHumanite()
        {
            util.titre("L'humanité");

            Humain h1 = new Humain("Albert", new DateTime(1881, 1, 1));
            h1.Afficher();

            Humain h2 = new Humain("Béatrice", DateTime.Now);
            h2.Afficher();

            Console.WriteLine("Nom de h1:" + h1.getNom());
            h1.setNom("Alberto");
            h1.Afficher();




            util.pause();
            string[] param = new string[1];
            Main(param);
        }

        static void AfficherMenu()
        {
            Console.WriteLine("f- Le Financier");
            Console.WriteLine("h- Humanité");
            Console.WriteLine("q- Quitter");
            Console.Write("Votre choix:");
        }


    }
}
