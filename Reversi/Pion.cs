using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    class Pion
    {
        //attributs de pion
        private Color couleur;
        private Size s_rect = new Size(65, 65);

        public Color Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public void Dessine(Graphics g, Size s_pion)
        {
            Rectangle r = new Rectangle(new Point(0,0),s_pion);
            r.X += (s_rect.Height - s_pion.Height)/2;
            r.Y += (s_rect.Width - s_pion.Width) / 2;
            SolidBrush SB = new SolidBrush(couleur);
            g.FillEllipse(SB, r);
        }    
    }
}
