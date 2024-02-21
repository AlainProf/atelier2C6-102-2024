using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024
{
    internal class Voiture
    {
        public string _Modele { get; set; }
        public string _Couleur { get; set; } 
        
        public void Afficher()
        {
            Console.WriteLine($"Une {_Modele} de couleur {_Couleur}");
        }

    }
}
