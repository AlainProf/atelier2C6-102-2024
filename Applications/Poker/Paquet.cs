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
        int _curseur = 0;
        public Paquet() {
            int cpm = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    lesCartes[cpm] = new Carte(i,j);
                        cpm++;
                }
            }
        }
        
        public void Afficher()
        {
            for(int i = 0;i < 52;i++) 
            {
                lesCartes[i].Afficher(true, i%13,  i/13);    
            }
        }

        public Carte Distribuer()
        {
            return lesCartes[_curseur++];
        }

        public void Melanger()
        {
            Random alea = new Random();

            for(int i = 52 -1; i>1; --i)
            {
                int randomIndex = alea.Next(i);
                Carte temp = lesCartes[i];
                lesCartes[i] = lesCartes[randomIndex];
                lesCartes[randomIndex] = temp;
            }
        }
    }
}
