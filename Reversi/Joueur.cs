using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    class Joueur
    {
        // attributs de joueur
        private Color couleur;
        public Color Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        
        public void jouer(Case c, bool verifier,Reversi r)
        {
            if (verifier)
            {
                c.Present_pion = true;
                r.passer();
            }

        }
    }
}
