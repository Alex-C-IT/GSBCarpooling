namespace GSBCarpooling
{
    partial class FEN_GestionCars
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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.TABLE_Cars = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.societe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomProprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Actualiser = new System.Windows.Forms.Button();
            this.BTN_Disable = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.BTN_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Cars)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Fermer.Location = new System.Drawing.Point(693, 425);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(97, 23);
            this.BTN_Fermer.TabIndex = 15;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // TABLE_Cars
            // 
            this.TABLE_Cars.AllowUserToAddRows = false;
            this.TABLE_Cars.AllowUserToDeleteRows = false;
            this.TABLE_Cars.AllowUserToOrderColumns = true;
            this.TABLE_Cars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_Cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marque,
            this.Modele,
            this.Annee,
            this.couleur,
            this.nbPlaces,
            this.societe,
            this.immatriculation,
            this.carburant,
            this.nomProprietaire,
            this.prenomProprietaire,
            this.typeVehicule});
            this.TABLE_Cars.Location = new System.Drawing.Point(7, 95);
            this.TABLE_Cars.Name = "TABLE_Cars";
            this.TABLE_Cars.ReadOnly = true;
            this.TABLE_Cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_Cars.Size = new System.Drawing.Size(781, 325);
            this.TABLE_Cars.TabIndex = 14;
            this.TABLE_Cars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_Cars_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Marque
            // 
            this.Marque.HeaderText = "Marque";
            this.Marque.Name = "Marque";
            this.Marque.ReadOnly = true;
            // 
            // Modele
            // 
            this.Modele.HeaderText = "Modèle";
            this.Modele.Name = "Modele";
            this.Modele.ReadOnly = true;
            // 
            // Annee
            // 
            this.Annee.HeaderText = "Année";
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            // 
            // couleur
            // 
            this.couleur.HeaderText = "Couleur";
            this.couleur.Name = "couleur";
            this.couleur.ReadOnly = true;
            // 
            // nbPlaces
            // 
            this.nbPlaces.HeaderText = "Nb Places";
            this.nbPlaces.Name = "nbPlaces";
            this.nbPlaces.ReadOnly = true;
            // 
            // societe
            // 
            this.societe.HeaderText = "Societe ?";
            this.societe.Name = "societe";
            this.societe.ReadOnly = true;
            this.societe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.societe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // immatriculation
            // 
            this.immatriculation.HeaderText = "Immatriculation";
            this.immatriculation.Name = "immatriculation";
            this.immatriculation.ReadOnly = true;
            // 
            // carburant
            // 
            this.carburant.HeaderText = "Carburant";
            this.carburant.Name = "carburant";
            this.carburant.ReadOnly = true;
            // 
            // nomProprietaire
            // 
            this.nomProprietaire.HeaderText = "Nom propriétaire";
            this.nomProprietaire.Name = "nomProprietaire";
            this.nomProprietaire.ReadOnly = true;
            // 
            // prenomProprietaire
            // 
            this.prenomProprietaire.HeaderText = "Prénom propriétaire";
            this.prenomProprietaire.Name = "prenomProprietaire";
            this.prenomProprietaire.ReadOnly = true;
            // 
            // typeVehicule
            // 
            this.typeVehicule.HeaderText = "Type véhicule";
            this.typeVehicule.Name = "typeVehicule";
            this.typeVehicule.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.applicationToolStripMenuItem.Text = "GSBCarpooling";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.FermerToolStripMenuItem_Click);
            // 
            // BTN_Actualiser
            // 
            this.BTN_Actualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Actualiser.Image = global::GSBCarpooling.Properties.Resources.actualiser;
            this.BTN_Actualiser.Location = new System.Drawing.Point(696, 59);
            this.BTN_Actualiser.Name = "BTN_Actualiser";
            this.BTN_Actualiser.Size = new System.Drawing.Size(95, 31);
            this.BTN_Actualiser.TabIndex = 16;
            this.BTN_Actualiser.UseVisualStyleBackColor = true;
            this.BTN_Actualiser.Click += new System.EventHandler(this.BTN_Actualiser_Click);
            // 
            // BTN_Disable
            // 
            this.BTN_Disable.Image = global::GSBCarpooling.Properties.Resources.delete;
            this.BTN_Disable.Location = new System.Drawing.Point(199, 29);
            this.BTN_Disable.Name = "BTN_Disable";
            this.BTN_Disable.Size = new System.Drawing.Size(90, 61);
            this.BTN_Disable.TabIndex = 13;
            this.BTN_Disable.UseVisualStyleBackColor = true;
            this.BTN_Disable.Click += new System.EventHandler(this.BTN_Disable_Click);
            // 
            // Modifier
            // 
            this.Modifier.Image = global::GSBCarpooling.Properties.Resources.clipart12307922;
            this.Modifier.Location = new System.Drawing.Point(103, 29);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(90, 61);
            this.Modifier.TabIndex = 12;
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // BTN_Nouveau
            // 
            this.BTN_Nouveau.Image = global::GSBCarpooling.Properties.Resources.add;
            this.BTN_Nouveau.Location = new System.Drawing.Point(7, 29);
            this.BTN_Nouveau.Name = "BTN_Nouveau";
            this.BTN_Nouveau.Size = new System.Drawing.Size(90, 61);
            this.BTN_Nouveau.TabIndex = 11;
            this.BTN_Nouveau.UseVisualStyleBackColor = true;
            this.BTN_Nouveau.Click += new System.EventHandler(this.BTN_Nouveau_Click);
            // 
            // FEN_GestionCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTN_Actualiser);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.TABLE_Cars);
            this.Controls.Add(this.BTN_Disable);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.BTN_Nouveau);
            this.Name = "FEN_GestionCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des véhicules";
            this.Load += new System.EventHandler(this.FEN_GestionCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Cars)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Actualiser;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.DataGridView TABLE_Cars;
        private System.Windows.Forms.Button BTN_Disable;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button BTN_Nouveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewCheckBoxColumn societe;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn carburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomProprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeVehicule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
    }
}