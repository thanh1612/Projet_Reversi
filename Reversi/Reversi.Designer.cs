namespace Reversi
{
    partial class Reversi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aide = new System.Windows.Forms.CheckBox();
            this.Sauvegarder = new System.Windows.Forms.Button();
            this.Passer = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.Label();
            this.Blancs = new System.Windows.Forms.Label();
            this.Noirs = new System.Windows.Forms.Label();
            this.Afficher_Tour = new System.Windows.Forms.Label();
            this.Total_Pion = new System.Windows.Forms.Label();
            this.Ouvrir = new System.Windows.Forms.Button();
            this.Rejouer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.Label();
            this.E1 = new System.Windows.Forms.Label();
            this.F1 = new System.Windows.Forms.Label();
            this.G1 = new System.Windows.Forms.Label();
            this.H1 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.V2 = new System.Windows.Forms.Label();
            this.V3 = new System.Windows.Forms.Label();
            this.V4 = new System.Windows.Forms.Label();
            this.V5 = new System.Windows.Forms.Label();
            this.V6 = new System.Windows.Forms.Label();
            this.V7 = new System.Windows.Forms.Label();
            this.V8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aide
            // 
            this.Aide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Aide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Aide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aide.Location = new System.Drawing.Point(816, 40);
            this.Aide.Margin = new System.Windows.Forms.Padding(4);
            this.Aide.Name = "Aide";
            this.Aide.Size = new System.Drawing.Size(131, 48);
            this.Aide.TabIndex = 6;
            this.Aide.Text = "Aide";
            this.Aide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aide.UseVisualStyleBackColor = false;
            this.Aide.CheckedChanged += new System.EventHandler(this.Aide_Check);
            // 
            // Sauvegarder
            // 
            this.Sauvegarder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sauvegarder.Location = new System.Drawing.Point(816, 325);
            this.Sauvegarder.Name = "Sauvegarder";
            this.Sauvegarder.Size = new System.Drawing.Size(140, 50);
            this.Sauvegarder.TabIndex = 14;
            this.Sauvegarder.Text = "Sauvegarder";
            this.Sauvegarder.UseVisualStyleBackColor = false;
            this.Sauvegarder.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Passer
            // 
            this.Passer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Passer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passer.Location = new System.Drawing.Point(816, 505);
            this.Passer.Name = "Passer";
            this.Passer.Size = new System.Drawing.Size(140, 50);
            this.Passer.TabIndex = 10;
            this.Passer.Text = "Passer";
            this.Passer.UseVisualStyleBackColor = false;
            this.Passer.Click += new System.EventHandler(this.Passer_Click);
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores.Location = new System.Drawing.Point(811, 98);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(89, 29);
            this.Scores.TabIndex = 7;
            this.Scores.Text = "Scores";
            // 
            // Blancs
            // 
            this.Blancs.AutoSize = true;
            this.Blancs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blancs.Location = new System.Drawing.Point(829, 148);
            this.Blancs.Name = "Blancs";
            this.Blancs.Size = new System.Drawing.Size(92, 25);
            this.Blancs.TabIndex = 8;
            this.Blancs.Text = "0  Blancs";
            // 
            // Noirs
            // 
            this.Noirs.AutoSize = true;
            this.Noirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noirs.Location = new System.Drawing.Point(829, 198);
            this.Noirs.Name = "Noirs";
            this.Noirs.Size = new System.Drawing.Size(78, 25);
            this.Noirs.TabIndex = 9;
            this.Noirs.Text = "0  Noirs";
            // 
            // Afficher_Tour
            // 
            this.Afficher_Tour.AutoSize = true;
            this.Afficher_Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficher_Tour.Location = new System.Drawing.Point(227, 710);
            this.Afficher_Tour.Name = "Afficher_Tour";
            this.Afficher_Tour.Size = new System.Drawing.Size(149, 25);
            this.Afficher_Tour.TabIndex = 11;
            this.Afficher_Tour.Text = "                Au noir de jouer";
            // 
            // Total_Pion
            // 
            this.Total_Pion.AutoSize = true;
            this.Total_Pion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Pion.Location = new System.Drawing.Point(811, 248);
            this.Total_Pion.Name = "Total_Pion";
            this.Total_Pion.Size = new System.Drawing.Size(99, 29);
            this.Total_Pion.TabIndex = 12;
            this.Total_Pion.Text = "Total   0";
            // 
            // Ouvrir
            // 
            this.Ouvrir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ouvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ouvrir.Location = new System.Drawing.Point(816, 415);
            this.Ouvrir.Name = "Ouvrir";
            this.Ouvrir.Size = new System.Drawing.Size(140, 50);
            this.Ouvrir.TabIndex = 13;
            this.Ouvrir.Text = "Ouvrir";
            this.Ouvrir.UseVisualStyleBackColor = false;
            this.Ouvrir.Click += new System.EventHandler(this.Ouvrir_CLick);
            // 
            // Rejouer
            // 
            this.Rejouer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejouer.Location = new System.Drawing.Point(816, 595);
            this.Rejouer.Margin = new System.Windows.Forms.Padding(4);
            this.Rejouer.Name = "Rejouer";
            this.Rejouer.Size = new System.Drawing.Size(140, 50);
            this.Rejouer.TabIndex = 3;
            this.Rejouer.Text = "Rejouer";
            this.Rejouer.UseVisualStyleBackColor = false;
            this.Rejouer.Click += new System.EventHandler(this.Rejouer_Click);
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.RosyBrown;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(816, 685);
            this.Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(140, 50);
            this.Quitter.TabIndex = 4;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(80, 8);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(20, 20);
            this.A1.TabIndex = 15;
            this.A1.Text = "A";
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(170, 8);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(21, 20);
            this.B1.TabIndex = 16;
            this.B1.Text = "B";
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(255, 8);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(21, 20);
            this.C1.TabIndex = 17;
            this.C1.Text = "C";
            // 
            // D1
            // 
            this.D1.AutoSize = true;
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(340, 8);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(22, 20);
            this.D1.TabIndex = 18;
            this.D1.Text = "D";
            // 
            // E1
            // 
            this.E1.AutoSize = true;
            this.E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1.Location = new System.Drawing.Point(430, 8);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(20, 20);
            this.E1.TabIndex = 19;
            this.E1.Text = "E";
            // 
            // F1
            // 
            this.F1.AutoSize = true;
            this.F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1.Location = new System.Drawing.Point(520, 8);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(19, 20);
            this.F1.TabIndex = 20;
            this.F1.Text = "F";
            // 
            // G1
            // 
            this.G1.AutoSize = true;
            this.G1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G1.Location = new System.Drawing.Point(600, 8);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(22, 20);
            this.G1.TabIndex = 21;
            this.G1.Text = "G";
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.Location = new System.Drawing.Point(690, 8);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(22, 20);
            this.H1.TabIndex = 22;
            this.H1.Text = "H";
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V1.Location = new System.Drawing.Point(12, 79);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(18, 20);
            this.V1.TabIndex = 31;
            this.V1.Text = "1";
            // 
            // V2
            // 
            this.V2.AutoSize = true;
            this.V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V2.Location = new System.Drawing.Point(12, 159);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(18, 20);
            this.V2.TabIndex = 32;
            this.V2.Text = "2";
            // 
            // V3
            // 
            this.V3.AutoSize = true;
            this.V3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V3.Location = new System.Drawing.Point(12, 239);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(18, 20);
            this.V3.TabIndex = 33;
            this.V3.Text = "3";
            // 
            // V4
            // 
            this.V4.AutoSize = true;
            this.V4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V4.Location = new System.Drawing.Point(12, 319);
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(18, 20);
            this.V4.TabIndex = 34;
            this.V4.Text = "4";
            // 
            // V5
            // 
            this.V5.AutoSize = true;
            this.V5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V5.Location = new System.Drawing.Point(12, 399);
            this.V5.Name = "V5";
            this.V5.Size = new System.Drawing.Size(18, 20);
            this.V5.TabIndex = 35;
            this.V5.Text = "5";
            // 
            // V6
            // 
            this.V6.AutoSize = true;
            this.V6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V6.Location = new System.Drawing.Point(12, 479);
            this.V6.Name = "V6";
            this.V6.Size = new System.Drawing.Size(18, 20);
            this.V6.TabIndex = 36;
            this.V6.Text = "6";
            // 
            // V7
            // 
            this.V7.AutoSize = true;
            this.V7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V7.Location = new System.Drawing.Point(12, 559);
            this.V7.Name = "V7";
            this.V7.Size = new System.Drawing.Size(18, 20);
            this.V7.TabIndex = 37;
            this.V7.Text = "7";
            // 
            // V8
            // 
            this.V8.AutoSize = true;
            this.V8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V8.Location = new System.Drawing.Point(12, 639);
            this.V8.Name = "V8";
            this.V8.Size = new System.Drawing.Size(18, 20);
            this.V8.TabIndex = 38;
            this.V8.Text = "8";
            // 
            // Reversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(993, 756);
            this.Controls.Add(this.V8);
            this.Controls.Add(this.V7);
            this.Controls.Add(this.V6);
            this.Controls.Add(this.V5);
            this.Controls.Add(this.V4);
            this.Controls.Add(this.V3);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.H1);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.Sauvegarder);
            this.Controls.Add(this.Ouvrir);
            this.Controls.Add(this.Total_Pion);
            this.Controls.Add(this.Afficher_Tour);
            this.Controls.Add(this.Passer);
            this.Controls.Add(this.Noirs);
            this.Controls.Add(this.Blancs);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.Aide);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Rejouer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reversi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Aide;
        private System.Windows.Forms.Button Sauvegarder;
        private System.Windows.Forms.Button Ouvrir;
        private System.Windows.Forms.Button Passer;
        private System.Windows.Forms.Button Rejouer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label Scores;
        public System.Windows.Forms.Label Blancs;
        public System.Windows.Forms.Label Noirs;
        public System.Windows.Forms.Label Afficher_Tour;
        public System.Windows.Forms.Label Total_Pion;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.Label E1;
        private System.Windows.Forms.Label F1;
        private System.Windows.Forms.Label G1;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.Label V2;
        private System.Windows.Forms.Label V3;
        private System.Windows.Forms.Label V4;
        private System.Windows.Forms.Label V5;
        private System.Windows.Forms.Label V6;
        private System.Windows.Forms.Label V7;
        private System.Windows.Forms.Label V8;
    }
}

