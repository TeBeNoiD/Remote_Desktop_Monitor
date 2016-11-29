namespace ClientTest
{
    partial class frmClient
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
            this.cmdCnx = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lstPseudo = new System.Windows.Forms.ListBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.cmdDecnx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCnx
            // 
            this.cmdCnx.Location = new System.Drawing.Point(190, 4);
            this.cmdCnx.Name = "cmdCnx";
            this.cmdCnx.Size = new System.Drawing.Size(119, 43);
            this.cmdCnx.TabIndex = 0;
            this.cmdCnx.Text = "Se connecter";
            this.cmdCnx.UseVisualStyleBackColor = true;
            this.cmdCnx.Click += new System.EventHandler(this.cmdCnx_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(19, 53);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(290, 23);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Mot de passe";
            // 
            // lstPseudo
            // 
            this.lstPseudo.FormattingEnabled = true;
            this.lstPseudo.ItemHeight = 20;
            this.lstPseudo.Location = new System.Drawing.Point(418, 12);
            this.lstPseudo.Name = "lstPseudo";
            this.lstPseudo.Size = new System.Drawing.Size(120, 224);
            this.lstPseudo.TabIndex = 2;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(23, 12);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(161, 26);
            this.txtPseudo.TabIndex = 3;
            // 
            // cmdDecnx
            // 
            this.cmdDecnx.Location = new System.Drawing.Point(23, 189);
            this.cmdDecnx.Name = "cmdDecnx";
            this.cmdDecnx.Size = new System.Drawing.Size(141, 43);
            this.cmdDecnx.TabIndex = 4;
            this.cmdDecnx.Text = "Se déconnecter";
            this.cmdDecnx.UseVisualStyleBackColor = true;
            this.cmdDecnx.Click += new System.EventHandler(this.cmdDecnx_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.cmdDecnx);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lstPseudo);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.cmdCnx);
            this.Name = "frmClient";
            this.Text = "Test du WebService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCnx;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.ListBox lstPseudo;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button cmdDecnx;
    }
}

