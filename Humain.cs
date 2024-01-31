//---------------------------------
//   Fichier : Humain.cs
//   Auteur  : Alain Martel
//   Date    : 2024-01-31
//---------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Humain
    {
        private string _nom;
        private DateTime _naissance;

        //----------------------
        //
        //---------------------
        public Humain()
        {
            _nom = "inconnu";
            _naissance = new DateTime(1,1,1);
        }
        //----------------------
        //
        //---------------------
        public Humain(string n)
        {
            _nom = n;
            _naissance = DateTime.Now;
        }

        //----------------------
        //
        //---------------------
        public Humain(string n, DateTime nais)
        {
            _nom = n;
            _naissance = nais;
        }

        //----------------------
        //
        //---------------------
        public void Afficher()
        {
            Console.WriteLine(_nom + " né le " + _naissance.ToShortDateString() + ", " + Age() + " ans");   
        }

        //----------------------
        //
        //---------------------
        public string GetNom()        {
            return _nom;
        }

        //----------------------
        //
        //---------------------
        public void SetNom(string n)
        {
            _nom = n;
        }

        private int Age()
        {
            double delta = DateTime.Now.Ticks - _naissance.Ticks;
            int deltaInt = (int) (delta/ 10000000 / (365.24 * 24 * 60 * 60));

            return (int)deltaInt;

            //Console.WriteLine(_naissance.Ticks/
                    }


    }
}
