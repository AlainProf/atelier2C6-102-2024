using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Etudiant : Humain
    {
        public string? _Matricule {  get; set; } 
        public double _Moyenne { get; set; }
        
        public Etudiant() {
            _Nom = "incognito";
            _Matricule = "0";
        }
        public Etudiant(string n) : base(n)
        {
            _Matricule = "0";
        }
        public Etudiant(string n, DateTime nais) : base(n, nais)
        {
            _Matricule = "0";
        }
        public Etudiant(string n, DateTime nais, string mat) : base(n, nais)
        {
            _Matricule = mat;
        }

        public new void Afficher()
        {
            Console.WriteLine("Aff de etudiant");
            base.Afficher();
            Console.WriteLine($"Matricule:{_Matricule}");
        }

    }

    class Universitaire: Etudiant
    {
        public string _Programme;

        public Universitaire(): base()
        {

        }

        public Universitaire(string programme) : base()
        {
            _Programme = programme;
        }

        //----------------------
        //
        //---------------------
        public void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Aff de univesitaire");
            Console.WriteLine($"prog: {_Programme}");
        }


    }
}
