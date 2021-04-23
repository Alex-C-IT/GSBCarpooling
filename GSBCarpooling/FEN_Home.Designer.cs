namespace GSBCarpooling
{
    partial class FEN_Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_VosTrajets = new System.Windows.Forms.ToolStripButton();
            this.BTN_RechercherTrajet = new System.Windows.Forms.ToolStripButton();
            this.BTN_GestionCars = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Param = new System.Windows.Forms.ToolStripButton();
            this.BTN_Admin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Quitter = new System.Windows.Forms.ToolStripButton();
            this.L_Welcome = new System.Windows.Forms.Label();
            this.TABLE_TrajetsReserves = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_Trajets = new System.Windows.Forms.Label();
            this.BTN_AnnulerReservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_CompteurReservations = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_TrajetsReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 2;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_VosTrajets,
            this.BTN_RechercherTrajet,
            this.BTN_GestionCars,
            this.toolStripSeparator1,
            this.BTN_Param,
            this.BTN_Admin,
            this.toolStripSeparator2,
            this.BTN_Quitter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 58);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_VosTrajets
            // 
            this.BTN_VosTrajets.AutoSize = false;
            this.BTN_VosTrajets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_VosTrajets.Image = global::GSBCarpooling.Properties.Resources.VosTrajets;
            this.BTN_VosTrajets.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_VosTrajets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_VosTrajets.Name = "BTN_VosTrajets";
            this.BTN_VosTrajets.Size = new System.Drawing.Size(100, 55);
            this.BTN_VosTrajets.Text = "Vos trajets";
            this.BTN_VosTrajets.ToolTipText = "Vos trajets";
            this.BTN_VosTrajets.Click += new System.EventHandler(this.BTN_VosTrajets_Click);
            // 
            // BTN_RechercherTrajet
            // 
            this.BTN_RechercherTrajet.AutoSize = false;
            this.BTN_RechercherTrajet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_RechercherTrajet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_RechercherTrajet.Image = global::GSBCarpooling.Properties.Resources.RechercherTrajets;
            this.BTN_RechercherTrajet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_RechercherTrajet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_RechercherTrajet.Name = "BTN_RechercherTrajet";
            this.BTN_RechercherTrajet.Size = new System.Drawing.Size(100, 55);
            this.BTN_RechercherTrajet.Text = "Rechercher un trajet";
            this.BTN_RechercherTrajet.Click += new System.EventHandler(this.BTN_RechercherTrajet_Click);
            // 
            // BTN_GestionCars
            // 
            this.BTN_GestionCars.AutoSize = false;
            this.BTN_GestionCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_GestionCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_GestionCars.Image = global::GSBCarpooling.Properties.Resources.proposer_petit;
            this.BTN_GestionCars.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_GestionCars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_GestionCars.Name = "BTN_GestionCars";
            this.BTN_GestionCars.Size = new System.Drawing.Size(100, 55);
            this.BTN_GestionCars.Text = "Proposer un trajet";
            this.BTN_GestionCars.Click += new System.EventHandler(this.BTN_GestionCars_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // BTN_Param
            // 
            this.BTN_Param.AutoSize = false;
            this.BTN_Param.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Param.Image = global::GSBCarpooling.Properties.Resources.settings;
            this.BTN_Param.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_Param.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Param.Name = "BTN_Param";
            this.BTN_Param.Size = new System.Drawing.Size(100, 55);
            this.BTN_Param.Text = "Paramètres utilisateur";
            this.BTN_Param.Click += new System.EventHandler(this.BTN_Param_Click);
            // 
            // BTN_Admin
            // 
            this.BTN_Admin.AutoSize = false;
            this.BTN_Admin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Admin.Image = global::GSBCarpooling.Properties.Resources.admin;
            this.BTN_Admin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_Admin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Admin.Name = "BTN_Admin";
            this.BTN_Admin.Size = new System.Drawing.Size(100, 55);
            this.BTN_Admin.Text = "Espace administration";
            this.BTN_Admin.Click += new System.EventHandler(this.BTN_Admin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.AutoSize = false;
            this.BTN_Quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_Quitter.Image = global::GSBCarpooling.Properties.Resources.quitter1;
            this.BTN_Quitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BTN_Quitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(100, 55);
            this.BTN_Quitter.Text = "Quitter l\'application";
            this.BTN_Quitter.ToolTipText = "Quitter l\'application";
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // L_Welcome
            // 
            this.L_Welcome.AutoSize = true;
            this.L_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Welcome.Location = new System.Drawing.Point(364, 122);
            this.L_Welcome.Name = "L_Welcome";
            this.L_Welcome.Size = new System.Drawing.Size(71, 20);
            this.L_Welcome.TabIndex = 4;
            this.L_Welcome.Text = "Bonjour";
            // 
            // TABLE_TrajetsReserves
            // 
            this.TABLE_TrajetsReserves.AllowUserToAddRows = false;
            this.TABLE_TrajetsReserves.AllowUserToDeleteRows = false;
            this.TABLE_TrajetsReserves.AllowUserToOrderColumns = true;
            this.TABLE_TrajetsReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_TrajetsReserves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.heure,
            this.depart,
            this.arrivee});
            this.TABLE_TrajetsReserves.Location = new System.Drawing.Point(16, 122);
            this.TABLE_TrajetsReserves.Name = "TABLE_TrajetsReserves";
            this.TABLE_TrajetsReserves.ReadOnly = true;
            this.TABLE_TrajetsReserves.Size = new System.Drawing.Size(293, 266);
            this.TABLE_TrajetsReserves.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // heure
            // 
            this.heure.HeaderText = "Heure";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // depart
            // 
            this.depart.HeaderText = "Depart";
            this.depart.Name = "depart";
            this.depart.ReadOnly = true;
            // 
            // arrivee
            // 
            this.arrivee.HeaderText = "Arrivée";
            this.arrivee.Name = "arrivee";
            this.arrivee.ReadOnly = true;
            // 
            // L_Trajets
            // 
            this.L_Trajets.AutoSize = true;
            this.L_Trajets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Trajets.Location = new System.Drawing.Point(12, 92);
            this.L_Trajets.Name = "L_Trajets";
            this.L_Trajets.Size = new System.Drawing.Size(137, 20);
            this.L_Trajets.TabIndex = 9;
            this.L_Trajets.Text = "Trajets réservés";
            // 
            // BTN_AnnulerReservation
            // 
            this.BTN_AnnulerReservation.Location = new System.Drawing.Point(16, 394);
            this.BTN_AnnulerReservation.Name = "BTN_AnnulerReservation";
            this.BTN_AnnulerReservation.Size = new System.Drawing.Size(293, 23);
            this.BTN_AnnulerReservation.TabIndex = 10;
            this.BTN_AnnulerReservation.Text = "Annuler réservation";
            this.BTN_AnnulerReservation.UseVisualStyleBackColor = true;
            this.BTN_AnnulerReservation.Click += new System.EventHandler(this.BTN_AnnulerReservation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GSBCarpooling.Properties.Resources.GSB_Logo1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::GSBCarpooling.Properties.Resources.GSB_Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(383, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // L_CompteurReservations
            // 
            this.L_CompteurReservations.AutoSize = true;
            this.L_CompteurReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CompteurReservations.ForeColor = System.Drawing.Color.LimeGreen;
            this.L_CompteurReservations.Location = new System.Drawing.Point(62, 72);
            this.L_CompteurReservations.Name = "L_CompteurReservations";
            this.L_CompteurReservations.Size = new System.Drawing.Size(57, 20);
            this.L_CompteurReservations.TabIndex = 12;
            this.L_CompteurReservations.Text = "label1";
            // 
            // FEN_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 431);
            this.Controls.Add(this.L_CompteurReservations);
            this.Controls.Add(this.BTN_AnnulerReservation);
            this.Controls.Add(this.L_Trajets);
            this.Controls.Add(this.TABLE_TrajetsReserves);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.L_Welcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FEN_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSBCarpooling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_TrajetsReserves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_RechercherTrajet;
        private System.Windows.Forms.ToolStripButton BTN_GestionCars;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_Quitter;
        private System.Windows.Forms.Label L_Welcome;
        private System.Windows.Forms.DataGridView TABLE_TrajetsReserves;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivee;
        private System.Windows.Forms.Label L_Trajets;
        private System.Windows.Forms.ToolStripButton BTN_Param;
        private System.Windows.Forms.ToolStripButton BTN_Admin;
        private System.Windows.Forms.Button BTN_AnnulerReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_VosTrajets;
        private System.Windows.Forms.Label L_CompteurReservations;
    }
}