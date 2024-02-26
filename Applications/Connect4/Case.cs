//---------------------------------
//   Fichier : Case.cs
//   Auteur  : Alain Martel
//   Date    : 2024-02-26
//---------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications.Connect4
{
    internal class Case
    {
        public string _Contenu { get; set; }
        int _colonne;
        int _rangee;

        //----------------------------------
        //
        //----------------------------------
        public Case(int col, int rang)
        {
            _colonne = col;
            _rangee = rang;
            _Contenu = "vide";
        }

        //----------------------------------
        //
        //----------------------------------
        public void Afficher()
        {
            Console.SetCursorPosition(_colonne * 4, _rangee + 6);
            Console.Write("___|");
        }
    }
}
