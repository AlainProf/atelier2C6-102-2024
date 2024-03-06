using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2C6_102_2024.Applications.Poker
{
    internal class Paquet
    {
        Carte[] lesCartes = new Carte[52];  
        public Paquet() {
            int cpm = 0;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    lesCartes[cpm] = new Carte(j,i);
                        cpm++;
                }
            }
        }
        
        public void Afficher()
        {
            for(int i = 0;i < 52;i++) 
            {
                lesCartes[i].Afficher(true, i);    
            }
        }
    }
}
