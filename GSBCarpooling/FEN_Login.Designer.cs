namespace GSBCarpooling
{
    partial class FEN_Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEN_Login));
            this.SAI_Username = new System.Windows.Forms.TextBox();
            this.SAI_Password = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.L_Username = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Erreur = new System.Windows.Forms.Label();
            this.CBX_Mdp = new System.Windows.Forms.CheckBox();
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SAI_Username
            // 
            this.SAI_Username.Location = new System.Drawing.Point(46, 193);
            this.SAI_Username.Name = "SAI_Username";
            this.SAI_Username.Size = new System.Drawing.Size(202, 20);
            this.SAI_Username.TabIndex = 0;
            // 
            // SAI_Password
            // 
            this.SAI_Password.Location = new System.Drawing.Point(46, 236);
            this.SAI_Password.Name = "SAI_Password";
            this.SAI_Password.Size = new System.Drawing.Size(202, 20);
            this.SAI_Password.TabIndex = 1;
            this.SAI_Password.UseSystemPasswordChar = true;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(46, 282);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(202, 23);
            this.BTN_Login.TabIndex = 2;
            this.BTN_Login.Text = "Se connecter";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(46, 311);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(202, 23);
            this.BTN_Close.TabIndex = 3;
            this.BTN_Close.Text = "Quitter";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // L_Username
            // 
            this.L_Username.AutoSize = true;
            this.L_Username.Location = new System.Drawing.Point(43, 177);
            this.L_Username.Name = "L_Username";
            this.L_Username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Username.Size = new System.Drawing.Size(84, 13);
            this.L_Username.TabIndex = 4;
            this.L_Username.Text = "Nom d\'utilisateur";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(46, 220);
            this.L_Password.Name = "L_Password";
            this.L_Password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Password.Size = new System.Drawing.Size(71, 13);
            this.L_Password.TabIndex = 5;
            this.L_Password.Text = "Mot de passe";
            // 
            // L_Erreur
            // 
            this.L_Erreur.AutoSize = true;
            this.L_Erreur.Location = new System.Drawing.Point(10, 356);
            this.L_Erreur.Name = "L_Erreur";
            this.L_Erreur.Size = new System.Drawing.Size(35, 13);
            this.L_Erreur.TabIndex = 8;
            this.L_Erreur.Text = "label1";
            // 
            // CBX_Mdp
            // 
            this.CBX_Mdp.AutoSize = true;
            this.CBX_Mdp.Location = new System.Drawing.Point(46, 262);
            this.CBX_Mdp.Name = "CBX_Mdp";
            this.CBX_Mdp.Size = new System.Drawing.Size(139, 17);
            this.CBX_Mdp.TabIndex = 9;
            this.CBX_Mdp.Text = "Afficher le mot de passe";
            this.CBX_Mdp.UseVisualStyleBackColor = true;
            this.CBX_Mdp.CheckedChanged += new System.EventHandler(this.CBX_Mdp_CheckedChanged);
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Image = global::GSBCarpooling.Properties.Resources.GSB_Logo2;
            this.IMG_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("IMG_Logo.InitialImage")));
            this.IMG_Logo.Location = new System.Drawing.Point(3, 12);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(293, 137);
            this.IMG_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Logo.TabIndex = 6;
            this.IMG_Logo.TabStop = false;
            // 
            // FEN_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 386);
            this.Controls.Add(this.CBX_Mdp);
            this.Controls.Add(this.L_Erreur);
            this.Controls.Add(this.IMG_Logo);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Username);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.SAI_Password);
            this.Controls.Add(this.SAI_Username);
            this.Name = "FEN_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSBCarpooling";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SAI_Username;
        private System.Windows.Forms.TextBox SAI_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label L_Erreur;
        private System.Windows.Forms.CheckBox CBX_Mdp;
    }
}

