namespace GSBCarpooling
{
    partial class FEN_RechercherTrajet
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
            this.TABLE_Trajets = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_HeureDepart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.L_VilleD = new System.Windows.Forms.Label();
            this.L_Heure = new System.Windows.Forms.Label();
            this.L_Date = new System.Windows.Forms.Label();
            this.C_VilleArrivee = new System.Windows.Forms.ComboBox();
            this.C_VilleDepart = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DateDepart = new System.Windows.Forms.DateTimePicker();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            this.BTN_Reserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Trajets)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLE_Trajets
            // 
            this.TABLE_Trajets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_Trajets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dateDepart,
            this.heureDepart,
            this.nom,
            this.prenom});
            this.TABLE_Trajets.Location = new System.Drawing.Point(4, 121);
            this.TABLE_Trajets.Name = "TABLE_Trajets";
            this.TABLE_Trajets.Size = new System.Drawing.Size(489, 224);
            this.TABLE_Trajets.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // dateDepart
            // 
            this.dateDepart.HeaderText = "Date départ";
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.ReadOnly = true;
            // 
            // heureDepart
            // 
            this.heureDepart.HeaderText = "Heure départ";
            this.heureDepart.Name = "heureDepart";
            this.heureDepart.ReadOnly = true;
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
            // dateTimePicker_HeureDepart
            // 
            this.dateTimePicker_HeureDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_HeureDepart.Location = new System.Drawing.Point(47, 64);
            this.dateTimePicker_HeureDepart.MinDate = new System.DateTime(2021, 1, 7, 0, 0, 0, 0);
            this.dateTimePicker_HeureDepart.Name = "dateTimePicker_HeureDepart";
            this.dateTimePicker_HeureDepart.ShowUpDown = true;
            this.dateTimePicker_HeureDepart.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_HeureDepart.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ville d\'arrivée";
            // 
            // L_VilleD
            // 
            this.L_VilleD.AutoSize = true;
            this.L_VilleD.Location = new System.Drawing.Point(264, 9);
            this.L_VilleD.Name = "L_VilleD";
            this.L_VilleD.Size = new System.Drawing.Size(74, 13);
            this.L_VilleD.TabIndex = 25;
            this.L_VilleD.Text = "Ville de départ";
            // 
            // L_Heure
            // 
            this.L_Heure.AutoSize = true;
            this.L_Heure.Location = new System.Drawing.Point(45, 48);
            this.L_Heure.Name = "L_Heure";
            this.L_Heure.Size = new System.Drawing.Size(84, 13);
            this.L_Heure.TabIndex = 24;
            this.L_Heure.Text = "Heure de départ";
            // 
            // L_Date
            // 
            this.L_Date.AutoSize = true;
            this.L_Date.Location = new System.Drawing.Point(45, 9);
            this.L_Date.Name = "L_Date";
            this.L_Date.Size = new System.Drawing.Size(78, 13);
            this.L_Date.TabIndex = 23;
            this.L_Date.Text = "Date de départ";
            // 
            // C_VilleArrivee
            // 
            this.C_VilleArrivee.FormattingEnabled = true;
            this.C_VilleArrivee.Location = new System.Drawing.Point(267, 65);
            this.C_VilleArrivee.Name = "C_VilleArrivee";
            this.C_VilleArrivee.Size = new System.Drawing.Size(187, 21);
            this.C_VilleArrivee.TabIndex = 22;
            // 
            // C_VilleDepart
            // 
            this.C_VilleDepart.FormattingEnabled = true;
            this.C_VilleDepart.Location = new System.Drawing.Point(267, 25);
            this.C_VilleDepart.Name = "C_VilleDepart";
            this.C_VilleDepart.Size = new System.Drawing.Size(187, 21);
            this.C_VilleDepart.TabIndex = 21;
            // 
            // dateTimePicker_DateDepart
            // 
            this.dateTimePicker_DateDepart.Location = new System.Drawing.Point(48, 25);
            this.dateTimePicker_DateDepart.Name = "dateTimePicker_DateDepart";
            this.dateTimePicker_DateDepart.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker_DateDepart.TabIndex = 20;
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Location = new System.Drawing.Point(161, 92);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(177, 23);
            this.BTN_Rechercher.TabIndex = 28;
            this.BTN_Rechercher.Text = "Rechercher un trajet";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(391, 351);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(102, 23);
            this.BTN_Fermer.TabIndex = 29;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // BTN_Reserver
            // 
            this.BTN_Reserver.Location = new System.Drawing.Point(208, 351);
            this.BTN_Reserver.Name = "BTN_Reserver";
            this.BTN_Reserver.Size = new System.Drawing.Size(177, 23);
            this.BTN_Reserver.TabIndex = 30;
            this.BTN_Reserver.Text = "Réserver trajet";
            this.BTN_Reserver.UseVisualStyleBackColor = true;
            this.BTN_Reserver.Click += new System.EventHandler(this.BTN_Reserver_Click);
            // 
            // FEN_RechercherTrajet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 378);
            this.Controls.Add(this.BTN_Reserver);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Rechercher);
            this.Controls.Add(this.dateTimePicker_HeureDepart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_VilleD);
            this.Controls.Add(this.L_Heure);
            this.Controls.Add(this.L_Date);
            this.Controls.Add(this.C_VilleArrivee);
            this.Controls.Add(this.C_VilleDepart);
            this.Controls.Add(this.dateTimePicker_DateDepart);
            this.Controls.Add(this.TABLE_Trajets);
            this.Name = "FEN_RechercherTrajet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche d\'un trajet";
            this.Load += new System.EventHandler(this.FEN_RechercherTrajet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Trajets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLE_Trajets;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_HeureDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_VilleD;
        private System.Windows.Forms.Label L_Heure;
        private System.Windows.Forms.Label L_Date;
        private System.Windows.Forms.ComboBox C_VilleArrivee;
        private System.Windows.Forms.ComboBox C_VilleDepart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateDepart;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.Button BTN_Reserver;
    }
}