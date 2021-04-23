namespace GSBCarpooling
{
    partial class FEN_GestionUsers
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
            this.TABLE_Users = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseudonyme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Actualiser = new System.Windows.Forms.Button();
            this.BTN_Desable = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.BTN_Nouveau = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // TABLE_Users
            // 
            this.TABLE_Users.AllowUserToAddRows = false;
            this.TABLE_Users.AllowUserToDeleteRows = false;
            this.TABLE_Users.AllowUserToOrderColumns = true;
            this.TABLE_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Pseudonyme,
            this.mail,
            this.telephone,
            this.rue,
            this.ville,
            this.codePostal,
            this.typeUser});
            this.TABLE_Users.Location = new System.Drawing.Point(7, 95);
            this.TABLE_Users.Name = "TABLE_Users";
            this.TABLE_Users.ReadOnly = true;
            this.TABLE_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_Users.Size = new System.Drawing.Size(781, 325);
            this.TABLE_Users.TabIndex = 6;
            this.TABLE_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_Users_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Pseudonyme
            // 
            this.Pseudonyme.HeaderText = "Pseudonyme";
            this.Pseudonyme.Name = "Pseudonyme";
            this.Pseudonyme.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "E-Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Mobile";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // rue
            // 
            this.rue.HeaderText = "Adresse";
            this.rue.Name = "rue";
            this.rue.ReadOnly = true;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // codePostal
            // 
            this.codePostal.HeaderText = "Code postal";
            this.codePostal.Name = "codePostal";
            this.codePostal.ReadOnly = true;
            // 
            // typeUser
            // 
            this.typeUser.HeaderText = "Type utilisateur";
            this.typeUser.Name = "typeUser";
            this.typeUser.ReadOnly = true;
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Fermer.Location = new System.Drawing.Point(693, 424);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(97, 23);
            this.BTN_Fermer.TabIndex = 8;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Actualiser
            // 
            this.BTN_Actualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Actualiser.Image = global::GSBCarpooling.Properties.Resources.actualiser;
            this.BTN_Actualiser.Location = new System.Drawing.Point(693, 58);
            this.BTN_Actualiser.Name = "BTN_Actualiser";
            this.BTN_Actualiser.Size = new System.Drawing.Size(95, 31);
            this.BTN_Actualiser.TabIndex = 9;
            this.BTN_Actualiser.UseVisualStyleBackColor = true;
            this.BTN_Actualiser.Click += new System.EventHandler(this.BTN_Actualiser_Click);
            // 
            // BTN_Desable
            // 
            this.BTN_Desable.Image = global::GSBCarpooling.Properties.Resources.delete;
            this.BTN_Desable.Location = new System.Drawing.Point(199, 28);
            this.BTN_Desable.Name = "BTN_Desable";
            this.BTN_Desable.Size = new System.Drawing.Size(90, 61);
            this.BTN_Desable.TabIndex = 5;
            this.BTN_Desable.UseVisualStyleBackColor = true;
            this.BTN_Desable.Click += new System.EventHandler(this.BTN_Desable_Click);
            // 
            // Modifier
            // 
            this.Modifier.Image = global::GSBCarpooling.Properties.Resources.clipart12307922;
            this.Modifier.Location = new System.Drawing.Point(103, 27);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(90, 61);
            this.Modifier.TabIndex = 4;
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // BTN_Nouveau
            // 
            this.BTN_Nouveau.Image = global::GSBCarpooling.Properties.Resources.add;
            this.BTN_Nouveau.Location = new System.Drawing.Point(7, 27);
            this.BTN_Nouveau.Name = "BTN_Nouveau";
            this.BTN_Nouveau.Size = new System.Drawing.Size(90, 61);
            this.BTN_Nouveau.TabIndex = 3;
            this.BTN_Nouveau.UseVisualStyleBackColor = true;
            this.BTN_Nouveau.Click += new System.EventHandler(this.BTN_Nouveau_Click);
            // 
            // FEN_GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Actualiser);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.TABLE_Users);
            this.Controls.Add(this.BTN_Desable);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.BTN_Nouveau);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FEN_GestionUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.FEN_GestionUsers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Nouveau;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button BTN_Desable;
        private System.Windows.Forms.DataGridView TABLE_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudonyme;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeUser;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Actualiser;
    }
}