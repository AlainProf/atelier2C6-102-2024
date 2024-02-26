//---------------------------------
//   Fichier : Etudiant.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Classes
{
    internal class Etudiant : Humain
    {
        public string? _Matricule { get; set; }
        public double _Moyenne { get; set; }

        //----------------------------------
        //
        //----------------------------------
        public Etudiant()
        {
            compteur++;
            _Nom = "incognito";
            _Matricule = "0";
        }
        //----------------------------------
        //
        //----------------------------------
        public Etudiant(string n) : base(n)
        {
            compteur++;
            _Matricule = compteur.ToString();
        }
        //----------------------------------
        //
        //----------------------------------
        public Etudiant(string n, DateTime nais) : base(n, nais)
        {
            compteur++;
            _Matricule = compteur.ToString();
        }
        //----------------------------------
        //
        //----------------------------------
        public Etudiant(string n, DateTime nais, string mat) : base(n, nais)
        {
            compteur++;
            _Matricule = compteur.ToString();
        }

        //----------------------------------
        //
        //----------------------------------
        public void Afficher()
        {
            Console.WriteLine("Aff de etudiant");
            base.Afficher();
            Console.WriteLine($"Matricule:{_Matricule}");
        }

    }

    class Universitaire : Etudiant
    {
        public string _Programme = "";

        //----------------------------------
        //
        //----------------------------------
        public Universitaire() : base()
        {

        }

        //----------------------------------
        //
        //----------------------------------
        public Universitaire(string programme) : base()
        {
            _Programme = programme;
        }

        //----------------------
        //
        //---------------------
        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Aff de univesitaire");
            Console.WriteLine($"prog: {_Programme}");
        }


    }
}
