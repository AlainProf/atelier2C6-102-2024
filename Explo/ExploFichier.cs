//---------------------------------
//   Fichier : ExploFichier.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atelier2C6_102_2024.Classes;

namespace Atelier2C6_102_2024.Explo
{
    internal class ExploFichier
    {
        const string FICHIER_POPULATION = @"d:\alainm\BD\population.txt";
        List<Humain> _listeHumains = new List<Humain>();

        Util u;


        //----------------------------------
        //
        //----------------------------------
        public ExploFichier()
        {
            u = new Util(); 
        }

        //----------------------------------
        //
        //----------------------------------
        public void Exec()
        {
            u.Titre("Production d'une liste sur fichier");
            //EcritureDUneListe();
            LectureDUneListe();
        }


        //----------------------------------
        //
        //----------------------------------
        void EcritureDUneListe()
        {
            StreamWriter writer = new StreamWriter(FICHIER_POPULATION);
            int NB_MAX = 100;
            int compteur = 0;
            StringBuilder infoHumain = new StringBuilder();

            while (compteur < NB_MAX)
            {
                infoHumain.Append(u.tabNoms[u.rdm.Next(0, 10)]);

                DateTime naissance = new DateTime(u.rdm.Next(1964, 2024), u.rdm.Next(1, 13), u.rdm.Next(1, 29));

                infoHumain.Append(";" + naissance.ToShortDateString());
                writer.WriteLine(infoHumain);
                compteur++;
                infoHumain = new StringBuilder();
            }
            writer.Close();
            Console.WriteLine($"{compteur} humains générés");
        }

        //----------------------------------
        //
        //----------------------------------
        void LectureDUneListe()
        {
            u.Titre("Chargement d'un fichier en mémoire en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = File.OpenText(FICHIER_POPULATION);
                int numLigne = 0;
                int humCharges = 0;
                string? ligneCourante;
                int codeErr = 0;

                while (reader.Peek() > -1)
                {
                    numLigne++;
                    ligneCourante = reader.ReadLine();
                    //Console.WriteLine($"{numLigne} : {ligneCourante}");

                    if (ParsingHumain(ligneCourante, out Humain humain, ref codeErr))
                    {
                        humCharges++;
                        _listeHumains.Add(humain);
                    }
                    else
                    {
                        Console.WriteLine($"Erreur {codeErr} ({(Util.ERREUR_CODE)codeErr}) à la ligne{numLigne}: {ligneCourante}");
                    }
                }

                _listeHumains.Sort(new Humain().ComparerAge);
                Console.WriteLine("Liste chargée:");
                //AfficherListeHumain();
                Console.WriteLine($"{humCharges} ligne chargée correctement\n{numLigne} lignes lues\n{humCharges / numLigne * (double)100}% d'efficacité");

                reader.Close();
            }
            else
            {
                Console.WriteLine("ERREUR...");
            }
        }

        //----------------------------------
        //
        //----------------------------------
        bool ParsingHumain(string? infoBrute, out Humain humain, ref int codeErr)
        {
            humain = new Humain();

            if (infoBrute == null)
                return false;

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

                if (ParsingDate(tabInfoBrute[1], out DateTime naissance, ref codeErr))
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

        //----------------------------------
        //
        //----------------------------------
        bool ParsingDate(string dateBrute, out DateTime naissance, ref int codeErr)
        {
            naissance = DateTime.MinValue;
            string[] tabDateBrute = dateBrute.Split("-");

            if (tabDateBrute.Length < 3)
            {
                codeErr = (int)Util.ERREUR_CODE.ERR_DATE_CORROMPUE;
                return false;
            }

            if (int.TryParse(tabDateBrute[0], out int an))
            {
                if (an > 9999 || an < 1)
                {
                    codeErr = (int)Util.ERREUR_CODE.ERR_ANNEE_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = (int)Util.ERREUR_CODE.ERR_ANNEE_CORROMPUE;
                return false;
            }

            if (int.TryParse(tabDateBrute[1], out int mois))
            {
                if (mois > 12 || mois < 1)
                {
                    codeErr = (int)Util.ERREUR_CODE.ERR_MOIS_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = (int)Util.ERREUR_CODE.ERR_MOIS_CORROMPU;
                return false;
            }

            if (int.TryParse(tabDateBrute[2], out int jour))
            {
                if (jour > 28 || jour < 1)
                {
                    codeErr = (int)Util.ERREUR_CODE.ERR_JOUR_HORS_LIMITE;
                    return false;
                }
            }
            else
            {
                codeErr = (int)Util.ERREUR_CODE.ERR_JOUR_CORROMPU;
                return false;
            }

            naissance = new DateTime(an, mois, jour);
            return true;
        }

        //----------------------------------
        //
        //----------------------------------
        int compteurChamps(string infoBrute)
        {
            int nbChamps = 0;
            if (infoBrute.Length == 0)
            {
                return 0;
            }

            nbChamps++;
            foreach (char ch in infoBrute)
            {
                if (ch == ';')
                    nbChamps++;
            }
            return nbChamps;
        }

        //----------------------------------
        //
        //----------------------------------
        void AfficherListeHumain()
        {
            for (int i = 0; i < _listeHumains.Count; i++)
            {
                _listeHumains[i].Afficher();
            }
        }

    }
}
