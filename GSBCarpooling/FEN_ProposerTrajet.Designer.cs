namespace GSBCarpooling
{
    partial class FEN_ProposerTrajet
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
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.dateTimePicker_DateDepart = new System.Windows.Forms.DateTimePicker();
            this.C_VilleDepart = new System.Windows.Forms.ComboBox();
            this.C_VilleArrivee = new System.Windows.Forms.ComboBox();
            this.LB_Etapes = new System.Windows.Forms.ListBox();
            this.BTN_Etape = new System.Windows.Forms.Button();
            this.C_Etape = new System.Windows.Forms.ComboBox();
            this.L_Info = new System.Windows.Forms.Label();
            this.L_Date = new System.Windows.Forms.Label();
            this.L_Heure = new System.Windows.Forms.Label();
            this.L_VilleD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_SupprimerEtape = new System.Windows.Forms.Button();
            this.dateTimePicker_HeureDepart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.C_Vehicuke = new System.Windows.Forms.ComboBox();
            this.numericUpDown_nbPassagers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RTB_commentaire = new System.Windows.Forms.RichTextBox();
            this.L_commentaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPassagers)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(341, 380);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(104, 23);
            this.BTN_Valider.TabIndex = 0;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(451, 380);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(97, 23);
            this.BTN_Fermer.TabIndex = 1;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // dateTimePicker_DateDepart
            // 
            this.dateTimePicker_DateDepart.Location = new System.Drawing.Point(92, 13);
            this.dateTimePicker_DateDepart.Name = "dateTimePicker_DateDepart";
            this.dateTimePicker_DateDepart.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker_DateDepart.TabIndex = 2;
            // 
            // C_VilleDepart
            // 
            this.C_VilleDepart.FormattingEnabled = true;
            this.C_VilleDepart.Location = new System.Drawing.Point(92, 65);
            this.C_VilleDepart.Name = "C_VilleDepart";
            this.C_VilleDepart.Size = new System.Drawing.Size(216, 21);
            this.C_VilleDepart.TabIndex = 5;
            this.C_VilleDepart.TextChanged += new System.EventHandler(this.C_VilleDepart_TextChanged);
            // 
            // C_VilleArrivee
            // 
            this.C_VilleArrivee.FormattingEnabled = true;
            this.C_VilleArrivee.Location = new System.Drawing.Point(92, 92);
            this.C_VilleArrivee.Name = "C_VilleArrivee";
            this.C_VilleArrivee.Size = new System.Drawing.Size(216, 21);
            this.C_VilleArrivee.TabIndex = 6;
            this.C_VilleArrivee.TextChanged += new System.EventHandler(this.C_VilleArrivee_TextChanged);
            // 
            // LB_Etapes
            // 
            this.LB_Etapes.FormattingEnabled = true;
            this.LB_Etapes.Location = new System.Drawing.Point(92, 119);
            this.LB_Etapes.Name = "LB_Etapes";
            this.LB_Etapes.Size = new System.Drawing.Size(216, 147);
            this.LB_Etapes.TabIndex = 8;
            // 
            // BTN_Etape
            // 
            this.BTN_Etape.Location = new System.Drawing.Point(92, 299);
            this.BTN_Etape.Name = "BTN_Etape";
            this.BTN_Etape.Size = new System.Drawing.Size(216, 23);
            this.BTN_Etape.TabIndex = 9;
            this.BTN_Etape.Text = "Ajouter une étape";
            this.BTN_Etape.UseVisualStyleBackColor = true;
            this.BTN_Etape.Click += new System.EventHandler(this.BTN_Etape_Click);
            // 
            // C_Etape
            // 
            this.C_Etape.FormattingEnabled = true;
            this.C_Etape.Location = new System.Drawing.Point(92, 272);
            this.C_Etape.Name = "C_Etape";
            this.C_Etape.Size = new System.Drawing.Size(216, 21);
            this.C_Etape.TabIndex = 10;
            // 
            // L_Info
            // 
            this.L_Info.AutoSize = true;
            this.L_Info.Location = new System.Drawing.Point(314, 209);
            this.L_Info.Name = "L_Info";
            this.L_Info.Size = new System.Drawing.Size(73, 13);
            this.L_Info.TabIndex = 11;
            this.L_Info.Text = "Informations...";
            // 
            // L_Date
            // 
            this.L_Date.AutoSize = true;
            this.L_Date.Location = new System.Drawing.Point(8, 19);
            this.L_Date.Name = "L_Date";
            this.L_Date.Size = new System.Drawing.Size(78, 13);
            this.L_Date.TabIndex = 12;
            this.L_Date.Text = "Date de départ";
            // 
            // L_Heure
            // 
            this.L_Heure.AutoSize = true;
            this.L_Heure.Location = new System.Drawing.Point(2, 41);
            this.L_Heure.Name = "L_Heure";
            this.L_Heure.Size = new System.Drawing.Size(84, 13);
            this.L_Heure.TabIndex = 13;
            this.L_Heure.Text = "Heure de départ";
            // 
            // L_VilleD
            // 
            this.L_VilleD.AutoSize = true;
            this.L_VilleD.Location = new System.Drawing.Point(12, 68);
            this.L_VilleD.Name = "L_VilleD";
            this.L_VilleD.Size = new System.Drawing.Size(74, 13);
            this.L_VilleD.TabIndex = 14;
            this.L_VilleD.Text = "Ville de départ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ville d\'arrivée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Liste des étapes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Villes étape";
            // 
            // BTN_SupprimerEtape
            // 
            this.BTN_SupprimerEtape.Location = new System.Drawing.Point(92, 325);
            this.BTN_SupprimerEtape.Name = "BTN_SupprimerEtape";
            this.BTN_SupprimerEtape.Size = new System.Drawing.Size(216, 23);
            this.BTN_SupprimerEtape.TabIndex = 18;
            this.BTN_SupprimerEtape.Text = "Supprimer étape sélectionnée";
            this.BTN_SupprimerEtape.UseVisualStyleBackColor = true;
            this.BTN_SupprimerEtape.Click += new System.EventHandler(this.BTN_SupprimerEtape_Click);
            // 
            // dateTimePicker_HeureDepart
            // 
            this.dateTimePicker_HeureDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_HeureDepart.Location = new System.Drawing.Point(92, 41);
            this.dateTimePicker_HeureDepart.MinDate = new System.DateTime(2021, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker_HeureDepart.Name = "dateTimePicker_HeureDepart";
            this.dateTimePicker_HeureDepart.ShowUpDown = true;
            this.dateTimePicker_HeureDepart.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker_HeureDepart.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Véhicule utilisé";
            // 
            // C_Vehicuke
            // 
            this.C_Vehicuke.FormattingEnabled = true;
            this.C_Vehicuke.Location = new System.Drawing.Point(92, 355);
            this.C_Vehicuke.Name = "C_Vehicuke";
            this.C_Vehicuke.Size = new System.Drawing.Size(216, 21);
            this.C_Vehicuke.TabIndex = 20;
            this.C_Vehicuke.TextChanged += new System.EventHandler(this.C_Vehicuke_TextChanged);
            // 
            // numericUpDown_nbPassagers
            // 
            this.numericUpDown_nbPassagers.Location = new System.Drawing.Point(92, 383);
            this.numericUpDown_nbPassagers.Name = "numericUpDown_nbPassagers";
            this.numericUpDown_nbPassagers.Size = new System.Drawing.Size(216, 20);
            this.numericUpDown_nbPassagers.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nb passagers";
            // 
            // RTB_commentaire
            // 
            this.RTB_commentaire.Location = new System.Drawing.Point(313, 40);
            this.RTB_commentaire.Name = "RTB_commentaire";
            this.RTB_commentaire.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTB_commentaire.Size = new System.Drawing.Size(235, 147);
            this.RTB_commentaire.TabIndex = 25;
            this.RTB_commentaire.Text = "";
            this.RTB_commentaire.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // L_commentaire
            // 
            this.L_commentaire.AutoSize = true;
            this.L_commentaire.Location = new System.Drawing.Point(313, 17);
            this.L_commentaire.Name = "L_commentaire";
            this.L_commentaire.Size = new System.Drawing.Size(170, 13);
            this.L_commentaire.TabIndex = 26;
            this.L_commentaire.Text = "Commentaire (250 caractères max)";
            // 
            // FEN_ProposerTrajet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 413);
            this.Controls.Add(this.L_commentaire);
            this.Controls.Add(this.RTB_commentaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_nbPassagers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C_Vehicuke);
            this.Controls.Add(this.dateTimePicker_HeureDepart);
            this.Controls.Add(this.BTN_SupprimerEtape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_VilleD);
            this.Controls.Add(this.L_Heure);
            this.Controls.Add(this.L_Date);
            this.Controls.Add(this.L_Info);
            this.Controls.Add(this.C_Etape);
            this.Controls.Add(this.BTN_Etape);
            this.Controls.Add(this.LB_Etapes);
            this.Controls.Add(this.C_VilleArrivee);
            this.Controls.Add(this.C_VilleDepart);
            this.Controls.Add(this.dateTimePicker_DateDepart);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Valider);
            this.Name = "FEN_ProposerTrajet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proposer un trajet";
            this.Load += new System.EventHandler(this.FEN_ProposerTrajet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbPassagers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateDepart;
        private System.Windows.Forms.ComboBox C_VilleDepart;
        private System.Windows.Forms.ComboBox C_VilleArrivee;
        private System.Windows.Forms.ListBox LB_Etapes;
        private System.Windows.Forms.Button BTN_Etape;
        private System.Windows.Forms.ComboBox C_Etape;
        private System.Windows.Forms.Label L_Info;
        private System.Windows.Forms.Label L_Date;
        private System.Windows.Forms.Label L_Heure;
        private System.Windows.Forms.Label L_VilleD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_SupprimerEtape;
        private System.Windows.Forms.DateTimePicker dateTimePicker_HeureDepart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox C_Vehicuke;
        private System.Windows.Forms.NumericUpDown numericUpDown_nbPassagers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RTB_commentaire;
        private System.Windows.Forms.Label L_commentaire;
    }
}