namespace GSBCarpooling
{
    partial class FEN_ChangerMotDePasse
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
            this.components = new System.ComponentModel.Container();
            this.SAI_AncienMdp = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SAI_NouveauMdp = new System.Windows.Forms.TextBox();
            this.SAI_ConfirmerNouveauMdp = new System.Windows.Forms.TextBox();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.L_AncienMotDePasse = new System.Windows.Forms.Label();
            this.L_NouveauMotDePasse = new System.Windows.Forms.Label();
            this.L_ConfirmerNouveauMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SAI_AncienMdp
            // 
            this.SAI_AncienMdp.Location = new System.Drawing.Point(15, 25);
            this.SAI_AncienMdp.Name = "SAI_AncienMdp";
            this.SAI_AncienMdp.Size = new System.Drawing.Size(203, 20);
            this.SAI_AncienMdp.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SAI_NouveauMdp
            // 
            this.SAI_NouveauMdp.Location = new System.Drawing.Point(15, 64);
            this.SAI_NouveauMdp.Name = "SAI_NouveauMdp";
            this.SAI_NouveauMdp.Size = new System.Drawing.Size(203, 20);
            this.SAI_NouveauMdp.TabIndex = 2;
            // 
            // SAI_ConfirmerNouveauMdp
            // 
            this.SAI_ConfirmerNouveauMdp.Location = new System.Drawing.Point(15, 103);
            this.SAI_ConfirmerNouveauMdp.Name = "SAI_ConfirmerNouveauMdp";
            this.SAI_ConfirmerNouveauMdp.Size = new System.Drawing.Size(203, 20);
            this.SAI_ConfirmerNouveauMdp.TabIndex = 3;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(60, 144);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_Valider.TabIndex = 4;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(141, 144);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // L_AncienMotDePasse
            // 
            this.L_AncienMotDePasse.AutoSize = true;
            this.L_AncienMotDePasse.Location = new System.Drawing.Point(12, 9);
            this.L_AncienMotDePasse.Name = "L_AncienMotDePasse";
            this.L_AncienMotDePasse.Size = new System.Drawing.Size(103, 13);
            this.L_AncienMotDePasse.TabIndex = 6;
            this.L_AncienMotDePasse.Text = "Mot de passe actuel";
            // 
            // L_NouveauMotDePasse
            // 
            this.L_NouveauMotDePasse.AutoSize = true;
            this.L_NouveauMotDePasse.Location = new System.Drawing.Point(12, 48);
            this.L_NouveauMotDePasse.Name = "L_NouveauMotDePasse";
            this.L_NouveauMotDePasse.Size = new System.Drawing.Size(117, 13);
            this.L_NouveauMotDePasse.TabIndex = 7;
            this.L_NouveauMotDePasse.Text = "Nouveau mot de passe";
            // 
            // L_ConfirmerNouveauMdp
            // 
            this.L_ConfirmerNouveauMdp.AutoSize = true;
            this.L_ConfirmerNouveauMdp.Location = new System.Drawing.Point(12, 87);
            this.L_ConfirmerNouveauMdp.Name = "L_ConfirmerNouveauMdp";
            this.L_ConfirmerNouveauMdp.Size = new System.Drawing.Size(162, 13);
            this.L_ConfirmerNouveauMdp.TabIndex = 8;
            this.L_ConfirmerNouveauMdp.Text = "Confirmer nouveau mot de passe";
            // 
            // FEN_ChangerMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 176);
            this.Controls.Add(this.L_ConfirmerNouveauMdp);
            this.Controls.Add(this.L_NouveauMotDePasse);
            this.Controls.Add(this.L_AncienMotDePasse);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.SAI_ConfirmerNouveauMdp);
            this.Controls.Add(this.SAI_NouveauMdp);
            this.Controls.Add(this.SAI_AncienMdp);
            this.Name = "FEN_ChangerMotDePasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Changement de mot de passe";
            this.Load += new System.EventHandler(this.FEN_ChangerMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SAI_AncienMdp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SAI_NouveauMdp;
        private System.Windows.Forms.TextBox SAI_ConfirmerNouveauMdp;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label L_AncienMotDePasse;
        private System.Windows.Forms.Label L_NouveauMotDePasse;
        private System.Windows.Forms.Label L_ConfirmerNouveauMdp;
    }
}