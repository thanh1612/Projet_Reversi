using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Reversi
{
    public class Case : PictureBox
    {
        //attributs de case
        private Point origin = new Point(40, 40);
        private Pion pi = new Pion();
        private Size s_pion = new Size(50, 50);
        private Size s_pion_aide = new Size(31, 31);
        
        private int i; // position de case dans la grille
        public int I
        {
            get { return i; }
            set { i = value; }
        }

        private int j;
        public int J
        {
            get { return j; }
            set { j = value; }
        }

        private Color couleur;
        public Color Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        private bool present_pion = false;
        public bool Present_pion
        {
            get { return present_pion; }
            set { present_pion = value; }
        }

        private bool aide = false;
        public bool Aide
        {
            get { return aide; }
            set { aide = value; }
        }

        private Reversi r;
        private static int nb_Constructeur = 0; // variable pour Constructer par Main
        public bool check = false;      // changer de couleur Pion pour événement MouseDown.
        
        public Case(int a, int b, Reversi courrant)
        {
            i = a;
            j = b;
            r = courrant;
            Point po = new Point(origin.Y+ j*65, origin.X + i*65);
            this.Size = new Size(65, 65);
            this.Location = po;
            this.BorderStyle = BorderStyle.FixedSingle;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Turquoise);
            if (present_pion)
            {
                pi.Couleur = couleur;
                pi.Dessine(e.Graphics,s_pion);
                aide = false;
            }
            if (aide)
            {
                pi.Couleur = Color.Yellow;
                pi.Dessine(e.Graphics,s_pion_aide);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (r.Nb_noirs < 3 && r.Nb_blancs < 2) // cette condition c'est pour retourner
                nb_Constructeur = 0;            //   la valeur par defaut au debut de jeux
            else nb_Constructeur = 4;
            check = true;
            if (nb_Constructeur >= 4)
            {
                if (present_pion == false)
                {
                    couleur = r.LaMain.Couleur;
                    bool veri = r.RegleDuJeux(i, j);
                    r.LaMain.jouer(this, veri, r);
                }
            }
            else
            {
                #region Constructeur par main
                if ((i == 3 && j == 3) || (i == 4 && j == 4) ||
                    ((i == 3 && j == 4)) || (i == 4 && j == 3))
                {
                    if (present_pion == false)
                    {
                        bool sans_veri = true; // mettre 4 pion premier sans verifier la regle du jeux.
                        couleur = r.LaMain.Couleur;
                        r.LaMain.jouer(this, sans_veri, r);
                        nb_Constructeur += 1;
                        r.Compter_Pion();
                        r.Noirs.Text = r.Nb_noirs.ToString() + "  Noirs";
                        r.Blancs.Text = r.Nb_blancs.ToString() + "  Blancs";
                        r.Total_Pion.Text = "Total   " + nb_Constructeur.ToString();
                    }
                }
                else
                    MessageBox.Show("Vous devriez mettre 4 pions premiers à la position "+
                                "D4,E4,D5,E5 pour commencer le jeux.", "Notification");
                #endregion
            }
            check = false;
            r.reload();
            Refresh();
        }

        public void Clear()
        {
            couleur = new Color();
            present_pion = false;
            aide = false;
        }
        public string ToXML()
        {
            string text = "<case>";
            text += " <position>";
            text += " " + "{i=" + i.ToString()+",j=" +j.ToString()+"}";
            text += " </position>";
            text += " <present_pion>";
            text += " " + present_pion.ToString();
            text += " </present_pion>";
            text += " <couleur>";
            text += " " + couleur.ToArgb().ToString();
            text += " </couleur>";
            text += "</case>";
            return text;
        }

        public Case(XmlNode xNN)
        {
            foreach (XmlNode xNNN in xNN.ChildNodes)
            {
                switch (xNNN.Name)
                {
                    case "present_pion":
                        present_pion = bool.Parse(xNNN.InnerText);
                        break;
                    case "couleur":
                        int c = int.Parse(xNNN.InnerText);
                        couleur = Color.FromArgb(c);
                        break;
                    case "position":
                        string[] data = xNNN.InnerText.Split(',');
                        i = int.Parse(data[0].Split('=')[1]);
                        j = int.Parse(data[1].Replace("}", "").Split('=')[1]);
                        break;
                }
            }
        }

    }
}
