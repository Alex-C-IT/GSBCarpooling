namespace GSBCarpooling
{
    partial class FEN_GestionTrajets
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
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.TABLE_Trajets = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Actualiser = new System.Windows.Forms.Button();
            this.BTN_Disable = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.BTN_Nouveau = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Trajets)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
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
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Fermer.Location = new System.Drawing.Point(693, 426);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(97, 23);
            this.BTN_Fermer.TabIndex = 22;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click_1);
            // 
            // TABLE_Trajets
            // 
            this.TABLE_Trajets.AllowUserToAddRows = false;
            this.TABLE_Trajets.AllowUserToDeleteRows = false;
            this.TABLE_Trajets.AllowUserToOrderColumns = true;
            this.TABLE_Trajets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_Trajets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_Trajets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.date,
            this.heure,
            this.commentaire,
            this.vehicule,
            this.nom,
            this.prenom});
            this.TABLE_Trajets.Location = new System.Drawing.Point(9, 97);
            this.TABLE_Trajets.Name = "TABLE_Trajets";
            this.TABLE_Trajets.ReadOnly = true;
            this.TABLE_Trajets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_Trajets.Size = new System.Drawing.Size(781, 325);
            this.TABLE_Trajets.TabIndex = 21;
            this.TABLE_Trajets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_Trajets_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // heure
            // 
            this.heure.HeaderText = "Heure du départ";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // commentaire
            // 
            this.commentaire.HeaderText = "Commentaire";
            this.commentaire.Name = "commentaire";
            this.commentaire.ReadOnly = true;
            this.commentaire.Width = 300;
            // 
            // vehicule
            // 
            this.vehicule.HeaderText = "Véhicule";
            this.vehicule.Name = "vehicule";
            this.vehicule.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // BTN_Actualiser
            // 
            this.BTN_Actualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Actualiser.Image = global::GSBCarpooling.Properties.Resources.actualiser;
            this.BTN_Actualiser.Location = new System.Drawing.Point(696, 60);
            this.BTN_Actualiser.Name = "BTN_Actualiser";
            this.BTN_Actualiser.Size = new System.Drawing.Size(95, 31);
            this.BTN_Actualiser.TabIndex = 23;
            this.BTN_Actualiser.UseVisualStyleBackColor = true;
            this.BTN_Actualiser.Click += new System.EventHandler(this.BTN_Actualiser_Click_1);
            // 
            // BTN_Disable
            // 
            this.BTN_Disable.Image = global::GSBCarpooling.Properties.Resources.delete;
            this.BTN_Disable.Location = new System.Drawing.Point(199, 30);
            this.BTN_Disable.Name = "BTN_Disable";
            this.BTN_Disable.Size = new System.Drawing.Size(90, 61);
            this.BTN_Disable.TabIndex = 20;
            this.BTN_Disable.UseVisualStyleBackColor = true;
            this.BTN_Disable.Click += new System.EventHandler(this.BTN_Disable_Click);
            // 
            // Modifier
            // 
            this.Modifier.Image = global::GSBCarpooling.Properties.Resources.clipart12307922;
            this.Modifier.Location = new System.Drawing.Point(103, 30);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(90, 61);
            this.Modifier.TabIndex = 19;
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click_1);
            // 
            // BTN_Nouveau
            // 
            this.BTN_Nouveau.Image = global::GSBCarpooling.Properties.Resources.add;
            this.BTN_Nouveau.Location = new System.Drawing.Point(7, 30);
            this.BTN_Nouveau.Name = "BTN_Nouveau";
            this.BTN_Nouveau.Size = new System.Drawing.Size(90, 61);
            this.BTN_Nouveau.TabIndex = 18;
            this.BTN_Nouveau.UseVisualStyleBackColor = true;
            this.BTN_Nouveau.Click += new System.EventHandler(this.BTN_Nouveau_Click_1);
            // 
            // FEN_GestionTrajets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTN_Actualiser);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.TABLE_Trajets);
            this.Controls.Add(this.BTN_Disable);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.BTN_Nouveau);
            this.Name = "FEN_GestionTrajets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des trajets";
            this.Load += new System.EventHandler(this.FEN_GestionTrajets_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Trajets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Actualiser;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.DataGridView TABLE_Trajets;
        private System.Windows.Forms.Button BTN_Disable;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button BTN_Nouveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
    }
}