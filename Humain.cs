﻿//---------------------------------
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
        protected string _Nom { get; set; }
        public DateTime _Naissance { get; set; }
        public DateTime _Deces { get; set; }
        public Adresse _Residence { get; set; }


        /*
         * Property
         * 
         * public DateTime _Deces
        {
            get { return _deces; }
            set { _deces = value }
        }*/


        static public int compteur = 0;


        //----------------------
        //
        //---------------------
        public Humain()
        {
            _Nom = "inconnu";
            _Naissance = new DateTime(1,1,1);
            _Residence = new Adresse();
            compteur++;
        }
        //----------------------
        //
        //---------------------
        public Humain(string n)
        {
            _Nom = n;
            _Naissance = DateTime.Now;
            _Residence = new Adresse();
            compteur++;

        }

        //----------------------
        //
        //---------------------
        public Humain(string n, DateTime nais)
        {
            _Nom = n;
            _Naissance = nais;
            _Residence = new Adresse();
            compteur++;

        }
        //----------------------
        //
        //---------------------
        public Humain(string n, DateTime nais, Adresse residence)
        {
            _Nom = n;
            _Naissance = nais;
            _Residence = residence;
            compteur++;

        }

        public static int ComparerAge(Humain humA, Humain humB)
        {
            if (humA._Naissance < humB._Naissance)
                return -1;
            if (humA._Naissance > humB._Naissance)
                return 1;
            return 0;

        }

        public static int comparerNom(Humain humA, Humain humB)
        {
            return humA._Nom.CompareTo(humB._Nom);
        }


        //----------------------
        //
        //---------------------
        public void Afficher()
        {
            Console.WriteLine("Aff de humain");

            Console.WriteLine(_Nom + " né le " + _Naissance.ToShortDateString() + ", " + Age() + " ans"); 
            if (_Residence._NumCivique != "0")
                _Residence.Afficher();  
        }

       
        //----------------------
        //
        //---------------------
        private int Age()
        {
            double delta = DateTime.Now.Ticks - _Naissance.Ticks;
            int deltaInt = (int) (delta/ 10000000 / (365.24 * 24 * 60 * 60));

            return (int)deltaInt;

          
        }

        //----------------------
        //
        //---------------------
        public void Mourir()
        {
            _Deces = DateTime.Now;
        }


    }
}
