namespace GSBCarpooling
{
    partial class FEN_VosTrajets
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
            this.TABLE_VosTrajets = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDépart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeArrivée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_VosTrajets)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLE_VosTrajets
            // 
            this.TABLE_VosTrajets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABLE_VosTrajets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_VosTrajets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dateDepart,
            this.heureDépart,
            this.villeDepart,
            this.villeArrivée});
            this.TABLE_VosTrajets.Location = new System.Drawing.Point(2, 3);
            this.TABLE_VosTrajets.Name = "TABLE_VosTrajets";
            this.TABLE_VosTrajets.Size = new System.Drawing.Size(491, 255);
            this.TABLE_VosTrajets.TabIndex = 0;
            this.TABLE_VosTrajets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLE_VosTrajets_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
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
            // heureDépart
            // 
            this.heureDépart.HeaderText = "Heure départ";
            this.heureDépart.Name = "heureDépart";
            this.heureDépart.ReadOnly = true;
            // 
            // villeDepart
            // 
            this.villeDepart.HeaderText = "Ville départ";
            this.villeDepart.Name = "villeDepart";
            this.villeDepart.ReadOnly = true;
            // 
            // villeArrivée
            // 
            this.villeArrivée.HeaderText = "Ville arrivée";
            this.villeArrivée.Name = "villeArrivée";
            this.villeArrivée.ReadOnly = true;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Image = global::GSBCarpooling.Properties.Resources.delete;
            this.BTN_Supprimer.Location = new System.Drawing.Point(87, 264);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(82, 41);
            this.BTN_Supprimer.TabIndex = 22;
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Image = global::GSBCarpooling.Properties.Resources.clipart12307922;
            this.BTN_Modifier.Location = new System.Drawing.Point(5, 264);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(76, 41);
            this.BTN_Modifier.TabIndex = 21;
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Fermer
            // 
            this.BTN_Fermer.Location = new System.Drawing.Point(418, 282);
            this.BTN_Fermer.Name = "BTN_Fermer";
            this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fermer.TabIndex = 23;
            this.BTN_Fermer.Text = "Fermer";
            this.BTN_Fermer.UseVisualStyleBackColor = true;
            this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
            // 
            // FEN_VosTrajets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.Controls.Add(this.BTN_Fermer);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.TABLE_VosTrajets);
            this.Name = "FEN_VosTrajets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste de vos trajets";
            this.Load += new System.EventHandler(this.FEN_VosTrajets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_VosTrajets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLE_VosTrajets;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDépart;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeArrivée;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Fermer;
    }
}