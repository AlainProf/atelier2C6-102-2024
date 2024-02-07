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
            Util.Titre("Exploration de la manipulation de fichiers avec C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = File.OpenText(FICHIER_POPULATION);
                int numLigne = 0;
                string ligneCourante;

                while(reader.Peek() > -1)
                {
                    numLigne++;
                    ligneCourante = reader.ReadLine();
                    //Console.WriteLine($"{numLigne} : {ligneCourante}");

                    if (ParsingHumain(ligneCourante, out Humain humain))
                    {
                        _listeHumains.Add(humain);
                    }

                }

                _listeHumains.Sort(comparerHumain);   
                AfficherListeHumain();
                Console.WriteLine($"\n{numLigne} lignes");
            }
            else
            {
                Console.WriteLine("ERREUR...");
            }
        }

        static int comparerHumain(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom);
        }


        static bool ParsingHumain(string infoBrute, out Humain humain)
        {
            humain = new Humain();  
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
                if (ParsingDate(tabInfoBrute[1], out DateTime naissance))
                {
                    humain = new Humain(tabInfoBrute[0], naissance);
                    return true;
                }
            }

            if (nbChamps == 7)
            {
                string[] tabInfoBrute = infoBrute.Split(';');
                if (ParsingDate(tabInfoBrute[1], out DateTime naissance))
                {
                    humain = new Humain(tabInfoBrute[0], naissance, new Adresse(tabInfoBrute[2], tabInfoBrute[3], tabInfoBrute[4], tabInfoBrute[5], tabInfoBrute[6]));
                    return true;    
                }
            }

            return false;
        }

        static bool ParsingDate(string dateBrute, out DateTime naissance)
        {
            string[] tabDateBrute = dateBrute.Split("-");

            naissance = new DateTime(int.Parse(tabDateBrute[0]), int.Parse(tabDateBrute[1]), int.Parse(tabDateBrute[2]));
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
