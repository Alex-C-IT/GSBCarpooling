namespace GSBCarpooling
{
    partial class FEN_Admin
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
            this.L_Welcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_GestionUsers = new System.Windows.Forms.ToolStripButton();
            this.BTN_GestionCars = new System.Windows.Forms.ToolStripButton();
            this.BTN_GestionTrajets = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Quitter = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_UtilisationVehicule = new System.Windows.Forms.Label();
            this.CBX_Annees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TABLE_UtilisationVehicules = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbUtilisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_UtilisationVehicules)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Welcome
            // 
            this.L_Welcome.AutoSize = true;
            this.L_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Welcome.Location = new System.Drawing.Point(12, 92);
            this.L_Welcome.Name = "L_Welcome";
            this.L_Welcome.Size = new System.Drawing.Size(71, 20);
            this.L_Welcome.TabIndex = 0;
            this.L_Welcome.Text = "Bonjour";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_GestionUsers,
            this.BTN_GestionCars,
            this.BTN_GestionTrajets,
            this.toolStripSeparator1,
            this.BTN_Quitter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_GestionUsers
            // 
            this.BTN_GestionUsers.AutoSize = false;
            this.BTN_GestionUsers.BackgroundImage = global::GSBCarpooling.Properties.Resources.user;
            this.BTN_GestionUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_GestionUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_GestionUsers.Image = global::GSBCarpooling.Properties.Resources.user;
            this.BTN_GestionUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_GestionUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_GestionUsers.Name = "BTN_GestionUsers";
            this.BTN_GestionUsers.Size = new System.Drawing.Size(150, 55);
            this.BTN_GestionUsers.Text = "Gestion des utilisateurs";
            this.BTN_GestionUsers.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // BTN_GestionCars
            // 
            this.BTN_GestionCars.AutoSize = false;
            this.BTN_GestionCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_GestionCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_GestionCars.Image = global::GSBCarpooling.Properties.Resources.vehicule1;
            this.BTN_GestionCars.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_GestionCars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_GestionCars.Name = "BTN_GestionCars";
            this.BTN_GestionCars.Size = new System.Drawing.Size(150, 55);
            this.BTN_GestionCars.Text = "Gestion des véhicules";
            this.BTN_GestionCars.Click += new System.EventHandler(this.BTN_GestionCars_Click);
            // 
            // BTN_GestionTrajets
            // 
            this.BTN_GestionTrajets.AutoSize = false;
            this.BTN_GestionTrajets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_GestionTrajets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_GestionTrajets.Image = global::GSBCarpooling.Properties.Resources.trajet1;
            this.BTN_GestionTrajets.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_GestionTrajets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_GestionTrajets.Name = "BTN_GestionTrajets";
            this.BTN_GestionTrajets.Size = new System.Drawing.Size(150, 55);
            this.BTN_GestionTrajets.Text = "Gestion des trajets";
            this.BTN_GestionTrajets.Click += new System.EventHandler(this.BTN_GestionTrajets_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.AutoSize = false;
            this.BTN_Quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Quitter.Image = global::GSBCarpooling.Properties.Resources.quitter1;
            this.BTN_Quitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_Quitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(55, 55);
            this.BTN_Quitter.Text = "Quitter l\'espace administration";
            this.BTN_Quitter.ToolTipText = "Quitter l\'espace administration";
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GSBCarpooling.Properties.Resources.GSB_Logo1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::GSBCarpooling.Properties.Resources.GSB_Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 309);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // L_UtilisationVehicule
            // 
            this.L_UtilisationVehicule.AutoSize = true;
            this.L_UtilisationVehicule.Location = new System.Drawing.Point(397, 129);
            this.L_UtilisationVehicule.Name = "L_UtilisationVehicule";
            this.L_UtilisationVehicule.Size = new System.Drawing.Size(172, 13);
            this.L_UtilisationVehicule.TabIndex = 4;
            this.L_UtilisationVehicule.Text = "Utilisation des véhicules de société";
            // 
            // CBX_Annees
            // 
            this.CBX_Annees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBX_Annees.FormattingEnabled = true;
            this.CBX_Annees.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.CBX_Annees.Location = new System.Drawing.Point(448, 145);
            this.CBX_Annees.Name = "CBX_Annees";
            this.CBX_Annees.Size = new System.Drawing.Size(121, 21);
            this.CBX_Annees.TabIndex = 5;
            this.CBX_Annees.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Années";
            // 
            // TABLE_UtilisationVehicules
            // 
            this.TABLE_UtilisationVehicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_UtilisationVehicules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marque,
            this.modele,
            this.immatriculation,
            this.nbUtilisation});
            this.TABLE_UtilisationVehicules.Location = new System.Drawing.Point(405, 177);
            this.TABLE_UtilisationVehicules.Name = "TABLE_UtilisationVehicules";
            this.TABLE_UtilisationVehicules.Size = new System.Drawing.Size(385, 260);
            this.TABLE_UtilisationVehicules.TabIndex = 7;
            // 
            // marque
            // 
            this.marque.HeaderText = "Marque";
            this.marque.Name = "marque";
            // 
            // modele
            // 
            this.modele.HeaderText = "Modèle";
            this.modele.Name = "modele";
            // 
            // immatriculation
            // 
            this.immatriculation.HeaderText = "Immatriculation";
            this.immatriculation.Name = "immatriculation";
            // 
            // nbUtilisation
            // 
            this.nbUtilisation.HeaderText = "Nombre d\'utilisations";
            this.nbUtilisation.Name = "nbUtilisation";
            // 
            // FEN_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TABLE_UtilisationVehicules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBX_Annees);
            this.Controls.Add(this.L_UtilisationVehicule);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.L_Welcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FEN_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_UtilisationVehicules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Welcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_GestionUsers;
        private System.Windows.Forms.ToolStripButton BTN_GestionCars;
        private System.Windows.Forms.ToolStripButton BTN_GestionTrajets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_Quitter;
        private System.Windows.Forms.Label L_UtilisationVehicule;
        private System.Windows.Forms.ComboBox CBX_Annees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TABLE_UtilisationVehicules;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbUtilisation;
    }
}