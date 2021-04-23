namespace GSBCarpooling
{
    partial class FEN_Car
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
            this.L_Marque = new System.Windows.Forms.Label();
            this.SAI_Marque = new System.Windows.Forms.TextBox();
            this.SAI_Modele = new System.Windows.Forms.TextBox();
            this.L_Modele = new System.Windows.Forms.Label();
            this.SAI_Annee = new System.Windows.Forms.TextBox();
            this.L_Annnee = new System.Windows.Forms.Label();
            this.SAI_Couleur = new System.Windows.Forms.TextBox();
            this.L_Couleur = new System.Windows.Forms.Label();
            this.SAI_nbPlaces = new System.Windows.Forms.TextBox();
            this.L_NbPlaces = new System.Windows.Forms.Label();
            this.SAI_immatriculation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_TypeVehicule = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Carburant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SAI_userId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_Societe = new System.Windows.Forms.CheckBox();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Marque
            // 
            this.L_Marque.AutoSize = true;
            this.L_Marque.Location = new System.Drawing.Point(12, 29);
            this.L_Marque.Name = "L_Marque";
            this.L_Marque.Size = new System.Drawing.Size(43, 13);
            this.L_Marque.TabIndex = 0;
            this.L_Marque.Text = "Marque";
            // 
            // SAI_Marque
            // 
            this.SAI_Marque.Location = new System.Drawing.Point(95, 29);
            this.SAI_Marque.Name = "SAI_Marque";
            this.SAI_Marque.Size = new System.Drawing.Size(138, 20);
            this.SAI_Marque.TabIndex = 1;
            // 
            // SAI_Modele
            // 
            this.SAI_Modele.Location = new System.Drawing.Point(95, 55);
            this.SAI_Modele.Name = "SAI_Modele";
            this.SAI_Modele.Size = new System.Drawing.Size(138, 20);
            this.SAI_Modele.TabIndex = 3;
            // 
            // L_Modele
            // 
            this.L_Modele.AutoSize = true;
            this.L_Modele.Location = new System.Drawing.Point(12, 55);
            this.L_Modele.Name = "L_Modele";
            this.L_Modele.Size = new System.Drawing.Size(42, 13);
            this.L_Modele.TabIndex = 2;
            this.L_Modele.Text = "Modèle";
            // 
            // SAI_Annee
            // 
            this.SAI_Annee.Location = new System.Drawing.Point(95, 81);
            this.SAI_Annee.Name = "SAI_Annee";
            this.SAI_Annee.Size = new System.Drawing.Size(138, 20);
            this.SAI_Annee.TabIndex = 5;
            // 
            // L_Annnee
            // 
            this.L_Annnee.AutoSize = true;
            this.L_Annnee.Location = new System.Drawing.Point(12, 81);
            this.L_Annnee.Name = "L_Annnee";
            this.L_Annnee.Size = new System.Drawing.Size(38, 13);
            this.L_Annnee.TabIndex = 4;
            this.L_Annnee.Text = "Année";
            // 
            // SAI_Couleur
            // 
            this.SAI_Couleur.Location = new System.Drawing.Point(95, 107);
            this.SAI_Couleur.Name = "SAI_Couleur";
            this.SAI_Couleur.Size = new System.Drawing.Size(138, 20);
            this.SAI_Couleur.TabIndex = 7;
            // 
            // L_Couleur
            // 
            this.L_Couleur.AutoSize = true;
            this.L_Couleur.Location = new System.Drawing.Point(12, 107);
            this.L_Couleur.Name = "L_Couleur";
            this.L_Couleur.Size = new System.Drawing.Size(43, 13);
            this.L_Couleur.TabIndex = 6;
            this.L_Couleur.Text = "Couleur";
            // 
            // SAI_nbPlaces
            // 
            this.SAI_nbPlaces.Location = new System.Drawing.Point(95, 133);
            this.SAI_nbPlaces.Name = "SAI_nbPlaces";
            this.SAI_nbPlaces.Size = new System.Drawing.Size(138, 20);
            this.SAI_nbPlaces.TabIndex = 9;
            // 
            // L_NbPlaces
            // 
            this.L_NbPlaces.AutoSize = true;
            this.L_NbPlaces.Location = new System.Drawing.Point(12, 133);
            this.L_NbPlaces.Name = "L_NbPlaces";
            this.L_NbPlaces.Size = new System.Drawing.Size(56, 13);
            this.L_NbPlaces.TabIndex = 8;
            this.L_NbPlaces.Text = "Nb Places";
            // 
            // SAI_immatriculation
            // 
            this.SAI_immatriculation.Location = new System.Drawing.Point(95, 159);
            this.SAI_immatriculation.Name = "SAI_immatriculation";
            this.SAI_immatriculation.Size = new System.Drawing.Size(138, 20);
            this.SAI_immatriculation.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Immatriculation";
            // 
            // CB_TypeVehicule
            // 
            this.CB_TypeVehicule.FormattingEnabled = true;
            this.CB_TypeVehicule.Location = new System.Drawing.Point(16, 225);
            this.CB_TypeVehicule.Name = "CB_TypeVehicule";
            this.CB_TypeVehicule.Size = new System.Drawing.Size(196, 21);
            this.CB_TypeVehicule.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Type de véhicule";
            // 
            // CB_Carburant
            // 
            this.CB_Carburant.FormattingEnabled = true;
            this.CB_Carburant.Location = new System.Drawing.Point(16, 269);
            this.CB_Carburant.Name = "CB_Carburant";
            this.CB_Carburant.Size = new System.Drawing.Size(196, 21);
            this.CB_Carburant.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Carburant";
            // 
            // SAI_userId
            // 
            this.SAI_userId.Location = new System.Drawing.Point(95, 318);
            this.SAI_userId.Name = "SAI_userId";
            this.SAI_userId.Size = new System.Drawing.Size(138, 20);
            this.SAI_userId.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID Utilisateur";
            // 
            // CBX_Societe
            // 
            this.CBX_Societe.AutoSize = true;
            this.CBX_Societe.Location = new System.Drawing.Point(14, 354);
            this.CBX_Societe.Name = "CBX_Societe";
            this.CBX_Societe.Size = new System.Drawing.Size(120, 17);
            this.CBX_Societe.TabIndex = 31;
            this.CBX_Societe.Text = "Voiture de société ?";
            this.CBX_Societe.UseVisualStyleBackColor = true;
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Fermer.Location = new System.Drawing.Point(155, 419);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(96, 23);
            this.BTN_Fermer.TabIndex = 33;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Valider.Location = new System.Drawing.Point(51, 419);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(98, 23);
            this.BTN_Valider.TabIndex = 32;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // FEN_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.CBX_Societe);
            this.Controls.Add(this.SAI_userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Carburant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_TypeVehicule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SAI_immatriculation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SAI_nbPlaces);
            this.Controls.Add(this.L_NbPlaces);
            this.Controls.Add(this.SAI_Couleur);
            this.Controls.Add(this.L_Couleur);
            this.Controls.Add(this.SAI_Annee);
            this.Controls.Add(this.L_Annnee);
            this.Controls.Add(this.SAI_Modele);
            this.Controls.Add(this.L_Modele);
            this.Controls.Add(this.SAI_Marque);
            this.Controls.Add(this.L_Marque);
            this.Name = "FEN_Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un véhicule";
            this.Load += new System.EventHandler(this.FEN_Car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Marque;
        private System.Windows.Forms.TextBox SAI_Marque;
        private System.Windows.Forms.TextBox SAI_Modele;
        private System.Windows.Forms.Label L_Modele;
        private System.Windows.Forms.TextBox SAI_Annee;
        private System.Windows.Forms.Label L_Annnee;
        private System.Windows.Forms.TextBox SAI_Couleur;
        private System.Windows.Forms.Label L_Couleur;
        private System.Windows.Forms.TextBox SAI_nbPlaces;
        private System.Windows.Forms.Label L_NbPlaces;
        private System.Windows.Forms.TextBox SAI_immatriculation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_TypeVehicule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_Carburant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SAI_userId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBX_Societe;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Valider;
    }
}