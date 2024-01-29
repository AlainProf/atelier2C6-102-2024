using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2C6_102_2024
{
    internal class Humain
    {
        private string nom;
        private DateTime naissance;



        public Humain(string n, DateTime nais ) {
            nom = n;
            naissance = nais;
        }

        public void Afficher()
        {
            Console.WriteLine(nom + " né le " + naissance.ToString());   
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string n)
        {
            nom = n;
        }


    }
}
