using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class ExploFichier
    {
        const string FICHIER_POPULATION = @"d:\alainm\BD\population.txt";
        static List<Humain> _listeHumains = new List<Humain>();


        public static void Exec()
        {
            Util.Titre("Production d'une liste sur fichier");
            //EcritureDUneListe();
            LectureDUneListe();
        }


        static void EcritureDUneListe()
        {
            StreamWriter writer = new StreamWriter(FICHIER_POPULATION);
            int NB_MAX = 100;
            int compteur = 0;
            StringBuilder infoHumain = new StringBuilder();

            while(compteur < NB_MAX)
            {
                infoHumain.Append(Util.tabNoms[Util.rdm.Next(0, 10)]);

                DateTime naissance = new DateTime(Util.rdm.Next(1964, 2024), Util.rdm.Next(1, 13), Util.rdm.Next(1, 29));

                infoHumain.Append(";" + naissance.ToShortDateString());
                writer.WriteLine(infoHumain);
                compteur++;
                infoHumain = new StringBuilder();
            }
            writer.Close();
            Console.WriteLine($"{compteur} humains générés");
        }

        static void LectureDUneListe()
        {
            Util.Titre("Chargement d'un fichier en mémoire en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = File.OpenText(FICHIER_POPULATION);
                int numLigne = 0;
                int humCharges = 0;
                string ligneCourante;

                while(reader.Peek() > -1)
                {
                    numLigne++;
                    ligneCourante = reader.ReadLine();
                    //Console.WriteLine($"{numLigne} : {ligneCourante}");

                    if (ParsingHumain(ligneCourante, out Humain humain))
                    {
                        humCharges++;   
                        _listeHumains.Add(humain);
                    }
                }

                _listeHumains.Sort(Humain.ComparerAge);
                Console.WriteLine("Liste chargée:");
                //AfficherListeHumain();
                Console.WriteLine($"{humCharges} ligne chargée correctement\n{numLigne} lignes lues\n{(double)(humCharges/numLigne)*(double)100}% d'efficacité");

                reader.Close(); 
            }
            else
            {
                Console.WriteLine("ERREUR...");
            }
        }

   

        static bool ParsingHumain(string infoBrute, out Humain humain)
        {
            humain = new Humain();
            int codeErr = 0;
            int nbChamps = compteurChamps(infoBrute);

            if (nbChamps == 0)
                return false;

            if (nbChamps == 1)
            {
                humain = new Humain(infoBrute);
                return true;
            }

            if (nbChamps == 2)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                if (ParsingDate(tabInfoBrute[1], out DateTime naissance, ref codeErr))
                {
                    humain = new Humain(tabInfoBrute[0], naissance);
                    return true;
                }
                else
                {
                    return false;   
                }
            }

            if (nbChamps == 7)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                
                if (ParsingDate(tabInfoBrute[1], out DateTime naissance,ref codeErr))
                {
                    humain = new Humain(tabInfoBrute[0], naissance, new Adresse(tabInfoBrute[2], tabInfoBrute[3], tabInfoBrute[4], tabInfoBrute[5], tabInfoBrute[6]));
                    return true;    
                }
                else
                {
                    Console.WriteLine($"ERREUR {codeErr}");
                }
            }

            return false;
        }

        static bool ParsingDate(string dateBrute, out DateTime naissance, ref int codeErr)
        {
            naissance = DateTime.MinValue;
            string[] tabDateBrute = dateBrute.Split("-");

            if (tabDateBrute.Length < 3) 
            {
                codeErr = Util.ERR_DATE_CORROMPUE;
                return false;
            }

            if (int.TryParse(tabDateBrute[0], out int an))
            {
                if (an > 9999 || an < 1)
                {
                    codeErr = Util.ERR_ANNEE_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = Util.ERR_ANNEE_CORROMPUE;
                return false;
            }

            if (int.TryParse(tabDateBrute[1], out int mois))
            {
                if (mois > 12 || mois < 1)
                {
                    codeErr = Util.ERR_MOIS_HORS_LIMITE;
                    return false;
                }  
            }
            else
            {
                codeErr = Util.ERR_MOIS_CORROMPU;
                return false;
            }

            if (int.TryParse(tabDateBrute[2], out int jour))
            {
                if (jour > 28 || jour < 1)
                {
                    codeErr = Util.ERR_JOUR_HORS_LIMITE;
                    return false; 
                }   
            }
            else
            {
                codeErr = Util.ERR_JOUR_CORROMPU;
                return false;
            }

            naissance = new DateTime(an, mois, jour);
            return true;
        }

        static int compteurChamps(string infoBrute)
        {
            int nbChamps = 0;   
            if (infoBrute.Length == 0) 
            {
                return 0;
            }

            nbChamps++;
            foreach(char ch in infoBrute)
            {
                if (ch == ';')
                    nbChamps++;
            }
            return nbChamps;
        }

        static void AfficherListeHumain()
        {
            for (int i = 0; i < _listeHumains.Count; i++)
            {
                _listeHumains[i].Afficher();
            }
        }

    }
}
