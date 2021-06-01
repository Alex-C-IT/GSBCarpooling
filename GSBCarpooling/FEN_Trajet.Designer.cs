namespace GSBCarpooling
{
    partial class FEN_Trajet
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
            this.TABLE_Participants = new System.Windows.Forms.DataGridView();
            this.L_Participants = new System.Windows.Forms.Label();
            this.L_DemandeEnAttente = new System.Windows.Forms.Label();
            this.TABLE_DemandesEnAttente = new System.Windows.Forms.DataGridView();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_Refuser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDemande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDemande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDemande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Participants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_DemandesEnAttente)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(441, 415);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fermer.TabIndex = 0;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // TABLE_Participants
            // 
            this.TABLE_Participants.AllowUserToAddRows = false;
            this.TABLE_Participants.AllowUserToDeleteRows = false;
            this.TABLE_Participants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_Participants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom,
            this.Prenom});
            this.TABLE_Participants.Location = new System.Drawing.Point(276, 25);
            this.TABLE_Participants.Name = "TABLE_Participants";
            this.TABLE_Participants.ReadOnly = true;
            this.TABLE_Participants.Size = new System.Drawing.Size(240, 140);
            this.TABLE_Participants.TabIndex = 1;
            // 
            // L_Participants
            // 
            this.L_Participants.AutoSize = true;
            this.L_Participants.Location = new System.Drawing.Point(273, 9);
            this.L_Participants.Name = "L_Participants";
            this.L_Participants.Size = new System.Drawing.Size(62, 13);
            this.L_Participants.TabIndex = 2;
            this.L_Participants.Text = "Participants";
            // 
            // L_DemandeEnAttente
            // 
            this.L_DemandeEnAttente.AutoSize = true;
            this.L_DemandeEnAttente.Location = new System.Drawing.Point(273, 176);
            this.L_DemandeEnAttente.Name = "L_DemandeEnAttente";
            this.L_DemandeEnAttente.Size = new System.Drawing.Size(109, 13);
            this.L_DemandeEnAttente.TabIndex = 3;
            this.L_DemandeEnAttente.Text = "Demandes en attente";
            // 
            // TABLE_DemandesEnAttente
            // 
            this.TABLE_DemandesEnAttente.AllowUserToAddRows = false;
            this.TABLE_DemandesEnAttente.AllowUserToDeleteRows = false;
            this.TABLE_DemandesEnAttente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_DemandesEnAttente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDemande,
            this.nomDemande,
            this.prenomDemande});
            this.TABLE_DemandesEnAttente.Location = new System.Drawing.Point(276, 192);
            this.TABLE_DemandesEnAttente.Name = "TABLE_DemandesEnAttente";
            this.TABLE_DemandesEnAttente.ReadOnly = true;
            this.TABLE_DemandesEnAttente.Size = new System.Drawing.Size(240, 151);
            this.TABLE_DemandesEnAttente.TabIndex = 4;
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.Location = new System.Drawing.Point(323, 349);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accepter.TabIndex = 5;
            this.BTN_Accepter.Text = "Accepter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_Refuser
            // 
            this.BTN_Refuser.Location = new System.Drawing.Point(404, 349);
            this.BTN_Refuser.Name = "BTN_Refuser";
            this.BTN_Refuser.Size = new System.Drawing.Size(75, 23);
            this.BTN_Refuser.TabIndex = 6;
            this.BTN_Refuser.Text = "Refuser";
            this.BTN_Refuser.UseVisualStyleBackColor = true;
            this.BTN_Refuser.Click += new System.EventHandler(this.BTN_Refuser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 426);
            this.button1.TabIndex = 7;
            this.button1.Text = "MAP TRAJET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
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
            // idDemande
            // 
            this.idDemande.HeaderText = "#";
            this.idDemande.Name = "idDemande";
            this.idDemande.ReadOnly = true;
            this.idDemande.Width = 30;
            // 
            // nomDemande
            // 
            this.nomDemande.HeaderText = "Nom";
            this.nomDemande.Name = "nomDemande";
            this.nomDemande.ReadOnly = true;
            // 
            // prenomDemande
            // 
            this.prenomDemande.HeaderText = "Prenom";
            this.prenomDemande.Name = "prenomDemande";
            this.prenomDemande.ReadOnly = true;
            // 
            // FEN_Trajet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Refuser);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.TABLE_DemandesEnAttente);
            this.Controls.Add(this.L_DemandeEnAttente);
            this.Controls.Add(this.L_Participants);
            this.Controls.Add(this.TABLE_Participants);
            this.Controls.Add(this.BTN_Fermer);
            this.Name = "FEN_Trajet";
            this.Text = "Trajet n°";
            this.Load += new System.EventHandler(this.FEN_Trajet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_Participants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_DemandesEnAttente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Fermer;
        private System.Windows.Forms.DataGridView TABLE_Participants;
        private System.Windows.Forms.Label L_Participants;
        private System.Windows.Forms.Label L_DemandeEnAttente;
        private System.Windows.Forms.DataGridView TABLE_DemandesEnAttente;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_Refuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDemande;
    }
}