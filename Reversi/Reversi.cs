using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Reversi
{
    public partial class Reversi : Form
    {
        // attributs de case
        Case[,] grille = new Case[8, 8];

        // attributs de joueur
        private Joueur noir = new Joueur();
        internal Joueur Noir
        {
            get { return noir; }
            set { noir = value; }
        }

        private Joueur blanc = new Joueur();

        private Joueur laMain = new Joueur();
        internal Joueur LaMain
        {
            get { return laMain; }
            set { laMain = value; }
        }

        private int nb_noirs;              // variables pour compter les Pions 
                                             //de chaque joueur dans le jeux.
        public int Nb_noirs
        {
            get { return nb_noirs; }
            set { nb_noirs = value; }
        }

        private int nb_blancs;
        public int Nb_blancs
        {
            get { return nb_blancs; }
            set { nb_blancs = value; }
        }    
        
        // attributs de vérifier la fin du jeux.
        private int move_noir;          //    
        private int move_blanc;         // compter les Pions possible de mouvement dans le jeux.
        private int move_possible;  //     

        public Reversi()
        {
            InitializeComponent();
            Constructeur();
        }

        private void Constructeur()
        {
            noir.Couleur = Color.Black; 
            blanc.Couleur = Color.White;
            laMain = noir;
            #region Constructeur case
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grille[i, j] = new Case(i, j, this);
                    this.Controls.Add(grille[i, j]);
                }
            }
            #endregion
        }

        public void reload()
        {
            Compter_Pion();              // mettre à jour les Pions de chaque joueur.
            this.Noirs.Text = nb_noirs.ToString() + "  Noirs";
            this.Blancs.Text = nb_blancs.ToString() + "  Blancs";
            int total = nb_noirs + nb_blancs;
            this.Total_Pion.Text = "Total   " + total.ToString();

            #region Mettre à jour la tour de joueur
            if (laMain.Couleur == noir.Couleur)
                this.Afficher_Tour.Text = "                Au noir de jouer";
            else
                this.Afficher_Tour.Text = "                Au blanc de jouer";
            #endregion

            if (total >= 4)  // si 4 pions sont mis, marcher la fonction fin_Jeux pour verifier la fin du jeux.
            {
                if (fin_Jeux())
                {
                    if (nb_noirs > nb_blancs)
                        this.Afficher_Tour.Text = "Bravo, le joueur Noir gagne le jeux";
                    else if (nb_noirs < nb_blancs)
                        this.Afficher_Tour.Text = "Bravo, le joueur Blanc gagne le jeux";
                    else
                        this.Afficher_Tour.Text = "                        Égalité!";
                    rejouer();
                }
            }
        }

        public bool RegleDuJeux(int m, int n) 
        // vérifier si le case[i,j] est possible pour mettre pion
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == m && j ==n)
                    {
                        bool ver1 = verifier_right(i, j);
                        bool ver2 = verifier_left(i, j);
                        bool ver3 = verifier_up(i, j);
                        bool ver4 = verifier_down(i, j);
                        bool ver5 = verifier_left_up(i, j);
                        bool ver6 = verifier_right_up(i, j);
                        bool ver7 = verifier_right_down(i, j);
                        bool ver8 = verifier_left_down(i, j);
                        bool verifier = (ver1 || ver2 || ver3 || ver4 || ver5 || ver6 || ver7 || ver8);
                        return verifier;
                    }
                }
            }
            return false;
        }  

        
        /************************************************/
        #region vérifier selon le règle du jeux
        private bool verifier_down(int i, int j)
        {
            if (i + 1 < 8 && grille[i, j].Couleur.ToArgb() == grille[i + 1, j].Couleur.ToArgb())
                return false;
            else
                for (int k = i + 1; k < 8; k++)
                {
                    if (grille[k,j].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, j].Couleur.ToArgb() )
                        {
                            if (grille[i,j].check)
                            {
                                for (k = k - 1; k > i; k--)
                                {
                                    grille[k, j].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            return false;
        }
        private bool verifier_up(int i, int j)
        {
            if (i - 1 >= 0 && grille[i, j].Couleur.ToArgb() == grille[i - 1, j].Couleur.ToArgb())
                return false  ;
            else
                for (int k = i-1; k >= 0; k--)
                {
                    if (grille[k, j].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, j].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k + 1; k < i; k++)
                                {
                                    grille[k, j].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true ;
                        }
                    }
                    else return false ;
                }
            return false;
        }
        private bool verifier_left(int i, int j)
        {
            if (j - 1 >= 0 && grille[i, j].Couleur.ToArgb() == grille[i, j - 1].Couleur.ToArgb())
                return false ;
            else
                for (int k = j - 1; k >= 0; k--)
                {
                    if (grille[i, k].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[i, k].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k + 1; k < j; k++)
                                {
                                    grille[i, k].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            return false;
        }
        private bool verifier_right(int i, int j)
        {
            if (j + 1 < 8 && grille[i, j].Couleur.ToArgb() == grille[i, j + 1].Couleur.ToArgb())
                return false  ;
            else
                for (int k = j + 1; k < 8; k++)
                {
                    if (grille[i, k].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[i, k].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k - 1; k > j; k--)
                                {
                                    grille[i, k].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            return false ;
        }
        private bool verifier_left_up (int i, int j)
        {
            if (i - 1 >= 0 && j - 1 >= 0 && 
                grille[i, j].Couleur.ToArgb() == grille[i - 1, j - 1].Couleur.ToArgb())
                return false;
            else
            {
                int l = j;
                for (int k = i - 1; k >= 0; k--)
                {
                    l -= 1;
                    if (l >= 0 && grille[k, l].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, l].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k + 1; k < i; k++)
                                {
                                    l += 1;
                                    grille[k, l].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            }
            return false;
        }
        private bool verifier_right_up(int i, int j)
        {
            if (i - 1 >= 0 && j + 1 < 8 &&
                grille[i, j].Couleur.ToArgb() == grille[i - 1, j + 1].Couleur.ToArgb())
                return false;
            else
            {
                int l = j;
                for (int k = i - 1; k >= 0; k--)
                {
                    l += 1;
                    if (l < 8 && grille[k, l].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, l].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k + 1; k < i; k++)
                                {
                                    l -= 1;
                                    grille[k, l].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            }
            return false;
        }
        private bool verifier_right_down(int i, int j)
        {
            if (i + 1 < 8 && j + 1 < 8 &&
                grille[i, j].Couleur.ToArgb() == grille[i + 1, j + 1].Couleur.ToArgb())
                return false;
            else
            {
                int l = j;
                for (int k = i + 1; k < 8; k++)
                {
                    l += 1;
                    if (l < 8 && grille[k, l].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, l].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k - 1; k > i; k--)
                                {
                                    l -= 1;
                                    grille[k, l].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            }
            return false;
        }
        private bool verifier_left_down(int i, int j)
        {
            if (i + 1 < 8 && j - 1 >= 0 &&
                grille[i, j].Couleur.ToArgb() == grille[i + 1, j - 1].Couleur.ToArgb())
                return false;
            else
            {
                int l = j;
                for (int k = i + 1; k < 8; k++)
                {
                    l -= 1;
                    if (l >= 0 && grille[k, l].Present_pion)
                    {
                        if (grille[i, j].Couleur.ToArgb() == grille[k, l].Couleur.ToArgb())
                        {
                            if (grille[i, j].check)
                            {
                                for (k = k - 1; k > i; k--)
                                {
                                    l += 1;
                                    grille[k, l].Couleur = grille[i, j].Couleur;
                                }
                            }
                            return true;
                        }
                    }
                    else return false;
                }
            }
            return false;
        }
        #endregion
        /*************************************************/


        public bool fin_Jeux()
        {
            aide(); // compter les mouvements possibles.
            if (move_possible == 0)
                passer();
            if (move_blanc == 0 && move_noir == 0)
                return true;
            return false;
        }
        public void aide()
        {
            move_possible = 0;
            move_blanc = 0;
            move_noir = 0;
            not_aide();             // éclaircir les cases aides anciens
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (grille[i, j].Present_pion == false)
                    {
                        grille[i, j].Couleur = laMain.Couleur;

                        bool ver1 = verifier_right(i, j);
                        bool ver2 = verifier_left(i, j);
                        bool ver3 = verifier_up(i, j);
                        bool ver4 = verifier_down(i, j);
                        bool ver5 = verifier_left_up(i, j);
                        bool ver6 = verifier_right_up(i, j);
                        bool ver7 = verifier_right_down(i, j);
                        bool ver8 = verifier_left_down(i, j);
                        bool verifier = (ver1 || ver2 || ver3 || ver4 || ver5 || ver6 || ver7 || ver8);

                        if (verifier) //variable pour vérifier si aucune case est possible pour mettre pion.
                        {
                            if (Aide.Checked) // afficher les cases aides
                                grille[i, j].Aide = true;
                            if (laMain.Couleur == noir.Couleur)     // compter les mouvement possible
                            {
                                move_noir += 1;
                                move_possible = move_noir;
                            }
                            else
                            {
                                move_blanc += 1;
                                move_possible = move_blanc;
                            }
                        }
                    }
                }
            }
        }
        private void not_aide()
        {
            for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        grille[i, j].Aide = false;
                    }
                }
        }
        private void Aide_Check(object sender, EventArgs e)
        {
            if (Aide.Checked && nb_noirs+nb_blancs >=4)
                aide();
            else
                not_aide();
            Refresh();
        }

        public void Compter_Pion()
        {
            nb_noirs = 0; nb_blancs = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    grille[i, j].Refresh();
                    if (grille[i, j].Present_pion && grille[i, j].Couleur.ToArgb() == noir.Couleur.ToArgb())
                        nb_noirs++;
                    if (grille[i, j].Present_pion && grille[i, j].Couleur.ToArgb() == blanc.Couleur.ToArgb())
                        nb_blancs++;
                }
            }
        }
        private void rejouer()
        { 
            var result = MessageBox.Show("Confirmer?", "Rejouer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        grille[i, j].Clear();
                nb_noirs = 0;
                nb_blancs = 0;
                laMain = noir;
                reload();
            }
        }
        private void Rejouer_Click(object sender, EventArgs e)
        {
            rejouer();
            Refresh();
        }

        public void passer()
        {
            if (laMain.Couleur == noir.Couleur)
            {
                laMain = blanc;
                this.Afficher_Tour.Text = "                Au blanc de jouer";
            }
            else
            {
                laMain = noir;
                this.Afficher_Tour.Text = "                Au noir de jouer";
            }
            if (nb_noirs + nb_blancs >= 3)
                aide();
            Refresh();
        }
        private void Passer_Click(object sender, EventArgs e)
        {
            if (nb_noirs + nb_blancs >= 4)
            {
                passer();
                fin_Jeux(); // si le joueur passer la main mais le reste joueur
                            // ne peut pas mettre pion, repasser.
            }
        }
        
        private void Quitter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirmer?", "Quitter", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (nb_blancs+nb_noirs>=4)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                    enregistrerXML(saveDialog.FileName);
            }
            else
                MessageBox.Show("Pour enregistrer le jeux, vous devriez mettre 4 pions premiers.","Erreur");
        }
        private void enregistrerXML(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("<!--?xml version=\"1.0\" encoding=\"UTF-8\" ?--> ");
            sw.WriteLine("<reversi>");
            //  sauvegarder des cases            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sw.WriteLine(grille[i, j].ToXML());
                }
            }
            //  sauvegarder la tour de joueur et Aide_Checked.
            if (laMain.Couleur == noir.Couleur)
                sw.WriteLine("<tour>noir</tour>");
            else sw.WriteLine("<tour>blanc</tour>");
            sw.WriteLine("<aide>" + Aide.Checked.ToString() + "</aide>");
            sw.WriteLine("</reversi>");
            sw.Close();
        }

        private void Ouvrir_CLick(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "Fichier xml|*.xml";
            opfd.Title = "Choisir le fichier";
            opfd.InitialDirectory =
                   Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                recharger(opfd.FileName);
                reload();
                Refresh();
            }
        }
        private void recharger(string fileName)
        {
            // tentatitive d'éxécution du chargement d'un fichier
            try
            {
                #region codeprotégé
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                foreach (XmlNode xN in doc.ChildNodes)
                {
                    if (xN.Name == "reversi")
                    {
                        foreach (XmlNode xNN in xN.ChildNodes)
                        {
                            switch (xNN.Name)
                            {
                                case "case":
                                    Case c = new Case(xNN);
                                    grille[c.I, c.J].Present_pion = c.Present_pion;
                                    if (c.Present_pion )
                                        grille[c.I, c.J].Couleur = c.Couleur;
                                    break;
                                case "tour":
                                    if (xNN.InnerText.ToString() == "noir")
                                        laMain = noir;
                                    else if (xNN.InnerText.ToString() == "blanc")
                                        laMain = blanc;
                                    break;
                                case "aide":
                                    Aide.Checked = bool.Parse(xNN.InnerText);
                                    break;
                            }
                        }
                    }
                }
                #endregion
            }
            catch (FormatException)
            {
                MessageBox.Show(" le fichier " + fileName + " n'est utulisable, valeurs incorectes dans le fichier", "Erreur");
            }
            catch (Exception)
            {
                MessageBox.Show(" le fichier " + fileName + " n'est utulisable", "Autre Erreur");
            }
        }
    }
}
