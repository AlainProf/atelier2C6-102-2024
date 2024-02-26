//---------------------------------
//   Fichier : Adresse.cs
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
    internal class Adresse
    {
        public string _NumCivique { get; set; }
        public string _Rue { get; set; }
        public string _Ville { get; set; }
        public string _Province { get; set; }
        public string _CodePostal { get; set; }

        //----------------------------------
        //
        //----------------------------------
        public Adresse()
        {
            _NumCivique = "0";
            _Rue = "inconnue";
            _Ville = "inconnue";
            _Province = "inconnue";
            _CodePostal = "A1A1A1";
        }

        //----------------------------------
        //
        //----------------------------------
        public Adresse(string num, string r, string v, string p, string cp)
        {
            _NumCivique = num;
            _Rue = r;
            _Ville = v;
            _Province = p;
            _CodePostal = cp;
        }

        //----------------------------------
        //
        //----------------------------------
        public void Afficher()
        {
            Console.WriteLine("Num ciniquee:{0} {1}\n{2}\n{3}\n{4}", _NumCivique, _Rue, _Ville, _Province, _CodePostal);
        }
    }
}
