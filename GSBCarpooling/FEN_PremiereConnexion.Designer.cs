namespace GSBCarpooling
{
    partial class FEN_PremiereConnexion
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
            this.SAI_Password = new System.Windows.Forms.TextBox();
            this.SAI_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.L_MDP = new System.Windows.Forms.Label();
            this.L_MDPC = new System.Windows.Forms.Label();
            this.BTN_Confirmer = new System.Windows.Forms.Button();
            this.L_Bienvenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SAI_Password
            // 
            this.SAI_Password.Location = new System.Drawing.Point(15, 126);
            this.SAI_Password.Name = "SAI_Password";
            this.SAI_Password.Size = new System.Drawing.Size(216, 20);
            this.SAI_Password.TabIndex = 0;
            // 
            // SAI_ConfirmPassword
            // 
            this.SAI_ConfirmPassword.Location = new System.Drawing.Point(15, 168);
            this.SAI_ConfirmPassword.Name = "SAI_ConfirmPassword";
            this.SAI_ConfirmPassword.Size = new System.Drawing.Size(216, 20);
            this.SAI_ConfirmPassword.TabIndex = 1;
            // 
            // L_MDP
            // 
            this.L_MDP.AutoSize = true;
            this.L_MDP.Location = new System.Drawing.Point(12, 110);
            this.L_MDP.Name = "L_MDP";
            this.L_MDP.Size = new System.Drawing.Size(117, 13);
            this.L_MDP.TabIndex = 2;
            this.L_MDP.Text = "Nouveau mot de passe";
            // 
            // L_MDPC
            // 
            this.L_MDPC.AutoSize = true;
            this.L_MDPC.Location = new System.Drawing.Point(12, 152);
            this.L_MDPC.Name = "L_MDPC";
            this.L_MDPC.Size = new System.Drawing.Size(162, 13);
            this.L_MDPC.TabIndex = 3;
            this.L_MDPC.Text = "Confirmer nouveau mot de passe";
            // 
            // BTN_Confirmer
            // 
            this.BTN_Confirmer.Location = new System.Drawing.Point(15, 201);
            this.BTN_Confirmer.Name = "BTN_Confirmer";
            this.BTN_Confirmer.Size = new System.Drawing.Size(216, 23);
            this.BTN_Confirmer.TabIndex = 4;
            this.BTN_Confirmer.Text = "Confirmer";
            this.BTN_Confirmer.UseVisualStyleBackColor = true;
            this.BTN_Confirmer.Click += new System.EventHandler(this.BTN_Confirmer_Click);
            // 
            // L_Bienvenue
            // 
            this.L_Bienvenue.Location = new System.Drawing.Point(7, 43);
            this.L_Bienvenue.Name = "L_Bienvenue";
            this.L_Bienvenue.Size = new System.Drawing.Size(227, 67);
            this.L_Bienvenue.TabIndex = 5;
            this.L_Bienvenue.Text = "Ceci étant votre première connexion, pour des raisons de sécurité il vous est con" +
    "seillé de changer votre mot de passe. ";
            this.L_Bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenue sur GSB Carpooling";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FEN_PremiereConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(242, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Bienvenue);
            this.Controls.Add(this.BTN_Confirmer);
            this.Controls.Add(this.L_MDPC);
            this.Controls.Add(this.L_MDP);
            this.Controls.Add(this.SAI_ConfirmPassword);
            this.Controls.Add(this.SAI_Password);
            this.Name = "FEN_PremiereConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue sur GSB Carpooling";
            this.Load += new System.EventHandler(this.FEN_PremiereConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SAI_Password;
        private System.Windows.Forms.TextBox SAI_ConfirmPassword;
        private System.Windows.Forms.Label L_MDP;
        private System.Windows.Forms.Label L_MDPC;
        private System.Windows.Forms.Button BTN_Confirmer;
        private System.Windows.Forms.Label L_Bienvenue;
        private System.Windows.Forms.Label label1;
    }
}